using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyCalcLibrery
{
    public class PasswordStrengthCheker
    {
        public static int GetPassw0rdStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }

            int result = 0;

            if (Math.Max(password.Length, 7) > 7)
            {
                result++;
            }

            if (Regex.Match(password, "[a-z]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[A-Z]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[0-9]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[\\!\\@\\#]").Success)
            {
                result++;
            }

            return result;

        }
    }
}
