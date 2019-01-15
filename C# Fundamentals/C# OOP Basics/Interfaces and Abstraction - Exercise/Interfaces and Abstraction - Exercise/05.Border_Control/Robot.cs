using System;
using System.Collections.Generic;
using System.Text;

public class Robot : ICitizen
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Model { get; set; }
    public string Id { get; set; }

    public override string ToString()
    {
        return $"{this.Id}";
    }
}