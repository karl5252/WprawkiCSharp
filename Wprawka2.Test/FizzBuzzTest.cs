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
        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;

            //Act
            string output = FizzBuzz.GetVal(input);
            //Assert.Pass();

            //Assert
            Assert.AreEqual("1", output);
        }
        [Test]
        public void Buzzer_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzz.GetVal(input);
            Assert.AreEqual("2", output);
        }
    }
}
