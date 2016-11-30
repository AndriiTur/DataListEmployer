using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DataListEmployer
{
    public class Employee
    {
        private int emploeeID;
        private string surname;
        private string name;
        private DateTime date_Of_Employment;
        private double salary;
        
        public int EmploeeID { get { return emploeeID; } }
        public string Surname { get { return surname; } }
        public string Name { get { return name; } }
        public DateTime Date_Of_Employment { get { return date_Of_Employment; } }
        public double Salary { get { return salary;} set { salary = value; } }

        public Employee(int emploeeID,string surname, string name, DateTime date_Of_Employment, double salary)
        {
            this.emploeeID = emploeeID;
            this.surname = surname;
            this.name = name;
            this.date_Of_Employment = date_Of_Employment;
            this.salary = salary;
        }
    }
}