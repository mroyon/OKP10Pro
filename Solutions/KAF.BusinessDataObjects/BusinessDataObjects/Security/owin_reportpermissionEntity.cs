using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "owin_reportpermissionEntity", Namespace = "http://www.KAF.com/types")]
    public partial class owin_reportpermissionEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _reportpersmissionid;
        protected long ? _masteruserid;
        protected Guid ? _userid;
        protected long ? _reportroleid;
        protected long ? _reportid;
        protected bool ? _isaccessible;
        protected bool ? _isprintable;
                
        
        [DataMember]
        public long ? reportpersmissionid
        {
            get { return _reportpersmissionid; }
            set { _reportpersmissionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "masteruserid", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "masteruseridRequired")]
        public long ? masteruserid
        {
            get { return _masteruserid; }
            set { _masteruserid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reportroleid", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "reportroleidRequired")]
        public long ? reportroleid
        {
            get { return _reportroleid; }
            set { _reportroleid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reportid", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "reportidRequired")]
        public long ? reportid
        {
            get { return _reportid; }
            set { _reportid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isaccessible", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "isaccessibleRequired")]
        public bool ? isaccessible
        {
            get { return _isaccessible; }
            set { _isaccessible = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isprintable", ResourceType = typeof(KAF.MsgContainer._owin_reportpermission))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._owin_reportpermission), ErrorMessageResourceName = "isprintableRequired")]
        public bool ? isprintable
        {
            get { return _isprintable; }
            set { _isprintable = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public owin_reportpermissionEntity():base()
        {
        }
        
        public owin_reportpermissionEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public owin_reportpermissionEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ReportPersmissionID"))) _reportpersmissionid = reader.GetInt64(reader.GetOrdinal("ReportPersmissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportRoleID"))) _reportroleid = reader.GetInt64(reader.GetOrdinal("ReportRoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAccessible"))) _isaccessible = reader.GetBoolean(reader.GetOrdinal("IsAccessible"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrintable"))) _isprintable = reader.GetBoolean(reader.GetOrdinal("IsPrintable"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ReportPersmissionID"))) _reportpersmissionid = reader.GetInt64(reader.GetOrdinal("ReportPersmissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MasterUserID"))) _masteruserid = reader.GetInt64(reader.GetOrdinal("MasterUserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportRoleID"))) _reportroleid = reader.GetInt64(reader.GetOrdinal("ReportRoleID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsAccessible"))) _isaccessible = reader.GetBoolean(reader.GetOrdinal("IsAccessible"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrintable"))) _isprintable = reader.GetBoolean(reader.GetOrdinal("IsPrintable"));
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
