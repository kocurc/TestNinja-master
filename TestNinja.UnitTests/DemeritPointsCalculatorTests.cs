using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(301)]
        [TestCase(-1)]
        public void CalculateDemeritPoints_SpeedIsInvalid_ThrowsArgumentOutOfRangeException(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var demeritPointsCalculator = new DemeritPointsCalculator();

                demeritPointsCalculator.CalculateDemeritPoints(speed);
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(50)]
        [TestCase(64)]
        [TestCase(65)]
        public void CalculateDemeritPoints_SpeedIsEqualToOrLessThanSpeedLimit_Return0(int speed)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var points = demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(0));
        }

        [Test]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(100, 7)]
        [TestCase(300, 47)]
        public void CalculateDemeritPoints_SpeedIsHigherThan65_ReturnsCorrectPoints(int speed, int pts)
        {
            var demericPointsCalculator = new DemeritPointsCalculator();
            var points = demericPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(pts));
        }
    }
}
