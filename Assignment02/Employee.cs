using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment02.Program;

namespace Assignment02
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        private char gender;

        public Employee(int id, string name, string securityLevel, decimal salary, DateTime hire)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hire;
        }
        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3}, Hire Date: {4}, Gender: {5}", ID, Name, SecurityLevel, Salary, HireDate);

        }

        public class HiringDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HiringDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
            public override string ToString()
            {
                return String.Format("Hire Date: {0}/{1}/{2}", Day, Month, Year);
            }
        }
    }
}
