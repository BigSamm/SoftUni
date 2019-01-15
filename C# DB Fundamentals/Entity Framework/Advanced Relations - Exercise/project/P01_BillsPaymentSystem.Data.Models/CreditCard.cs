namespace P01_BillsPaymentSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CreditCard
    {
        public CreditCard(decimal limit, decimal moneyOwed)
        {
            this.Limit = limit;
            this.MoneyOwed = moneyOwed;
        }

        [Key]
        public int CreditCardId { get; set; }
        
        public decimal Limit { get; private set; }
        
        public decimal MoneyOwed { get; private set; }

        [NotMapped]
        public decimal LimitLeft => this.Limit - this.MoneyOwed;
        
        public DateTime ExpirationDate { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            this.MoneyOwed -= amount;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount > this.LimitLeft)
            {
                decimal oldLimitLeft = this.LimitLeft;
                this.MoneyOwed = this.Limit;
                return oldLimitLeft;
            }
            else
            {
                this.MoneyOwed += amount;
                return amount;
            }
        }

        public override string ToString()
        {
            return $"-- ID: {this.CreditCardId}" + Environment.NewLine +
                $"--- Limit: {this.Limit:f2}" + Environment.NewLine +
                $"--- Money Owed: {this.MoneyOwed:f2}" + Environment.NewLine +
                $"--- Limit Left:: {this.LimitLeft}" + Environment.NewLine +
                $"--- Expiration Date: {this.ExpirationDate.Year}/{this.ExpirationDate.Month}";
        }
    }
}
