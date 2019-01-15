namespace P01_BillsPaymentSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using P01_BillsPaymentSystem.Data.Models.Attributes;

    public class BankAccount
    {
        public BankAccount(decimal balance)
        {
            this.Balance = balance;
        }

        [Key]
        public int BankAccountId { get; set; }
        
        public decimal Balance { get; private set; }

        [Required]
        [MaxLength(50)]
        public string BankName { get; set; }

        [Required]
        [MaxLength(25)]
        [NonUnicode]
        public string SwiftCode { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; } 

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                decimal oldBalance = this.Balance;
                this.Balance = 0;
                return oldBalance;
            }
            else
            {
                this.Balance -= amount;
                return amount;
            }
        }

        public override string ToString()
        {
            return $"-- ID: {this.BankAccountId}" + Environment.NewLine +
                $"--- Balance: {this.Balance:f2}" + Environment.NewLine +
                $"--- Bank: {this.BankName}" + Environment.NewLine +
                $"--- SWIFT: {this.SwiftCode}";
        }
    }
}
