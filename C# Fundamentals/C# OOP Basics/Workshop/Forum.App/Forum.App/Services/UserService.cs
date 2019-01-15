using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Forum.App.Controllers.SignUpController;

namespace Forum.App.Services
{
    public static class UserService
    {
        public static bool TryLogInUser(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
                return false;

            var forumData = new ForumData();

            var userExists = forumData.Users.Any(u => u.Username == username && u.Password == password);
            return userExists;
        }

        public static SignUpStatus TrySignUpUser(string username, string password)
        {
            var validUsername = !String.IsNullOrWhiteSpace(username) && username.Length > 3;
            var validPassword = !String.IsNullOrWhiteSpace(password) && username.Length > 3;

            if (!validUsername || !validPassword)
                return SignUpStatus.DetailsError;

            var forumData = new ForumData();

            var userAlreadyExists = forumData.Users.Any(u => u.Username == username);

            if (!userAlreadyExists)
            {
                var userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                var user = new User(userId, username, password);
                forumData.Users.Add(user);
                forumData.SaveChanges();

                return SignUpStatus.Success;
            }

            return SignUpStatus.UsernameTakenError;
        }

        internal static User GetUser(int userId)
        {
            var forumData = new ForumData();

            var user = forumData.Users.Find(u => u.Id == userId);

            return user;
        }

        internal static User GetUser(string username)
        {
            var forumData = new ForumData();

            var user = forumData.Users.Find(u => u.Username == username);

            return user;
        }
    }
}
