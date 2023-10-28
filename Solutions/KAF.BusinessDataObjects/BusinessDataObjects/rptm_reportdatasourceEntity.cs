using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "rptm_reportdatasourceEntity", Namespace = "http://www.KAF.com/types")]
    public partial class rptm_reportdatasourceEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _reportdatasourceid;
        protected long ? _reportid;
        protected string _reportdatasourcename;
        protected string _reportdatasourcespname;
        protected string _reportdatasourcedescription;
                
        
        [DataMember]
        public long ? reportdatasourceid
        {
            get { return _reportdatasourceid; }
            set { _reportdatasourceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reportid", ResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource), ErrorMessageResourceName = "reportidRequired")]
        public long ? reportid
        {
            get { return _reportid; }
            set { _reportid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportdatasourcename", ResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource), ErrorMessageResourceName = "reportdatasourcenameRequired")]
        public string reportdatasourcename
        {
            get { return _reportdatasourcename; }
            set { _reportdatasourcename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportdatasourcespname", ResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource), ErrorMessageResourceName = "reportdatasourcespnameRequired")]
        public string reportdatasourcespname
        {
            get { return _reportdatasourcespname; }
            set { _reportdatasourcespname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "reportdatasourcedescription", ResourceType = typeof(KAF.MsgContainer._rptm_reportdatasource))]
        public string reportdatasourcedescription
        {
            get { return _reportdatasourcedescription; }
            set { _reportdatasourcedescription = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public rptm_reportdatasourceEntity():base()
        {
        }
        
        public rptm_reportdatasourceEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public rptm_reportdatasourceEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceID"))) _reportdatasourceid = reader.GetInt64(reader.GetOrdinal("ReportDataSourceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceName"))) _reportdatasourcename = reader.GetString(reader.GetOrdinal("ReportDataSourceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceSPName"))) _reportdatasourcespname = reader.GetString(reader.GetOrdinal("ReportDataSourceSPName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceDescription"))) _reportdatasourcedescription = reader.GetString(reader.GetOrdinal("ReportDataSourceDescription"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceID"))) _reportdatasourceid = reader.GetInt64(reader.GetOrdinal("ReportDataSourceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceName"))) _reportdatasourcename = reader.GetString(reader.GetOrdinal("ReportDataSourceName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceSPName"))) _reportdatasourcespname = reader.GetString(reader.GetOrdinal("ReportDataSourceSPName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDataSourceDescription"))) _reportdatasourcedescription = reader.GetString(reader.GetOrdinal("ReportDataSourceDescription"));
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
