using System;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.Extensions.DependencyInjection;

public class Engine
{
    private ICommandInterpreter commandInterpreter;
    private IReader reader;
    private IWriter writer;

    public Engine(ICommandInterpreter commandInterpreter, IReader reader, IWriter writer)
    {
        this.commandInterpreter = commandInterpreter;
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        while (true)
        {
            string input = this.reader.ReadLine();
            List<string> data = input.Split().ToList();

            string result = this.commandInterpreter.ProcessCommand(data);
            this.writer.WriteLine(result);

            if (data[0] == "Shutdown")
                break;
        }
    }
}