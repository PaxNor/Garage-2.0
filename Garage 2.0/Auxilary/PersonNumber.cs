using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Garage_2._0.Auxilary
{
    public class PersonNumber : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {

            var errorMessage = "Ej giltigt personnummer, måste innehålla 12 siffror";

            Regex rgx = new Regex(@"\d{12}");

            if(value is string input)
            {
                input = StringFormatter.CompactPersonNumber(input);
                if(rgx.IsMatch(input)) return ValidationResult.Success;
            }

            return new ValidationResult(errorMessage);
        }
    }
}
