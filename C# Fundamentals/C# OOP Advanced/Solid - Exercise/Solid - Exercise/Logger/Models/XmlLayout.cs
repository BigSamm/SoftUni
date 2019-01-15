using Logger.Models.Interfaces;
using System;
using System.Globalization;

namespace Logger.Models
{
    public class XmlLayout : ILayout
    {
        const string DATE_FORMAT = "HH:mm:ss dd-MMM-yyyy";
        private string format =
            "<log>" + Environment.NewLine +
                "\t<date>{0}</date>" + Environment.NewLine +
                "\t<level>{1}</level>" + Environment.NewLine +
                "\t<message>{2}</message>" + Environment.NewLine +
            "</log>";

        public string FormatError(IError error)
        {
            var dateString = error.DateTime.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
            var formattedError = String.Format(format, dateString, error.Level, error.Message);
            return formattedError;
        }
    }
}
