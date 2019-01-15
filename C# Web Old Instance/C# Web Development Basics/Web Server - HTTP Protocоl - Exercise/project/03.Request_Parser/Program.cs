using System;
using System.Collections.Generic;

namespace _03.Request_Parser
{
    class Program
    {
        static void Main()
        {
            var pathsMethods = new Dictionary<string, List<string>>();
            ParsePathsMethods(pathsMethods);

            string response = ParseResponse(pathsMethods);
            Console.WriteLine(response);
        }

        private static string ParseResponse(Dictionary<string, List<string>> pathsMethods)
        {
            string request = Console.ReadLine();

            string[] args = request.Split(new[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string method = args[0].ToLower();
            string path = args[1].ToLower();
            string version = args[2] + '/' + args[3];

            string statusCode, statusText;
            if (pathsMethods.ContainsKey(path))
            {
                if (pathsMethods[path].Contains(method))
                {
                    statusCode = "200";
                    statusText = "OK";
                }
                else
                {
                    statusCode = "404";
                    statusText = "NotFound";
                }
            }
            else
            {
                statusCode = "404";
                statusText = "NotFound";
            }

            string response = version + " " + statusCode + " " + statusText + Environment.NewLine +
                "Content-Length: " + statusText.Length + Environment.NewLine +
                "Content-Type: text/plain" + Environment.NewLine + Environment.NewLine +
                statusText;
            return response;
        }

        private static void ParsePathsMethods(Dictionary<string, List<string>> pathsMethods)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] args = input.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string path = args[0].ToLower();
                string method = args[1].ToLower();

                if (pathsMethods.ContainsKey(path))
                {
                    if (!pathsMethods[path].Contains(method))
                        pathsMethods[path].Add(method);
                }
                else
                {
                    pathsMethods[path] = new List<string>();
                    pathsMethods[path].Add(method);
                }
            }
        }
    }
}