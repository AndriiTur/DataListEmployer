using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DataListEmployer
{
    public class Employee
    {
        private int personID;
        private string surname;
        private string name;
        private DateTime date_Of_Employment;
        private int salary;
        
        public int PersonID { get { return personID; } }
        public string Surname { get { return surname; } }
        public string Name { get { return name; } }
        public DateTime Date_Of_Employment { get { return date_Of_Employment; } }
        public int Salary { get { return salary;} set { salary = value; } }

        public Employee(int personID,string surname, string name, DateTime date_Of_Employment, int salary)
        {
            this.personID = personID;
            this.surname = surname;
            this.name = name;
            this.date_Of_Employment = date_Of_Employment;
            this.salary = salary;
        }
    }
}