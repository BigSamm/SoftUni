using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Bubble_Sort_Test
{
    public class Bubble
    {
        public IList<int> Sort(IList<int> items)
        {
            for (int counter = 1; counter < items.Count; counter++)
            {
                for (int index = 0; index < items.Count - counter; index++)
                {
                    var firstItem = items[index];
                    var secondItem = items[index + 1];
                    if (firstItem > secondItem)
                    {
                        items[index] = secondItem;
                        items[index + 1] = firstItem;
                    }
                }
            }

            return items;
        }
    }
}
