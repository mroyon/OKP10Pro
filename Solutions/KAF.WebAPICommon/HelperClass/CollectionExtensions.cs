using System.Collections.Generic;

namespace KAF.WebAPICommon.HelperClass
{
    internal static class CollectionExtensions
    {
        public static void AddCommaSeperatedValues(this ICollection<string> current, string raw)
        {
            if (current == null)
            {
                return;
            }

            var valuesToAdd = raw.SplitCommaSeperatedValues();
            foreach (var value in valuesToAdd)
            {
                current.Add(value);
            }
        }
    }
}