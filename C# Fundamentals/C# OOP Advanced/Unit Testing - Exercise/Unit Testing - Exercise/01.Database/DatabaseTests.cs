using Moq;
using NUnit.Framework;
using System.Linq;
using Castle.Core.Internal;
using System;

namespace _01.Database
{
    public class DatabaseTests
    {
        [Test]
        public void CreateDatabaseWithRightSize()
        {
            IDatabase database = InitializeDatabase(16);

            Assert.That(database.Users.Count, Is.EqualTo(16));
        }

        [TestCase(20)]
        [TestCase(10)]
        public void CreateDatabaseWithInvalidSizeThrowsException(int databaseSize)
        {
            var users = new IUser[databaseSize];

            Assert.That(() => new Database(users), 
                Throws.InvalidOperationException.With.Message.EqualTo("Invalid Array Size!"));
        }

        [Test]
        public void RemoveItemFromDatabase()
        {
            IDatabase database = InitializeDatabase(16);

            IUser user = InitializeUser(1, "user1");
            database.Add(user);
            database.Remove();

            Assert.That(database.Users.Contains(user), Is.EqualTo(false));
        }

        [Test]
        public void RemoveItemFromEmptyDatabaseThrowsException()
        {
            IDatabase database = InitializeDatabase(16);
            
            Assert.That(() => database.Remove(), 
                Throws.InvalidOperationException.With.Message.EqualTo("No Users In Database!"));
        }

        [Test]
        public void AddItemInDatabase()
        {
            IDatabase database = InitializeDatabase(16);
            
            IUser testUser = InitializeUser(1, "user1");
            database.Add(testUser);

            Assert.That(database.Users.First(), Is.EqualTo(testUser));
        }

        [Test]
        public void AddItemInFullDatabaseThrowsException()
        {
            IDatabase database = InitializeDatabase(16);

            for (int counter = 0; counter < 16; counter++)
            {
                IUser testUser = InitializeUser(counter, $"user{counter}");
                database.Add(testUser);
            }

            Assert.That(() => database.Add(new User(16, "user16")), 
                Throws.InvalidOperationException.With.Message.EqualTo("No Free Cell!"));
        }

        [Test]
        public void AddUserWithExistingIdThrowsException()
        {
            var firstUser = InitializeUser(1, "user1");
            var secondUser = InitializeUser(1, "user2");
            
            IDatabase database = InitializeDatabase(16);
            database.Add(firstUser);

            Assert.That(() => database.Add(secondUser), 
                Throws.InvalidOperationException.With.Message.EqualTo("This Id Is Already In Use!"));
        }

        [Test]
        public void AddUserWithExistingUsernameThrowsException()
        {
            var firstUser = InitializeUser(1, "user1");
            var secondUser = InitializeUser(2, "user1");

            IDatabase database = InitializeDatabase(16);
            database.Add(firstUser);

            Assert.That(() => database.Add(secondUser),
                Throws.InvalidOperationException.With.Message.EqualTo("Thid Username Is Already In Use!"));
        }

        [Test]
        public void FetchItemsFromDatabase()
        {
            IDatabase database = InitializeDatabase(16);
            IUser testUser = InitializeUser(1, "user1");
            database.Add(testUser);

            var fetchedItems = database.Fetch();

            Assert.That(fetchedItems, Is.EqualTo(new IUser[] { testUser }));
        }

        [Test]
        public void FindUserById()
        {
            IDatabase database = InitializeDatabase(16);
            long userId = 1;
            IUser testUser = InitializeUser(userId, "user1");
            database.Add(testUser);

            Assert.That(database.FindById(userId), Is.EqualTo(testUser));
        }

        [Test]
        public void SearchForUserWithNotExistingIdThrowsException()
        {
            IDatabase database = InitializeDatabase(16);
            long testId = 1;

            Assert.That(() => database.FindById(testId),
                Throws.InvalidOperationException.With.Message.EqualTo($"No User With Id {testId}"));
        }

        [Test]
        public void SearchForUserWithNegativeIdThrowsException()
        {
            IDatabase database = InitializeDatabase(16);
            long userId = -1;
            IUser user = InitializeUser(userId, "user1");
            database.Add(user);

            Assert.That(() => database.FindById(userId),
                Throws.ArgumentException.With.Message.EqualTo("Id Can Not Be Negative"));
        }

        [Test]
        public void FindUserByUsername()
        {
            IDatabase database = InitializeDatabase(16);
            var username = "user1";
            IUser testUser = InitializeUser(1, username);
            database.Add(testUser);

            Assert.That(database.FindByUsername(username), Is.EqualTo(testUser));
        }

        [Test]
        public void SearchForUserWithUsernameEqualToNullThrowsException()
        {
            IDatabase database = InitializeDatabase(16);

            Assert.That(() => database.FindByUsername(null),
                Throws.ArgumentNullException.With.Message.EqualTo("Value cannot be null."));
        }

        [Test]
        public void SearchForUserWithNotExistingUsernameThrowsException()
        {
            IDatabase database = InitializeDatabase(16);
            var username = "user1";

            Assert.That(() => database.FindByUsername(username),
                Throws.InvalidOperationException.With.Message.EqualTo($"No User With Username {username}"));
        }

        private IDatabase InitializeDatabase(int databaseSize)
        {
            var users = new IUser[databaseSize];

            IDatabase database = new Database(users);

            return database;
        }

        private IUser InitializeUser(long id, string username)
        {
            IUser user = new User(id, username);
            return user;
        }
    }
}
