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

                //Next birth month

            Console.WriteLine("What is your birth month as a number?");

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

            //Next, favorite color question

            Console.WriteLine("What letter in ROYGBIV best represents your favorite color?");
            Console.ReadLine(); 
            char favColor = char.Parse(Console.ReadLine());

            if(favColor == 'R')
            {
                Console.WriteLine("flying a dirigible");
            }
                else if(favColor == 'O')
            {
                Console.WriteLine("captaining the black pearl");
            }
                else if (favColor == 'Y')
            {
                Console.WriteLine("cruisin' on a vespa");
            }
                else if(favColor == 'G')
            {
                Console.WriteLine("inside a trojan horse");
            }
                else if(favColor == 'B')
            {
                Console.WriteLine("driving the batmobile, the crappy original one from the 70s,\nnot the Christian Bale Dark Knight batmobile");
            }
            else if(favColor == 'I')
            {
                Console.WriteLine("riding a goat");
            }
            else if(favColor == 'V')
            {
                Console.WriteLine("driving a power wheel");
            }
                else
            {
                Console.WriteLine("That wasn't a valid answer, but we'll move on.");
            }
                                                                                                                                            
            Console.WriteLine("How many siblings do you have?");
            int numOfSibs = int.Parse(Console.ReadLine()); 

            if(numOfSibs == 0)
            {
                Console.WriteLine("to your vacation home in an igloo");
            }
            else if(numOfSibs == 1)
            {
                Console.WriteLine("to your vacation home in Schenectady");
            }
            else if(numOfSibs == 2)
            {
                Console.WriteLine("to your vacation home in Cleveland Hopkins Terminal C");
            }
            else if(numOfSibs == 3)
            {
                Console.WriteLine("to your vacation home in Walla Walla Washington");
            }
            else if(numOfSibs <= 0 || numOfSibs >= 4)
            {
                Console.WriteLine("to your vacation home in the BMV");
            }
                else
                    {
                Console.WriteLine(", you were going to have a vacation home but since you couldn't enter a valid number of sibling your future is unknown");
            }
        }
    }
} 
