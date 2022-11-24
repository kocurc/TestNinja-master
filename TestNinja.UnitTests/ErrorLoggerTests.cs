using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        // TODO Test void methods
        [Test]
        public void Log_ForAnyNotNullOrWhiteSpacesString_AssignsItToLastErrorProperty()
        {
            var result = new ErrorLogger();
            const string message = "test";

            result.Log(message);

            Assert.That(result.LastError, Is.EqualTo(message));
        }

        [Test]
        public void Log_ForNullString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new ErrorLogger().Log(null);
            });
        }

        [Test]
        public void Log_ForWhiteSpacesString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new ErrorLogger().Log("  ");
            });
        }

        [Test]
        public void Log_ForEmptyString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new ErrorLogger().Log(string.Empty);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        public void Log_ForInvalidString_ThrowsArgumentNullException(string message)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new ErrorLogger().Log(message);
            });

            Assert.That(() => new ErrorLogger().Log(message), Throws.ArgumentNullException);
            Assert.That(() => new ErrorLogger().Log(message), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;

            logger.ErrorLogged += ((sender, guid) =>
            {
                id = guid;
            });
            logger.Log("test");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        // TODO We don't test private and protected methods!
        /*[Test]
        public void Test()
        {
            var log = new ErrorLogger();

            log.OnErrorLogged();
            Assert.True(true);
        }*/
    }
}
