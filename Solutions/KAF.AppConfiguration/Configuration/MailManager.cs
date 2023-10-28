using System;
using System.Collections;
using System.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.AppConfiguration.Configuration
{
    public class EmailManager
    {

        //public string From;
        //public string To;
        //public string Subject;
        //public string Body;
        //public Boolean IsHTMLMail = true;
        //public string ThisMessge;
        //public string HostIP;
        //public int PortNumber;

        private MailEntity objMailEntity = new MailEntity();

        //public string HTMLContentAsString;

        /// <summary>
        /// Send Mail
        /// </summary>
        /// <method name="SendMail" type="bool"></method>
        /// <param name="To" type="string"></param>
        /// <param name="pagebody" type="string"></param>
        /// <param name="SubjectT" type="string"></param>
        /// <returns></returns>
        public bool SendMail(string To, string pagebody, string SubjectT)
        {
            try
            {
                bool result;
                try
                {
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(objMailEntity.fromemailaddress)
                    };

                    mailMessage.To.Add(new MailAddress(To));
                    mailMessage.IsBodyHtml = objMailEntity.IsHTMLMail;
                    mailMessage.Subject = SubjectT;
                    mailMessage.Body = pagebody;

                    var userName = objMailEntity.smtpusername;
                    var password = objMailEntity.smtppassword;
                    var smtpClient = new SmtpClient
                    {
                        UseDefaultCredentials = true,
                        Credentials = new NetworkCredential(userName, password),
                        Host = objMailEntity.smtphost,
                        Port = (int)objMailEntity.mailport,
                        EnableSsl = (bool)objMailEntity.mailssl
                    };

                    smtpClient.Send(mailMessage);
                    result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
                return result;

            }
            catch (Exception ex)
            {
                objMailEntity.MailStatus = ex.Message;
                return false;
            }
            return true;
        }
        /// <summary>
        /// SendMail
        /// </summary>
        /// <method name="SendMail" type="bool"></method>
        /// <param name="To" type="string"></param>
        /// <param name="pagebody" type="string"></param>
        /// <param name="SubjectT" type="string"></param>
        /// <param name="atch" type="Attachment"></param>
        /// <returns></returns>
        public bool SendMail(string To, string pagebody, string SubjectT, Attachment atch)
        {
            try
            {
                bool result;
                try
                {
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(objMailEntity.fromemailaddress)
                    };

                    mailMessage.To.Add(new MailAddress(To));
                    mailMessage.IsBodyHtml = objMailEntity.IsHTMLMail;
                    mailMessage.Subject = SubjectT;
                    mailMessage.Body = pagebody;
                    mailMessage.Attachments.Add(atch);
                    var userName = objMailEntity.smtpusername;
                    var password = objMailEntity.smtppassword;
                    var smtpClient = new SmtpClient
                    {
                        Credentials = new NetworkCredential(userName, password),
                        Host = objMailEntity.smtphost,
                        Port = (int)objMailEntity.mailport,
                        EnableSsl = (bool)objMailEntity.mailssl
                    };

                    smtpClient.Send(mailMessage);
                    result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
                return result;

            }
            catch (Exception ex)
            {
                objMailEntity.MailStatus = ex.Message;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Email Manager
        /// </summary>
        /// <method name="EmailManager" type="void"></method>
        /// <param name="_MailEntity" type="MailEntity"></param>
        public EmailManager(MailEntity _MailEntity)
        {
            objMailEntity = _MailEntity;
        }



    }
}
