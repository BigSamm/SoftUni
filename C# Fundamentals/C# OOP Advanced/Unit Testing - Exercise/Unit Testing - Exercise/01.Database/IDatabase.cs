using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Database
{
    public interface IDatabase
    {
        IUser[] Users { get; }

        void Add(IUser user);

        void Remove();

        IUser[] Fetch();

        IUser FindById(long id);

        IUser FindByUsername(string username);
    }
}
