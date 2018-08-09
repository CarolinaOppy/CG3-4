using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing variables//
            int x;
            int y;
            string method;

            //establishing the program//
            Console.WriteLine("Let's Do Math!");
            //asking for variables and method//
            Console.WriteLine("Input your first number.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number.");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to add, subtract, multiply or divide?");
            method = Console.ReadLine();

            //creating code to read input and determine method//
            int answer = 0;

            if (method == "add")
            {
                answer = x + y;
            }

            else if (method == "subtract")
            {
                answer = x-y;
            }

            else if (method == "multiply")
            {
                answer = x*y;
            }

            else if (method == "divide")
            {
                answer = x/y;
            }

            else
            {
                Console.WriteLine("Sorry that is not correct format!");     //Catch
                Console.ReadLine();
            }

            Console.WriteLine(answer);
            Console.ReadLine();

        }

    }
}
