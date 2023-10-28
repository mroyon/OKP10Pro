using KAF.AppConfiguration.EncryptionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KAF.AppConfiguration.Configuration
{
    public partial class PostDataHelper
    {
        private static string SecretKey;
        private static string InitializeVector;
        private static TrippleDESCryptoService des;
        private PostDataHelper.PostData _PostData = new PostDataHelper.PostData();
        private HttpResponse Response;
        private HttpRequest Request;
        /// <summary>
        /// Data
        /// </summary>
        public PostDataHelper.PostData Data
        {
            get
            {
                return this._PostData;
            }
        }
        /// <summary>
        /// Get/Set FormName for data
        /// </summary>
        public string FormName
        {
            get
            {
                return this.Data.FormName;
            }
            set
            {
                this.Data.FormName = value;
            }
        }
        /// <summary>
        /// Static ctor to initialize encryptor
        /// </summary>
        static PostDataHelper()
        {
            PostDataHelper.SecretKey = "asdf456jklhihioh23094hih";
            PostDataHelper.InitializeVector = "RontyMeg";
            PostDataHelper.des = new TrippleDESCryptoService(PostDataHelper.SecretKey, PostDataHelper.InitializeVector);
        }
        /// <summary>
        /// ctor    
        /// </summary>
        /// <param name="request">Current Request</param>
        /// <param name="response">Current Response</param>
        public PostDataHelper(HttpRequest request, HttpResponse response)
        {
            this.Request = request;
            this.Response = response;
        }
        /// <summary>
        /// Reads data posted using same utility
        /// </summary>
        public void ReadPostedData()
        {
            this._PostData = new PostDataHelper.PostData();
            if (this.Request.Form != null && this.Request.Form["__TransferKAFDataEnd"] != null)
            {
                foreach (string key in this.Request.Form.Keys)
                {
                    this.Data.SetRawData(key, PostDataHelper.des.DecryptData(HttpUtility.HtmlDecode(this.Request.Form[key])));
                }
            }
        }
        /// <summary>
        /// Posts data
        /// </summary>
        /// <param name="Destination"></param>
        public void RedirectWithData(string Destination)
        {
            this.Response.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<body onload='document.forms[\"form\"].submit()'>");
            sb.AppendFormat("<form name='form' action='{0}' method='post'>", Destination);
            foreach (string key in this.Data)
            {
                sb.AppendFormat("<input type='hidden' name='{0}' value='{1}' />", key, HttpUtility.HtmlEncode(PostDataHelper.des.EncryptData(this.Data.GetRawData(key))));
            }
            //sb.Append("Loading, please wait...");

            sb.Append("<span id=\"MainContent_lblHeader\" class=\"labelHeader\">Loading, please wait...</span>");
            sb.Append("<noscript>Javascript is disabled, Click submit to proceed.");
            sb.Append("<br/><input type='submit' value='submit'/>");
            sb.Append("</noscript>");
            sb.Append("</form>");
            sb.Append("</body>");   
            sb.Append("</html>"); 
            //Response.ContentEncoding = Encoding.GetEncoding("ISO-8859-1");
            //Response.HeaderEncoding = Encoding.GetEncoding("ISO-8859-1");
            //Response.Charset = "ISO-8859-1";
            this.Response.Write(sb.ToString());
            this.Response.Flush();
            //this.Response.End();
            HttpContext.Current.ApplicationInstance.CompleteRequest();
            //this.Response.End();

        }


    }
}
