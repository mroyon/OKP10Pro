using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    [Serializable]
    [DataContract(Name = "KAF_ReplyContainerEntity", Namespace = "http://www.KAF.BusinessDataObjects.com/types")]
    public class KAF_ReplyContainerEntity : BaseEntity
    {
        protected long _ReplyKey;
        protected string  _ReplyToUser;
        protected bool? _SendSMS;
        protected string _SendSMSText;
        protected bool? _SendEmail;
        protected string _SendEmailText;
        protected DateTime? _ReplyDateTime;
        protected long? _SMSSendStatus;
        protected long? _EmailSendStatus;
        protected bool? _iserror;
        protected string _SentSMSSMSPostFeedBack;
        protected string _SentEmailPostFeedBack;
        
        public KAF_ReplyContainerEntity()
        {
        }

        [DataMember]
        public string  SentSMSSMSPostFeedBack
        {
            get { return _SentSMSSMSPostFeedBack; }
            set { _SentSMSSMSPostFeedBack = value; }
        }
        [DataMember]
        public string  SentEmailPostFeedBack
        {
            get { return _SentEmailPostFeedBack; }
            set { _SentEmailPostFeedBack = value; }
        }
        [DataMember]
        public long? SMSSendStatus
        {
            get { return _SMSSendStatus; }
            set { _SMSSendStatus = value; }
        }
        [DataMember]
        public long? EmailSendStatus
        {
            get { return _EmailSendStatus; }
            set { _EmailSendStatus = value; }
        }
        [DataMember]
        public string  SendSMSText
        {
            get { return _SendSMSText; }
            set { _SendSMSText = value; }
        }
        [DataMember]
        public string SendEmailText
        {
            get { return _SendEmailText; }
            set { _SendEmailText = value; }
        }
        [DataMember]
        public bool? iserror
        {
            get { return _iserror; }
            set { _iserror = value; }
        }
        [DataMember]
        public long ReplyKey
        {
            get { return _ReplyKey; }
            set { _ReplyKey = value; }
        }
        [DataMember]
        public string  ReplyToUser
        {
            get { return _ReplyToUser; }
            set { _ReplyToUser = value; }
        }
        [DataMember]
        public bool? SendSMS
        {
            get { return _SendSMS; }
            set { _SendSMS = value; }
        }
        [DataMember]
        public bool? SendEmail
        {
            get { return _SendEmail; }
            set { _SendEmail = value; }
        }
        [DataMember]
        public DateTime? ReplyDateTime
        {
            get { return _ReplyDateTime; }
            set { _ReplyDateTime = value; }
        }

    }

}
