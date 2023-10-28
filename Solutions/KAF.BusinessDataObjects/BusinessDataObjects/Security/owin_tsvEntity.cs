using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "owin_tsvEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_tsvEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serail;
        protected Guid ? _userid;
        protected DateTime ? _tsvtokenrequestdate;
        protected string _tsvtoken;
        protected bool ? _isvalid;
        protected int ? _varificationtried;
        protected DateTime ? _validdate;
        protected string _usersessionid;
        protected string __requestaft;
                
        
        [DataMember]
        public long ? serail
        {
            get { return _serail; }
            set { _serail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "tsvtokenrequestdate", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "tsvtokenrequestdateRequired")]
        public DateTime ? tsvtokenrequestdate
        {
            get { return _tsvtokenrequestdate; }
            set { _tsvtokenrequestdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "tsvtoken", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "tsvtokenRequired")]
        public string tsvtoken
        {
            get { return _tsvtoken; }
            set { _tsvtoken = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isvalid", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "isvalidRequired")]
        public bool ? isvalid
        {
            get { return _isvalid; }
            set { _isvalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "varificationtried", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "varificationtriedRequired")]
        public int ? varificationtried
        {
            get { return _varificationtried; }
            set { _varificationtried = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "validdate", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        public DateTime ? validdate
        {
            get { return _validdate; }
            set { _validdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "usersessionid", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_tsv), ErrorMessageResourceName = "usersessionidRequired")]
        public string usersessionid
        {
            get { return _usersessionid; }
            set { _usersessionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "_requestaft", ResourceType = typeof(KAF.MsgContainer._owin_tsv))]
        public string _requestaft
        {
            get { return __requestaft; }
            set { __requestaft = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_tsvEntity():base()
        {
        }
        
        public owin_tsvEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_tsvEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Serail"))) _serail = reader.GetInt64(reader.GetOrdinal("Serail"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("TSVTokenRequestDate"))) _tsvtokenrequestdate = reader.GetDateTime(reader.GetOrdinal("TSVTokenRequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TSVToken"))) _tsvtoken = reader.GetString(reader.GetOrdinal("TSVToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsValid"))) _isvalid = reader.GetBoolean(reader.GetOrdinal("IsValid"));
                if (!reader.IsDBNull(reader.GetOrdinal("VarificationTried"))) _varificationtried = reader.GetInt32(reader.GetOrdinal("VarificationTried"));
                if (!reader.IsDBNull(reader.GetOrdinal("ValidDate"))) _validdate = reader.GetDateTime(reader.GetOrdinal("ValidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserSessionID"))) _usersessionid = reader.GetString(reader.GetOrdinal("UserSessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("_RequestAFT"))) __requestaft = reader.GetString(reader.GetOrdinal("_RequestAFT"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("Serail"))) _serail = reader.GetInt64(reader.GetOrdinal("Serail"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserId"))) _userid = reader.GetGuid(reader.GetOrdinal("UserId"));
                if (!reader.IsDBNull(reader.GetOrdinal("TSVTokenRequestDate"))) _tsvtokenrequestdate = reader.GetDateTime(reader.GetOrdinal("TSVTokenRequestDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TSVToken"))) _tsvtoken = reader.GetString(reader.GetOrdinal("TSVToken"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsValid"))) _isvalid = reader.GetBoolean(reader.GetOrdinal("IsValid"));
                if (!reader.IsDBNull(reader.GetOrdinal("VarificationTried"))) _varificationtried = reader.GetInt32(reader.GetOrdinal("VarificationTried"));
                if (!reader.IsDBNull(reader.GetOrdinal("ValidDate"))) _validdate = reader.GetDateTime(reader.GetOrdinal("ValidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserSessionID"))) _usersessionid = reader.GetString(reader.GetOrdinal("UserSessionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("_RequestAFT"))) __requestaft = reader.GetString(reader.GetOrdinal("_RequestAFT"));
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
