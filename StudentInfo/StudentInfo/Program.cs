using System;
using System.Linq;

namespace StudentInfo
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = string.Empty;

        beginning_label:

            Console.Clear();
            
            Console.WriteLine("\n\nWhat's your name?  ");
            input = Console.ReadLine();
            Console.WriteLine("\nHi {0}!\n", input);

            Console.WriteLine("\n\nWhat's your age?  ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("\nAt age {0}, I was {1} \n", input, result > 25 ? "a superhero" : "a pirate");
            }
            else
            {
                Console.WriteLine("\nYou are an alien! LOL\n");
            }

            Console.WriteLine("\n\nWhat's your favorite color?");
            input = Console.ReadLine();
            Console.WriteLine("\nWhat are the odds, my favorite color is {0}, too!\n\n", input);

            Console.Write("<Y> to quit: ");

            if (Console.ReadLine().ToLower() != "y")
                goto beginning_label;

        }
    }
}
