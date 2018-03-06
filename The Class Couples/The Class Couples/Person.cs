using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Class_Couples
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
         {
            return this.FirstName + " " + this.LastName;
         }   

        public void PrintNameAndAge()
        {
            Console.WriteLine(GetFullName() + ", age " + Age);
        }
    }
}
