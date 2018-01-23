using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();

            while (repeat == true)
            {
                Console.WriteLine("Enter a number between 1 and 100");
                string Input = Console.ReadLine();

                if (int.TryParse(Input, out var num1) && num1 >= 0 && num1 <= 100)//validate input
                {
                    Console.WriteLine($"Thanks, {Name}!");
                    if (num1 % 2 == 1)//checks for odd value
                    {
                        Console.WriteLine($"{Input} Odd");
                    }
                    else if (num1 <= 25)//checks for even values under or equal to 25
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (num1 > 25)//checks for even values over 25
                    {
                        Console.WriteLine("Even");
                    }

                    Console.WriteLine("Would you like to try again? (Y/N)");
                    string again = Console.ReadLine();

                    if (again != "Y" && again != "y")
                    {
                        repeat = false;
                        Console.WriteLine($"Goodbye, {Name}");
                    }

                }
                else
                {
                    Console.WriteLine($"Sorry, {Name}, that's an invalid entry");
                    Console.WriteLine("Would you like to try again? (Y/N)");
                    string again = Console.ReadLine();

                    if (again != "Y" && again != "y")
                    {
                        repeat = false;
                        Console.WriteLine($"Goodbye, {Name}");
                    }
                }

            }


            

        }
    }
}
