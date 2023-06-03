using System.ComponentModel.DataAnnotations;

namespace Anadolu
{

    public class NumbersOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            string stringValue = value.ToString();
            if (string.IsNullOrWhiteSpace(stringValue))
                return true;

            return IsNumeric(stringValue);
        }

        private bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }

}
