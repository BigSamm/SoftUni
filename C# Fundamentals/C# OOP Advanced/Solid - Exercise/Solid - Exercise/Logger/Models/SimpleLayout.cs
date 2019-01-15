using Logger.Models.Interfaces;
using System;
using System.Globalization;

namespace Logger.Models
{
    public class SimpleLayout : ILayout
    {
        //error.DateTime - error.Level - error.Message
        const string FORMAT = "{0} - {1} - {2}";
        const string DATE_FORMAT = "M/d/yyyy h:mm:ss tt";

        public string FormatError(IError error)
        {
            var dateString = error.DateTime.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
            var formattedError = String.Format(FORMAT, dateString, error.Level, error.Message);
            return formattedError;
        }
    }
}
