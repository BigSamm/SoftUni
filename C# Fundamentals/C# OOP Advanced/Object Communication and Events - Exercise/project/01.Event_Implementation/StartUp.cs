using System;

public class StartUp
{
    static void Main()
    {
        var dispatcher = new Dispatcher();
        var handler = new Handler();

        dispatcher.NameChange += handler.OnDispatcherNameChange;

        string name;
        while ((name = Console.ReadLine()) != "End")
        {
            dispatcher.Name = name;
        }
    }
}
