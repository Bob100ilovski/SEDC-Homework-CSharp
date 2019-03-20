using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class SalesPerson : Employee
    {
        // properti
        private double SuccessSaleRevenue { get; set; }
        public Role WhatRole { get; set; }

        public SalesPerson (double successSaleRevenue, Role whatRole, string firstName, string lastName, double salary) 
            : base ( firstName,  lastName,  salary)
        {

            //novite od SalesPerson
            this.SuccessSaleRevenue = successSaleRevenue;
            this.WhatRole = whatRole;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary} {SuccessSaleRevenue} {WhatRole}");
        }


    }
}




