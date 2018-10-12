using System;

namespace CG_14_2__Calculator_unit_testing_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Update your calculator app with a unit testing project.Create tests that send 
            //in valid input and tests that send in bad input.

            //explain program, prompt user for equation, give example for correct format.
            Console.WriteLine("Calculator to add, subtract, multiply, or divide two numbers. ");
            Console.Write("Please type out equation to be calculated. (Example: 1 + 1) ");

            //put equation into string
            string equation = Console.ReadLine();

            //create new instance of calculator class using equation string as input.
            Calculator calculator = new Calculator(equation);

            //initiate method from calculator class to calculate equation and print to console
            Console.WriteLine("Answer: {0}", calculator.Calculate());


            Console.ReadLine();

        }
    }
}
