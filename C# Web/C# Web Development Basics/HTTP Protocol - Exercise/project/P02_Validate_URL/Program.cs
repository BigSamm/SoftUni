using System;
using System.Net;
using System.Text.RegularExpressions;

namespace P02_Validate_URL
{
    class Program
    {
        static void Main()
        {
            string encodedUrl = Console.ReadLine();
            string decodedUrl = WebUtility.UrlDecode(encodedUrl);

            string pattern = @"(http[s]?):\/\/([\w.-]+\.[\w\.-]+):([0-9]+)?([\/\w.]+)?\??([&\w+=\w+]+)?#?(\w+)?";
            Match match = Regex.Match(decodedUrl, pattern);

            if (!match.Success)
                PrintError();

            string protocol = match.Groups[1].Value;
            string host = match.Groups[2].Value;
            string port = ParsePort(match.Groups[3], protocol);
            string path = ParsePath(match.Groups[4]);

            Console.WriteLine($"Protocol: {protocol}");
            Console.WriteLine($"Host: {host}");
            Console.WriteLine($"Port: {port}");
            Console.WriteLine($"Path: {path}");

            if (match.Groups[5].Success)
                Console.WriteLine($"Query: {match.Groups[5].Value}");

            if (match.Groups[6].Success)
                Console.WriteLine($"Fragment: {match.Groups[6].Value}");
        }

        private static string ParsePath(Group pathGroup)
        {
            string path;

            if (pathGroup.Success)
                path = pathGroup.Value;
            else
                path = "/";

            return path;
        }

        private static string ParsePort(Group portGroup, string protocol)
        {
            string port;
            if (portGroup.Success)
            {
                port = portGroup.Value;
            }
            else
            {
                if (protocol == "http")
                    port = "80";
                else
                    port = "443";
            }

            if ((protocol == "http" && port != "80") || (protocol == "https" && port != "443"))
                PrintError();

            return port;
        }

        private static void PrintError()
        {
            Console.WriteLine("Invalid URL");
            Environment.Exit(0);
        }
    }
}
