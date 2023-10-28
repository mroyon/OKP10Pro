

using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    #region KAF_GetUserInfoByCredentialEntity
    /// <summary>
    /// This object represents the properties and methods of a KAF_GetUserInfoByCredentialEntity.
    /// </summary>
    [Serializable]
    [DataContract(Name = "KAF_GetUserInfoByCredentialEntity", Namespace = "http://www.KAF.com/types")]
    public class KAF_GetUserInfoByCredentialEntity : BaseEntity
    {

      
        protected long? _masteruserid;
        [DataMember]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; }
        }
        protected bool? _ischildenable;
        [DataMember]
        public bool? ischildenable
        {
            get { return _ischildenable; }
            set { _ischildenable = value; }
        }


        protected string _userprofilephoto = String.Empty;
        [DataMember]
        public string userprofilephoto
        {
            get { return _userprofilephoto; }
            set { _userprofilephoto = value; }
        }

        protected string _loweredusername = String.Empty;
        [DataMember]
        public string loweredusername
        {
            get { return _loweredusername; }
            set { _loweredusername = value; }
        }
        protected string _username = String.Empty;
        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        protected Guid? _userid = Guid.Empty;
        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        protected string _emailaddress = String.Empty;
        [DataMember]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; }
        }
        protected string _masprivatekey = String.Empty;
        public string masprivatekey
        {
            get { return _masprivatekey; }
            set { _masprivatekey = value; }
        }
        protected string _maspublickey = String.Empty;
        public string maspublickey
        {
            get { return _maspublickey; }
            set { _maspublickey = value; }
        }
        protected DateTime? _lastlogindate;
        [DataMember]
        public DateTime? lastlogindate
        {
            get { return _lastlogindate; }
            set { _lastlogindate = value; }
        }
        protected string _passwordquestion = String.Empty;
        [DataMember]
        public string passwordquestion
        {
            get { return _passwordquestion; }
            set { _passwordquestion = value; }
        }
        protected string _passwordanswer = String.Empty;
        [DataMember]
        public string passwordanswer
        {
            get { return _passwordanswer; }
            set { _passwordanswer = value; }
        }
        protected string _password = String.Empty;
        [DataMember]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        protected int? _passwordformat;
        [DataMember]
        public int? passwordformat
        {
            get { return _passwordformat; }
            set { _passwordformat = value; }
        }
        protected string _passwordsalt = String.Empty;
        [DataMember]
        public string passwordsalt
        {
            get { return _passwordsalt; }
            set { _passwordsalt = value; }
        }
        protected string _passwordkey = String.Empty;
        [DataMember]
        public string passwordkey
        {
            get { return _passwordkey; }
            set { _passwordkey = value; }
        }
        protected string _passwordvector = String.Empty;
        [DataMember]
        public string passwordvector
        {
            get { return _passwordvector; }
            set { _passwordvector = value; }
        }
        protected long? _userorganizationkey;
        [DataMember]
        public long? userorganizationkey
        {
            get { return _userorganizationkey; }
            set { _userorganizationkey = value; }
        }
        protected DateTime? _lastpasschangeddate;
        [DataMember]
        public DateTime? lastpasschangeddate
        {
            get { return _lastpasschangeddate; }
            set { _lastpasschangeddate = value; }
        }
        protected bool? _approved;
        [DataMember]
        public bool? approved
        {
            get { return _approved; }
            set { _approved = value; }
        }
        protected bool? _locked;
        [DataMember]
        public bool? locked
        {
            get { return _locked; }
            set { _locked = value; }
        }
        protected long? _userentitykey;
        [DataMember]
        public long? userentitykey
        {
            get { return _userentitykey; }
            set { _userentitykey = value; }
        }
        protected string _EntityName;
        [DataMember]
        public string EntityName
        {
            get { return _EntityName; }
            set { _EntityName = value; }
        }
        protected DateTime? _laslogoutdate;
        public DateTime? laslogoutdate
        {
            get { return _laslogoutdate; }
            set { _laslogoutdate = value; }
        }
        protected string _mobilenumber;
        [DataMember]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; }
        }


        protected string _stkn;
        [DataMember]
        public string stkn
        {
            get { return _stkn; }
            set { _stkn = value; }
        }


        protected string _uploadFolder;
        [DataMember]
        public string uploadFolder
        {
            get { return _uploadFolder; }
            set { _uploadFolder = value; }
        }

        protected long? _loginserial;
        [DataMember]
        public long? loginserial
        {
            get { return _loginserial; }
            set { _loginserial = value; }
        }

        protected stp_organizationEntity _organizationinfo;
        [DataMember]
        public stp_organizationEntity organizationinfo
        {
            get { return _organizationinfo; }
            set { _organizationinfo = value; }
        }
        protected bool? _istwosetepauthenable;
        [DataMember]
        public bool? istwosetepauthenable
        {
            get { return _istwosetepauthenable; }
            set { _istwosetepauthenable = value; }
        }

        protected long? _okpid;
        [DataMember]
        public long? okpid
        {
            get { return _okpid; }
            set { _okpid = value; }
        }

        public KAF_GetUserInfoByCredentialEntity()
        {
        }

        public KAF_GetUserInfoByCredentialEntity(IDataReader ireader)
        {
            this.LoadFromReader(ireader);
        }

        public void LoadFromReader(IDataReader reader)
        {
            //SqlDataReader reader = (SqlDataReader)ireader;
            if (reader != null && !reader.IsClosed)
            {

                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) _userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) _userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _EntityName = reader.GetString(reader.GetOrdinal("EntityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LasLogOutDate"))) _laslogoutdate = reader.GetDateTime(reader.GetOrdinal("LasLogOutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _userprofilephoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _istwosetepauthenable = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));

            }
        }




    }
    #endregion
}
