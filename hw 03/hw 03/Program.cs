using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //------EXERCISE 4----------
            string[] arrayWords = new string[]{"word1", "word2", "word3", "word4", "word5"};
            Console.WriteLine(arrayWords);
            double[] arrayDecimal = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            Console.WriteLine(arrayDecimal);
            string[] arrayChara = new string[] { "!","@","#","$","%"};
            Console.WriteLine(arrayChara);
            bool[] arrayB = new bool[] { true, false, true, false, true };
            Console.WriteLine(arrayB);
            int[][] arrayNum = new int[5][] { new int[] { 1,2 }, new int[] { 3,4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 9, 10 } };
            Console.WriteLine(arrayNum);

            //------EXERCISE 5----------
            int[] myArray1 = new int[5];

            for(int i = 0; i<myArray1.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out myArray1[i]);
            }
            Console.WriteLine(myArray1);

            int mySum = 0;
            for(int j=0; j<myArray1.Length; j++)
            {
                mySum = mySum + myArray1[j];
            }
            Console.WriteLine(mySum);
            

            // Zadaca 6 inputot napraven e samo so mali bukvi "y" ili "n".
            //------EXERCISE 6 ----------
            string[] myNames = new string[0];
            int fillMyArray = 1;
            string userInput = "y";
            string userInput2 = "n";

            for (int i = 0; i < fillMyArray; i++)
            {
                Console.WriteLine("Enter 'y' to continue, or 'n' to stop!");
                if (userInput == Console.ReadLine())
                {
                    Array.Resize(ref myNames, fillMyArray);
                    Console.WriteLine("Enter name");
                    myNames[i] = Console.ReadLine();
                    fillMyArray++;
                    
                }
                else if (userInput2 == Console.ReadLine())
                {
                    Console.WriteLine("end entering names");
                    break;
                }
            }
            Console.WriteLine(myNames);

            Console.Read();
        }
    }
}
