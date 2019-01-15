using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();

            string name;
            while((name = Console.ReadLine()) != "stop")
            {
                string email = Console.ReadLine();
                emails[name] = email;
            }

            Dictionary<string, string> validEmails = emails
                .Where(e => !e.Value.EndsWith("us", true, CultureInfo.CurrentCulture) &&
                            !e.Value.EndsWith("uk", true, CultureInfo.CurrentCulture))
                .ToDictionary(e => e.Key, e => e.Value);

            foreach (var email in validEmails)
            {
                Console.WriteLine(email.Key + " -> " + email.Value);
            }
        }
    }
}
