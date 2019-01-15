using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace _05.Integration_Tests
{
    public class UserTests
    {
        [Test]
        public void TestValidUserConstructor()
        {
            string name = "user1";
            IUser user = this.InitializeUser(name);

            Assert.That(user.Name, Is.EqualTo(name));

            var testList = new List<ICategory>();

            Assert.That(user.Categories, Is.EquivalentTo(testList));
        }

        [Test]
        public void RemoveCategoryFromUser()
        {
            IUser user = this.InitializeUser("user1");

            var userProperties = user.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var categories = userProperties.First(p => p.GetType() == typeof(List<ICategory>));
            categories.SetValue(new Category("category1"));
        }

        private IUser InitializeUser(string name)
        {
            IUser user = new User(name);
            return user;
        }
    }
}
