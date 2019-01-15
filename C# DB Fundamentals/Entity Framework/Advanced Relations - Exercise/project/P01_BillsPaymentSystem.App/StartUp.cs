namespace P01_BillsPaymentSystem.App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P01_BillsPaymentSystem.Data;
    using P01_BillsPaymentSystem.Data.Models;

    public class StartUp
    {
        public static void Main()
        {
            var context = new BillsPaymentSystemContext();

            // 02. Seed Some Data
            //Seeder.Seed(context);

            // 03. User Details
            //int userId = int.Parse(Console.ReadLine());
            //PrintUserInfo(userId, context);

            // 04. Pay Bills
            //int userId = int.Parse(Console.ReadLine());
            //decimal amount = decimal.Parse(Console.ReadLine());
            //PayBills(userId, amount, context);
        }

        private static void PayBills(int userId, decimal amount, BillsPaymentSystemContext context)
        {
            User user = context.Users.Find(userId);
            if (user == null)
            {
                Console.WriteLine($"User with id {userId} not found!");
                Environment.Exit(0);
            }

            decimal userTotalBalance = GetUserTotalBalance(user, amount);

            if (amount > userTotalBalance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                WithdrawMoneyFromUser(user, amount);
                context.SaveChanges();
            }
        }

        private static void WithdrawMoneyFromUser(User user, decimal amount)
        {
            IEnumerable<BankAccount> orderedBankAccounts = GetUserBankAccounts(user);

            foreach (BankAccount ba in orderedBankAccounts)
            {
                if (amount > 0)
                {
                    decimal withdrawedValue = ba.Withdraw(amount);
                    amount -= withdrawedValue;
                }
            }

            IEnumerable<CreditCard> orderedCreditCards = GetUserCreditCards(user);

            foreach (CreditCard cc in orderedCreditCards)
            {
                if (amount > 0)
                {
                    decimal withdrawedValue = cc.Withdraw(amount);
                    amount -= withdrawedValue;
                }
            }
        }

        private static IEnumerable<CreditCard> GetUserCreditCards(User user)
        {
            var creditCards = new List<CreditCard>();

            foreach (PaymentMethod pm in user.PaymentMethods)
            {
                if (pm.CreditCard != null)
                    creditCards.Add(pm.CreditCard);
            }

            return creditCards.OrderBy(cc => cc.CreditCardId);
        }

        private static IEnumerable<BankAccount> GetUserBankAccounts(User user)
        {
            var bankAccounts = new List<BankAccount>();

            foreach (PaymentMethod pm in user.PaymentMethods)
            {
                if (pm.BankAccount != null)
                    bankAccounts.Add(pm.BankAccount);
            }

            return bankAccounts.OrderBy(ba => ba.BankAccountId);
        }

        private static decimal GetUserTotalBalance(User user, decimal amount)
        {
            decimal totalBalance = 0m;

            foreach (PaymentMethod pm in user.PaymentMethods)
            {
                if (pm.BankAccount != null)
                    totalBalance += pm.BankAccount.Balance;
                else
                    totalBalance += pm.CreditCard.LimitLeft;
            }

            return totalBalance;
        }

        private static void PrintUserInfo(int userId, BillsPaymentSystemContext context)
        {
            User user = context.Users.Find(userId);

            if (user == null)
                Console.WriteLine($"User with id {userId} not found!");
            else
                Console.WriteLine(user);
        }
    }
}
