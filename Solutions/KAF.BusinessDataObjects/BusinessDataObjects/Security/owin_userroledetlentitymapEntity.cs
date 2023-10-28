using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "owin_userroledetlentitymapEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_userroledetlentitymapEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _userroledetentitymaplid;
        protected long ? _userroledetlid;
        protected long ? _userroleid;
        protected Guid ? _userid;
        protected long ? _roleid;
        protected long ? _entitykey;
        protected bool ? _allchild;
        protected bool ? _isunitadmin;
        protected bool ? _allunit;
        protected bool ? _allprofile;
        protected string _remarks;
                
        
        [DataMember]
        public long ? userroledetentitymaplid
        {
            get { return _userroledetentitymaplid; }
            set { _userroledetentitymaplid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userroledetlid", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap), ErrorMessageResourceName = "userroledetlidRequired")]
        public long ? userroledetlid
        {
            get { return _userroledetlid; }
            set { _userroledetlid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userroleid", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap), ErrorMessageResourceName = "userroleidRequired")]
        public long ? userroleid
        {
            get { return _userroleid; }
            set { _userroleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "roleid", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap), ErrorMessageResourceName = "roleidRequired")]
        public long ? roleid
        {
            get { return _roleid; }
            set { _roleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "entitykey", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public long ? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "allchild", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public bool ? allchild
        {
            get { return _allchild; }
            set { _allchild = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isunitadmin", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public bool ? isunitadmin
        {
            get { return _isunitadmin; }
            set { _isunitadmin = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "allunit", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public bool ? allunit
        {
            get { return _allunit; }
            set { _allunit = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "allprofile", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public bool ? allprofile
        {
            get { return _allprofile; }
            set { _allprofile = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._owin_userroledetlentitymap))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_userroledetlentitymapEntity():base()
        {
        }
        
        public owin_userroledetlentitymapEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_userroledetlentitymapEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleDetEntityMaplID"))) _userroledetentitymaplid = reader.GetInt64(reader.GetOrdinal("UserRoleDetEntityMaplID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleDetlID"))) _userroledetlid = reader.GetInt64(reader.GetOrdinal("UserRoleDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleID"))) _userroleid = reader.GetInt64(reader.GetOrdinal("UserRoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllChild"))) _allchild = reader.GetBoolean(reader.GetOrdinal("AllChild"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitAdmin"))) _isunitadmin = reader.GetBoolean(reader.GetOrdinal("IsUnitAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllUnit"))) _allunit = reader.GetBoolean(reader.GetOrdinal("AllUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllProfile"))) _allprofile = reader.GetBoolean(reader.GetOrdinal("AllProfile"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleDetEntityMaplID"))) _userroledetentitymaplid = reader.GetInt64(reader.GetOrdinal("UserRoleDetEntityMaplID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleDetlID"))) _userroledetlid = reader.GetInt64(reader.GetOrdinal("UserRoleDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserRoleID"))) _userroleid = reader.GetInt64(reader.GetOrdinal("UserRoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RoleID"))) _roleid = reader.GetInt64(reader.GetOrdinal("RoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllChild"))) _allchild = reader.GetBoolean(reader.GetOrdinal("AllChild"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsUnitAdmin"))) _isunitadmin = reader.GetBoolean(reader.GetOrdinal("IsUnitAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllUnit"))) _allunit = reader.GetBoolean(reader.GetOrdinal("AllUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("AllProfile"))) _allprofile = reader.GetBoolean(reader.GetOrdinal("AllProfile"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
