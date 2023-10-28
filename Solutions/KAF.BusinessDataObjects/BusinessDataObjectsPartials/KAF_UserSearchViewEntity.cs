    

using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    #region KAF_UserSearchViewEntity
    /// <summary>
    /// This object represents the properties and methods of a dddd.
    /// </summary>
    [Serializable]
    [DataContract(Name = "KAF_UserSearchViewEntity", Namespace = "http://www.MOI.com/types")]
    public class KAF_UserSearchViewEntity : BaseEntity
    {

        #region Properties

        protected Guid _userid;
        protected long? _userkey;
        protected long? _entitykey;
        protected long? _organizationkey;
        protected string _entityname;
        protected string _firstname;
        protected string _middlename;
        protected string _lastname;
        protected string _username;
        protected string _password;
        protected int? _passwordformat;
        protected string _passwordsalt;
        protected string _passwordkey;
        protected string _passwordvector;
        protected string _email;
        protected string _passwordquestion;
        protected string _passwordanswer;
        protected bool? _isapproved;
        protected bool? _islockedout;
        protected bool? _ischildenable;
        protected long? _masteruserid;
        protected long? _usercategoryid;
        protected string _userfullname;
        protected string _usercategory;
        protected DateTime? _lastlogindate;
        protected string _mobilenumber;


        [DataMember]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }
        [DataMember]
        public DateTime? lastlogindate
        {
            get { return _lastlogindate; }
            set { _lastlogindate = value; this.OnChnaged(); }
        }
        [DataMember]
        public Guid userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? userkey
        {
            get { return _userkey; }
            set { _userkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public string entityname
        {
            get { return _entityname; }
            set { _entityname = value; this.OnChnaged(); }
        }
        [DataMember]
        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string middlename
        {
            get { return _middlename; }
            set { _middlename = value; this.OnChnaged(); }
        }

        [DataMember]
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }

        [DataMember]
        public string password
        {
            get { return _password; }
            set { _password = value; this.OnChnaged(); }
        }

        [DataMember]
        public int? passwordformat
        {
            get { return _passwordformat; }
            set { _passwordformat = value; this.OnChnaged(); }
        }

        [DataMember]
        public string passwordsalt
        {
            get { return _passwordsalt; }
            set { _passwordsalt = value; this.OnChnaged(); }
        }

        [DataMember]
        public string passwordkey
        {
            get { return _passwordkey; }
            set { _passwordkey = value; this.OnChnaged(); }
        }

        [DataMember]
        public string passwordvector
        {
            get { return _passwordvector; }
            set { _passwordvector = value; this.OnChnaged(); }
        }

        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }

        [DataMember]
        public string passwordquestion
        {
            get { return _passwordquestion; }
            set { _passwordquestion = value; this.OnChnaged(); }
        }

        [DataMember]
        public string passwordanswer
        {
            get { return _passwordanswer; }
            set { _passwordanswer = value; this.OnChnaged(); }
        }


        [DataMember]
        public string usercategory
        {
            get { return _usercategory; }
            set { _usercategory = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isapproved
        {
            get { return _isapproved; }
            set { _isapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? islockedout
        {
            get { return _islockedout; }
            set { _islockedout = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? ischildenable
        {
            get { return _ischildenable; }
            set { _ischildenable = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? usercategoryid
        {
            get { return _usercategoryid; }
            set { _usercategoryid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string userfullname
        {
            get { return _userfullname; }
            set { _userfullname = value; this.OnChnaged(); }
        }

        protected string _masprivatekey = String.Empty;
        protected string _maspublickey = String.Empty;

        [DataMember]
        public string masprivatekey
        {
            get { return _masprivatekey; }
            set { _masprivatekey = value; }
        }
        [DataMember]
        public string maspublickey
        {
            get { return _maspublickey; }
            set { _maspublickey = value; }
        }
        #endregion

        public KAF_UserSearchViewEntity()
        {
        }

        public KAF_UserSearchViewEntity(IDataReader ireader)
        {
            this.LoadFromReader(ireader);
        }


        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UserKey"))) _userkey = reader.GetInt64(reader.GetOrdinal("UserKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("FirstName"))) _firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MiddleName"))) _middlename = reader.GetString(reader.GetOrdinal("MiddleName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastName"))) _lastname = reader.GetString(reader.GetOrdinal("LastName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                //if (!reader.IsDBNull(reader.GetOrdinal("PasswordFormat"))) _passwordformat = reader.GetInt32(reader.GetOrdinal("PasswordFormat"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsLockedOut"))) _islockedout = reader.GetBoolean(reader.GetOrdinal("IsLockedOut"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserCategoryID"))) _usercategoryid = reader.GetInt64(reader.GetOrdinal("UserCategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserFullName"))) _userfullname = reader.GetString(reader.GetOrdinal("UserFullName"));

                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _entityname = reader.GetString(reader.GetOrdinal("EntityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));

                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));

                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));


                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) this.BaseSecurityParam.createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) this.BaseSecurityParam.updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserCategory"))) _usercategory = reader.GetString(reader.GetOrdinal("UserCategory"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));


                CurrentState = EntityState.Unchanged;

            }
        }

    }
    #endregion

}
