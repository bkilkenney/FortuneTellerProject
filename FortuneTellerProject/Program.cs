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
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\aWhat is your first name?");
            string fName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month as a number?");
            int bMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?  If you are not familiar with ROYGBIV enter\"Help\"");
            string favColor = Console.ReadLine();
            string convertAllToLower = "help";
                if (favColor == "help")
                {
                Console.WriteLine("R is for Red\nO is for Orange\nY is for Yellow\nG is for Green\nB is for Blue\nI is for Indigo\nV is for Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                Console.ReadLine();
                }
         
            
            Console.WriteLine("How many siblings do you have?");
            int numOfSibs = int.Parse(Console.ReadLine());

            string fullName = fName + " " + lname;

//1st if

            if (age % 2 == 0)
            {
                Console.WriteLine(fullName + ", you will retire in 63 years");
            }

            else if (age % 2 != 0)
            {
                Console.WriteLine(fullName + ", you will retire in 3 years");
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }

//2nd if

            if (bMonth >= 1 && bMonth <= 4)
            {
                Console.WriteLine("with $200,000 in the bank");
            }
            else if (bMonth >= 5 && bMonth <= 8)
            {
                Console.WriteLine("with $6M in the bank");
            }
            else if (bMonth >= 9 && bMonth <= 12)
            {
                Console.WriteLine("with $35.78 in the bank");
            }
            else if (bMonth < 1 || bMonth > 12)
            {
                Console.WriteLine(", and there won't be any money, but when you die, on your deathbed,\n you will receive total consciousness.  Now go");
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }


      //3rd if


            if (numOfSibs == 0)
            {
                Console.WriteLine("to your vacation home in an igloo");
            }
            else if (numOfSibs == 1)
            {
                Console.WriteLine("to your vacation home in Schenectady");
            }
            else if (numOfSibs == 2)
            {
                Console.WriteLine("to your vacation home in Cleveland Hopkins International Airport Terminal C");
            }
            else if (numOfSibs == 3)
            {
                Console.WriteLine("to your vacation home in Walla Walla Washington");
            }
            else if (numOfSibs <= 0 || numOfSibs >= 4)
            {
                Console.WriteLine("to your vacation home at the BMV");
            }


            //Last of the ifs. It is taking the char answer and parsing it to a int behind the scenes so ==, > operators will work.  But what about the help option?  


            if (favColor == "Red")
            {
                Console.WriteLine("flying a dirigible.");
            }
            else if (favColor == "Orange")
            {
                Console.WriteLine("captaining the black pearl.");
            }
            else if (favColor == "Yellow")
            {
                Console.WriteLine("cruisin' on a vespa.");
            }
            else if (favColor == "Green")
            {
                Console.WriteLine("inside a trojan horse.");
            }
            else if (favColor == "Blue")
            {
                Console.WriteLine("driving the batmobile, the crappy original one from the 70s,\nnot the Christian Bale Dark Knight batmobile.");
            }
            else if (favColor == "Indigo")
            {
                Console.WriteLine("riding a goat.");
            }
            else if (favColor == "Violet")
            {
                Console.WriteLine("driving a power wheel.");
            }
            else if (favColor == "help") ;
            {
                Console.WriteLine("driving an M1 Abrahms tank.");
            }
        }
    }
} 
