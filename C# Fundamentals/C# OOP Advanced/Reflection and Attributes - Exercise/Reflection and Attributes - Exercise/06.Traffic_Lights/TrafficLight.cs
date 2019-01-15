using System;
using System.Collections.Generic;
using System.Linq;

public class TrafficLight
{
    public TrafficLight(string colors)
    {
        this.Light = Enum.Parse<TrafficLightsEnum>(colors);
    }

    public TrafficLightsEnum Light { get; private set; }

    internal void Update()
    {
        switch (Light)
        {
            case TrafficLightsEnum.Red:
                this.Light = TrafficLightsEnum.Green;
                break;
            case TrafficLightsEnum.Green:
                this.Light = TrafficLightsEnum.Yellow;
                break;
            case TrafficLightsEnum.Yellow:
                this.Light = TrafficLightsEnum.Red;
                break;
        }
    }

    public override string ToString()
    {
        return this.Light.ToString();
    }
}