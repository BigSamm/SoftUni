using System;
using System.Collections.Generic;
using System.Text;

public class Clinic
{
    private int centralRoom => this.Rooms.Length / 2;

    public Clinic(string name, int roomsCount)
    {
        this.Name = name;

        ValidateRoomsCount(roomsCount);
        this.Rooms = new Pet[roomsCount];
    }

    private void ValidateRoomsCount(int roomsCount)
    {
        if (roomsCount % 2 == 0)
            throw new InvalidOperationException("Invalid Operation!");
    }

    public string Name { get; private set; }

    public Pet[] Rooms { get; private set; }

    public bool Add(Pet pet)
    {
        if (!this.HasEmptyRooms())
            return false;

        var index = this.centralRoom;
        if (this.Rooms[index] == null)
        {
            this.Rooms[index] = pet;
            return true;
        }

        var step = 1;
        while(index - step >= 0 && index + step < this.Rooms.Length)
        {
            if (this.Rooms[index - step] == null)
            {
                this.Rooms[index - step] = pet;
                return true;
            }
            else if (this.Rooms[index + step] == null)
            {
                this.Rooms[index + step] = pet;
                return true;
            }

            step++;
        }

        return false;
    }

    public bool Release()
    {
        for (int index = this.centralRoom; index < this.Rooms.Length; index++)
        {
            if (this.Rooms[index] != null)
            {
                this.Rooms[index] = null;
                return true;
            }
        }

        for (int index = 0; index < this.centralRoom; index++)
        {
            if (this.Rooms[index] != null)
            {
                this.Rooms[index] = null;
                return true;
            }
        }

        return false;
    }

    public bool HasEmptyRooms()
    {
        foreach (var room in this.Rooms)
        {
            if (room == null)
                return true;
        }

        return false;
    }

    public string Print()
    {
        var result = new StringBuilder();

        for (int index = 0; index < this.Rooms.Length; index++)
        {
            if (this.Rooms[index] == null)
                result.AppendLine("Room empty");
            else
                result.AppendLine(this.Rooms[index].ToString());
        }

        return result.ToString().TrimEnd();
    }

    public string Print(int room)
    {
        if (this.Rooms[room - 1] == null)
            return "Room empty";

        var pet = this.Rooms[room - 1];
        var result = pet.ToString();
        return result;
    }
}