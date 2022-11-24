using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stackEmpty;

        public StackTests()
        {
            _stackEmpty = new Stack<string>();
        }

        [Test]
        public void Count_ReturnsNumberOfListElements()
        {
            _stackEmpty.Push("test1");
            _stackEmpty.Push("test2");
            _stackEmpty.Push("test3");
            Assert.That(_stackEmpty.Count, Is.EqualTo(3));
            _stackEmpty = new Stack<string>();
        }

        [Test]
        public void Push_ForGivenObject_AddsToTheList()
        {
            _stackEmpty.Push("test1");
            _stackEmpty.Push("test2");
            Assert.That(_stackEmpty.Count, Is.EqualTo(2));
            _stackEmpty = new Stack<string>();
        }

        [Test]
        public void Push_WhenObjectIsNull_ThrowsInvalidOperationException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _stackEmpty.Push(null);
            });
        }

        [Test]
        public void Pop_ForEmptyList_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                _stackEmpty.Pop();
            });
        }

        [Test]
        public void Pop_RemovesLastElementFromListAndReturnsIt()
        {
            _stackEmpty.Push("test1");
            _stackEmpty.Push("test2");
            _stackEmpty.Push("test3");

            var element = _stackEmpty.Pop();

            Assert.That(element, Is.EqualTo("test3"));
            Assert.That(_stackEmpty.Count, Is.EqualTo(2));
            _stackEmpty = new Stack<string>();
        }

        [Test]
        public void Peek_WhenListIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                _stackEmpty.Peek();
            });
        }

        [Test]
        public void Peek_ReturnsLastElementFromList()
        {
            _stackEmpty.Push("test1");
            _stackEmpty.Push("test2");
            _stackEmpty.Push("test3");
            
            var element = _stackEmpty.Peek();

            Assert.That(element, Is.EqualTo("test3"));
            Assert.That(_stackEmpty.Count, Is.EqualTo(3));
            _stackEmpty = new Stack<string>();
        }
    }
}
