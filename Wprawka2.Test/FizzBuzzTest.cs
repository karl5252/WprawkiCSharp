using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprawka2.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4,7,8)] int input)
        {
            //Act
            string output = FizzBuzz.GetVal(input);
            //Assert.Pass();

            //Assert
            Assert.AreEqual(input.ToString(), output);
        }     
        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("Fizz", output);
        }
       
        [Test]
        public void Buzzer_WhenDefault_ReturnBuzz(
            [Values(5)] int input)
        {
            
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_WhenDivisibleBy3_ReturnFizz([Values(3,6,9,12,18,21,24,27)] int input)
        {
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_WhenDivisibleBy5_ReturnBuzz([Values(5,10,20)] int input)
        {
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_WhenDivisibleBy3And5_ReturnFizzBuzz([Values(15,30)] int input)
        {
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
