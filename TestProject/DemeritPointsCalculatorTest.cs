using System;
using MainProject.Fundamentals;
using NUnit.Framework;

namespace TestProject
{
	[TestFixture]
	public class DemeritPointsCalculatorTest
	{
		private DemeritPointsCalculator? _demerit;

		[SetUp]
        public void SetUp()
        {
            _demerit = new DemeritPointsCalculator();
        }


        [Test]
		public void CalculateDemeritPoints_SpeedLessThanZero_ReturnOutOfRangeException()
		{
			Assert.That(() => _demerit?.CalculateDemtericPoints(-1),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
		}

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65, 0)]
        public void CalculateDemeritPoints_SpeedBetweenZeroAndSpeedLimit_ReturnZero(int speed, int expectedResult)
        {
            var result = _demerit?.CalculateDemtericPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(68,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        [TestCase(99,6)]
        public void CalculateDemeritPoints_SpeedGreaterThan65_ReturnsNumberGreaterThan0(int speed, int expectedResult)
        {
            var result = _demerit?.CalculateDemtericPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

