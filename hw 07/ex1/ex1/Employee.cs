using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Employee
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        // constructor
        public Employee(string firstName, string lastName, double salary)
        {
            //'this.' koristam za avtomatski da mi snapne na properito
            this.FirstName = firstName; 
            this.LastName = lastName;
            this.Salary = salary;
        }


        //Method PrintInfor() and GetSalary()
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }
        public double GetSalary()
        {
            return Salary;
        }

        public Employee()
        {
            //ova go napraviv za da funkcionira SalesPerson
            this.FirstName = "fN";
            this.LastName = "lN";
            this.Salary = 1.1;
        }

    }
}
