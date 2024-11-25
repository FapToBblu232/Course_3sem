using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_3sem
{
    internal class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName} {Name} {Otchestvo} | г. {City} улица {Street} дом {HouseNumber} | {PhoneNumber}";
            }
        }
        public string City { get; set; }
        public string Street { get; set; }
        public Int16 HouseNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
