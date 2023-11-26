using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_familypassportinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_familypassportinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _familypassportid;
        protected long ? _hrfamilyid;
        protected long ? _hrbasicid;
        protected string _familypassportno;
        protected DateTime ? _familypassportissuedate;
        protected DateTime ? _familypassportexpirydate;
        protected long ? _familypassportissuecountryid;
        protected bool ? _isfamilyfamilypassport;
        protected string _familypassportfiledescription;
        protected string _familypassportfilepath;
        protected string _familypassportfilename;
        protected string _familypassportfiletype;
        protected string _familypassportextension;
        protected Guid ? _familypassportfileid;
        protected string _remarks;
        protected int ? _forreview;
        protected bool ? _iscurrent;
                
        
        [DataMember]
        public long ? familypassportid
        {
            get { return _familypassportid; }
            set { _familypassportid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrfamilyid", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo), ErrorMessageResourceName = "hrfamilyidRequired")]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "familypassportno", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo), ErrorMessageResourceName = "familypassportnoRequired")]
        public string familypassportno
        {
            get { return _familypassportno; }
            set { _familypassportno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familypassportissuedate", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public DateTime ? familypassportissuedate
        {
            get { return _familypassportissuedate; }
            set { _familypassportissuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familypassportexpirydate", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public DateTime ? familypassportexpirydate
        {
            get { return _familypassportexpirydate; }
            set { _familypassportexpirydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familypassportissuecountryid", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public long ? familypassportissuecountryid
        {
            get { return _familypassportissuecountryid; }
            set { _familypassportissuecountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isfamilyfamilypassport", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public bool ? isfamilyfamilypassport
        {
            get { return _isfamilyfamilypassport; }
            set { _isfamilyfamilypassport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "familypassportfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string familypassportfiledescription
        {
            get { return _familypassportfiledescription; }
            set { _familypassportfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familypassportfilepath", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string familypassportfilepath
        {
            get { return _familypassportfilepath; }
            set { _familypassportfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familypassportfilename", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string familypassportfilename
        {
            get { return _familypassportfilename; }
            set { _familypassportfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familypassportfiletype", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string familypassportfiletype
        {
            get { return _familypassportfiletype; }
            set { _familypassportfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familypassportextension", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string familypassportextension
        {
            get { return _familypassportextension; }
            set { _familypassportextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familypassportfileid", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public Guid ? familypassportfileid
        {
            get { return _familypassportfileid; }
            set { _familypassportfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "iscurrent", ResourceType = typeof(KAF.MsgContainer._hr_familypassportinfo))]
        public bool ? iscurrent
        {
            get { return _iscurrent; }
            set { _iscurrent = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_familypassportinfoEntity():base()
        {
        }
        
        public hr_familypassportinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_familypassportinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportID"))) _familypassportid = reader.GetInt64(reader.GetOrdinal("FamilyPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportNo"))) _familypassportno = reader.GetString(reader.GetOrdinal("FamilyPassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportIssueDate"))) _familypassportissuedate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportExpiryDate"))) _familypassportexpirydate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportIssueCountryID"))) _familypassportissuecountryid = reader.GetInt64(reader.GetOrdinal("FamilyPassportIssueCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyFamilyPassport"))) _isfamilyfamilypassport = reader.GetBoolean(reader.GetOrdinal("IsFamilyFamilyPassport"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileDescription"))) _familypassportfiledescription = reader.GetString(reader.GetOrdinal("FamilyPassportFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFilePath"))) _familypassportfilepath = reader.GetString(reader.GetOrdinal("FamilyPassportFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileName"))) _familypassportfilename = reader.GetString(reader.GetOrdinal("FamilyPassportFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileType"))) _familypassportfiletype = reader.GetString(reader.GetOrdinal("FamilyPassportFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportExtension"))) _familypassportextension = reader.GetString(reader.GetOrdinal("FamilyPassportExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileID"))) _familypassportfileid = reader.GetGuid(reader.GetOrdinal("FamilyPassportFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportID"))) _familypassportid = reader.GetInt64(reader.GetOrdinal("FamilyPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportNo"))) _familypassportno = reader.GetString(reader.GetOrdinal("FamilyPassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportIssueDate"))) _familypassportissuedate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportExpiryDate"))) _familypassportexpirydate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportIssueCountryID"))) _familypassportissuecountryid = reader.GetInt64(reader.GetOrdinal("FamilyPassportIssueCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyFamilyPassport"))) _isfamilyfamilypassport = reader.GetBoolean(reader.GetOrdinal("IsFamilyFamilyPassport"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileDescription"))) _familypassportfiledescription = reader.GetString(reader.GetOrdinal("FamilyPassportFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFilePath"))) _familypassportfilepath = reader.GetString(reader.GetOrdinal("FamilyPassportFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileName"))) _familypassportfilename = reader.GetString(reader.GetOrdinal("FamilyPassportFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileType"))) _familypassportfiletype = reader.GetString(reader.GetOrdinal("FamilyPassportFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportExtension"))) _familypassportextension = reader.GetString(reader.GetOrdinal("FamilyPassportExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileID"))) _familypassportfileid = reader.GetGuid(reader.GetOrdinal("FamilyPassportFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
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
