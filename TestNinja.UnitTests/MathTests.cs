using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // TODO Coverage: we can cover tests by RMB clicking on a class file with tests and choosing Cover Unit Tests from ReSharper
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        // TODO Testing numbers
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Already covered.")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ShouldReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        // TODO Testing collections
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var math = new Math();
            var numbers = math.GetOddNumbers(5);

            CollectionAssert.AreEquivalent(new[] {1, 3, 5}, numbers);
            CollectionAssert.IsOrdered(numbers);
        }

        [Test]
        public void GetOddNumbers_LimitIsLessThanZero_ReturnEmptyCollection()
        {
            var math = new Math();
            var numbers = math.GetOddNumbers(-5);

            CollectionAssert.IsEmpty(numbers);
        }

        [Test]
        public void GetOddNumbers_LimitIsEqualToZero_ReturnEmptyCollection()
        {
            var math = new Math();
            var numbers = math.GetOddNumbers(0);

            CollectionAssert.IsEmpty(numbers);
        }
    }
}
