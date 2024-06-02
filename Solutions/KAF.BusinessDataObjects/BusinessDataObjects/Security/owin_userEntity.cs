﻿using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "owin_userEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userEntity : BaseEntity
    {
        #region Properties

        protected Guid? _userid;
        protected Guid? _applicationid;
        protected long? _masteruserid;
        protected long? _userroleid;
        protected string _UserProfilePhoto;
        protected string _roleid;
        protected string _username;
        protected string _emailaddress;
        protected string _loweredusername;
        protected string _mobilenumber;
        protected bool? _isanonymous;
        protected bool? _ischildenable;
        protected string _masprivatekey;
        protected string _maspublickey;
        protected string _password;
        protected string _passwordsalt;
        protected string _passwordkey;
        protected string _passwordvector;
        protected string _mobilepin;
        protected string _passwordquestion;
        protected string _passwordanswer;
        protected bool? _approved;
        protected bool? _locked;
        protected DateTime? _lastlogindate;
        protected DateTime? _lastpasschangeddate;
        protected DateTime? _lastlockoutdate;
        protected int? _failedpasswordattemptcount;
        protected string _comment;
        protected DateTime? _lastactivitydate;
        protected bool? _isreviewed;
        protected long? _reviewedby;
        protected string _reviewedbyusername;
        protected DateTime? _revieweddate;
        protected bool? _isapproved;
        protected long? _approvedby;
        protected string _approvedbyusername;
        protected DateTime? _approveddate;

        protected string _actionview;
        protected string _actionedit;
        protected string _actiondelete;
        protected bool? _isAdUser;


        [DataMember]
        [Display(Name = "UserProfilePhoto", ResourceType = typeof(KAF.MsgContainer._Login))]
        public string UserProfilePhoto
        {
            get { return _UserProfilePhoto; }
            set { _UserProfilePhoto = value; this.OnChnaged(); }
        }
        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }

        public bool? isAdUser
        {
            get { return _isAdUser; }
            set { _isAdUser = value; this.OnChnaged(); }
        }

        [DataMember]
        public Guid? applicationid
        {
            get { return _applicationid; }
            set { _applicationid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? userroleid
        {
            get { return _userroleid; }
            set { _userroleid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "username", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "usernameRequired")]
        public string username
        {
            get { return _username; }
            set { _username = value; this.OnChnaged(); }
        }


        [DataMember]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "emailaddressRequired")]
        //[RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "invalidemailRequired")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "invalidemailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "invalidemailRequired")]
        [Display(Name = "emailaddress", ResourceType = typeof(KAF.MsgContainer._Login))]
        public string emailaddress
        {
            get { return _emailaddress; }
            set { _emailaddress = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "fullname", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "fullnameRequired")]
        public string loweredusername
        {
            get { return _loweredusername; }
            set { _loweredusername = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(15)]
        [Display(Name = "mobilenumber", ResourceType = typeof(KAF.MsgContainer._Login))]
        [RegularExpression(@"^\d+$", ErrorMessageResourceType = typeof(KAF.MsgContainer._Common), ErrorMessageResourceName = "_onlyinteger")]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "mobilenumberRequired")]
        public string mobilenumber
        {
            get { return _mobilenumber; }
            set { _mobilenumber = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isanonymous
        {
            get { return _isanonymous; }
            set { _isanonymous = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? ischildenable
        {
            get { return _ischildenable; }
            set { _ischildenable = value; this.OnChnaged(); }
        }

        [DataMember]
        public string masprivatekey
        {
            get { return _masprivatekey; }
            set { _masprivatekey = value; this.OnChnaged(); }
        }

        [DataMember]
        public string maspublickey
        {
            get { return _maspublickey; }
            set { _maspublickey = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "password", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordRequired")]
        [MinLength(4, ErrorMessage = "في عقد الإيجار 4 أرقام")]
        public string password
        {
            get { return _password; }
            set { _password = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passwordsalt", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordsaltRequired")]
        public string passwordsalt
        {
            get { return _passwordsalt; }
            set { _passwordsalt = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passwordkey", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordkeyRequired")]
        [MinLength(4, ErrorMessage = "في عقد الإيجار 4 أرقام")]
        public string passwordkey
        {
            get { return _passwordkey; }
            set { _passwordkey = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passwordvector", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordvectorRequired")]
        public string passwordvector
        {
            get { return _passwordvector; }
            set { _passwordvector = value; this.OnChnaged(); }
        }

        [DataMember]
        [Required(ErrorMessage = "Military ID is rquired.")]
        public string mobilepin
        {
            get { return _mobilepin; }
            set { _mobilepin = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passwordquestion", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordquestionRequired")]
        public string passwordquestion
        {
            get { return _passwordquestion; }
            set { _passwordquestion = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "passwordanswer", ResourceType = typeof(KAF.MsgContainer._Login))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._Login), ErrorMessageResourceName = "passwordanswerRequired")]
        public string passwordanswer
        {
            get { return _passwordanswer; }
            set { _passwordanswer = value; this.OnChnaged(); }
        }

        [DataMember]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._CommonHtml), ErrorMessageResourceName = "pleaseselect")]
        public bool? approved
        {
            get { return _approved; }
            set { _approved = value; this.OnChnaged(); }
        }

        [DataMember]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._CommonHtml), ErrorMessageResourceName = "pleaseselect")]
        public bool? locked
        {
            get { return _locked; }
            set { _locked = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? lastlogindate
        {
            get { return _lastlogindate; }
            set { _lastlogindate = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? lastpasschangeddate
        {
            get { return _lastpasschangeddate; }
            set { _lastpasschangeddate = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? lastlockoutdate
        {
            get { return _lastlockoutdate; }
            set { _lastlockoutdate = value; this.OnChnaged(); }
        }

        [DataMember]
        public int? failedpasswordattemptcount
        {
            get { return _failedpasswordattemptcount; }
            set { _failedpasswordattemptcount = value; this.OnChnaged(); }
        }

        [DataMember]
        public string comment
        {
            get { return _comment; }
            set { _comment = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? lastactivitydate
        {
            get { return _lastactivitydate; }
            set { _lastactivitydate = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }

        [DataMember]
        public string reviewedbyusername
        {
            get { return _reviewedbyusername; }
            set { _reviewedbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? revieweddate
        {
            get { return _revieweddate; }
            set { _revieweddate = value; this.OnChnaged(); }
        }

        [DataMember]
        public bool? isapproved
        {
            get { return _isapproved; }
            set { _isapproved = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? approvedby
        {
            get { return _approvedby; }
            set { _approvedby = value; this.OnChnaged(); }
        }

        [DataMember]
        public string approvedbyusername
        {
            get { return _approvedbyusername; }
            set { _approvedbyusername = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? approveddate
        {
            get { return _approveddate; }
            set { _approveddate = value; this.OnChnaged(); }
        }


        [DataMember]
        public string actionview
        {
            get { return _actionview; }
            set { _actionview = value; this.OnChnaged(); }
        }

        [DataMember]
        public string actionedit
        {
            get { return _actionedit; }
            set { _actionedit = value; this.OnChnaged(); }
        }

        [DataMember]
        public string actiondelete
        {
            get { return _actiondelete; }
            set { _actiondelete = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public owin_userEntity() : base()
        {
        }

        public owin_userEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public owin_userEntity(IDataReader reader, bool IsListView)
        {
            this.LoadFromReader(reader, IsListView);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) _createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _UserProfilePhoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));

                CurrentState = EntityState.Unchanged;
            }
        }
        protected void LoadFromReader(IDataReader reader, bool IsListView)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ApplicationId"))) _applicationid = reader.GetGuid(reader.GetOrdinal("ApplicationId"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _userroleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) _username = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmailAddress"))) _emailaddress = reader.GetString(reader.GetOrdinal("EmailAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoweredUserName"))) _loweredusername = reader.GetString(reader.GetOrdinal("LoweredUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileNumber"))) _mobilenumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAnonymous"))) _isanonymous = reader.GetBoolean(reader.GetOrdinal("IsAnonymous"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsChildEnable"))) _ischildenable = reader.GetBoolean(reader.GetOrdinal("IsChildEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPrivateKey"))) _masprivatekey = reader.GetString(reader.GetOrdinal("MasPrivateKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasPublicKey"))) _maspublickey = reader.GetString(reader.GetOrdinal("MasPublicKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) _password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordSalt"))) _passwordsalt = reader.GetString(reader.GetOrdinal("PasswordSalt"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordKey"))) _passwordkey = reader.GetString(reader.GetOrdinal("PasswordKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordVector"))) _passwordvector = reader.GetString(reader.GetOrdinal("PasswordVector"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobilePIN"))) _mobilepin = reader.GetString(reader.GetOrdinal("MobilePIN"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordQuestion"))) _passwordquestion = reader.GetString(reader.GetOrdinal("PasswordQuestion"));
                if (!reader.IsDBNull(reader.GetOrdinal("PasswordAnswer"))) _passwordanswer = reader.GetString(reader.GetOrdinal("PasswordAnswer"));
                if (!reader.IsDBNull(reader.GetOrdinal("Approved"))) _approved = reader.GetBoolean(reader.GetOrdinal("Approved"));
                if (!reader.IsDBNull(reader.GetOrdinal("Locked"))) _locked = reader.GetBoolean(reader.GetOrdinal("Locked"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLoginDate"))) _lastlogindate = reader.GetDateTime(reader.GetOrdinal("LastLoginDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPassChangedDate"))) _lastpasschangeddate = reader.GetDateTime(reader.GetOrdinal("LastPassChangedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastLockoutDate"))) _lastlockoutdate = reader.GetDateTime(reader.GetOrdinal("LastLockoutDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FailedPasswordAttemptCount"))) _failedpasswordattemptcount = reader.GetInt32(reader.GetOrdinal("FailedPasswordAttemptCount"));
                if (!reader.IsDBNull(reader.GetOrdinal("Comment"))) _comment = reader.GetString(reader.GetOrdinal("Comment"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastActivityDate"))) _lastactivitydate = reader.GetDateTime(reader.GetOrdinal("LastActivityDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedByUserName"))) _reviewedbyusername = reader.GetString(reader.GetOrdinal("ReviewedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedDate"))) _revieweddate = reader.GetDateTime(reader.GetOrdinal("ReviewedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedBy"))) _approvedby = reader.GetInt64(reader.GetOrdinal("ApprovedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedByUserName"))) _approvedbyusername = reader.GetString(reader.GetOrdinal("ApprovedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApprovedDate"))) _approveddate = reader.GetDateTime(reader.GetOrdinal("ApprovedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) _createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserProfilePhoto"))) _UserProfilePhoto = reader.GetString(reader.GetOrdinal("UserProfilePhoto"));

                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
