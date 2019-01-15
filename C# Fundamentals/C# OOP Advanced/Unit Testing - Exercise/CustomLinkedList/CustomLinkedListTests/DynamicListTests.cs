using CustomLinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomLinkedListTests
{
    public class DynamicListTests
    {
        [Test]
        public void AddItemInEmptyDynamicListSetItemToHeadAndTail()
        {
            var classType = typeof(DynamicList<int>);
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);

            var head = classType.GetField("head", BindingFlags.NonPublic | BindingFlags.Instance);
            var tail = classType.GetField("tail", BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.That(head.GetValue(dynamicList), Is.EqualTo(tail.GetValue(dynamicList)));
        }

        [Test]
        public void AddItemInDynamicListSetItToTail()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(8);

            var tailValue = dynamicList.RemoveAt(1);

            Assert.That(tailValue, Is.EqualTo(8));
        }

        [Test]
        public void AddItemInDynamicListIncreaseCount()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);

            Assert.That(dynamicList.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveAtMethodRemoveItemAtGivenIndex()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(8);
            dynamicList.Add(13);

            dynamicList.RemoveAt(1);

            Assert.That(dynamicList[1], Is.EqualTo(13));
        }
        
        [Test]
        public void RemoveAtMethodReturnsItemAtGivenIndex()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(8);

            var removedItem = dynamicList.RemoveAt(1);

            Assert.That(removedItem, Is.EqualTo(8));
        }

        [Test]
        public void RemoveAtMethodDecreaseCount()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.RemoveAt(0);

            Assert.That(dynamicList.Count, Is.EqualTo(0));
        }

        [Test]
        public void RemoveMethodRemoveGivenElement()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(8);
            dynamicList.Remove(5);

            Assert.That(dynamicList[0], Is.EqualTo(8));
        }

        //[TestCase(-2)]
        //[TestCase(1)]
        //[TestCase(0)]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void RemoveAtMethodThrowsExceptionWhenIndexIsIncorect(int index)
        //{
        //    var dynamicList = new DynamicList<int>();

        //    Assert.That(() => dynamicList.RemoveAt(index),
        //        Throws.With.Message.EqualTo("Invalid index: " + index));
        //}
        
        [Test]
        public void DynamicListCountReturnCorrectCount()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(8);
            dynamicList.Add(13);

            Assert.That(dynamicList.Count, Is.EqualTo(3));
        }
    }
}
