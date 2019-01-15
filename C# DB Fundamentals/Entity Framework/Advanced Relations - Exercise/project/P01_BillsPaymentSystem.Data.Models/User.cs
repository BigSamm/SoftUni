namespace P01_BillsPaymentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using P01_BillsPaymentSystem.Data.Models.Attributes;

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(80)]
        [NonUnicode]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        [NonUnicode]
        public string Password { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"User: {this.FirstName} {this.LastName}");

            result.AppendLine("Bank Accounts:");
            foreach (PaymentMethod pm in this.PaymentMethods)
            {
                if (pm.BankAccount != null)
                    result.AppendLine(pm.BankAccount.ToString());
            }

            result.AppendLine("Credit Cards:");
            foreach (PaymentMethod pm in this.PaymentMethods)
            {
                if (pm.CreditCard != null)
                    result.AppendLine(pm.CreditCard.ToString());
            }

            return result.ToString();
        }
    }
}
