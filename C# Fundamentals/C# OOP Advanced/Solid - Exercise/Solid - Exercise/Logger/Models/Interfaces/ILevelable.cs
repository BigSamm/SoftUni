using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Interfaces
{
    public interface ILevelable
    {
        ErrorLevel Level { get; }
    }
}
