using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "rptm_allreportinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class rptm_allreportinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _reportid;
        protected string _modulename;
        protected string _reportname;
        protected string _reportnameeng;
        protected string _reporturl;
        protected string _reportspname;
        protected string _reportspnameeng;
        protected string _reportdescription;


        [DataMember]
        public long? reportid
        {
            get { return _reportid; }
            set { _reportid = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "modulename", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        public string modulename
        {
            get { return _modulename; }
            set { _modulename = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportname", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo), ErrorMessageResourceName = "reportnameRequired")]
        public string reportname
        {
            get { return _reportname; }
            set { _reportname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportnameeng", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        public string reportnameeng
        {
            get { return _reportnameeng; }
            set { _reportnameeng = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(400)]
        [Display(Name = "reporturl", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        public string reporturl
        {
            get { return _reporturl; }
            set { _reporturl = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportspname", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo), ErrorMessageResourceName = "reportspnameRequired")]
        public string reportspname
        {
            get { return _reportspname; }
            set { _reportspname = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reportspnameeng", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        public string reportspnameeng
        {
            get { return _reportspnameeng; }
            set { _reportspnameeng = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(4000)]
        [Display(Name = "reportdescription", ResourceType = typeof(KAF.MsgContainer._rptm_allreportinfo))]
        public string reportdescription
        {
            get { return _reportdescription; }
            set { _reportdescription = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public rptm_allreportinfoEntity() : base()
        {
        }

        public rptm_allreportinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public rptm_allreportinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModuleName"))) _modulename = reader.GetString(reader.GetOrdinal("ModuleName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportName"))) _reportname = reader.GetString(reader.GetOrdinal("ReportName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportNameEng"))) _reportnameeng = reader.GetString(reader.GetOrdinal("ReportNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportURL"))) _reporturl = reader.GetString(reader.GetOrdinal("ReportURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportSPName"))) _reportspname = reader.GetString(reader.GetOrdinal("ReportSPName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportSPNameEng"))) _reportspnameeng = reader.GetString(reader.GetOrdinal("ReportSPNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDescription"))) _reportdescription = reader.GetString(reader.GetOrdinal("ReportDescription"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ReportID"))) _reportid = reader.GetInt64(reader.GetOrdinal("ReportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModuleName"))) _modulename = reader.GetString(reader.GetOrdinal("ModuleName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportName"))) _reportname = reader.GetString(reader.GetOrdinal("ReportName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportNameEng"))) _reportnameeng = reader.GetString(reader.GetOrdinal("ReportNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportURL"))) _reporturl = reader.GetString(reader.GetOrdinal("ReportURL"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportSPName"))) _reportspname = reader.GetString(reader.GetOrdinal("ReportSPName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportSPNameEng"))) _reportspnameeng = reader.GetString(reader.GetOrdinal("ReportSPNameEng"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReportDescription"))) _reportdescription = reader.GetString(reader.GetOrdinal("ReportDescription"));
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


