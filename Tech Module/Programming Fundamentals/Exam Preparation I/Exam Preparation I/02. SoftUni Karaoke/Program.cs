using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = GetAllSongs();

            var nameAndAward = new Dictionary<string, List<string>>();
            for (;;)
            {
                var input = GetCurrentPerformance();
                if (input[0] == "dawn")
                {
                    break;
                }
                var name = input[0];
                var song = input[1];
                var award = input[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (nameAndAward.ContainsKey(name))
                    {
                        if (nameAndAward[name].Contains(award))
                        {
                            continue;
                        }
                        else
                        {
                            nameAndAward[name].Add(award);
                        }
                    }
                    else
                    {
                        nameAndAward[name] = new List<string> { award };
                    }
                }
            }

            nameAndAward = nameAndAward.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in nameAndAward)
            {
                item.Value.Sort();
            }

            if (nameAndAward.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in nameAndAward)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        Console.WriteLine($"--{item.Value[i]}");
                    }
                }
            }


        }

        static List<string> GetAllSongs()
        {
            var startingSongs = Console.ReadLine().Split(',').ToList();
            var songs = new List<string>();
            for (int i = 0; i < startingSongs.Count; i++)
            {
                List<char> songInCharArr = startingSongs[i].ToCharArray().ToList();
                while (songInCharArr[0] == ' ')
                {
                    songInCharArr.Remove(' ');
                }
                string songInString = string.Join("", songInCharArr);
                songs.Add(songInString);
            }
            return songs;
        }

        static List<string> GetCurrentPerformance()
        {
            var input = new List<string>();
            var startingInput = Console.ReadLine().Split(',').ToList();
            for (int i = 0; i < startingInput.Count; i++)
            {
                List<char> inputInCharArr = startingInput[i].ToCharArray().ToList();
                if (inputInCharArr[0] == ' ')
                {
                    inputInCharArr.Remove(' ');
                }
                string inputInString = string.Join("", inputInCharArr);
                input.Add(inputInString);
            }
            return input;
        }
    }
}
