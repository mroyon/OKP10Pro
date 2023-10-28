using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAF.AppConfiguration.Configuration
{
    public static class CSVReaderExtension
    {
        /// <summary>
        /// Convert a CSV-formatted string into a list of objects
        /// </summary>
        /// <returns>List of objects that contains the CSV data</returns>
        public static List<object> ReadCSVLine(this string input)
        {
            using (CSVReader reader = new CSVReader(input))
                return reader.ReadRow();
        }

        /// <summary>
        /// Convert a CSV-formatted string into a DataTable
        /// </summary>
        /// <param name="headerRow">True if the first row contains headers</param>
        /// <returns>System.Data.DataTable that contains the CSV data</returns>
        public static DataTable ReadCSVTable(this string input, bool headerRow)
        {
            using (CSVReader reader = new CSVReader(input))
                return reader.CreateDataTable(headerRow);
        }
    }
}
