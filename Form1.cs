using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course_3sem
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            LoadPeople();
        }

        private async void LoadPeople()
        {
            people = AccessSqliteData.LoadPeople();
            WriteDataListbox();
        }

        private void WriteDataListbox()
        {
            lbPerson.DataSource = null;
            lbPerson.DataSource = people;
            lbPerson.DisplayMember = "Fullname";
        }
        private void InsertPerson(Person? person)
        {
            AccessSqliteData.InsertPerson(person);
            LoadPeople();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static string Check_str(string str)
        {
            if (str.Contains('\'') || str.Contains("--") || str.Contains('*'))
            {
                return "";
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                Person person = new Person();
                person.LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());
                person.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text.ToLower());
                person.Otchestvo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox3.Text.ToLower());
                person.City = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                person.Street = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
                person.HouseNumber = Convert.ToInt16(textBox6.Text);
                person.PhoneNumber = textBox7.Text;
                if (Check_str(person.LastName) == "" || Check_str(person.Name) == "" ||
                    Check_str(person.Otchestvo) == "" || Check_str(person.City) == "" ||
                    Check_str(person.Street) == "")
                {
                    throw new Exception("Невалидные данные!");
                }
                InsertPerson(person);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность введённых данных", "Ошибка");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Int16 number = -1;
            if (textBox6.Text != "") number = Convert.ToInt16(textBox6.Text);
            people = await Task.Run(() => AccessSqliteData.FindByAll(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, number));
            WriteDataListbox();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            people.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            WriteDataListbox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            people.Sort((x, y) => x.City.CompareTo(y.City));
            WriteDataListbox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            people.Sort((x, y) => x.Street.CompareTo(y.Street));
            WriteDataListbox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                Person person = new Person();
                person.LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());
                person.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text.ToLower());
                person.Otchestvo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox3.Text.ToLower());
                person.City = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                person.Street = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
                person.HouseNumber = Convert.ToInt16(textBox6.Text);
                person.PhoneNumber = textBox7.Text;
                if (Check_str(person.LastName) == "" || Check_str(person.Name) == "" ||
                    Check_str(person.Otchestvo) == "" || Check_str(person.City) == "" ||
                    Check_str(person.Street) == "")
                {
                    throw new Exception("Невалидные данные!");
                }
                AccessSqliteData.UpdatePerson(person);
                LoadPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность введённых данных", "Ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                Person person = new Person();
                person.LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text.ToLower());
                person.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text.ToLower());
                person.Otchestvo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox3.Text.ToLower());
                person.City = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                person.Street = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
                person.HouseNumber = Convert.ToInt16(textBox6.Text);
                person.PhoneNumber = textBox7.Text;
                if (Check_str(person.LastName) == "" || Check_str(person.Name) == "" ||
                    Check_str(person.Otchestvo) == "" || Check_str(person.City) == "" ||
                    Check_str(person.Street) == "")
                {
                    throw new Exception("Невалидные данные!");
                }
                AccessSqliteData.DeletePerson(person);
                LoadPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность введённых данных", "Ошибка");
            }
        }
    }
}
