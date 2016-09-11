﻿using System;
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

            Console.WriteLine("What letter in ROYGBIV best represents your favorite color?");
            char favColor = char.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int numOfSibs = int.Parse(Console.ReadLine());

            string fullName = fName + " " + lname; 

//1st if

            if (age % 2 == 0)
            {
                Console.WriteLine(fullName + ", you will retire in 63 years"); 
            }

                else if(age % 2 != 0)
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
                    Console.WriteLine(", and there won't be any money, but when you die, on your deathbed, you will receive total consciousness.  Now go");
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
                    else
                    {
                    Console.WriteLine(", you were going to have a vacation home but since you couldn't enter a valid number of sibling your future is unknown");
                    }

//Last of the ifs

            if (favColor == 'R' || favColor == 'r')
            {
                Console.WriteLine("flying a dirigible.");                
            }
            else if (favColor == 'O' || favColor == 'o')
            {
                Console.WriteLine("captaining the black pearl.");
            }
            else if (favColor == 'Y' || favColor == 'y')
            {
                Console.WriteLine("cruisin' on a vespa.");
            }
            else if (favColor == 'G' || favColor == 'g')
            {
                Console.WriteLine("inside a trojan horse.");
            }
            else if (favColor == 'B' || favColor == 'b')
            {
                Console.WriteLine("driving the batmobile, the crappy original one from the 70s,\nnot the Christian Bale Dark Knight batmobile.");
            }
            else if (favColor == 'I' || favColor == 'i')
            {
                Console.WriteLine("riding a goat.");
            }
            else if (favColor == 'V' || favColor == 'v')
            {
                Console.WriteLine("driving a power wheel.");
            }
                else
                {
                Console.WriteLine("That wasn't a valid answer, but we'll move on.");
                }


        }
    }
} 
