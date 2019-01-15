using Logger.Models.Enums;
using Logger.Models.Interfaces;
using System;

namespace Logger.Models
{
    public class Error : IError
    {
        public Error(DateTime dateTime, ErrorLevel level, string message)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Message = message;
        }

        public DateTime DateTime { get; }
        public ErrorLevel Level { get; }
        public string Message { get; }
    }
}
