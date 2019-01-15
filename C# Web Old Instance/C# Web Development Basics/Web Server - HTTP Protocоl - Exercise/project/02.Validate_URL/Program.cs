using System;
using System.Net;
using System.Text.RegularExpressions;

namespace _02.Validate_URL
{
    class Program
    {
        static void Main()
        {
            string inputUrl = Console.ReadLine();
            string decodedUrl = WebUtility.UrlDecode(inputUrl);

            string pattern = @"^(http[s]?):\/\/(.+?\..+?)(:\d+)?(\/.*?)?(\?.+?)?(#.*)?$";
            Match match = Regex.Match(decodedUrl, pattern);

            ValidateUrl(match);

            PrintUrlParts(match);
        }

        private static void PrintUrlParts(Match match)
        {
            string protocol = match.Groups[1].Value;
            Console.WriteLine($"Protocol: {protocol}");

            string host = match.Groups[2].Value;
            Console.WriteLine($"Host: {host}");

            Console.Write("Port: ");
            if (protocol == "http")
                Console.WriteLine("80");
            else
                Console.WriteLine("443");

            Group path = match.Groups[4];
            if (path.Success == true)
                Console.WriteLine($"Path: {path}");
            else
                Console.WriteLine("Path: /");

            Group queryGroup = match.Groups[5];
            if (queryGroup.Success == true)
            {
                string query = queryGroup.Value.Substring(1);
                Console.WriteLine($"Query: {query}");
            }

            Group fragmentGroup = match.Groups[6];
            if (fragmentGroup.Success == true)
            {
                string fragment = fragmentGroup.Value.Substring(1);
                Console.WriteLine($"Fragment: {fragment}");
            }
        }

        private static void ValidateUrl(Match match)
        {
            Group protocol = match.Groups[1];
            if (protocol.Success == false || match.Groups[2].Success == false)
            {
                EndProgram();
            }

            Group port = match.Groups[3];
            if (protocol.Value == "http" && port.Success == true)
            {
                if (port.Value != ":80")
                    EndProgram();
            }

            if (protocol.Value == "https" && port.Success == true)
            {
                if (port.Value != ":443")
                    EndProgram();
            }
        }

        private static void EndProgram()
        {
            Console.WriteLine("Invalid URL");
            Environment.Exit(0);
        }
    }
}
