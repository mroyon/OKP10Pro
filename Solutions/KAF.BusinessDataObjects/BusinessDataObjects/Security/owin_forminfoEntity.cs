using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "owin_forminfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_forminfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _appformid;
        protected string _formname;
        protected long ? _parentid;
        protected int ? _levelid;
        protected string _menulevel;
        protected string _formnamear;
        protected bool ? _hasdirectchild;
        protected byte[] _icon;
        protected string _classicon;
        protected int ? _sequence;
        protected string _url;
        protected bool ? _isview;
        protected bool ? _isdynamic;
        protected bool ? _issuperadmin;
        protected bool ? _isvisibleinmenu;
        protected long ? _organizationkey;
                
        
        [DataMember]
        public long ? appformid
        {
            get { return _appformid; }
            set { _appformid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "formname", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_forminfo), ErrorMessageResourceName = "formnameRequired")]
        public string formname
        {
            get { return _formname; }
            set { _formname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentid", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public long ? parentid
        {
            get { return _parentid; }
            set { _parentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "levelid", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public int ? levelid
        {
            get { return _levelid; }
            set { _levelid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "menulevel", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public string menulevel
        {
            get { return _menulevel; }
            set { _menulevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "formnamear", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public string formnamear
        {
            get { return _formnamear; }
            set { _formnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hasdirectchild", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public bool ? hasdirectchild
        {
            get { return _hasdirectchild; }
            set { _hasdirectchild = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "icon", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public byte[] icon
        {
            get { return _icon; }
            set { _icon = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "classicon", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public string classicon
        {
            get { return _classicon; }
            set { _classicon = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "sequence", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public int ? sequence
        {
            get { return _sequence; }
            set { _sequence = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(200)]
        [Display(Name = "url", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public string url
        {
            get { return _url; }
            set { _url = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isview", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public bool ? isview
        {
            get { return _isview; }
            set { _isview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isdynamic", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public bool ? isdynamic
        {
            get { return _isdynamic; }
            set { _isdynamic = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issuperadmin", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public bool ? issuperadmin
        {
            get { return _issuperadmin; }
            set { _issuperadmin = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isvisibleinmenu", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public bool ? isvisibleinmenu
        {
            get { return _isvisibleinmenu; }
            set { _isvisibleinmenu = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "organizationkey", ResourceType = typeof(KAF.MsgContainer._owin_forminfo))]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_forminfoEntity():base()
        {
        }
        
        public owin_forminfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_forminfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _appformid = reader.GetInt64(reader.GetOrdinal("AppFormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormName"))) _formname = reader.GetString(reader.GetOrdinal("FormName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LevelID"))) _levelid = reader.GetInt32(reader.GetOrdinal("LevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MenuLevel"))) _menulevel = reader.GetString(reader.GetOrdinal("MenuLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormNameAr"))) _formnamear = reader.GetString(reader.GetOrdinal("FormNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasDirectChild"))) _hasdirectchild = reader.GetBoolean(reader.GetOrdinal("HasDirectChild"));
                if (!reader.IsDBNull(reader.GetOrdinal("Icon"))) _icon = (byte[])reader.GetValue(reader.GetOrdinal("Icon"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) _classicon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
                if (!reader.IsDBNull(reader.GetOrdinal("URL"))) _url = reader.GetString(reader.GetOrdinal("URL"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _isview = reader.GetBoolean(reader.GetOrdinal("IsView"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsDynamic"))) _isdynamic = reader.GetBoolean(reader.GetOrdinal("IsDynamic"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuperAdmin"))) _issuperadmin = reader.GetBoolean(reader.GetOrdinal("IsSuperAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsVisibleInMenu"))) _isvisibleinmenu = reader.GetBoolean(reader.GetOrdinal("IsVisibleInMenu"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("AppFormID"))) _appformid = reader.GetInt64(reader.GetOrdinal("AppFormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormName"))) _formname = reader.GetString(reader.GetOrdinal("FormName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentID"))) _parentid = reader.GetInt64(reader.GetOrdinal("ParentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LevelID"))) _levelid = reader.GetInt32(reader.GetOrdinal("LevelID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MenuLevel"))) _menulevel = reader.GetString(reader.GetOrdinal("MenuLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormNameAr"))) _formnamear = reader.GetString(reader.GetOrdinal("FormNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("HasDirectChild"))) _hasdirectchild = reader.GetBoolean(reader.GetOrdinal("HasDirectChild"));
                if (!reader.IsDBNull(reader.GetOrdinal("Icon"))) _icon = (byte[])reader.GetValue(reader.GetOrdinal("Icon"));
                if (!reader.IsDBNull(reader.GetOrdinal("ClassIcon"))) _classicon = reader.GetString(reader.GetOrdinal("ClassIcon"));
                if (!reader.IsDBNull(reader.GetOrdinal("Sequence"))) _sequence = reader.GetInt32(reader.GetOrdinal("Sequence"));
                if (!reader.IsDBNull(reader.GetOrdinal("URL"))) _url = reader.GetString(reader.GetOrdinal("URL"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsView"))) _isview = reader.GetBoolean(reader.GetOrdinal("IsView"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsDynamic"))) _isdynamic = reader.GetBoolean(reader.GetOrdinal("IsDynamic"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsSuperAdmin"))) _issuperadmin = reader.GetBoolean(reader.GetOrdinal("IsSuperAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsVisibleInMenu"))) _isvisibleinmenu = reader.GetBoolean(reader.GetOrdinal("IsVisibleInMenu"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
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
