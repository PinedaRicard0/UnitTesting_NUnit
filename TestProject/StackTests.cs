using System;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class StackTests
	{
        private MainProject.Fundamentals.Stack<int?>? _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new MainProject.Fundamentals.Stack<int?>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack?.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack?.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArgument_AddElementToTop()
        {
            _stack?.Push(5);
            Assert.That(_stack?.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack?.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackHasItems_ReturnTopValue()
        {
            _stack?.Push(5);
            _stack?.Push(3);
            _stack?.Push(2);
            _stack?.Push(8);

            var result = _stack?.Pop();

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Pop_StackHasItems_RemoveTopValue()
        {
            _stack?.Push(5);
            _stack?.Push(3);
            _stack?.Push(2);
            _stack?.Push(8);

            _= _stack?.Pop();

            Assert.That(_stack?.Count, Is.EqualTo(3));
        }

        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack?.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackHasItems_ReturnTopValue()
        {
            _stack?.Push(5);
            _stack?.Push(3);
            _stack?.Push(2);
            _stack?.Push(8);

            var result = _stack?.Peek();

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Peek_StackHasItems_DoesNotRemoveTopValue()
        {
            _stack?.Push(5);
            _stack?.Push(3);
            _stack?.Push(2);
            _stack?.Push(8);

            _= _stack?.Peek();

            Assert.That(_stack?.Count, Is.EqualTo(4));
        }
    }
}

