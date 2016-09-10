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
            Console.WriteLine("\aWhat is your first name?");
            Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine()); 
                if(age % 2 ==0)
                {
                Console.WriteLine("You will retire in 450 years");
                }
                else
                {
                Console.WriteLine("You will retire in 3 years"); 
                }

            Console.WriteLine("What is your birth month as a number?");
<<<<<<< HEAD
            int bMonth = int.Parse(Console.ReadLine());
  
             if(bMonth >= 1 && bMonth <= 4)
            {
                Console.WriteLine("with $200,000 in the bank");
            }
             else if(bMonth >= 5 && bMonth <= 8)
            {
                Console.WriteLine("with $6M in the bank");
            }
             else if(bMonth >= 9 && bMonth <= 12)
            {
                Console.WriteLine("with $35.78 in the bank");
            }
             else if(bMonth < 1 || bMonth > 12)
            {
                Console.WriteLine("and there won't be any money, but when you die, on your deathbed, you will receive total consciousness");
            }

            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.ReadLine();  //want to only look for the first letter behind the scenes here. 
                                   
=======
            Console.ReadLine(); 
            Console.WriteLine("What is your favorite ROYGBIV color?  Enter \"Help\" if you don't know the ROYGBIV colors."); //All strings
            Console.ReadLine();                                                                                             //convert where needed
            Console.WriteLine("How many siblings do you have?");
            Console.ReadLine(); 
>>>>>>> b0fdb85e6ca6da4acf57de6ace04f463351606ef
        }
    }
} 
