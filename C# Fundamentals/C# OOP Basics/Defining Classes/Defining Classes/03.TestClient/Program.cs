using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandList = command.Split();
            var id = int.Parse(commandList[1]);

            switch (commandList[0])
            {
                case "Create":
                    CreateAccount(accounts, id);
                    break;
                case "Deposit":
                    decimal amount = decimal.Parse(commandList[2]);
                    DepositAccount(accounts, id, amount);
                    break;
                case "Withdraw":
                    amount = decimal.Parse(commandList[2]);
                    WithdrawAccount(accounts, id, amount);
                    break;
                case "Print":
                    PrintAcoount(accounts, id);
                    break;
            }
        }
    }

    private static void PrintAcoount(Dictionary<int, BankAccount> accounts, int id)
    {
        if (accounts.ContainsKey(id))
            Console.WriteLine(accounts[id]);
        else
            Console.WriteLine("Account does not exist");
    }

    private static void WithdrawAccount(Dictionary<int, BankAccount> accounts, int id, decimal amount)
    {
        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance >= amount)
                accounts[id].Withdraw(amount);
            else
                Console.WriteLine("Insufficient balance");
        }
        else
            Console.WriteLine("Account does not exist");

    }

    private static void DepositAccount(Dictionary<int, BankAccount> accounts, int id, decimal amount)
    {
        if (accounts.ContainsKey(id))
            accounts[id].Deposit(amount);
        else
            Console.WriteLine("Account does not exist");
    }

    private static void CreateAccount(Dictionary<int, BankAccount> accounts, int id)
    {
        if (accounts.ContainsKey(id))
            Console.WriteLine("Account already exists");
        else
        {
            accounts[id] = new BankAccount();
            accounts[id].Id = id;
        }
    }
}