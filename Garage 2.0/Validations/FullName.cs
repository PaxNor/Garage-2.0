using Garage_2._0.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Validations
{
    public class FullName : ValidationAttribute
    {
        //protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        //{
        //    if (value is string input)
        //    {
        //        //var input = value as string;
        //        var viewModel = validationContext.ObjectInstance as MemberCreateViewModel;
        //        //var db = validationContext.GetService(typeof(LexiconUniversityContext)) as LexiconUniversityContext;

        //        if (viewModel is not null)
        //        {
        //            if(viewModel.FirstName == input)
        //            {
        //                return new ValidationResult(ErrorMessage);
        //            }
        //            else
        //            {
        //                return ValidationResult.Success;
        //            }
        //        }
        //    }


        //    return new ValidationResult(ErrorMessage);
        //}
    }
}
