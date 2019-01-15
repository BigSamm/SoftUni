using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Database
{
    public class User : IUser
    {
        public User(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id { get; private set; }

        public string Username { get; private set; }
    }
}
