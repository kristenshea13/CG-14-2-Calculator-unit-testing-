using CG_14_2__Calculator_unit_testing_;
using System;
using Xunit;

namespace calctest
{
    public class UnitTest1
    {
        
        //needed to test method addition, subtraction, multiplication, and division
        //also created tests that will fail (put incorrect answer in the Assert statement)

        [Fact]
        public void Calculate_Addition_CorrectSum()
        {
            //create equation to input for test and construct instance of class.
            //arrange
            string equation = "3 + 3";
            Calculator calculator = new Calculator(equation);

            //use method to calculate equation
            //act
            double sum = calculator.Calculate();

            //assert that the answer 6 will match the calculated answer.
            //assert
            Assert.Equal(6, sum);
        }

        //testing invalid info, should be 6 so this will not work.
        [Fact]
        public void Calculate_Addition_IncorrectSum()
        {
            //arrange
            string equation = "3 + 3";
            Calculator calculator = new Calculator(equation);

            //act
            double sum = calculator.Calculate();

            //assert
            Assert.Equal(7, sum);
        }

        [Fact]
        public void Calculate_Subtraction_CorrectDifference()
        {

            //arrange
            string equation = "3 - 3";
            Calculator calculator = new Calculator(equation);

            //act
            double difference = calculator.Calculate();

            //assert
            Assert.Equal(0, difference);
        }

        [Fact]
        public void Calculate_Subtraction_IncorrectDifference()
        {
            //incorrect statement, test will fail.
            //arrange
            string equation = "3 - 3";
            Calculator calculator = new Calculator(equation);

            //act
            double difference = calculator.Calculate();

            //assert
            Assert.Equal(1, difference);
        }

        [Fact]
        public void Calculate_Division_CorrectQuotient()
        {
            //set up equation to use in test, construct instance of class.
            //arrange
            string equation = "6 / 3";
            Calculator calculator = new Calculator(equation);

            //use method to calculate equation
            //act
            double quotient = calculator.Calculate();

            //assert that answer from method is the same as the correct answer.
            //assert
            Assert.Equal(2, quotient);
        }

        [Fact]
        public void Calculate_Division_IncorrectQuotient()
        {   
            //incorrect answer, same thing as above but test will fail
            //arrange
            string equation = "6 / 3";
            Calculator calculator = new Calculator(equation);

            //act
            double quotient = calculator.Calculate();

            //assert
            Assert.Equal(1, quotient);
        }

        [Fact]
        public void Calculate_Multiplication_CorrectProduct()
        {
            //set up equation to use in test and construct instance of class
            //arrange
            string equation = "3 * 3";
            Calculator calculator = new Calculator(equation);

            //use method to calculate answer
            //act
            double product = calculator.Calculate();

            //assert that answer produced with method will be equal to correct answer.
            //assert
            Assert.Equal(9, product);
        }

        [Fact]
        public void Calculate_Multiplication_IncorrectProduct()
        {

            //tests incorrect answer, will fail
            //arrange
            string equation = "3 * 3";
            Calculator calculator = new Calculator(equation);

            //act
            double product = calculator.Calculate();

            //assert
            Assert.Equal(7, product);
        }

        [Fact]
        public void Calculate_Gibberish_ThrowsException()
        {
            //arrange
            //incorrect input
            string equation = "7#3";

            //act
            //created a try/catch to test the try/catch in the program
            try
            {
                new Calculator(equation);
            }
            catch (Exception ex)
            {
                Assert.Equal("Invalid equation.", ex.Message);
                return;
            }

            //assert
            //if formula is not entered correctly program will throw an exception.
            Assert.True(false);
        }

        [Fact]
        public void Calculate_Gibberish_ShouldNotThrowException()
        {
            //created to test properly input equation to make sure it won't
            //throw an exception.
            //arrange
            
            string equation = "7 - 3";

            //act
            //created a try/catch to test the try/catch in the program
            try
            {
                new Calculator(equation);
            }
            catch (Exception ex)
            {
                Assert.Equal("Invalid equation.", ex.Message);
                return;
            }

            //assert
            //if formula is not entered correctly program will throw an exception.
            Assert.True(false);
        }

    }
}