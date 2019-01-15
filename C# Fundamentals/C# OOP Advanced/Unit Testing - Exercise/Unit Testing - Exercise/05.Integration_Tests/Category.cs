using System.Collections.Generic;

namespace _05.Integration_Tests
{
    public class Category : ICategory
    {
        public Category(string name)
        {
            this.Name = name;
            this.Users = new List<IUser>();
            this.ChildCategory = null;
            this.ParentCategory = null;
        }

        public string Name { get; }

        public List<IUser> Users { get; private set; }

        public ICategory ChildCategory { get; private set; }

        public ICategory ParentCategory { get; private set; }

        public void AssignUser(IUser user)
        {
            if (!this.Users.Contains(user))
            {
                this.Users.Add(user);
                user.AssignCategory(this);
            }
        }

        public void AssignChildCategory(ICategory category)
        {
            this.ChildCategory = category;
            category.AddParentCategory(this);
        }

        public void AddParentCategory(ICategory category)
        {
            this.ParentCategory = category;
        }

        public void Remove()
        {
            foreach (var user in this.Users)
            {
                user.RemoveCategory(this);

                if (this.ChildCategory != null)
                    this.ChildCategory.AssignUser(user);
            }

            this.RemoveChildCategory();
            this.RemoveParentCategory();

            this.Users = new List<IUser>();
        }

        public void RemoveChildCategory()
        {
            if (this.ChildCategory != null)
            {
                var childCategory = this.ChildCategory;
                this.ChildCategory = null;
                childCategory.RemoveParentCategory();
            }
        }

        public void RemoveParentCategory()
        {
            if (this.ParentCategory != null)
            {
                var parentCategory = this.ParentCategory;
                this.ParentCategory = null;
                parentCategory.RemoveChildCategory();
            }
        }
    }
}
