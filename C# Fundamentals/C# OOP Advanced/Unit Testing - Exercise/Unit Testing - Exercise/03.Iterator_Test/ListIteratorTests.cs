using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Iterator_Test
{
    public class ListIteratorTests
    {
        [Test]
        public void NewListIteratorSetCollectionOfStrings()
        {
            IListIterator listIterator = InitializeListIterator();

            Assert.That(listIterator.Items, Is.EqualTo(new List<string>()));
        }

        [Test]
        public void NewListIteratorSetCurrentIndexAtZero()
        {
            IListIterator listIterator = InitializeListIterator();

            Assert.That(listIterator.CurrentIndex, Is.EqualTo(0));
        }

        [Test]
        public void ListIteratorCurrentItemReturnItemAtCurrentIndex()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b" };
            listIterator.Create(testList);
            listIterator.Move();

            Assert.That(listIterator.CurrentItem, Is.EqualTo("b"));
        }

        [Test]
        public void ListIteratorCreateCommandSetItemsInCollection()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b", "c" };
            listIterator.Create(testList);

            Assert.That(listIterator.Items, Is.EqualTo(testList));
        }

        [Test]
        public void ListIteratorMoveCurrentIndexToNext()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b" };
            listIterator.Create(testList);
            listIterator.Move();

            Assert.That(listIterator.CurrentIndex, Is.EqualTo(1));
        }

        [Test]
        public void MoveCommandReturnTrueWhenMoveCurrentIndex()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b" };
            listIterator.Create(testList);

            Assert.That(listIterator.Move(), Is.EqualTo(true));
        }

        [Test]
        public void MoveCommandReturnFalseWhenHasNotNextIndex()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a" };
            listIterator.Create(testList);

            Assert.That(listIterator.Move(), Is.EqualTo(false));
        }

        [Test]
        public void HasNextCommandReturnTrueWhenHasNextIndex()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b" };
            listIterator.Create(testList);

            Assert.That(listIterator.HasNext(), Is.EqualTo(true));
        }

        [Test]
        public void HasNextCommandReturnFalseWhenHasNotNextIndex()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a" };
            listIterator.Create(testList);

            Assert.That(listIterator.HasNext(), Is.EqualTo(false));
        }

        [Test]
        public void PrintCommandReturnCurrentItem()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string> { "a", "b" };
            listIterator.Create(testList);
            listIterator.Move();

            Assert.That(listIterator.Print(), Is.EqualTo("b"));
        }

        [Test]
        public void PrintCommandThrowsExceptionWhenHasNoItems()
        {
            IListIterator listIterator = InitializeListIterator();

            var testList = new List<string>();
            listIterator.Create(testList);

            Assert.That(() => listIterator.Print(), 
                Throws.InvalidOperationException.With.Message.EqualTo("Invalid Operation!"));
        }

        private IListIterator InitializeListIterator()
        {
            IListIterator listIterator = new ListIterator();
            return listIterator;
        }
    }
}
