using System;
using System.Collections.Generic;
using System.Text;

namespace CG_14_2__Calculator_unit_testing_
{
    public class Calculator
    {

        //properties for calculator class
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string EqAction { get; set; }


        //separate equation string into elements to create instance of calculator class.
        public Calculator(string equation)
        {
            //use try/catch to print an error message if equation was not entered in proper format.
            //if it was typed correctly, split into Number1, Number2, and EqAction(equation action)
            try
            {
                string[] equationSplit = equation.Split(" ");

                for (int i = 0; i < equationSplit.Length; i++)
                {
                    if (i == 0)
                        Number1 = int.Parse(equationSplit[i]);

                    else if (i == 1)
                        EqAction = equationSplit[i];

                    else
                        Number2 = int.Parse(equationSplit[i]);

                }
            }
            //when user inputs equation incorrectly, it will tell them the equation is invalid.
            catch (Exception ex)
            {
                Console.WriteLine("Invalid equation.");
                Console.WriteLine(ex.Message);
            }


        }

        //method to complete calculation of equation.
        public void Calculate()
        {
            double answer = 0;

            if (EqAction == "+")
                answer = Number1 + Number2;

            else if (EqAction == "-")
                answer = Number1 - Number2;

            else if (EqAction == "*")
                answer = Number1 * Number2;

            else if (EqAction == "/")
                answer = Number1 / Number2;

            //don't need an else statement, exceptions are
            //caught in the try/catch statement above.

            Console.WriteLine($"Answer: {answer}");
        }

    }











}
