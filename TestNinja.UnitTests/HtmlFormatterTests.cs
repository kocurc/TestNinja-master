using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        // TODO Testing strings
        [Test]
        public void FormatAsBold_ContentIsEmptyStringOrNull_ReturnsTagsWithoutContent()
        {
            var formatted = new HtmlFormatter();
            var resultEmpty = formatted.FormatAsBold("");
            var resultNull = formatted.FormatAsBold("");

            Assert.AreEqual(resultEmpty, "<strong></strong>");
            Assert.That(resultNull, Is.EqualTo("<strong></strong>"));
        }

        [Test]
        public void FormatAsBold_ContentIsSomeText_ReturnsFormattedString()
        {
            var formatted = new HtmlFormatter();
            var result = formatted.FormatAsBold("test");

            Assert.AreEqual(result, "<strong>test</strong>");
            Assert.That(result, Is.EqualTo("<strong>test</strong>"));
        }
    }
}
