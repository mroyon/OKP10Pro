using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsMailComponent :IDisposable
    {

        #region Constructer & Destructor

        public clsMailComponent()
        {
        }


        private bool isDisposed = false;

        ~clsMailComponent()
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
        public string ForgetPassword(MailEntity token)
        {
            token.subject = "Your Reset Password Request.";
            token.strValue4 += "</br> Reset Link (URL): " + token.strValue3 + "</br>";
            token.strValue4 += "</br> Auth Code: " + token.strValue2 + "</br>";
            string str = SendMail(token);
            return str;
        }

        public string SendMail(MailEntity token)
        {
            string str = string.Empty;
            try
            {
                stp_organizationEntity obj = new stp_organizationEntity();
                obj = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity()
                {
                    organizationkey = 14
                }).FirstOrDefault();

                if (string.IsNullOrEmpty(obj.strValue1))
                {

                    MailEntity objMailList = new MailEntity();
                    objMailList.ismailenable = true;
                    objMailList.smtphost = obj.smtphost;
                    objMailList.mailport = obj.mailport;
                    objMailList.smtpusername = obj.smtpusername;
                    objMailList.smtppassword = obj.smtppassword;
                    objMailList.mailssl = obj.mailssl;
                    objMailList.fromemailaddress = obj.fromemailaddress;
                    objMailList.maildisplayName = obj.maildisplayname;

                    objMailList.ToEmail = token.ToEmail;
                    objMailList.Body = token.strValue4;
                    objMailList.Subject = token.subject;
                    KAF.AppConfiguration.Configuration.EmailManager objMail = new KAF.AppConfiguration.Configuration.EmailManager(objMailList);
                    bool flg = objMail.SendMail(objMailList.ToEmail, objMailList.Body, objMailList.Subject);
                    if (flg)
                        str = "Your mail has been sent.";
                    else
                        str = "We encounter some difficulties to send your mail.";
                }
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            return str;
        }

    }
}