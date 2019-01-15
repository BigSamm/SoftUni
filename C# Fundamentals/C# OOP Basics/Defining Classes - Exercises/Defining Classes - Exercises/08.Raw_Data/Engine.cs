using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }

    public Engine(string speedStr, string powerStr)
    {
        EngineSpeed = int.Parse(speedStr);
        EnginePower = int.Parse(powerStr);
    }
}
