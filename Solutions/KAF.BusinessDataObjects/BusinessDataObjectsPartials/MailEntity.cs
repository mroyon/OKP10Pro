using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    #region MailEntity
    /// <summary>
    /// This object represents the properties and methods of a MailEntity.
    /// </summary>
    [Serializable]
    [DataContract(Name = "MailEntity", Namespace = "http://www.KAF.com/types")]
    public class MailEntity : BaseEntity
    {
        //protected long? _UserNumber;
        protected string _fullName;
        protected string _mobileNo;
        protected string _email;
        protected string _subject;
        protected string _body;

        [DataMember]
        public bool? ismailenable;
        [DataMember]
        public string smtphost;
        [DataMember]
        public long? mailport;
        [DataMember]
        public string smtpusername;
        [DataMember]
        public string smtppassword;
        [DataMember]
        public bool? mailssl;
        [DataMember]
        public string fromemailaddress;
        [DataMember]
        public string maildisplayName;
        [DataMember]
        public bool IsHTMLMail;
        [DataMember]
        public string MailStatus;


        [DataMember]
        public string ToEmail;
        [DataMember]
        public string Body;
        [DataMember]
        public string Subject;
        [DataMember]
        public string MobileNo;

        public MailEntity()
        {
        }

        #region Public Properties
        //[DataMember]
        //public long? UserNumber
        //{
        //    get { return _UserNumber; }
        //    set { _UserNumber = value; this.OnChnaged(); }
        //}


        [DataMember]
        public string body
        {
            get { return _body; }
            set { _body = value; }
        }
        [DataMember]
        public string subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }


        [DataMember]
        public string fullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        [DataMember]
        public string mobileNo
        {
            get { return _mobileNo; }
            set { _mobileNo = value; }
        }







        #endregion//


    }
    #endregion
}
