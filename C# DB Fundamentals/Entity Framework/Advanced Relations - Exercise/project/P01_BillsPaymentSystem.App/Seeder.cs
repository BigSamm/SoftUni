namespace P01_BillsPaymentSystem.App
{
    using System;
    using System.Linq;

    using P01_BillsPaymentSystem.Data;
    using P01_BillsPaymentSystem.Data.Models;
    using P01_BillsPaymentSystem.Data.Models.Enums;

    public class Seeder
    {
        public static void Seed(BillsPaymentSystemContext db)
        {
            using (db)
            {
                var user = new User
                {
                    FirstName = "Guy",
                    LastName = "Gilbert",
                    Email = "Gilbert@abv.bg",
                    Password = "HashPassword"
                };

                var card = new CreditCard(800, 100)
                {
                    ExpirationDate = new DateTime(2020, 03, 1)
                };

                var bankAccounts = new[]
                {
                    new BankAccount(200)
                    {
                        BankName = "Unicredit Bulbank",
                        SwiftCode = "UNCRBGSF"
                    },
                    new BankAccount(1000)
                    {
                        BankName = "First Investment Bank",
                        SwiftCode = "FINVBGSF"
                    }
                }.ToList();

                var paymentMethods = new[]
                {
                    new PaymentMethod
                    {
                        User = user,
                        BankAccount = bankAccounts[0],
                        Type = PaymentMethodType.BankAccount
                    },
                    new PaymentMethod
                    {
                        User = user,
                        BankAccount = bankAccounts[1],
                        Type = PaymentMethodType.BankAccount
                    },
                    new PaymentMethod
                    {
                        User = user,
                        CreditCard = card,
                        Type = PaymentMethodType.CreditCard
                    }
                }.ToList();

                db.Users.Add(user);
                db.CreditCards.Add(card);
                db.BankAccounts.AddRange(bankAccounts);
                db.PaymentMethods.AddRange(paymentMethods);

                db.SaveChanges();
            }
        }
    }
}
