using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        class Event
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public List<string> Participants { get; set; }
        }

        static void Main(string[] args)
        {
            var allEvents = new List<Event>();
            var events = new List<Event>();
            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                var inputList = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                allEvents.Add(GetCurrentEvent(inputList, events));
                events = allEvents.Where(x => x != null).ToList();
            }
            var orderedEvents = events.OrderByDescending(x => x.Participants.Count).ThenBy(x => x.Name).ToList();

            foreach (var e in orderedEvents)
            {
                Console.WriteLine($"{e.Name} - {e.Participants.Count}");
                for (int i = 0; i < e.Participants.Count; i++)
                {
                    Console.WriteLine(e.Participants[i]);
                }
            }
        }

        static Event GetCurrentEvent(List<string> input, List<Event> allEvents)
        {
            var ID = int.Parse(input[0]);
            string eventName = input[1];
            var participants = new List<string>();

            if (!IsThereOnlyLetters(eventName))
            {
                return null;
            }
            for (int i = 2; i < input.Count; i++)
            {
                bool a = IsItCorrectName(input[i]);
                if (IsItCorrectName(input[i]))
                {
                    participants.Add(input[i]);
                }
            }
            


            var nameArr = eventName.ToCharArray();
            nameArr[0] = ' ';
            eventName = string.Join("", nameArr.Where(x => x != ' '));

            var isMissing = true;
            foreach (var x in allEvents)
            {
                if (x.ID == ID)
                {
                    if (x.Name == eventName)
                    {
                        isMissing = false;
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (x.Participants.Contains(participants[i]))
                            { }
                            else
                            {
                                x.Participants.Add(participants[i]);
                                x.Participants = x.Participants.OrderBy(a => a).ToList();
                                return null;
                            }
                        }
                    }
                    else { }
                }
            }
            Event currentEvent = new Event();
            if (isMissing)
            {
                currentEvent = new Event
                {
                    ID = ID,
                    Name = eventName,
                    Participants = participants
                };
                currentEvent.Participants = currentEvent.Participants.OrderBy(x => x).ToList();
            }
            return currentEvent;
        }

        static bool IsItCorrectName(string name)
        {
            if (name.First() != '@')
            {
                return false;
            }
            var nameArr = name.ToCharArray();
            for (int i = 1; i < nameArr.Length; i++)
            {
                if( (nameArr[i] < 65 || nameArr[i] > 90) &&
                    (nameArr[i] < 97 || nameArr[i] > 122) &&
                    (nameArr[i] < 48 || nameArr[i] > 57) &&
                    nameArr[i] != 39 && nameArr[i] != 45)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsThereOnlyLetters(string name)
        {
            var nameArr = name.ToCharArray();
            if (nameArr.First() != '#')
            {
                return false;
            }
            for (int i = 1; i < nameArr.Length; i++)
            {
                if ((nameArr[i] < 65 || nameArr[i] > 90) && (nameArr[i] < 97 || nameArr[i] > 122))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
