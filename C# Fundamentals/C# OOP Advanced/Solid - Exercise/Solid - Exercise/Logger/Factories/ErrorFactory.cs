using Logger.Models;
using Logger.Models.Enums;
using Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Factories
{
    public class ErrorFactory
    {
        const string DATE_FORMAT = "M/d/yyyy h:mm:ss tt";

        public IError CreateError(string dateTimeStr, string errorLevelStr, string message)
        {
            var dateTime = DateTime.ParseExact(dateTimeStr, DATE_FORMAT, CultureInfo.InvariantCulture);
            ErrorLevel errorLevel = ParseErrorLevel(errorLevelStr);

            IError error = new Error(dateTime, errorLevel, message);
            return error;
        }

        private ErrorLevel ParseErrorLevel(string levelString)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(ErrorLevel), levelString);
                return (ErrorLevel)levelObj;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Invalid ErrorLevel Type!", ex);
            }

        }
    }
}
