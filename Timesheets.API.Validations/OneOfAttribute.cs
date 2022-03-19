using System.ComponentModel.DataAnnotations;

namespace Timesheets.API.Validations
{
    public class OneOfAttribute:ValidationAttribute
    {
        private readonly string[] _values;

        public OneOfAttribute(params string[] values)
        {
            _values = values;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var str=value as string;

            if (!string.IsNullOrWhiteSpace(str) && _values.Contains(str))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Value is not one of params");
        }
    }
}
