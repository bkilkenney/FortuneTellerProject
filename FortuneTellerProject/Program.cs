using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
            Console.WriteLine("How old are you?");
            Console.ReadLine();
            Console.WriteLine("What is your birth month as a number?");
            Console.ReadLine(); 
            Console.WriteLine("What is your favorite ROYGBIV color?  Enter \"Help\" if you don't know the ROYGBIV colors."); //All strings
            Console.ReadLine();                                                                                             //convert where needed
            Console.WriteLine("How many siblings do you have?");
            Console.ReadLine(); 
        }
    }
}
