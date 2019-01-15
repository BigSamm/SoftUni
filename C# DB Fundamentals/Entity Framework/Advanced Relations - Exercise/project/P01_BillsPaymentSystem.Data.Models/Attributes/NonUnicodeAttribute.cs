namespace P01_BillsPaymentSystem.Data.Models.Attributes
{
    using System.ComponentModel.DataAnnotations;

    public class NonUnicodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string nullErrorMsg = "Value cannot be null!";
            if (value == null)
            {
                return new ValidationResult(nullErrorMsg);
            }

            string unicodeErrorMsg = "Value cannot contains unicode characters!";
            string text = (string)value;

            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] > 255)
                {
                    return new ValidationResult(unicodeErrorMsg);
                }
            }

            return ValidationResult.Success;
        }
    }
}
