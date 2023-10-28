using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using KAF.BusinessDataObjects;
using Newtonsoft.Json;
using System.Web.Routing;
using System.Configuration;
using System.Text.RegularExpressions;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace KAF.WebFramework
{
    public class clsPrivateKeys
    {

        #region
        public string getStringFromDate(DateTime? Dot)
        {
            if (Dot.HasValue)
                return Dot.Value.ToString("dd-MM-yyyy");
            else
                return "";
        }
        public DateTime? getDateFromString(string date)
        {
            return date.Trim() != string.Empty ? DateTime.Parse(date.Trim(), new System.Globalization.CultureInfo("en-GB")) : (DateTime?)null;
        }
        public Object DeSerializeAnObject(string XmlOfAnObject, Type ObjectType)
        {
            try
            {
                try
                {

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(ObjectType);
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(XmlOfAnObject));
                    Object obj = (Object)serializer.ReadObject(ms);
                    return obj;

                }
                catch (Exception ex)
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string getPublicKey()
        {
            string publickey = string.Empty;
            publickey = @"<BitStrength>4448</BitStrength><RSAKeyValue><Modulus>wYICuPiqsj90MMtTcJXzxGyNolSCaA+otaz09Dm1TXRLwh7Q7jLV8W7Jy8a25nkU/0SDM3bD9KgrNNgxRZnIB6H2RpZg+8AhdUJ8O1ifHgtdmIQPfBu28hdyGimMzWzBIlssAcMTfdPbtpvEBRegtuoIXbCChaLpnlI/INGkxu3+zBSGYC9JvuXaYRCP8Kd/W1bEN169HLb3SKEI1k5co43ituS517NwimFzjNUpA99A6KHPaddavQsDe6VCR78qpSOYMHObq3ge8u5rcGD9XGtHvTW211UjtzqiIghNIm9g//Tb64NtP+eGpSN/2X5FgzMUEi2Bpa9HiDjJXaR0M+8iu/a38JAkO3PF8Xols3cnsPvZ/OOPyaOI7D0H34zYEH0QVR/JcICm/CNPPpeHc6ilO6hpwa/Jg+5wGELpDvKSl/UMrbLZp0wysE130BY3uDaHgv6Mbjs0Co/2652JF8sxOjYVMtC/HeWBMm1MkIX8JCUi2GCz32hFYEQO6oX+yrKvBebfPZsReR8JBHdCDaUunAYbZHqkTK+7s7Lw5avoaJcW1szerXebYO+Ma6O4eCTBqkvOGdImHsu8/FBCLaiBM9BnzpVFCvuPij8y7h71KVJDRzP7HRAUbauQ8X94EYmOSJzplcsrb5h3KrTx41yDoo9Dz+cjLXa68ha+HG56b1BvldxkqAHYqZn2Kurf2UuZZ9XTES7x2UwxU90p7z24tIHVuHrCge6isw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            return publickey;
        }

        public string getPrivateKey()
        {
            string privatekey = string.Empty;
            privatekey = @"<BitStrength>4448</BitStrength><RSAKeyValue><Modulus>wYICuPiqsj90MMtTcJXzxGyNolSCaA+otaz09Dm1TXRLwh7Q7jLV8W7Jy8a25nkU/0SDM3bD9KgrNNgxRZnIB6H2RpZg+8AhdUJ8O1ifHgtdmIQPfBu28hdyGimMzWzBIlssAcMTfdPbtpvEBRegtuoIXbCChaLpnlI/INGkxu3+zBSGYC9JvuXaYRCP8Kd/W1bEN169HLb3SKEI1k5co43ituS517NwimFzjNUpA99A6KHPaddavQsDe6VCR78qpSOYMHObq3ge8u5rcGD9XGtHvTW211UjtzqiIghNIm9g//Tb64NtP+eGpSN/2X5FgzMUEi2Bpa9HiDjJXaR0M+8iu/a38JAkO3PF8Xols3cnsPvZ/OOPyaOI7D0H34zYEH0QVR/JcICm/CNPPpeHc6ilO6hpwa/Jg+5wGELpDvKSl/UMrbLZp0wysE130BY3uDaHgv6Mbjs0Co/2652JF8sxOjYVMtC/HeWBMm1MkIX8JCUi2GCz32hFYEQO6oX+yrKvBebfPZsReR8JBHdCDaUunAYbZHqkTK+7s7Lw5avoaJcW1szerXebYO+Ma6O4eCTBqkvOGdImHsu8/FBCLaiBM9BnzpVFCvuPij8y7h71KVJDRzP7HRAUbauQ8X94EYmOSJzplcsrb5h3KrTx41yDoo9Dz+cjLXa68ha+HG56b1BvldxkqAHYqZn2Kurf2UuZZ9XTES7x2UwxU90p7z24tIHVuHrCge6isw==</Modulus><Exponent>AQAB</Exponent><P>5ufNUyWc85IsQ+yZRf8fnyl7/XOxYknGbt4Ig7uUPIN1MHrrD/UQBVyp4sXohuHg42nIdF3PQ3Lt+uCqr/lfrIeE0VN4cH5/ykmiI/S8USuKEj06p+q2JuYzKMap+suUPMt+5J0G6hge7mml8jvIMJEzHWrmaIX5sEwe+v/NX3beLF5pVIrLPK3vLewQcLR2OceP8udmDwRl3VCaD+bbrheYapGcrc1wOdPwa8MuZxGJR/N+ohpEcz2+A5FtituO7DpNbDeBfcPSFD4rOfbwNjR5qaiGRdHRx8/ygK4kLObC3Cn1+Eo9Az4h/S/TxkSsR43CEYjP+eZvt9msQ+DCR61YAV9pb0sw2yZer5g8BDCqT9xmnnE=</P><Q>1om9nwoqkoxMJOwibYmfaaTnQDSRTRqTdepDoob0JMZqoFhcC0nirIxcknay63X/0rm09UJsB8rGRkLiV6xetZ+o3v6EQszzcOpPMKGfk20a1pWe3dGV6KpuJzXmnxk3JFcvb3ka0W54+10thljAk6nKz0TripcXsPDFXpCl7aEehJtI7u5apmRDy65flHDP5odAxU+20rk0VwBGSJBWPKtgojvkRV/7q/Dx+kdzQYy4nM6AzbsBieGvkiUKIdvI/c8LLPGORlSkXC7QobDqVry8fF1sBauH0WpXBlMWQHGKU4/zNAveoskd3r6825+O53hlQIqp4NT+N3poiJVOF16Gvsu9oMYny+vhXbhErtd79JB9rWM=</Q><DP>EUHNxKMRAdsw17q9EdApatnM3HpjDXd6DxslA8NnJsakYYUuQDkOg3gTclFcOYh0KErlolzIesACLTfRSemXTuup74MPg0jRACtUpN9Lm71nSkmtMpOGHY4i0K9YUNgaMhj7WNarh59Z4HOg5WO2aHrRmSc+JR2uNZDa1+N6U+IsZKCBusHMwrI1J/d2mxXBqDvT9FF6/TBU9J9rhDi6vl4hFAXh8dNiyc+fLk6eDzHuUqROGItiBkLdCqM5zqDuI5WP58CWOvIBp2WmEWT1OvfdB+MCdgFibk6KTze0mG5+rbmtGmth9/YS0Dtc1nqXbZmYoXraIFEqlFD+YOxRWM4Jv8CDvr+d3SMW/ISiJ6YDdIiCWuE=</DP><DQ>RWswdkO93smS4eeehD8h2/dF9JqN4ZsV1/PDitWMLlIdsmCk9+oidJ6+XY4W+uWlr7Pzf+DMQAE3AwklYCUgSDivVeiZN1xF8WV/1kaV8gg9xO2JCFGG5lAvcHSaeSSZmSK08KcJLHdIol1WG8CgH6ezPjoY1TFqsxBVbPH1Ht0hmNr+UIHDx09uOHvl5YxTWU6ugKn4iFrxOq2WEGjT3rG9hQFILcKPFuXSBqAUBUPZgLO5Ldiy+MCUJP/jNW1+rdHO1e4bkVpWDJYBYDB0wzgy7TL1fygvvG1iV2OPMa8LiVps4Yxtr9LP3YFubspEXVWxvZ6gtWV2FNGA/aECMcGebCJU667ytaNPuxmi78g+DbarU+0=</DQ><InverseQ>exKMTvyjKkyOvscHH1SwYi0qM60NlOhhBqgpUcAiKM53bLyLMX2ciQYh0ofx+CrVvDyPBtpYzh9YDmC+0Fp+jRGFulGfiCEE5dNZGKk9C6HXlvjpHfdTYqtpfKigf9s1Enej6FVBVPgLzJnC5+MTQz62itHdHPDlDA9ky0wljdo1QltXLgyoHYCLFVg6NYaGh2wwv+yZ21Ajad43FJUPIOTOdI+Comb51DshHScd/DBftfg1E/TOom28QwF+wr6jRbnF51bZfamCibR3AUTxusQYB/uDfSa8JIK/mJeRudo1JGBjPlJ3UzWPt9PLTGs+1ZT7Hst3fm3rvskEVSDGT/C37xTdPh2YmYdg+I0IdC8D3C7l55I=</InverseQ><D>GwmUYc3048Tz8iFmvjNlhQt52rWeJvYRJ5lL/JfXmkPmlfACV1XpCLvnHD7erWM7qNMk1dsBVDzvFIokkEoFZfOeWoyGboaQ5jZs70nZqbQC1t2U4E1rCXZ3LeqiTs2kSq2cf36HSayBZYlsIR4FCam3k4enJQ73P3TUdzxznowAbvlrMSNKVY7+LVPIGOL+a3+7GNV27P0vnglKF8+JKB0aEV3yDY536g3lvEbIXU8jXZ3GQk6h0goo6WzUzvuJ9Nr9V7+/f3zgLidcAa67l98xfeF0c6/ktqRNpR2t0WLolbrbw5Nwf15VNNu58GSxR7yqUEPleoX8I69zi08AIYWHP+YgG0+4kEoD3VKo0+OROyxlb+0Jm9+LqDdu8tBtHcg5tCDMqZocbmjTTQYRpYnd/+cW5866O8yVkWug2P6dt3bUlqsu5SrOcx1m9ukTMABi6kId5iGgRvjkmQtwKKb3KjnBUrlPTtsUvpO0VzjXSQx6+jXiApakfSxApJTOgOT+UWbJtVrJmgrYRaW5fNGEswJHKu7qQa1C0EOHLAYYr9tLoJdoIAeHc/+Ic5rGyUnIvSgf2LGq1O3zNqI3uzf68Y0jj5gGuwvnTj0H5KJp6L1cDiu8gxm+8n4maCjX1Ykq7UVa9nAP+owKTEWYJL+PZudYtAthtcKQq4CxA7yozup9zhTtTnkfFvjTfIdjf+mBR0LEjD2BQ4jSld23/zK+cNGrzCFyIHR6YQ==</D></RSAKeyValue>";
            return privatekey;
        }

        //public clsWebFrontAuthenticatedUserEntity GetApplicantDecCookieUser(HttpCookie vcCookie)
        //{
        //    KAF.AppConfiguration.Configuration.EncryptionHelper obje = new AppConfiguration.Configuration.EncryptionHelper();
        //    clsWebFrontAuthenticatedUserEntity objStd = new clsWebFrontAuthenticatedUserEntity();
        //    try
        //    {
        //        if (vcCookie != null)
        //        {
        //            string strDec = obje.Decrypt(vcCookie.Value, true, _pk);
        //            MemoryStream msDec = new MemoryStream(Encoding.UTF8.GetBytes(strDec));
        //            DataContractJsonSerializer serDec = new DataContractJsonSerializer(objStd.GetType());
        //            objStd = serDec.ReadObject(msDec) as clsWebFrontAuthenticatedUserEntity;
        //            msDec.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return objStd;
        //}

        public clsObjectUCaseIndentification GetDecCookieUser(HttpCookie vcCookie)
        {
            KAF.AppConfiguration.Configuration.EncryptionHelper obje = new AppConfiguration.Configuration.EncryptionHelper();
            clsObjectUCaseIndentification objStd = new clsObjectUCaseIndentification();
            try
            {
                if (vcCookie != null)
                {
                    string strDec = obje.Decrypt(vcCookie.Value, true, _pk);
                    MemoryStream msDec = new MemoryStream(Encoding.UTF8.GetBytes(strDec));
                    DataContractJsonSerializer serDec = new DataContractJsonSerializer(objStd.GetType());
                    objStd = serDec.ReadObject(msDec) as clsObjectUCaseIndentification;
                    msDec.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objStd;
        }

        private const string _pk = "35VkiSLfPV9t51/omcCEqg==";
        public string GetKeys()
        {
            try
            {
                return _pk;
            }
            catch (Exception ex)
            {
                throw new Exception("wrong domain.");
            }
        }
        public string GetKeys(HttpContext Ctext)
        {
            try
            {
                string requestUri = string.Empty;
                requestUri = Ctext.Request.Url.AbsoluteUri;
                string currentDomain = System.Configuration.ConfigurationManager.AppSettings["currentDomain"].ToString();
                if (!requestUri.Contains(currentDomain))
                {
                    throw new Exception("wrong domain.");
                }
                else
                {
                    //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(_pk);
                    return _pk;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("wrong domain.");
            }
        }

        /// <summary>   Builds an URL. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BuildUrl" type="public static string">    BuildUrl. </method>
        /// <param name="page" type="page">     The page. </param>
        /// <param name="param" type="params string[]">    A variable-length parameters list containing parameter. </param>
        /// <returns>   A string. </returns>

        public string BuildUrl(string page, params string[] param)
        {
            string url = page;
            string[] uparam = url.Split('?');
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }

            if (uparam.Length > 1)
            {
                RequestParam = RequestParam + "&" + uparam[1];
            }

            //url = uparam[0] + "?Param=" + EncryptDecryptQueryString.Encrypt(RequestParam);
            KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new AppConfiguration.Configuration.EncryptionHelper();

            url = uparam[0] + "?MOI=" + HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes((objEnc.Encrypt(RequestParam, true, _pk))));
            //url = uparam[0] + "?" + RequestParam;
            return url;
        }
        public string BuildUrl(params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }
            KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new AppConfiguration.Configuration.EncryptionHelper();

            return "MOI=" + HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes((objEnc.Encrypt(RequestParam, true, _pk))));
        }

        public string BuildUrlMVC(params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }
            return HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes(RequestParam));
        }
        public string BuildUrlMVCFromControllerWithDomain(string Controller, string Action, string domainurl, params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }

            return domainurl + Controller + "/" + Action + "/?KAF=" + HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes(RequestParam));
        }
        public string BuildUrlMVCFromController(string Controller, string Action, params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }

            return DomainUrl.GetDomainUrl() + Controller + "/" + Action + "/?KAF=" + HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes(RequestParam));
        }
        public string BuildUrlMVCOnlyParams(params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }

            return HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes(RequestParam));
        }
        public string GetUrlParamValMVCOnlyParam(string ParamName, string ParamValue)
        {
            string result = "";

            if (string.IsNullOrEmpty(ParamValue)) { return "-99"; }

            System.Collections.Specialized.NameValueCollection paramList = HttpUtility.ParseQueryString(System.Text.Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(ParamValue)));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return "-99";
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return "-99"; }

            return result;
        }

        public string GetUrlParamValMVC(string ParamName, string url)
        {
            string result = "";
            var uri = new Uri(url);
            var query = HttpUtility.ParseQueryString(uri.Query);
            var val = query.Get("KAF");


            if (string.IsNullOrEmpty(val)) { return "-99"; }
            System.Collections.Specialized.NameValueCollection paramList = HttpUtility.ParseQueryString(System.Text.Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(val)));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return "-99";
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return "-99"; }

            return result;
        }


        /// <summary>   Gets URL parameter value. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetUrlParamVal" type="string">  GetUrlParamVal. </method>
        /// <param name="ParamName" type="string">    Name of the parameter. </param>
        /// <returns>   The URL parameter value. </returns>

        public string GetUrlParamVal(string ParamName)
        {
            string result = "";

            string val = HttpContext.Current.Request.QueryString["MOI"];

            if (string.IsNullOrEmpty(val)) { return "0"; }

            KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new AppConfiguration.Configuration.EncryptionHelper();

            System.Collections.Specialized.NameValueCollection paramList = HttpUtility.ParseQueryString(objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(val)), true, _pk));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return "0";
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return "0"; }

            return result;
        }
        public string GetUrlParamVal(string ParamName, string url)
        {
            string result = "";
            var uri = new Uri(url);
            var query = HttpUtility.ParseQueryString(uri.Query);
            var val = query.Get("MOI");


            if (string.IsNullOrEmpty(val)) { return "-99"; }

            KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new KAF.AppConfiguration.Configuration.EncryptionHelper();

            System.Collections.Specialized.NameValueCollection paramList = HttpUtility.ParseQueryString(objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(val)), true, _pk));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return "-99";
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return "-99"; }

            return result;
        }

        /// <summary>   Copies the object described by obj. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="CopyObject<T>" type="T">   CopyObject<T> </method>
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <param name="obj" type="T">  The object. </param>
        /// <returns>   A T. </returns>

        public T CopyObject<T>(T obj)
        {
            if (obj == null)
            {
                return obj;
            }
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, obj);

                ms.Seek(0, SeekOrigin.Begin);

                return (T)(new BinaryFormatter()).Deserialize(ms);
            }
        }

        public string GetCurrentProtocol(string absoluteuri)
        {
            string strurl = string.Empty;
            try
            {
                strurl = absoluteuri;
                string[] protocol = DomainUrl.GetDomainUrl().Split(':');
                strurl = strurl.Replace("http", protocol[0].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strurl;
        }

        public string GetAppKey()
        {
            string _appkey = string.Empty;
            KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new AppConfiguration.Configuration.EncryptionHelper();

            try
            {
                var dateAndTime = DateTime.Now;
                _appkey = dateAndTime.ToString("dd/MMM/yyyy");
                _appkey = HttpServerUtility.UrlTokenEncode(System.Text.Encoding.UTF8.GetBytes((objEnc.Encrypt(_appkey, true, _pk))));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _appkey;
        }

        /// <summary>
        /// Get File Extention And Size Validated
        /// </summary>
        /// <param name="url"></param>
        /// <param name="iFileSize"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public string GetFileExtentionAndSizeValidated(string url, int iFileSize, string fileExtension)
        {
            if (!validateURLWithDomain(url))
                throw new Exception("Invalid Request");

            string msg = string.Empty;
            try
            {
                int fileSZ = 10485760;
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".bmp", ".jpg", ".doc", ".docx", ".pdf", ".rtf", ".pptx", ".ppt", ".xls", ".xlsx", ".avi", ".mov", ".mpeg", ".mp4", ".swf", ".mkv", ".txt" };

                bool uploadLargeFile = false;
                //foreach (string x in allowedExtensions)
                //{
                switch (fileExtension)
                {
                    case ".avi":
                        uploadLargeFile = true;
                        break;
                    case ".mpeg":
                        uploadLargeFile = true;
                        break;
                    case ".mov":
                        uploadLargeFile = true;
                        break;
                    case ".mp4":
                        uploadLargeFile = true;
                        break;
                    case ".mkv":
                        uploadLargeFile = true;
                        break;
                }
                //}

                if (iFileSize > fileSZ && uploadLargeFile == false)  // 10MB approx (actually less though)
                {
                    throw new Exception("حجم الملف لا يمكن أن يتجاوز 10MB.");
                }
                else
                {
                    msg = string.Empty;
                    for (int j = 0; j < allowedExtensions.Length; j++)
                    {
                        if (fileExtension == allowedExtensions[j])
                        {
                            #region Assign File Type
                            switch (fileExtension)
                            {
                                case ".gif":
                                case ".png":
                                case ".jpeg":
                                case ".jpg":
                                case ".bmp":
                                    msg = "Image";
                                    break;
                                case ".doc":
                                    msg = "application/msword";
                                    break;
                                case ".odt":
                                    msg = "application/msword";
                                    break;
                                case ".txt":
                                    msg = "application/msword";
                                    break;
                                case ".docx":
                                    msg = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                                    break;
                                case ".ppt":
                                case ".pptx":
                                    msg = "application/vnd.ms-powerpoint";
                                    break;
                                case ".xls":
                                case ".xlsx":
                                    msg = "application/vnd.ms-excel";
                                    break;
                                case ".pdf":
                                    msg = "application/pdf";
                                    break;
                                case ".rtf":
                                    msg = "application/rtf";
                                    break;
                                case ".avi":
                                    msg = "video/avi";
                                    break;
                                case ".mpeg":
                                    msg = "video/mpeg";
                                    break;
                                case ".mov":
                                    msg = "video/mov";
                                    break;
                                case ".mp4":
                                    msg = "video/mp4";
                                    break;
                            }
                            #endregion
                            break;
                        }
                    }
                    if (string.IsNullOrEmpty(msg))
                        throw new Exception("Unknown File Type.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msg;
        }

        public bool validateURL(string url)
        {
            try
            {
                string GetDate = GetUrlParamVal("_appKey", url);
                KAF.AppConfiguration.Configuration.EncryptionHelper objEnc = new KAF.AppConfiguration.Configuration.EncryptionHelper();
                GetDate = objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(HttpServerUtility.UrlTokenDecode(GetDate)), true, _pk);
                if (DateTime.Parse(GetDate) != DateTime.Now.Date)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool validateURLWithDomain(string url)
        {
            try
            {
                Uri myUri = new Uri(url);
                string host = myUri.Host;
                string CurrentDomain = System.Configuration.ConfigurationManager.AppSettings["Domain"].ToString();
                if (CurrentDomain.Contains(host))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region


        private string GetMenuParentChild(
            List<Owin_ProcessGetFormActionistEntity_Ext> menuItems,
            List<Owin_ProcessGetFormActionistEntity_Ext> formItems,
            long? ParentmenuID,
            string DomURLPrefix)
        {
            StringBuilder menubuilder = new StringBuilder();
            try
            {

                foreach (Owin_ProcessGetFormActionistEntity_Ext objparent in menuItems.Where(p => p.ParentID == ParentmenuID && p.IsView == true).ToList())
                {
                    // menubuilder.Append("<li>");
                    menubuilder.Append("<li class='treeview'>");
                    menubuilder.Append("<a href='#'><i class='fa fa-folder'></i> <span>" + objparent.FormName + "</span>");
                    menubuilder.Append("<span class='pull-right-container'>");
                    menubuilder.Append("<i class='fa fa-angle-left pull-right'></i>");
                    menubuilder.Append("</span>");
                    menubuilder.Append("</a>");
                    menubuilder.Append("<ul class='treeview-menu'>");
                    if (formItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
                    {
                        foreach (Owin_ProcessGetFormActionistEntity_Ext form in formItems.Where(p => p.ParentID == objparent.AppFormID && p.IsView == true))
                        {
                            menubuilder.Append("<li><a href='" + DomURLPrefix + form.URL + form.ActionName + "' class='isChild'><i class='fa fa-file'></i> " + form.Ex_Nvarchar1 + "</a></li>");
                        }
                    }

                    //If contain child
                    if (menuItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
                    {
                        menubuilder.Append(GetMenuParentChild(menuItems, formItems, objparent.AppFormID, DomURLPrefix));
                    }


                    menubuilder.Append("</ul>");
                    menubuilder.Append("</li>");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return menubuilder.ToString();
        }



        public string GetMenuWritten(List<Owin_ProcessGetFormActionistEntity_Ext> itemList, string DomURLPrefix)
        {
            StringBuilder menubuilder = new StringBuilder();

            menubuilder.Append("<li class='header'>MAIN NAVIGATION</li>");
            try
            {
                List<Owin_ProcessGetFormActionistEntity_Ext> menuItems = itemList.Where(p => p.FormActionID == 0 && p.IsView == true).ToList();
                List<Owin_ProcessGetFormActionistEntity_Ext> formItems = itemList.Where(p => p.FormActionID != 0 && p.IsView == true).ToList();

                if (menuItems != null && menuItems.Count > 0)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> parentMenus = itemList.Where(p => p.ParentID == 0 && p.IsView == true).ToList();

                    foreach (Owin_ProcessGetFormActionistEntity_Ext parentMenu in parentMenus.OrderBy(p => p.Sequence).ToList())
                    {
                        menubuilder.Append("<li class='treeview'>");
                        menubuilder.Append("<a href='#'> ");
                        menubuilder.Append("<i class='fa fa-folder'></i> <span>" + parentMenu.FormName + "</span>");
                        menubuilder.Append("<span class='pull-right-container'>");
                        menubuilder.Append("<i class='fa fa-angle-left pull-right'></i>");
                        menubuilder.Append("</span>");
                        menubuilder.Append("</a>");

                        menubuilder.Append("<ul class='treeview-menu'>");

                        if (formItems.Where(p => p.ParentID == parentMenu.AppFormID).FirstOrDefault() != null)
                        {
                            foreach (Owin_ProcessGetFormActionistEntity_Ext form in formItems.Where(p => p.ParentID == parentMenu.AppFormID && p.IsView == true))
                            {
                                menubuilder.Append("<li><a href='" + DomURLPrefix + form.URL + form.ActionName + "' class='isChild'><i class='fa fa-file'></i> " + form.Ex_Nvarchar1 + "</a></li>");
                            }
                        }

                        // seleced parent has morechild so call recursive
                        if (menuItems.Where(p => p.ParentID == parentMenu.AppFormID).FirstOrDefault() != null)
                        {
                            menubuilder.Append(GetMenuParentChild(menuItems, formItems, parentMenu.AppFormID, DomURLPrefix));
                        }

                        menubuilder.Append("</ul>");
                        menubuilder.Append("</li>");
                    }

                    return menubuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return menubuilder.ToString();
        }


        #endregion

        public string GetImageString(string normalcode)
        {
            string retstr = "";
            try
            {
                string level = "L";

                QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(normalcode, eccLevel))
                    {
                        using (QRCode qrCode = new QRCode(qrCodeData))
                        {

                            Bitmap bitMap = qrCode.GetGraphic(20, Color.Black, Color.White, null, 15);
                            using (MemoryStream ms = new MemoryStream())
                            {

                                bitMap.Save(ms, ImageFormat.Png);
                                retstr = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());

                            }
                        }
                    }
                }
            }
            catch (Exception es)
            {

            }

            return retstr;
        }
        public string GetURLGen(System.Web.Mvc.ControllerContext controllercontext, RouteCollection routetable,
            string controllername, string actionname, string currentURL)
        {
            string url = string.Empty;
            string protocol = string.Empty;
            string port = string.Empty;
            try
            {
                //string url = "http://www.contoso.com:8080/letters/readme.html";
                Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>\d+)?/", RegexOptions.None, TimeSpan.FromMilliseconds(150));
                Match m = r.Match(currentURL);
                if (m.Success)
                {
                    protocol = r.Match(currentURL).Result("${proto}");
                    port = r.Match(currentURL).Result("${port}");
                    string DomainName = HttpContext.Current.Request.Url.Host;
                    url = System.Web.Mvc.UrlHelper.GenerateUrl(null, actionname, controllername, protocol, DomainName, String.Empty, null, RouteTable.Routes, controllercontext.RequestContext, false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return url;
        }
    }
}