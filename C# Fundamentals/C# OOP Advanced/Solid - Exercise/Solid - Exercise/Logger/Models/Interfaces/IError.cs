using Logger.Models.Enums;
using System;

namespace Logger.Models.Interfaces
{
    public interface IError : ILevelable
    {
        DateTime DateTime { get; }

        string Message { get; }
    }
}