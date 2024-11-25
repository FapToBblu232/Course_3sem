using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Globalization;
using System.Xml.Linq;

namespace Course_3sem
{
    internal class AccessSqliteData
    {
        public static string Check_str(string str)
        {
            if (str.Contains('\'') || str.Contains("--") || str.Contains('*'))
            {
                return "";
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
        public static List<Person> LoadPeople()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Person>("select * from person", new DynamicParameters());
                return result.ToList();
            }
        }

        public async static Task<List<Person>> FindByAll(string Last, string name, string otchestvo, string city, string street, Int16 number = -1)
        {
            string request = "";
            if (Last != "")
            {
                request += $"LastName = '{Check_str(Last)}'";
            }
            if (name != "")
            {
                if (request != "")
                {
                    request += " and ";
                }
                request += $"Name = '{Check_str(name)}'";
            }
            if (otchestvo != "")
            {
                if (request != "")
                {
                    request += " and ";
                }
                request += $"Otchestvo = '{Check_str(otchestvo)}'";
            }
            if (city != "")
            {
                if (request != "")
                {
                    request += " and ";
                }
                request += $"City = '{Check_str(city)}'";
            }
            if (street != "")
            {
                if (request != "")
                {
                    request += " and ";
                }
                request += $"Street = '{Check_str(street)}'";
            }
            if (number != -1)
            {
                if (request != "")
                {
                    request += " and ";
                }
                request += $"HouseNumber = '{number.ToString()}'";
            }
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                if (request == "")
                {
                    var answ = con.Query<Person>("select * from person", new DynamicParameters());
                    return answ.ToList();
                }
                var result = con.Query<Person>($"select * from person where {request}", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void InsertPerson(Person? person)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("INSERT INTO person (LastName, Name, Otchestvo, City, Street, HouseNumber, PhoneNumber) values (@LastName, @Name, @Otchestvo, @City, @Street, @HouseNumber, @PhoneNumber)", person);
            }

        }

        public static void UpdatePerson(Person? person)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<Person>($"select * from person where LastName = '{person.LastName}' and Name = '{person.Name}' and Otchestvo = '{person.Otchestvo}' and City = '{person.City}' and Street = '{person.Street}' and HouseNumber = '{person.HouseNumber}'", new DynamicParameters());
                if (result.ToArray().Length == 0)
                {
                    con.Execute("INSERT INTO person (LastName, Name, Otchestvo, City, Street, HouseNumber, PhoneNumber) values (@LastName, @Name, @Otchestvo, @City, @Street, @HouseNumber, @PhoneNumber)", person);
                    return;
                }
                con.Execute($"UPDATE person SET PhoneNumber = '{person.PhoneNumber}' WHERE LastName = '{person.LastName}' and Name = '{person.Name}' and Otchestvo = '{person.Otchestvo}' and City = '{person.City}' and Street = '{person.Street}' and HouseNumber = '{person.HouseNumber}'");
            }
        }

        public static void DeletePerson(Person? person)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"DELETE from person WHERE LastName = '{person.LastName}' and Name = '{person.Name}' and Otchestvo = '{person.Otchestvo}' and City = '{person.City}' and Street = '{person.Street}' and HouseNumber = '{person.HouseNumber}'");
            }
        }

        private static string LoadConnectionString(string id = "people")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
