using System;
using MainProject.Fundamentals;
using NUnit.Framework;

namespace TestProject
{
	[TestFixture]
	public class FizzBuzzTest
	{
		[Test]
        public void GetOutput_DivisibleBy3And5_ReturnsFizzBuzz()
		{
            var result = FizzBuzz.GetOutput(15);

			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}

        [Test]
        public void GetOutput_DivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisibleBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NonDivisibleBy3Or5_ReturnsSameInput()
        {
            var result = FizzBuzz.GetOutput(8);

            Assert.That(result, Is.EqualTo("8"));
        }
    }
}

