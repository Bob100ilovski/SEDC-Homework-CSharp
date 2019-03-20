using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05
{
    class Student
    {

        public string FirstName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }


        public string Intro()
        {
            return $"{FirstName} from group {Group} academy {Academy}";
        }

    }
}
