using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_familycivilidinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_familycivilidinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _familycivilid;
        protected long ? _hrfamilyid;
        protected long ? _hrbasicid;
        protected string _familycivilidno;
        protected long ? _serialno;
        protected DateTime ? _familycivilidissuedate;
        protected DateTime ? _familycivilidexpirydate;
        protected string _familycivilidfiledescription;
        protected string _familycivilidfilepath;
        protected string _familycivilidfilename;
        protected string _familycivilidfiletype;
        protected string _familycivilidextension;
        protected Guid ? _familycivilidfileid;
        protected string _familycivilidfiledescription_2;
        protected string _familycivilidfilepath_2;
        protected string _familycivilidfilename_2;
        protected string _familycivilidfiletype_2;
        protected string _familycivilidextension_2;
        protected Guid ? _familycivilidfileid_2;
        protected string _remarks;
        protected int ? _forreview;
        protected bool ? _iscurrent;
                
        
        [DataMember]
        public long ? familycivilid
        {
            get { return _familycivilid; }
            set { _familycivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrfamilyid", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo), ErrorMessageResourceName = "hrfamilyidRequired")]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "familycivilidno", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo), ErrorMessageResourceName = "familycivilidnoRequired")]
        public string familycivilidno
        {
            get { return _familycivilidno; }
            set { _familycivilidno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "serialno", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public long ? serialno
        {
            get { return _serialno; }
            set { _serialno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycivilidissuedate", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public DateTime ? familycivilidissuedate
        {
            get { return _familycivilidissuedate; }
            set { _familycivilidissuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycivilidexpirydate", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public DateTime ? familycivilidexpirydate
        {
            get { return _familycivilidexpirydate; }
            set { _familycivilidexpirydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "familycivilidfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfiledescription
        {
            get { return _familycivilidfiledescription; }
            set { _familycivilidfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfilepath", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfilepath
        {
            get { return _familycivilidfilepath; }
            set { _familycivilidfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfilename", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfilename
        {
            get { return _familycivilidfilename; }
            set { _familycivilidfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfiletype", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfiletype
        {
            get { return _familycivilidfiletype; }
            set { _familycivilidfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidextension", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidextension
        {
            get { return _familycivilidextension; }
            set { _familycivilidextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycivilidfileid", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public Guid ? familycivilidfileid
        {
            get { return _familycivilidfileid; }
            set { _familycivilidfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "familycivilidfiledescription_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfiledescription_2
        {
            get { return _familycivilidfiledescription_2; }
            set { _familycivilidfiledescription_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfilepath_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfilepath_2
        {
            get { return _familycivilidfilepath_2; }
            set { _familycivilidfilepath_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfilename_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfilename_2
        {
            get { return _familycivilidfilename_2; }
            set { _familycivilidfilename_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidfiletype_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidfiletype_2
        {
            get { return _familycivilidfiletype_2; }
            set { _familycivilidfiletype_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familycivilidextension_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string familycivilidextension_2
        {
            get { return _familycivilidextension_2; }
            set { _familycivilidextension_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycivilidfileid_2", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public Guid ? familycivilidfileid_2
        {
            get { return _familycivilidfileid_2; }
            set { _familycivilidfileid_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "iscurrent", ResourceType = typeof(KAF.MsgContainer._hr_familycivilidinfo))]
        public bool ? iscurrent
        {
            get { return _iscurrent; }
            set { _iscurrent = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_familycivilidinfoEntity():base()
        {
        }
        
        public hr_familycivilidinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_familycivilidinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilID"))) _familycivilid = reader.GetInt64(reader.GetOrdinal("FamilyCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDNo"))) _familycivilidno = reader.GetString(reader.GetOrdinal("FamilyCivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDIssueDate"))) _familycivilidissuedate = reader.GetDateTime(reader.GetOrdinal("FamilyCivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExpiryDate"))) _familycivilidexpirydate = reader.GetDateTime(reader.GetOrdinal("FamilyCivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileDescription"))) _familycivilidfiledescription = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFilePath"))) _familycivilidfilepath = reader.GetString(reader.GetOrdinal("FamilyCivilIDFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileName"))) _familycivilidfilename = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileType"))) _familycivilidfiletype = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExtension"))) _familycivilidextension = reader.GetString(reader.GetOrdinal("FamilyCivilIDExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileID"))) _familycivilidfileid = reader.GetGuid(reader.GetOrdinal("FamilyCivilIDFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileDescription_2"))) _familycivilidfiledescription_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileDescription_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFilePath_2"))) _familycivilidfilepath_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFilePath_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileName_2"))) _familycivilidfilename_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileName_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileType_2"))) _familycivilidfiletype_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileType_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExtension_2"))) _familycivilidextension_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDExtension_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileID_2"))) _familycivilidfileid_2 = reader.GetGuid(reader.GetOrdinal("FamilyCivilIDFileID_2"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilID"))) _familycivilid = reader.GetInt64(reader.GetOrdinal("FamilyCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDNo"))) _familycivilidno = reader.GetString(reader.GetOrdinal("FamilyCivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDIssueDate"))) _familycivilidissuedate = reader.GetDateTime(reader.GetOrdinal("FamilyCivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExpiryDate"))) _familycivilidexpirydate = reader.GetDateTime(reader.GetOrdinal("FamilyCivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileDescription"))) _familycivilidfiledescription = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFilePath"))) _familycivilidfilepath = reader.GetString(reader.GetOrdinal("FamilyCivilIDFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileName"))) _familycivilidfilename = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileType"))) _familycivilidfiletype = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExtension"))) _familycivilidextension = reader.GetString(reader.GetOrdinal("FamilyCivilIDExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileID"))) _familycivilidfileid = reader.GetGuid(reader.GetOrdinal("FamilyCivilIDFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileDescription_2"))) _familycivilidfiledescription_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileDescription_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFilePath_2"))) _familycivilidfilepath_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFilePath_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileName_2"))) _familycivilidfilename_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileName_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileType_2"))) _familycivilidfiletype_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDFileType_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDExtension_2"))) _familycivilidextension_2 = reader.GetString(reader.GetOrdinal("FamilyCivilIDExtension_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilIDFileID_2"))) _familycivilidfileid_2 = reader.GetGuid(reader.GetOrdinal("FamilyCivilIDFileID_2"));
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
