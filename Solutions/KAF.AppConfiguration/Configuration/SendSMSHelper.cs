using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net;
using System.IO;

namespace KAF.AppConfiguration.Configuration
{
    public class SendSMSHelper : IDisposable
    {
        #region IDisposable Members

        private bool isDisposed = false;

        ~SendSMSHelper()
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
        /// retFrist5CharsMatchForCityCellOnly
        /// </summary>
        /// <method name="retFrist5CharsMatchForCityCellOnly" type="bool"></method>
        /// <param name="strInput" type="string"></param>
        /// <returns></returns>
        public bool retFrist5CharsMatchForCityCellOnly(string strInput)
        {
            if (strInput.Length < 5) return false;
            string strFirst5Chars = strInput.Substring(0, 5);

            switch (strFirst5Chars)
            {
                case "88011":
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// retFrist5CharsMatch
        /// </summary>
        /// <param name="strInput" type="string"></param>
        /// <returns></returns>
        public int retFrist5CharsMatch(string strInput)
        {
            if (strInput.Length < 5) return 0;
            string strFirst5Chars = strInput.Substring(0, 5);

            switch (strFirst5Chars)
            {
                case "88017":
                    return 1;
                //case "88011":
                //    return 2;
                case "88019":
                    return 3;
                case "88018":
                    return 4;
                case "88016":
                    return 6;
                case "88015":
                    return 5;
                default:
                    return 0;
            }
        }

      
    }
}
