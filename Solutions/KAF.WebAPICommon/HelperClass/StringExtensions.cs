using System;
using System.Collections.Generic;
using System.Linq;

namespace KAF.WebAPICommon.HelperClass
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Splits a comma delimited string into a new collection
        /// </summary>
        /// <param name="raw">Comma delimited string of values to split</param>
        /// <returns></returns>
        public static IEnumerable<string> SplitCommaSeperatedValues(this string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
            {
                return Enumerable.Empty<string>();
            }

            return raw.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(s => s.Trim())
                      .ToList();
        }
    }
}