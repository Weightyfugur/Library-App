using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class ISBNValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var tempValue = value.ToString();
            Regex ISBN13 = new Regex(@"^\d{3}[-]{1}\d{10}$");// ISBN 13 variant
            Regex ISBN10 = new Regex(@"^\d{10}$");// ISBN 10 variant

            if (ISBN13.IsMatch(tempValue) || ISBN10.IsMatch(tempValue))
            {
                return null;
            }

            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
