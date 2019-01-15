using Castle.Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Database
{
    public class Database : IDatabase
    {
        private IUser[] users;

        public Database(IUser[] users)
        {
            this.Users = users;
        }

        public IUser[] Users
        {
            get { return users; }
            private set
            {
                if (value.Length != 16)
                    throw new InvalidOperationException("Invalid Array Size!");

                users = value;
            }
        }

        public void Add(IUser user)
        {
            if (!this.Users.Contains(null))
                throw new InvalidOperationException("No Free Cell!");

            if (this.Users.Where(u => u != null).FirstOrDefault(u => u.Id == user.Id) != null)
                throw new InvalidOperationException("This Id Is Already In Use!");

            if (this.Users.Where(u => u != null).FirstOrDefault(u => u.Username == user.Username) != null)
                throw new InvalidOperationException("Thid Username Is Already In Use!");

            for (int index = 0; index < this.Users.Length; index++)
            {
                if (this.Users[index] == null)
                {
                    this.Users[index] = user;
                    break;
                }
            }
        }

        public void Remove()
        {
            bool isThereUser = false;
            for (int index = 0; index < this.Users.Length; index++)
            {
                if (this.Users[index] != null)
                    isThereUser = true;
            }

            if (!isThereUser)
                throw new InvalidOperationException("No Users In Database!");

            for (int index = this.Users.Length - 1; index >= 0; index--)
            {
                if (this.Users[index] != null)
                    this.Users[index] = null;
            }
        }

        public IUser[] Fetch()
        {
            var result = this.Users.Where(u => u != null).ToArray();
            return result;
        }

        public IUser FindById(long id)
        {
            IUser user = this.Users.Where(u => u != null).FirstOrDefault(u => u.Id == id);

            if (user == null)
                throw new InvalidOperationException($"No User With Id {id}");

            if (user.Id < 0)
                throw new ArgumentException("Id Can Not Be Negative");

            return user;
        }

        public IUser FindByUsername(string username)
        {
            if (username == null)
                throw new ArgumentNullException();

            IUser user = this.Users.Where(u => u != null).FirstOrDefault(u => u.Username == username);

            if (user == null)
                throw new InvalidOperationException($"No User With Username {username}");

            return user;
        }
    }
}