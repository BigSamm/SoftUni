namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var className = typeof(HarvestingFields).FullName; 
            var classType = Type.GetType(className);
            var classFields = classType.GetFields(
                 BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            string command;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                IEnumerable<FieldInfo> fieldsToPrint = null;

                switch (command)
                {
                    case "private":
                        fieldsToPrint = classFields.Where(f => f.IsPrivate);
                        break;
                    case "protected":
                        fieldsToPrint = classFields.Where(f => f.IsFamily);
                        break;
                    case "public":
                        fieldsToPrint = classFields.Where(f => f.IsPublic);
                        break;
                    case "all":
                        fieldsToPrint = classFields;
                        break;
                }

                foreach (var field in fieldsToPrint)
                {
                    PrintCurrentField(field);
                }
            }
        }

        private static void PrintCurrentField(FieldInfo field)
        {
            string access = String.Empty;
            switch (field.Attributes)
            {
                case FieldAttributes.Family:
                    access = "protected";
                    break;
                case FieldAttributes.Private:
                    access = "private";
                    break;
                case FieldAttributes.Public:
                    access = "public";
                    break;
            }

            var fieldString = access + " " + field.FieldType.Name + " " + field.Name;
            Console.WriteLine(fieldString);
        }
    }
}
