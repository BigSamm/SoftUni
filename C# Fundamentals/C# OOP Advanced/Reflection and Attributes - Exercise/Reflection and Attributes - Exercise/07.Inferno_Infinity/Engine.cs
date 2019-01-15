using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private List<IWeapon> weapons;
    private WeaponFactory weaponFactory;
    private GemFactory gemFactory;

    public Engine()
    {
        this.weapons = new List<IWeapon>();
        this.weaponFactory = new WeaponFactory();
        this.gemFactory = new GemFactory();
    }

    public void Run()
    {
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(';');
            var command = tokens[0];

            tokens = tokens.Skip(1).ToArray();
            switch (command)
            {
                case "Create":
                    DoCreаteCommand(tokens);
                    break;
                case "Add":
                    DoAddCommand(tokens);
                    break;
                case "Remove":
                    DoRemoveCommand(tokens);
                    break;
                case "Print":
                    DoPrintCommand(tokens);
                    break;
            }
        }
    }

    private void DoPrintCommand(string[] tokens)
    {
        var weaponName = tokens[0];
        var weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
        Console.WriteLine(weapon);
    }

    private void DoRemoveCommand(string[] tokens)
    {
        var weaponName = tokens[0];
        var socketIndex = int.Parse(tokens[1]);

        try
        {
            var weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            weapon.RemoveGem(socketIndex);
        }
        catch (Exception)
        { }
    }

    private void DoAddCommand(string[] tokens)
    {
        var weaponName = tokens[0];
        var socketIndex = int.Parse(tokens[1]);
        var gemTokens = tokens[2].Split();
        var clarityLeve = gemTokens[0];
        var gemType = gemTokens[1];

        try
        {
            var weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);
            var gem = gemFactory.CreateGem(gemType, clarityLeve);
            weapon.AddGem(gem, socketIndex);
        }
        catch (Exception)
        { }
    }

    private void DoCreаteCommand(string[] tokens)
    {
        var typeTokens = tokens[0].Split();
        var rarityLevel = typeTokens[0];
        var type = typeTokens[1];
        var name = tokens[1];
        var weapon = weaponFactory.CreateWeapon(type, rarityLevel, name);
        this.weapons.Add(weapon);
    }
}