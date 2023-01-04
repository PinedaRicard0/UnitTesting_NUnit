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
        [TestCase(5, 3, 5)]
        [TestCase(3, 5, 5)]
        [TestCase(5, 5, 5)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math?.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

