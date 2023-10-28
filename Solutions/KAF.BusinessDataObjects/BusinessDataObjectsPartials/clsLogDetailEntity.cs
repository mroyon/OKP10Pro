using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    #region clsLogDetail
    /// <summary>
    /// This object represents the properties and methods of a MailEntity.
    /// </summary>
    [Serializable]
    [DataContract(Name = "clsLogDetail", Namespace = "http://www.KAF.com/types")]
    public class clsLogDetail 
    {
        //protected long? _UserNumber;
        protected string _msg;
        protected string _sessionid;
        protected string _username;
        
        protected string _transid;
        protected string _pageurl;
        protected SecurityCapsule _sec;

      

        [DataMember]
        public string pageurl
        {
            get { return _pageurl; }
            set { _pageurl = value; }
        }
        [DataMember]
        public string msg
        {
            get { return _msg; }
            set { _msg = value; }
        }

        [DataMember]
        public string sessionid
        {
            get { return _sessionid; }
            set { _sessionid = value; }
        }
        [DataMember]
        public string transid
        {
            get { return _transid; }
            set { _transid = value; }
        }

        [DataMember]
        public SecurityCapsule securitycapule
        {
            get { return _sec; }
            set { _sec = value; }
        }

        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }




    }
    #endregion
}
