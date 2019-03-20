using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_02
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //------- Borce Stojilovski - Home work 02------
            // --- Domashna 1 -------
            Console.WriteLine("Choose a number from 1 to 3");
            string enterNum = Console.ReadLine();
            bool checkNum = int.TryParse(enterNum, out int someNum);

            if (!checkNum)
            {
                Console.WriteLine($"You enter: '{enterNum}'. Input only numbers from 1 to 3");
                return;
            }
  
            if (someNum == 1)
                Console.WriteLine("You got a new car"); 
            else if (someNum == 2)
                Console.WriteLine("You got a new plane");
            else if (someNum == 3)
                Console.WriteLine( "You got a new bike");
            else
                Console.WriteLine("Error!. Input only numbers from 1 to 3");
            //nemora zagradi "{}" ako imame 1 linija kod. 

            //----------------------------------------------

            // --- Domashna 2 -------
            //---First number-----
            Console.Write("Enter first number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = int.TryParse(firstInput, out int first);

            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstInput}' which is not a valid integer");
                return;
            }

            //---Second number-----
            Console.Write("Enter second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = int.TryParse(secondInput, out int second);

            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondInput}' which is not a valid integer");
                return;
            }


            //---Check bigger number -----
            int biggerNumber = (first > second) ? first : second;

            //---Check equal number -----
            if (first - second == 0)
            {
                Console.WriteLine($"The numbers are equal. {first}={second}.");
                return;
            }

            //---Check for even/odd ------
            bool isEven = biggerNumber % 2 == 0;
            string oddEven = isEven ? "even" : "odd";

            Console.WriteLine($"Between {first} and {second} the bigger one is {biggerNumber}, which is an {oddEven} number");
            Console.ReadLine();

        }
    }
}


