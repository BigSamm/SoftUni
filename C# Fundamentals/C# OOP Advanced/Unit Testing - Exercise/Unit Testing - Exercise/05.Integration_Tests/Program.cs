namespace _05.Integration_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            ICategory category1 = new Category("category1");
            ICategory category2 = new Category("category2");
            ICategory category3 = new Category("category3");
            IUser user = new User("user1");

            category2.AssignUser(user);
            category2.AssignChildCategory(category1);
            category3.AssignChildCategory(category2);

            category2.Remove();
        }
    }
}
