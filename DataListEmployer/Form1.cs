using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataListEmployer
{
    public partial class Form1 : Form
    {
        public static Employee person;
        public static List<Employee> employees;
        public static int personID = 1;
        public static string surname;
        public static string name;
        public static DateTime date_Of_Employment;
        public static int salary;

        public Form1()
        {
            var date_Of_Employment = new DateTime { };
            employees = new List<Employee>();
            InitializeComponent();
        }

        internal static void AddEmployer()
        {
            person = new Employee(personID, surname, name, date_Of_Employment, salary);
            employees.Add(person);
            personID++;
        }

        private void AddEmployerButton_Click(object sender, EventArgs e)
        {
            surname = SurnameTextBox.Text;
            name = NameTextBox.Text;
            date_Of_Employment = Convert.ToDateTime(DateTextBox.Text);
            salary = int.Parse(SalaryTextBox.Text);
            AddEmployer();
            SurnameTextBox.Clear();
            NameTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            IDToRemoveTextBox.Clear();
            RemoveEmployer(int.Parse(IDToRemoveTextBox.Text));
        }

        internal static void RemoveEmployer(int IDvalue)
        {
            foreach (var employee in employees)
            {
                if (employee.PersonID == IDvalue)
                    employees.Remove(employee);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            string resultStr = "";
            ResultTextBox.Clear();
            foreach (var employee in employees)
            {
               
                resultStr += " " + employee.PersonID.ToString() +
                             " " + employee.Surname.ToString() +
                             " " + employee.Name.ToString() +
                             " " + date_Of_Employment.Day.ToString() +
                             "." + date_Of_Employment.Month.ToString() +
                             "." + date_Of_Employment.Year.ToString() +
                             " " + employee.Salary.ToString() + " " + "$" + "\r\n";
                ResultTextBox.Text = resultStr;
            }
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\job\projects\DataListEmployer\WriteData.txt"))
                    file.WriteLine(ResultTextBox.Text);
        }

        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();
            LoadToEmployersList();
        }

        internal static void LoadToEmployersList()
        {
            string lineFromFile = "";
            string[] strArray = new string[] { };
            using (System.IO.StreamReader file =
               new System.IO.StreamReader(@"D:\job\projects\DataListEmployer\WriteData.txt"))
                lineFromFile = file.ReadToEnd();
            strArray = lineFromFile.Split(' ');

            for (int i = 1; i < strArray.Length - 5; i += 5)
            {
                personID = 1;
                surname = strArray[i + 1];
                name = strArray[i + 2];
                date_Of_Employment = DateTime.Parse(strArray[i + 3]);
                salary = int.Parse(strArray[i + 4]);
                AddEmployer();
                personID ++;
            }
        }
    }
}
