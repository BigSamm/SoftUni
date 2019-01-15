using System.Collections.Generic;

namespace _05.Integration_Tests
{
    public interface ICategory
    {
        string Name { get; }

        List<IUser> Users { get; }

        ICategory ChildCategory { get; }

        ICategory ParentCategory { get; }

        void AssignUser(IUser user);

        void AssignChildCategory(ICategory category);

        void AddParentCategory(ICategory category);

        void Remove();

        void RemoveChildCategory();

        void RemoveParentCategory();
    }
}
