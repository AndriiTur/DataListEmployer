using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;


namespace DataListEmployer
{
    public class Employee
    {
        public enum EmployeeToStringMode { store, displayInfo }

        public int EmployeeID { get; private set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public DateTime Date_Of_Employment { get; private set; }
        public double Salary { get; set; }

        public Employee(int emploeeID, string surname, string name, DateTime date_Of_Employment, double salary)
        {
            this.EmployeeID = emploeeID;
            this.Surname = surname;
            this.Name = name;
            this.Date_Of_Employment = date_Of_Employment;
            this.Salary = salary;
        }

        public static Employee LoadFromString(string employeeStr)
        {
            int employeeID = 1;
            string surname = "";
            string name = "";
            DateTime date_Of_Employment = new DateTime { };
            double salary = 0;
            var employee = new Employee(employeeID, surname, name, date_Of_Employment, salary);
            string[] result = new string[] { };
            result = employeeStr.Split('\t');
            employee.EmployeeID = int.Parse(result[0]);
            employee.Surname = result[1];
            employee.Name = result[2];
            employee.Date_Of_Employment = DateTime.Parse(result[3]);
            employee.Salary = int.Parse(result[4]);
            return employee;
        }

        public static string SaveToString(Employee employee, EmployeeToStringMode mode = EmployeeToStringMode.store)
        {
            string resultStr = "";
            if (mode == EmployeeToStringMode.displayInfo)
            {
                resultStr += employee.EmployeeID.ToString() +
                                "\t" + employee.Surname.ToString() +
                                " " + employee.Name.ToString() +
                                "\t" + string.Format("{0:ddd} {1:dd MMMM yyyy} y. Time{2:HH:mm}",
                                                     employee.Date_Of_Employment,
                                                     employee.Date_Of_Employment,
                                                     employee.Date_Of_Employment) +
                                "\t" + string.Format("${0:#,###}", employee.Salary) + "\r\n";
            }
            else
            {
                resultStr += employee.EmployeeID.ToString() +
                                "\t" + employee.Surname.ToString() +
                                "\t " + employee.Name.ToString() +
                                "\t" + string.Format("{0:dd.MM.yyyy HH:mm}", employee.Date_Of_Employment) +
                                "\t" + employee.Salary.ToString() + "\r\n";
            }
            return resultStr;
        }
    }
}