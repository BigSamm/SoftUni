using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();
            for (;;)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var item in result)
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    break;
                }
                var email = Console.ReadLine();

                if (email.Reverse().Take(2) != "'ku" && email.Reverse().Take(2) != "'su")
                    result[name] = email;
            }





        }
    }
}
