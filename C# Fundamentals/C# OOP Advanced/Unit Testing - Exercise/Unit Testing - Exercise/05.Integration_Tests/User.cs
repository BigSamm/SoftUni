using System.Collections.Generic;

namespace _05.Integration_Tests
{
    public class User : IUser
    {
        public User(string name)
        {
            this.Name = name;
            this.Categories = new List<ICategory>();
        }

        public string Name { get; }

        public List<ICategory> Categories { get; private set; }

        public void AssignCategory(ICategory category)
        {
            if (!this.Categories.Contains(category))
            {
                this.Categories.Add(category);
                category.AssignUser(this);
            }
        }

        public void RemoveCategory(ICategory category)
        {
            this.Categories.Remove(category);
        }
    }
}