using System;
using System.Globalization;
using System.Diagnostics;


namespace KAF.AppConfiguration.Configuration
{
    public static class ArgumentValidator
    {
        /// <summary>
        /// Validate Is Positive integer
        /// </summary>
        /// <method name="IsPositiveNumeric" type="bool"></method>
        /// <param name="variable" type="int"></param>
        /// <returns>bool</returns>
        /// <remarks>validator for positive numeric integer</remarks>
        [DebuggerStepThrough()]
        public static bool IsPositiveNumeric(int variable)
        {
            return (variable > 0);
        }

        /// <summary>
        /// validate is positive decimal
        /// </summary>
        /// <method name="IsPositiveNumeric" type="bool"></method>
        /// <param name="variable" type="decimal"></param>
        /// <returns>bool</returns>
        /// <remarks>validator for positive numeric decimal</remarks>
        [DebuggerStepThrough()]
        public static bool IsPositiveNumeric(decimal variable)
        {
            return (variable > 0);
        }

        /// <summary>
        /// validate is date
        /// </summary>
        /// <method name="IsValidDate" type="bool"></method>
        /// <param name="value" type="DateTime"></param>
        /// <returns>bool</returns>
        /// <remarks>validate datetime </remarks>
        [DebuggerStepThrough()]
        public static bool IsValidDate(DateTime value)
        {
            return ((value != DateTime.MinValue) && (value != DateTime.MaxValue));
        }

        /// <summary>
        /// validate is empty string
        /// </summary>
        /// <method name="IsEmptyString" type="bool"></method>
        /// <param name="value" type="string"></param>
        /// <returns>bool</returns>
        /// <remarks>validate is empty string</remarks>
        [DebuggerStepThrough()]
        public static bool IsEmptyString(string value)
        {
            return ((value == null) || (value.Trim().Length == 0));
        }

        /// <summary>
        ///  check for empty string 
        /// </summary>
        /// <method name="CheckForEmptyString" type="void"></method>
        /// <param name="variable" type="string"></param>
        /// <param name="variableName" type="string"></param>
        /// <remarks>check for empty string</remarks>
        [DebuggerStepThrough()]
        public static void CheckForEmptyString(string variable,
        string variableName)
        {
            CheckForNullReference(variableName, "variableName");
            CheckForNullReference(variable, variableName);

            if (IsEmptyString(variable))
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "The '{0}' can not be null or an empty string.", variableName), variableName);
            }
        }

        /// <summary>
        /// check for null reference
        /// </summary>
        /// <method name="CheckForNullReference" type="void"></method>
        /// <param name="variable" type="object"></param>
        /// <param name="variableName" type="string"></param>
        /// <remarks>check for null reference </remarks>
        [DebuggerStepThrough()]
        public static void CheckForNullReference(object variable,
        string variableName)
        {
            if (variableName == null)
            {
                throw new ArgumentNullException("variableName");
            }

            if (variable == null)
            {
                throw new ArgumentNullException(variableName);
            }
        }

        /// <summary>
        /// raise argument exception
        /// </summary>
        /// <method name="RaiseArgumnetException" type="void"></method>
        /// <param name="message" type="string"></param>
        /// <param name="paramName" type="string"></param>
        /// <remarks>raise argument exception</remarks>
        [DebuggerStepThrough()]
        public static void RaiseArgumnetException(string message,
        string paramName)
        {
            throw new ArgumentException(message, paramName);
        }

        /// <summary>
        /// raise argument exception
        /// </summary>
        ///  <method name="RaiseArgumnetException" type="void"></method>
        /// <param name="message" type="string"></param>
        /// <remarks>raise argument exception</remarks>
        [DebuggerStepThrough()]
        public static void RaiseArgumnetException(string message)
        {
            throw new ArgumentException(message);
        }
    }
}
