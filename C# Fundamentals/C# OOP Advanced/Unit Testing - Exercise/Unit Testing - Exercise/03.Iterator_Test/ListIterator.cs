using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Iterator_Test
{
    public class ListIterator : IListIterator
    {
        public ListIterator()
        {
            this.Items = new List<string>();
            this.CurrentIndex = 0;
        }

        public List<string> Items { get; private set; }

        public int CurrentIndex { get; private set; }

        public string CurrentItem => this.Items[this.CurrentIndex];

        public void Create(List<string> items)
        {
            this.Items = items;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.CurrentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.CurrentIndex == this.Items.Count - 1)
                return false;
            else
                return true;
        }

        public string Print()
        {
            if (this.Items.Count == 0)
                throw new InvalidOperationException("Invalid Operation!");

            return this.CurrentItem;
        }
    }
}
