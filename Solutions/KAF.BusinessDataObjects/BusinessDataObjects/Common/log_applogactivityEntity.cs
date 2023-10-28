
using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "log_applogactivityEntity", Namespace = "http://www.KAF.com/types")]
    public class log_applogactivityEntity : BaseEntity
    {
        #region Properties

      
        protected string _logger;
        protected string _message;
        protected string _useridentity;
        protected string _level;
        protected long? _organizationkey;
        protected string _pageurl;
        protected string _username;
        protected string _hitfrom;
        protected string _machinename;
        protected string _tranid;
        protected string _sessionid;
        protected string _raisingevent;
       
        [DataMember]
        public string logger
        {
            get { return _logger; }
            set { _logger = value; this.OnChnaged(); }
        }

        [DataMember]
        public string message
        {
            get { return _message; }
            set { _message = value; this.OnChnaged(); }
        }

        [DataMember]
        public string useridentity
        {
            get { return _useridentity; }
            set { _useridentity = value; this.OnChnaged(); }
        }

        [DataMember]
        public string level
        {
            get { return _level; }
            set { _level = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public string pageurl
        {
            get { return _pageurl; }
            set { _pageurl = value; this.OnChnaged(); }
        }

        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }

        [DataMember]
        public string hitfrom
        {
            get { return _hitfrom; }
            set { _hitfrom = value; this.OnChnaged(); }
        }

        [DataMember]
        public string machinename
        {
            get { return _machinename; }
            set { _machinename = value; this.OnChnaged(); }
        }

        [DataMember]
        public string tranid
        {
            get { return _tranid; }
            set { _tranid = value; this.OnChnaged(); }
        }
        [DataMember]
        public string sessionid
        {
            get { return _sessionid; }
            set { _sessionid = value; this.OnChnaged(); }
        }
        [DataMember]
        public string raisingevent
        {
            get { return _raisingevent; }
            set { _raisingevent = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public log_applogactivityEntity()
            : base()
        {
        }

        public log_applogactivityEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                //if (!reader.IsDBNull(reader.GetOrdinal("LogId"))) _logid = reader.GetInt64(reader.GetOrdinal("LogId"));
                //if (!reader.IsDBNull(reader.GetOrdinal("LogDate"))) _logdate = reader.GetDateTime(reader.GetOrdinal("LogDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Logger"))) _logger = reader.GetString(reader.GetOrdinal("Logger"));
                if (!reader.IsDBNull(reader.GetOrdinal("Message"))) _message = reader.GetString(reader.GetOrdinal("Message"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserIdentity"))) _useridentity = reader.GetString(reader.GetOrdinal("UserIdentity"));
                if (!reader.IsDBNull(reader.GetOrdinal("Level"))) _level = reader.GetString(reader.GetOrdinal("Level"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PageURL"))) _pageurl = reader.GetString(reader.GetOrdinal("PageURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("username"))) _username = reader.GetString(reader.GetOrdinal("username"));
                if (!reader.IsDBNull(reader.GetOrdinal("hitFrom"))) _hitfrom = reader.GetString(reader.GetOrdinal("hitFrom"));
                if (!reader.IsDBNull(reader.GetOrdinal("MachineName"))) _machinename = reader.GetString(reader.GetOrdinal("MachineName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TranID"))) _tranid = reader.GetString(reader.GetOrdinal("TranID"));

                if (!reader.IsDBNull(reader.GetOrdinal("RaisingEvent"))) _raisingevent = reader.GetString(reader.GetOrdinal("RaisingEvent"));
                if (!reader.IsDBNull(reader.GetOrdinal("SessionID"))) _sessionid = reader.GetString(reader.GetOrdinal("SessionID"));

                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));


                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
    }
}

