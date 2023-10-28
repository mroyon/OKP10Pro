using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KAF.AppConfiguration.Configuration
{
    public class UserNumberFormat
    {
        #region Check Mobile Number
        /// <summary>
        /// mobile number validation
        /// </summary>
        /// <method name="IsMobileNumberValid" type="string"></method>
        /// <param name="mobileNumber" type="string"></param>
        /// <returns></returns>
        public static string IsMobileNumberValid(string mobileNumber)
        {
            string _mobileNumber = string.Empty;
            _mobileNumber = ParsedMobileNumber(mobileNumber);

            if (_mobileNumber.Length == 13)
            {
                if (Regex.IsMatch(_mobileNumber, @"^[-+]?[0-9]*\.?[0-9]+$"))
                    return _mobileNumber;
            }
            else if (_mobileNumber.Length == 11)
            {
                if (Regex.IsMatch(_mobileNumber, @"^[-+]?[0-9]*\.?[0-9]+$"))
                {
                    string _default_prifix = "88";

                    _mobileNumber = _default_prifix + _mobileNumber;
                    return _mobileNumber;
                }
                return null;
            }
            else
                return null;

            return null;
        }
        /// <summary>
        /// parse mobile number
        /// </summary>
        /// <method name="ParsedMobileNumber" type="string"></method>
        /// <param name="number" type="string"></param>
        /// <returns></returns>
        public static string ParsedMobileNumber(string number)
        {
            number = number.Replace("+", "");
            number = number.Replace(".", "");
            number = number.Replace(" ", "");
            number = number.Replace("-", "");
            number = number.Replace("/", "");
            number = number.Replace("(", "");
            number = number.Replace(")", "");


            return number;
        }

        #endregion Check Mobile Number
    }
}
