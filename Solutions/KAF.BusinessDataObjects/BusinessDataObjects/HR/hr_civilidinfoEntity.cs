using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_civilidinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_civilidinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _civilid;
        protected long ? _hrbasicid;
        protected string _civilidno;
        protected DateTime ? _civilidissuedate;
        protected DateTime ? _civilidexpirydate;
        protected string _civilidfiledescription;
        protected string _civilidfilepath;
        protected string _civilidfilename;
        protected string _civilidfiletype;
        protected string _civilidextension;
        protected Guid ? _civilidfileid;
        protected string _civilidfiledescription_2;
        protected string _civilidfilepath_2;
        protected string _civilidfilename_2;
        protected string _civilidfiletype_2;
        protected string _civilidextension_2;
        protected Guid ? _civilidfileid_2;
        protected string _remarks;
        protected int ? _forreview;
        protected bool ? _iscurrent;
        protected long? _serialno;


        [DataMember]
        public long ? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_civilidinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "civilidno", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_civilidinfo), ErrorMessageResourceName = "civilidnoRequired")]
        public string civilidno
        {
            get { return _civilidno; }
            set { _civilidno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilidissuedate", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public DateTime ? civilidissuedate
        {
            get { return _civilidissuedate; }
            set { _civilidissuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilidexpirydate", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public DateTime ? civilidexpirydate
        {
            get { return _civilidexpirydate; }
            set { _civilidexpirydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "civilidfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfiledescription
        {
            get { return _civilidfiledescription; }
            set { _civilidfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfilepath", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfilepath
        {
            get { return _civilidfilepath; }
            set { _civilidfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfilename", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfilename
        {
            get { return _civilidfilename; }
            set { _civilidfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfiletype", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfiletype
        {
            get { return _civilidfiletype; }
            set { _civilidfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidextension", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidextension
        {
            get { return _civilidextension; }
            set { _civilidextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilidfileid", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public Guid ? civilidfileid
        {
            get { return _civilidfileid; }
            set { _civilidfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "civilidfiledescription_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfiledescription_2
        {
            get { return _civilidfiledescription_2; }
            set { _civilidfiledescription_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfilepath_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfilepath_2
        {
            get { return _civilidfilepath_2; }
            set { _civilidfilepath_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfilename_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfilename_2
        {
            get { return _civilidfilename_2; }
            set { _civilidfilename_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidfiletype_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidfiletype_2
        {
            get { return _civilidfiletype_2; }
            set { _civilidfiletype_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "civilidextension_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string civilidextension_2
        {
            get { return _civilidextension_2; }
            set { _civilidextension_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilidfileid_2", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public Guid ? civilidfileid_2
        {
            get { return _civilidfileid_2; }
            set { _civilidfileid_2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "iscurrent", ResourceType = typeof(KAF.MsgContainer._hr_civilidinfo))]
        public bool ? iscurrent
        {
            get { return _iscurrent; }
            set { _iscurrent = value; this.OnChnaged(); }
        }


        [DataMember]
        public long? serialno
        {
            get { return _serialno; }
            set { _serialno = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public hr_civilidinfoEntity():base()
        {
        }
        
        public hr_civilidinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_civilidinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDNo"))) _civilidno = reader.GetString(reader.GetOrdinal("CivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDIssueDate"))) _civilidissuedate = reader.GetDateTime(reader.GetOrdinal("CivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription"))) _civilidfiledescription = reader.GetString(reader.GetOrdinal("CivilIDFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath"))) _civilidfilepath = reader.GetString(reader.GetOrdinal("CivilIDFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName"))) _civilidfilename = reader.GetString(reader.GetOrdinal("CivilIDFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType"))) _civilidfiletype = reader.GetString(reader.GetOrdinal("CivilIDFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension"))) _civilidextension = reader.GetString(reader.GetOrdinal("CivilIDExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID"))) _civilidfileid = reader.GetGuid(reader.GetOrdinal("CivilIDFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription_2"))) _civilidfiledescription_2 = reader.GetString(reader.GetOrdinal("CivilIDFileDescription_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath_2"))) _civilidfilepath_2 = reader.GetString(reader.GetOrdinal("CivilIDFilePath_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName_2"))) _civilidfilename_2 = reader.GetString(reader.GetOrdinal("CivilIDFileName_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType_2"))) _civilidfiletype_2 = reader.GetString(reader.GetOrdinal("CivilIDFileType_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension_2"))) _civilidextension_2 = reader.GetString(reader.GetOrdinal("CivilIDExtension_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID_2"))) _civilidfileid_2 = reader.GetGuid(reader.GetOrdinal("CivilIDFileID_2"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDNo"))) _civilidno = reader.GetString(reader.GetOrdinal("CivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDIssueDate"))) _civilidissuedate = reader.GetDateTime(reader.GetOrdinal("CivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription"))) _civilidfiledescription = reader.GetString(reader.GetOrdinal("CivilIDFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath"))) _civilidfilepath = reader.GetString(reader.GetOrdinal("CivilIDFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName"))) _civilidfilename = reader.GetString(reader.GetOrdinal("CivilIDFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType"))) _civilidfiletype = reader.GetString(reader.GetOrdinal("CivilIDFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension"))) _civilidextension = reader.GetString(reader.GetOrdinal("CivilIDExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID"))) _civilidfileid = reader.GetGuid(reader.GetOrdinal("CivilIDFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription_2"))) _civilidfiledescription_2 = reader.GetString(reader.GetOrdinal("CivilIDFileDescription_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath_2"))) _civilidfilepath_2 = reader.GetString(reader.GetOrdinal("CivilIDFilePath_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName_2"))) _civilidfilename_2 = reader.GetString(reader.GetOrdinal("CivilIDFileName_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType_2"))) _civilidfiletype_2 = reader.GetString(reader.GetOrdinal("CivilIDFileType_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension_2"))) _civilidextension_2 = reader.GetString(reader.GetOrdinal("CivilIDExtension_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID_2"))) _civilidfileid_2 = reader.GetGuid(reader.GetOrdinal("CivilIDFileID_2"));
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
