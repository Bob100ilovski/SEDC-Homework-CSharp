using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //*----Today
            var today = DateTime.Now;
            int todayYear = DateTime.Now.Year; //int
            int todayMonth = DateTime.Now.Month; //int 
            int todayDay = DateTime.Now.Day;
            
            //*----input parametars
            Console.WriteLine("Age Calculator");
            Console.WriteLine("---------------------------");
            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.Write("Enter your last name: ");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.Write("Enter your birthday (MM/dd/yy): ");
            DateTime myB = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            //*----date to int
            int myBYear = myB.Year; //int
            int myBMonth = myB.Month; //int
            int myBDay = myB.Day;

            //*----rezult
            int rezultYear = (todayYear - myBYear); //int
            int rezultMonth = (todayMonth - myBMonth); //int
            int rezultDay = (todayDay - myBDay); //int

            //*----if
            if (rezultMonth < 0)
                Console.WriteLine($"{nameInput.ToUpper()} {lastNameInput.ToUpper()} you are {rezultYear-1} years old.");
            else if (rezultMonth == 0 && rezultDay == 0)
                Console.WriteLine($"It's your birthday today {nameInput.ToUpper()}. {rezultYear} and counting...");
            else
                Console.WriteLine($"{nameInput.ToUpper()} {lastNameInput.ToUpper()} you are {rezultYear} years old.");


        }



        


    }
}
