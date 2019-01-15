namespace P01_BillsPaymentSystem.Data.Models.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;

    [AttributeUsage(AttributeTargets.Property)]
    public class XorAttribute : ValidationAttribute
    {
        private string xorTargetAttr;

        public XorAttribute(string xorTargetAttr)
        {
            this.xorTargetAttr = xorTargetAttr;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            object targetAttr = validationContext.ObjectType
                .GetProperty(this.xorTargetAttr)
                .GetValue(validationContext.ObjectInstance);

            if ((targetAttr != null && value == null) || (targetAttr == null && value != null))
            {
                return ValidationResult.Success;
            }

            string errorMsg = "The two properties mush have opposite values!";
            return new ValidationResult(errorMsg);
        }
    }
}
