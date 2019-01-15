using System.Collections.Generic;

namespace _05.Integration_Tests
{
    public interface IUser
    {
        string Name { get; }

        List<ICategory> Categories { get; }

        void AssignCategory(ICategory category);

        void RemoveCategory(ICategory category);
    }
}
