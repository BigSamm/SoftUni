namespace SoftJail.DataProcessor.ExportDto
{
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [XmlType("Message")]
    public class MailDto
    {
        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                value = new string(value.Reverse().ToArray());
                description = value;
            }
        }

    }
}
