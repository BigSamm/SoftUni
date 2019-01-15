namespace SIS.HTTP.Extensions
{
    using System;

    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException(nameof(input) + " cannot be null!");

            string result = Char.ToLower(input[0]) + input.Substring(1).ToLower();
            return result;
        }
    }
}
