namespace P01_BillsPaymentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using P01_BillsPaymentSystem.Data.Models.Attributes;
    using P01_BillsPaymentSystem.Data.Models.Enums;

    public class PaymentMethod
    {
        [Key]
        public int Id { get; set; }
        
        public PaymentMethodType Type { get; set; }
        
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        [Xor(nameof(CreditCardId))]
        public int? BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        
        public int? CreditCardId { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
