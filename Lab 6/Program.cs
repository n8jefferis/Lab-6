using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            while (run == true)
            {
               
                    Random rando = new Random();

                
                    Console.WriteLine("Enter number of sides for a pair of dice ");
                    int sides = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of dice ");
                    int dice = int.Parse(Console.ReadLine());

                   //Console.WriteLine("Roll the dice? Y/N ");
                
                   run = Start();


                     int roll = Roll(sides, dice, rando);
                    Console.WriteLine("Roll total: " + roll);
                    
                    run = Continue();



            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Would you like to roll the dice again? Y/N");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("invalid input");
                run = Continue();
            }

            return run;
        }
    
        public static Boolean Start()
        {
            Console.WriteLine("Would you like to roll the dice? Y/N");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("invalid input");
                run = Start();
            }

            return run;
        }

        public static int GetRandom(int min, int max, Random rand)
        {
            Random r = new Random();
            int output = rand.Next(min, max);
            return output;

        }

        public static int Roll(int sides, int dice, Random rand)
        {
            int i;
            int output = 0;
            for (i = 0; i <= dice; i++)
            {
                output = output + GetRandom(1, sides, rand);

            }
            
            return output;
        }
    }
}
