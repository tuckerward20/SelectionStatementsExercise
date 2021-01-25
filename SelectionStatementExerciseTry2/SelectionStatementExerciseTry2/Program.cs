using System;

namespace SelectionStatementExerciseTry2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}
