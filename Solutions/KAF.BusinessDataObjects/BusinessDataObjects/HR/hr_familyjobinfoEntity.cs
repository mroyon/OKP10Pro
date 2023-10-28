using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_familyjobinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_familyjobinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrfamilyjobid;
        protected long ? _hrbasicid;
        protected long ? _hrfamilyid;
        protected long ? _jobtype;
        protected string _organization;
        protected string _designation;
        protected DateTime ? _joiningdate;
        protected string _workplaceaddress;
        protected string _remarks;
                
        
        [DataMember]
        public long ? hrfamilyjobid
        {
            get { return _hrfamilyjobid; }
            set { _hrfamilyjobid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrfamilyid", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "hrfamilyidRequired")]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "jobtype", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "jobtypeRequired")]
        public long ? jobtype
        {
            get { return _jobtype; }
            set { _jobtype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "organization", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "organizationRequired")]
        public string organization
        {
            get { return _organization; }
            set { _organization = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "designation", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "designationRequired")]
        public string designation
        {
            get { return _designation; }
            set { _designation = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "joiningdate", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo), ErrorMessageResourceName = "joiningdateRequired")]
        public DateTime ? joiningdate
        {
            get { return _joiningdate; }
            set { _joiningdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(500)]
        [Display(Name = "workplaceaddress", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        public string workplaceaddress
        {
            get { return _workplaceaddress; }
            set { _workplaceaddress = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_familyjobinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_familyjobinfoEntity():base()
        {
        }
        
        public hr_familyjobinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_familyjobinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyJobID"))) _hrfamilyjobid = reader.GetInt64(reader.GetOrdinal("HrFamilyJobID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobType"))) _jobtype = reader.GetInt64(reader.GetOrdinal("JobType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Organization"))) _organization = reader.GetString(reader.GetOrdinal("Organization"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designation"))) _designation = reader.GetString(reader.GetOrdinal("Designation"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningDate"))) _joiningdate = reader.GetDateTime(reader.GetOrdinal("JoiningDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceAddress"))) _workplaceaddress = reader.GetString(reader.GetOrdinal("WorkPlaceAddress"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyJobID"))) _hrfamilyjobid = reader.GetInt64(reader.GetOrdinal("HrFamilyJobID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("JobType"))) _jobtype = reader.GetInt64(reader.GetOrdinal("JobType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Organization"))) _organization = reader.GetString(reader.GetOrdinal("Organization"));
                if (!reader.IsDBNull(reader.GetOrdinal("Designation"))) _designation = reader.GetString(reader.GetOrdinal("Designation"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoiningDate"))) _joiningdate = reader.GetDateTime(reader.GetOrdinal("JoiningDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlaceAddress"))) _workplaceaddress = reader.GetString(reader.GetOrdinal("WorkPlaceAddress"));
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
