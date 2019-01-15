using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Database
{
    public interface IUser
    {
        long Id { get; }

        string Username { get; }
    }
}
