using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace KAF.AppConfiguration.Configuration
{
    public class WebSerTKC
    {
        /// <summary>
        /// Get token 
        /// </summary>
        /// <returns></returns>
        public string GetTokenX()
        {
            EncryptionHelper objEnc = new EncryptionHelper();
            return objEnc.encryptSimple("AppToken201118031980");
        }
        /// <summary>
        /// set token
        /// </summary>
        /// <param name="strToken" type="string"></param>
        /// <returns></returns>
        public bool SetTokenX(string strToken)
        {
            try
            {
                EncryptionHelper objEnc = new EncryptionHelper();
                if (objEnc.decryptSimple(strToken) == "AppToken201118031980")
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
