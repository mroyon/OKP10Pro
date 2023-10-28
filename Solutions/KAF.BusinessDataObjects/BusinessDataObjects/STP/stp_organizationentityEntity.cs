using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "stp_organizationentityEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_organizationentityEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _entitykey;
        protected long ? _organizationkey;
        protected long ? _parentkey;
        protected long ? _entirytypekey;
        protected int ? _entitylevel;
        protected string _seqfirstindex;
        protected string _seqfullindex;
        protected string _entitycode;
        protected string _entityname;
        protected string _entitynamear;
        protected string _description;
        protected bool ? _isactive;
        protected long ? _entitystatus;
        protected long ? _entityseniority;
        protected string _entityidentitycode;
        protected string _adidentitycode;
        protected string _remarks;
        protected string _entitylogo;
        protected string _entitylogofiledescription;
        protected string _entitylogofilepath;
        protected string _entitylogofilename;
        protected string _entitylogofiletype;
        protected string _entitylogoextension;
        protected Guid ? _entitylogofileno;
                
        
        [DataMember]
        public long ? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "organizationkey", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_organizationentity), ErrorMessageResourceName = "organizationkeyRequired")]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parentkey", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public long ? parentkey
        {
            get { return _parentkey; }
            set { _parentkey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entirytypekey", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_organizationentity), ErrorMessageResourceName = "entirytypekeyRequired")]
        public long ? entirytypekey
        {
            get { return _entirytypekey; }
            set { _entirytypekey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitylevel", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_organizationentity), ErrorMessageResourceName = "entitylevelRequired")]
        public int ? entitylevel
        {
            get { return _entitylevel; }
            set { _entitylevel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "seqfirstindex", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string seqfirstindex
        {
            get { return _seqfirstindex; }
            set { _seqfirstindex = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "seqfullindex", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string seqfullindex
        {
            get { return _seqfullindex; }
            set { _seqfullindex = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitycode", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitycode
        {
            get { return _entitycode; }
            set { _entitycode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entityname", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_organizationentity), ErrorMessageResourceName = "entitynameRequired")]
        public string entityname
        {
            get { return _entityname; }
            set { _entityname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entitynamear", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitynamear
        {
            get { return _entitynamear; }
            set { _entitynamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "description", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitystatus", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public long ? entitystatus
        {
            get { return _entitystatus; }
            set { _entitystatus = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entityseniority", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public long ? entityseniority
        {
            get { return _entityseniority; }
            set { _entityseniority = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entityidentitycode", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entityidentitycode
        {
            get { return _entityidentitycode; }
            set { _entityidentitycode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "adidentitycode", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string adidentitycode
        {
            get { return _adidentitycode; }
            set { _adidentitycode = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "entitylogo", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogo
        {
            get { return _entitylogo; }
            set { _entitylogo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "entitylogofiledescription", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogofiledescription
        {
            get { return _entitylogofiledescription; }
            set { _entitylogofiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitylogofilepath", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogofilepath
        {
            get { return _entitylogofilepath; }
            set { _entitylogofilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitylogofilename", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogofilename
        {
            get { return _entitylogofilename; }
            set { _entitylogofilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitylogofiletype", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogofiletype
        {
            get { return _entitylogofiletype; }
            set { _entitylogofiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "entitylogoextension", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public string entitylogoextension
        {
            get { return _entitylogoextension; }
            set { _entitylogoextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitylogofileno", ResourceType = typeof(KAF.MsgContainer._stp_organizationentity))]
        public Guid ? entitylogofileno
        {
            get { return _entitylogofileno; }
            set { _entitylogofileno = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_organizationentityEntity():base()
        {
        }
        
        public stp_organizationentityEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_organizationentityEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentKey"))) _parentkey = reader.GetInt64(reader.GetOrdinal("ParentKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntityTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFirstIndex"))) _seqfirstindex = reader.GetString(reader.GetOrdinal("SeqFirstIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFullIndex"))) _seqfullindex = reader.GetString(reader.GetOrdinal("SeqFullIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityCode"))) _entitycode = reader.GetString(reader.GetOrdinal("EntityCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _entityname = reader.GetString(reader.GetOrdinal("EntityName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityNameAr"))) _entitynamear = reader.GetString(reader.GetOrdinal("EntityNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityStatus"))) _entitystatus = reader.GetInt64(reader.GetOrdinal("EntityStatus"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntitySeniority"))) _entityseniority = reader.GetInt64(reader.GetOrdinal("EntitySeniority"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityIdentityCode"))) _entityidentitycode = reader.GetString(reader.GetOrdinal("EntityIdentityCode"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ADIdentityCode"))) _adidentitycode = reader.GetString(reader.GetOrdinal("ADIdentityCode"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogo"))) _entitylogo = reader.GetString(reader.GetOrdinal("EntityLogo"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileDescription"))) _entitylogofiledescription = reader.GetString(reader.GetOrdinal("EntityLogoFileDescription"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFilePath"))) _entitylogofilepath = reader.GetString(reader.GetOrdinal("EntityLogoFilePath"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileName"))) _entitylogofilename = reader.GetString(reader.GetOrdinal("EntityLogoFileName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileType"))) _entitylogofiletype = reader.GetString(reader.GetOrdinal("EntityLogoFileType"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoExtension"))) _entitylogoextension = reader.GetString(reader.GetOrdinal("EntityLogoExtension"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileNo"))) _entitylogofileno = reader.GetGuid(reader.GetOrdinal("EntityLogoFileNo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentKey"))) _parentkey = reader.GetInt64(reader.GetOrdinal("ParentKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityTypeKey"))) _entirytypekey = reader.GetInt64(reader.GetOrdinal("EntityTypeKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityLevel"))) _entitylevel = reader.GetInt32(reader.GetOrdinal("EntityLevel"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFirstIndex"))) _seqfirstindex = reader.GetString(reader.GetOrdinal("SeqFirstIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeqFullIndex"))) _seqfullindex = reader.GetString(reader.GetOrdinal("SeqFullIndex"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityCode"))) _entitycode = reader.GetString(reader.GetOrdinal("EntityCode"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _entityname = reader.GetString(reader.GetOrdinal("EntityName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityNameAr"))) _entitynamear = reader.GetString(reader.GetOrdinal("EntityNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityStatus"))) _entitystatus = reader.GetInt64(reader.GetOrdinal("EntityStatus"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntitySeniority"))) _entityseniority = reader.GetInt64(reader.GetOrdinal("EntitySeniority"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityIdentityCode"))) _entityidentitycode = reader.GetString(reader.GetOrdinal("EntityIdentityCode"));
                //if (!reader.IsDBNull(reader.GetOrdinal("ADIdentityCode"))) _adidentitycode = reader.GetString(reader.GetOrdinal("ADIdentityCode"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogo"))) _entitylogo = reader.GetString(reader.GetOrdinal("EntityLogo"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileDescription"))) _entitylogofiledescription = reader.GetString(reader.GetOrdinal("EntityLogoFileDescription"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFilePath"))) _entitylogofilepath = reader.GetString(reader.GetOrdinal("EntityLogoFilePath"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileName"))) _entitylogofilename = reader.GetString(reader.GetOrdinal("EntityLogoFileName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileType"))) _entitylogofiletype = reader.GetString(reader.GetOrdinal("EntityLogoFileType"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoExtension"))) _entitylogoextension = reader.GetString(reader.GetOrdinal("EntityLogoExtension"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityLogoFileNo"))) _entitylogofileno = reader.GetGuid(reader.GetOrdinal("EntityLogoFileNo"));
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
