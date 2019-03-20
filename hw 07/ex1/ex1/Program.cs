using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Igor", "Angelov", 24500.50);
            employee1.PrintInfo(); //Igor Angelov 24500.5
            double rezult = employee1.GetSalary();
            Console.WriteLine(rezult); // 24500.5


            SalesPerson sale1 = new SalesPerson(102.3, Role.Sales, "Vasil", "Zafircev", 500.2);
            sale1.PrintInfo();
        }
    }
}
