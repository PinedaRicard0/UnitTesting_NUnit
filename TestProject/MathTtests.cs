using System;
using NUnit.Framework;
namespace TestProject
{
	[TestFixture]
	public class MathTtests
	{
        private  MainProject.Fundamentals.Math? _math;

        /// <summary>
        /// This Decorator indicates that the logic inside will run before every
        /// test you have
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _math = new MainProject.Fundamentals.Math();
        }

		[Test]
		public void Add_WhenCalled_ReturnSumOfArguments()
		{
			var result = _math?.Add(5, 3);

			Assert.That(result, Is.EqualTo(8));
		}

        [Test]
        public void Max_WhenFirstArgumentIsGraeterThanSecond_ReturnFirstArgument()
        {
            var result = _math?.Max(5, 3);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Max_WhenSecondArgumentIsGraeterThanFirst_ReturnSecondArgument()
        {
            var result = _math?.Max(3, 5);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Max_WhenArgumentsAreEqual_ReturnSameArgument()
        {
            var result = _math?.Max(5, 5);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}

