using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15, "FizzBuzz")]
        [TestCase(39, "Fizz")]
        [TestCase(50, "Buzz")]
        [TestCase(11, "11")]
        [Test]
        public void GetOutput_ForGivenInt_ReturnsAppropriateString(int number, string output)
        {
            var outputMethod = FizzBuzz.GetOutput(number);

            Assert.AreEqual(outputMethod, output);
        }


    }
    
}
