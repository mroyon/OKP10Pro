using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAF.AppConfiguration.Configuration
{
    /// <summary>
    /// Return unique generated ID's for file handling
    /// </summary>
    public abstract class UniqueIDHelper
    {
        /// <summary>
        /// Generate a generated ID from the date and time
        /// </summary>
        private static String generatedID
        {
            // create a read only unique ID
            get { return String.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond); }
        }

        /// <summary>
        /// Get a unique ID for use with automated file handling
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public static String ReturnUniqueID(EUniqueIDFormat format)
        {
            // return value
            String modifiedID = "";
            // create a return value
            String capturedID = UniqueIDHelper.generatedID;

            // select which format the ID should take
            switch (format)
            {
                // text only
                case (EUniqueIDFormat.Text):
                    {
                        // work through each character
                        foreach (Char idElement in capturedID)
                        {
                            // expose its int value, + 16 for ASCII offset to captials
                            modifiedID += (Char)((Int32)idElement + 17);
                        }
                        break;
                    }
                // text and numeric
                case (EUniqueIDFormat.Combined):
                    {
                        // work through each character
                        foreach (Char idElement in capturedID)
                        {
                            // if the characters ascii value is even
                            if ((Int32)idElement % 2 == 0)
                            {
                                // expose its int value, + 16 for ASCII offset to captials
                                modifiedID += (Char)((Int32)idElement + 17);
                            }
                            // element must be odd
                            else
                            {
                                // just add the element as its numeric form
                                modifiedID += idElement;
                            }
                        }
                        break;
                    }
                case (EUniqueIDFormat.Numeric):
                    {
                        // just set ID
                        modifiedID = capturedID;
                        break;
                    }
                default:
                    {
                        // throw excetion
                        throw new Exception("Unique format type is invalid");
                    }
            }

            // retun ID
            return modifiedID;
        }
    }

    /// <summary>
    /// Enumeration of UniqueID types
    /// </summary>
    public enum EUniqueIDFormat { Numeric = 0, Text, Combined }
}
