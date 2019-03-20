using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // array
            Student[] student = new Student[5];

            // for for create students
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                Console.Write("Enter name: ");
                student[i].FirstName = Console.ReadLine();
                Console.Write("Enter group: ");
                student[i].Group = Console.ReadLine();
                Console.Write("Enter academy: ");
                student[i].Academy = Console.ReadLine();
            }

            // for for-Intro()
            for (int j = 0; j < student.Length; j++)
            {
                Console.WriteLine($"Student {j+1}: {student[j].Intro().ToUpper()}");
            }

            

            Console.Read();
        }
    }
}
