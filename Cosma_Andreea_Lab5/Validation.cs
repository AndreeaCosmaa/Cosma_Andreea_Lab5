using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cosma_Andreea_Lab5
{
    //3
   //validator pentru camp required
   public class StringNoEmpty : ValidationRule
    {
        //mostenim metoda Validate ce returneaza un ValidationResult
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");

            return new ValidationResult(true, null);
        }
    }

    //validator pentru lungimea minima a string-ului
    public class StringMinLengthValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");

            return new ValidationResult(true, null);
        }
    }

}
