using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //[easy] challenge #1
            // create a program that will ask the users name, age, and reddit username. have it tell them the information back, in the format:
            // your name is (blank), you are (blank)years old, and your username is (blank)

            string userFullName, userName;
            double userAge;

            Console.WriteLine("What is your full name?");
            userFullName = Console.ReadLine();
            Console.Write("What is your username?");
            userName = Console.ReadLine();
            Console.WriteLine("Whate is your age?");
            userAge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"your name is {userFullName}, your are {userAge} years old, and your username is {userName}");
            Console.ReadKey();

        }
    }
}
