using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "stp_organizationEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _organizationkey;
        protected string _organizationnamear;
        protected string _addresslineonear;
        protected string _addresslinetwoar;
        protected string _phonear;
        protected string _emailar;
        protected string _websitear;
        protected string _domainar;
        protected string _faxar;
        protected string _organizationname;
        protected string _addresslineone;
        protected string _addresslinetwo;
        protected string _phone;
        protected string _email;
        protected string _website;
        protected string _domain;
        protected string _fax;
        protected bool ? _ismailenable;
        protected string _smtphost;
        protected long ? _mailport;
        protected string _smtpusername;
        protected string _smtppassword;
        protected bool ? _mailssl;
        protected string _fromemailaddress;
        protected string _maildisplayname;
        protected bool ? _isftpenable;
        protected string _ftpaddress;
        protected string _ftpport;
        protected string _ftpusername;
        protected string _ftppassword;
        protected bool ? _isssl;
        protected string _logoimg;
        protected string _webheader;
        protected string _folderpath;
                
        
        [DataMember]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "organizationnamear", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string organizationnamear
        {
            get { return _organizationnamear; }
            set { _organizationnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslineonear", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string addresslineonear
        {
            get { return _addresslineonear; }
            set { _addresslineonear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslinetwoar", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string addresslinetwoar
        {
            get { return _addresslinetwoar; }
            set { _addresslinetwoar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "phonear", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string phonear
        {
            get { return _phonear; }
            set { _phonear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "emailar", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string emailar
        {
            get { return _emailar; }
            set { _emailar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "websitear", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string websitear
        {
            get { return _websitear; }
            set { _websitear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "domainar", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string domainar
        {
            get { return _domainar; }
            set { _domainar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "faxar", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string faxar
        {
            get { return _faxar; }
            set { _faxar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "organizationname", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_organization), ErrorMessageResourceName = "organizationnameRequired")]
        public string organizationname
        {
            get { return _organizationname; }
            set { _organizationname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslineone", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string addresslineone
        {
            get { return _addresslineone; }
            set { _addresslineone = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "addresslinetwo", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string addresslinetwo
        {
            get { return _addresslinetwo; }
            set { _addresslinetwo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "phone", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string phone
        {
            get { return _phone; }
            set { _phone = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "email", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string email
        {
            get { return _email; }
            set { _email = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "website", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string website
        {
            get { return _website; }
            set { _website = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "domain", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string domain
        {
            get { return _domain; }
            set { _domain = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fax", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string fax
        {
            get { return _fax; }
            set { _fax = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ismailenable", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public bool ? ismailenable
        {
            get { return _ismailenable; }
            set { _ismailenable = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtphost", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string smtphost
        {
            get { return _smtphost; }
            set { _smtphost = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "mailport", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public long ? mailport
        {
            get { return _mailport; }
            set { _mailport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtpusername", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string smtpusername
        {
            get { return _smtpusername; }
            set { _smtpusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "smtppassword", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string smtppassword
        {
            get { return _smtppassword; }
            set { _smtppassword = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "mailssl", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public bool ? mailssl
        {
            get { return _mailssl; }
            set { _mailssl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "fromemailaddress", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string fromemailaddress
        {
            get { return _fromemailaddress; }
            set { _fromemailaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "maildisplayname", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string maildisplayname
        {
            get { return _maildisplayname; }
            set { _maildisplayname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isftpenable", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public bool ? isftpenable
        {
            get { return _isftpenable; }
            set { _isftpenable = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftpaddress", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string ftpaddress
        {
            get { return _ftpaddress; }
            set { _ftpaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "ftpport", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string ftpport
        {
            get { return _ftpport; }
            set { _ftpport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftpusername", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string ftpusername
        {
            get { return _ftpusername; }
            set { _ftpusername = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ftppassword", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string ftppassword
        {
            get { return _ftppassword; }
            set { _ftppassword = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isssl", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public bool ? isssl
        {
            get { return _isssl; }
            set { _isssl = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "logoimg", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string logoimg
        {
            get { return _logoimg; }
            set { _logoimg = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "webheader", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string webheader
        {
            get { return _webheader; }
            set { _webheader = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "folderpath", ResourceType = typeof(KAF.MsgContainer._stp_organization))]
        public string folderpath
        {
            get { return _folderpath; }
            set { _folderpath = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_organizationEntity():base()
        {
        }
        
        public stp_organizationEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_organizationEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("OrganizationNameAr"))) _organizationnamear = reader.GetString(reader.GetOrdinal("OrganizationNameAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOneAr"))) _addresslineonear = reader.GetString(reader.GetOrdinal("AddressLineOneAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwoAr"))) _addresslinetwoar = reader.GetString(reader.GetOrdinal("AddressLineTwoAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("PhoneAr"))) _phonear = reader.GetString(reader.GetOrdinal("PhoneAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EmailAr"))) _emailar = reader.GetString(reader.GetOrdinal("EmailAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("WebsiteAr"))) _websitear = reader.GetString(reader.GetOrdinal("WebsiteAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("DomainAr"))) _domainar = reader.GetString(reader.GetOrdinal("DomainAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FaxAr"))) _faxar = reader.GetString(reader.GetOrdinal("FaxAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _organizationname = reader.GetString(reader.GetOrdinal("OrganizationName"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOne"))) _addresslineone = reader.GetString(reader.GetOrdinal("AddressLineOne"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwo"))) _addresslinetwo = reader.GetString(reader.GetOrdinal("AddressLineTwo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Phone"))) _phone = reader.GetString(reader.GetOrdinal("Phone"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("Website"))) _website = reader.GetString(reader.GetOrdinal("Website"));
                if (!reader.IsDBNull(reader.GetOrdinal("Domain"))) _domain = reader.GetString(reader.GetOrdinal("Domain"));
                if (!reader.IsDBNull(reader.GetOrdinal("Fax"))) _fax = reader.GetString(reader.GetOrdinal("Fax"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMailEnable"))) _ismailenable = reader.GetBoolean(reader.GetOrdinal("IsMailEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpHost"))) _smtphost = reader.GetString(reader.GetOrdinal("smtpHost"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailPort"))) _mailport = reader.GetInt64(reader.GetOrdinal("mailPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpUserName"))) _smtpusername = reader.GetString(reader.GetOrdinal("smtpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpPassword"))) _smtppassword = reader.GetString(reader.GetOrdinal("smtpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailSSL"))) _mailssl = reader.GetBoolean(reader.GetOrdinal("mailSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("fromemailaddress"))) _fromemailaddress = reader.GetString(reader.GetOrdinal("fromemailaddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("maildisplayName"))) _maildisplayname = reader.GetString(reader.GetOrdinal("maildisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("isFtpEnable"))) _isftpenable = reader.GetBoolean(reader.GetOrdinal("isFtpEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpAddress"))) _ftpaddress = reader.GetString(reader.GetOrdinal("ftpAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPort"))) _ftpport = reader.GetString(reader.GetOrdinal("ftpPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpUserName"))) _ftpusername = reader.GetString(reader.GetOrdinal("ftpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPassword"))) _ftppassword = reader.GetString(reader.GetOrdinal("ftpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSSL"))) _isssl = reader.GetBoolean(reader.GetOrdinal("IsSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoImg"))) _logoimg = reader.GetString(reader.GetOrdinal("LogoImg"));
                if (!reader.IsDBNull(reader.GetOrdinal("WebHeader"))) _webheader = reader.GetString(reader.GetOrdinal("WebHeader"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderPath"))) _folderpath = reader.GetString(reader.GetOrdinal("FolderPath"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("OrganizationNameAr"))) _organizationnamear = reader.GetString(reader.GetOrdinal("OrganizationNameAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOneAr"))) _addresslineonear = reader.GetString(reader.GetOrdinal("AddressLineOneAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwoAr"))) _addresslinetwoar = reader.GetString(reader.GetOrdinal("AddressLineTwoAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("PhoneAr"))) _phonear = reader.GetString(reader.GetOrdinal("PhoneAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EmailAr"))) _emailar = reader.GetString(reader.GetOrdinal("EmailAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("WebsiteAr"))) _websitear = reader.GetString(reader.GetOrdinal("WebsiteAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("DomainAr"))) _domainar = reader.GetString(reader.GetOrdinal("DomainAr"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FaxAr"))) _faxar = reader.GetString(reader.GetOrdinal("FaxAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _organizationname = reader.GetString(reader.GetOrdinal("OrganizationName"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineOne"))) _addresslineone = reader.GetString(reader.GetOrdinal("AddressLineOne"));
                if (!reader.IsDBNull(reader.GetOrdinal("AddressLineTwo"))) _addresslinetwo = reader.GetString(reader.GetOrdinal("AddressLineTwo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Phone"))) _phone = reader.GetString(reader.GetOrdinal("Phone"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) _email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("Website"))) _website = reader.GetString(reader.GetOrdinal("Website"));
                if (!reader.IsDBNull(reader.GetOrdinal("Domain"))) _domain = reader.GetString(reader.GetOrdinal("Domain"));
                if (!reader.IsDBNull(reader.GetOrdinal("Fax"))) _fax = reader.GetString(reader.GetOrdinal("Fax"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsMailEnable"))) _ismailenable = reader.GetBoolean(reader.GetOrdinal("IsMailEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpHost"))) _smtphost = reader.GetString(reader.GetOrdinal("smtpHost"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailPort"))) _mailport = reader.GetInt64(reader.GetOrdinal("mailPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpUserName"))) _smtpusername = reader.GetString(reader.GetOrdinal("smtpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("smtpPassword"))) _smtppassword = reader.GetString(reader.GetOrdinal("smtpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("mailSSL"))) _mailssl = reader.GetBoolean(reader.GetOrdinal("mailSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("fromemailaddress"))) _fromemailaddress = reader.GetString(reader.GetOrdinal("fromemailaddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("maildisplayName"))) _maildisplayname = reader.GetString(reader.GetOrdinal("maildisplayName"));
                if (!reader.IsDBNull(reader.GetOrdinal("isFtpEnable"))) _isftpenable = reader.GetBoolean(reader.GetOrdinal("isFtpEnable"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpAddress"))) _ftpaddress = reader.GetString(reader.GetOrdinal("ftpAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPort"))) _ftpport = reader.GetString(reader.GetOrdinal("ftpPort"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpUserName"))) _ftpusername = reader.GetString(reader.GetOrdinal("ftpUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ftpPassword"))) _ftppassword = reader.GetString(reader.GetOrdinal("ftpPassword"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSSL"))) _isssl = reader.GetBoolean(reader.GetOrdinal("IsSSL"));
                if (!reader.IsDBNull(reader.GetOrdinal("LogoImg"))) _logoimg = reader.GetString(reader.GetOrdinal("LogoImg"));
                if (!reader.IsDBNull(reader.GetOrdinal("WebHeader"))) _webheader = reader.GetString(reader.GetOrdinal("WebHeader"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderPath"))) _folderpath = reader.GetString(reader.GetOrdinal("FolderPath"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
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
