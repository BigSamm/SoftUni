using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.Items = new List<Item>();
        }

        public int Capacity { get; } = 100;
        public int Load => Items.Sum(i => i.Weight);
        public IReadOnlyCollection<Item> Items { get; private set; }

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
                throw new InvalidOperationException(ErrorMessages.FullBag);

            var newItems = new List<Item>(this.Items);
            newItems.Add(item);
            this.Items = newItems;
        }

        public Item GetItem(string name)
        {
            if (this.Items.Count == 0)
                throw new InvalidOperationException(ErrorMessages.EmptyBag);

            var item = this.Items.FirstOrDefault(i => i.GetType().Name == name);

            if (item == null)
                throw new ArgumentException(String.Format(ErrorMessages.ItemDoesNotExist, name));

            return item;
        }

        internal bool ExistItem(Item item)
        {
            if (this.Items.Contains(item))
                return true;
            else
                return false;
        }

        internal void UseItem(Item item)
        {
            var newItems = new List<Item>(this.Items);
            newItems.Remove(item);
            this.Items = newItems;
        }
    }
}
