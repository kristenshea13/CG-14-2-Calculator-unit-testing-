using CG_14_2__Calculator_unit_testing_;
using System;
using Xunit;

namespace calctest
{
    public class UnitTest1
    {
        

            //[fact] for every method in test project
            //should follow the three A's (AAA)
            //arrange-set up data for test to run
            //act-
            //assert


            [Fact]
        public void Calculate_Addition_CorrectSum()
        {
            //arrange
            string equation = "3 + 3";
            Calculator calculator = new Calculator(equation);

            //act
            double sum = calculator.Calculate();

            //assert
            Assert.Equal(6, sum);


        }







        
    }
}
