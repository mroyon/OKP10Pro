using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KAF.AppConfiguration.Configuration
{
    public class clsTextMasking : IDisposable
    {
        #region Constructer & Destructor

        public clsTextMasking()
        {
        }


        private bool isDisposed = false;

        ~clsTextMasking()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Code to dispose the managed resources of the class
            }
            // Code to dispose the un-managed resources of the class

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        /// <summary>
        /// Create Pin Pattern 
        /// </summary>
        /// <method name="patternLibrary" type="string"></method>
        /// <param name="strToMasked" type="string"></param>
        /// <returns>string</returns>
        /// <remarks>Create Pin Pattern </remarks>
        public string patternLibrary(string strToMasked)
        {
            string res = string.Empty;
            string pat = string.Empty;
            try
            {
                strToMasked = Regex.Replace(strToMasked, "PIN:.[0-9][0-9][0-9][0-9]", "PIN: ****");    // PIN: 1234.
                strToMasked = Regex.Replace(strToMasked, "PIN .[0-9][0-9][0-9][0-9]", "PIN ****");    // PIN 1234.
                strToMasked = Regex.Replace(strToMasked, "PIN is.[0-9][0-9][0-9][0-9]", "PIN is ****");    // PIN is 1234.
                strToMasked = Regex.Replace(strToMasked, "PIN is. [0-9][0-9][0-9][0-9]", "PIN is ****");    // PIN is 1234.

                //HIST
                pat = string.Empty;
                pat = @"HIST\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                //CP
                pat = string.Empty;
                pat = @"CP\s\d{4}\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 9);
                //BAL
                pat = string.Empty;
                pat = @"BAL\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///PAY
                pat = string.Empty;
                pat = @"PAY\s\d{13}\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///DP
                pat = string.Empty;
                pat = @"DP\s\d{13}\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///RC
                pat = string.Empty;
                pat = @"RC\s\d{13}\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///CO
                pat = string.Empty;
                pat = @"CO\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///RCAN
                pat = string.Empty;
                pat = @"RCAN\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///AUTH CODE
                pat = string.Empty;
                pat = @"Authorization Code:\s(\w+)";
                strToMasked = HideTRAN(pat, strToMasked, 4);


                ///BR
                pat = string.Empty;
                pat = @"BR\s\d{13}\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///BP
                pat = string.Empty;
                pat = @"BP\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///BRCAN
                pat = string.Empty;
                pat = @"BRCAN\s(\w+)\s\d{4}";
                strToMasked = HideTRAN(pat, strToMasked, 4);
                ///AUTH CODE
                pat = string.Empty;
                pat = @"Bill Code:\s(\w+)";
                strToMasked = HideTRAN(pat, strToMasked, 4);

                ///TRAN TOKEN
                pat = string.Empty;
                pat = @"transaction token is:\s(\w+)";
                strToMasked = HideTRAN(pat, strToMasked, 4);



                res = strToMasked;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        /// <summary>
        /// Hide Transaction Number
        /// </summary>
        /// <method name="HideTRAN" type="string"></method>
        /// <param name="pat" type="string"></param>
        /// <param name="s" type="string"></param>
        /// <param name="lentocut" type="string"></param>
        /// <returns></returns>
        /// <remarks>Hide Transaction number</remarks>
        private string HideTRAN(string pat, string s, int lentocut)
        {
            return Regex.Replace(s, pat, delegate(Match match)
            {
                string v = match.ToString();
                v = v.Remove(match.Length - lentocut, lentocut);
                v = v + "****";
                return v;
            });
        }
    }
}
