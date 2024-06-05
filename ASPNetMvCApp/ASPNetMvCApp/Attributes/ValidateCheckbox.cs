using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Attributes
{
    public class ValidateCheckbox : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is bool boolean && boolean)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "Please, accept terms and services.");
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-validatecheckbox", ErrorMessage ?? "Please, accept terms and services.");
        }
    }
}
