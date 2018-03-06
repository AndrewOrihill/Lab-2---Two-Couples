using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Class_Couples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Spouse = new Person();

            Console.Write("Hello there, first person! What is your first name? ");
            p1.FirstName = System.Console.ReadLine();

            Console.Write("And your last name? ");
            p1.LastName = Console.ReadLine();

            Console.Write("What about your age? ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.Write("Splendid. \nNow, I am going to assume that you are married, or if you are not, you have an ideal spouse in mind. \n" +
                "In either case, what is this lovely person's name? ");
            p1.Spouse.FirstName = Console.ReadLine(); 
            p1.Spouse.LastName = p1.LastName;

            Console.WriteLine("For marriage's sake, I shall assume your spouse in mind also shares your last name. \n" +
                "But what about your spouse's age?");
            p1.Spouse.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your full name is " + p1.GetFullName()); 
            Console.WriteLine("The full name of your spouse is " + p1.Spouse.GetFullName());

            Person p2 = new Person();
            p2.Spouse = new Person();

            Console.Write("Now, let's shift our attention to your friend. What is your friend's first name? ");
            p2.FirstName = System.Console.ReadLine();

            Console.Write("And your friend's last name? ");
            p2.LastName = Console.ReadLine();

            Console.Write("What about your friend's age? ");
            p2.Age = int.Parse(Console.ReadLine());

            Console.Write("Wonderful! \nJust like with you, I assume your friend is married, but if not, your has an ideal spouse in mind. \n" +
                "In either case, what is this delightful person's name? ");
            p2.Spouse.FirstName = Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;

            Console.WriteLine("For marriage's sake, I shall assume your friend's spouse in mind also shares your friend's last name. \n" +
                "But what about your friend's spouse's age?");
            p2.Spouse.Age = int.Parse(Console.ReadLine());


            Console.WriteLine("The full name of your friend is " + p2.GetFullName());
            Console.WriteLine("The full name of your friend's spouse is " + p2.Spouse.GetFullName());


            Console.WriteLine("So, the first happy couple we have is: ");
            p1.PrintNameAndAge();
            Console.WriteLine("Paired up with,");
            p1.Spouse.PrintNameAndAge();


            Console.WriteLine("The second happy couple we have is:");
            p2.PrintNameAndAge();
            Console.WriteLine("Hooked up with,");
            p2.Spouse.PrintNameAndAge();

            Person.SumOfAllAges = p1.Age + p1.Spouse.Age + p2.Age + p2.Spouse.Age;
            Console.WriteLine("The sum of the ages amounts to " + Person.SumOfAllAges);

            Console.WriteLine("The average age of the people here amounts to " + Person.SumOfAllAges / 4.0 );

            Console.WriteLine("That's all, folks! Press any key to continue.");
            Console.ReadKey();

        }
    }
}
