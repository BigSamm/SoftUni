using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Bubble_Sort_Test
{
    public class BubbleTests
    {
        //ohh that name 0_0
        [Test]
        public void SortMethodSortItems()
        {
            var itemsForSort = new List<int> { 5, 4, 3, 2, 1, 0 };
            var expectedItems = new List<int> { 0, 1, 2, 3, 4, 5 };

            var buuble = new Bubble();

            Assert.That(buuble.Sort(itemsForSort), Is.EqualTo(expectedItems));
        }
    }
}
