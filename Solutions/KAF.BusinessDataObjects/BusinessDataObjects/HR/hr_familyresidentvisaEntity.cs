using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_familyresidentvisaEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_familyresidentvisaEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _familyresidentid;
        protected long ? _hrfamilyid;
        protected long ? _hrbasicid;
        protected long ? _familypassportid;
        protected string _residencynumber;
        protected DateTime ? _issuedate;
        protected DateTime ? _expirydate;
        protected bool ? _isfamilyvisa;
        protected string _filedescription;
        protected string _filepath;
        protected string _filename;
        protected string _filetype;
        protected string _extension;
        protected Guid ? _fileno;
        protected string _remarks;
                
        
        [DataMember]
        public long ? familyresidentid
        {
            get { return _familyresidentid; }
            set { _familyresidentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrfamilyid", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "hrfamilyidRequired")]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familypassportid", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "familypassportidRequired")]
        public long ? familypassportid
        {
            get { return _familypassportid; }
            set { _familypassportid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "residencynumber", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "residencynumberRequired")]
        public string residencynumber
        {
            get { return _residencynumber; }
            set { _residencynumber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "issuedate", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "issuedateRequired")]
        public DateTime ? issuedate
        {
            get { return _issuedate; }
            set { _issuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "expirydate", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa), ErrorMessageResourceName = "expirydateRequired")]
        public DateTime ? expirydate
        {
            get { return _expirydate; }
            set { _expirydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isfamilyvisa", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public bool ? isfamilyvisa
        {
            get { return _isfamilyvisa; }
            set { _isfamilyvisa = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "filedescription", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string filedescription
        {
            get { return _filedescription; }
            set { _filedescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filepath", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string filepath
        {
            get { return _filepath; }
            set { _filepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filename", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string filename
        {
            get { return _filename; }
            set { _filename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "filetype", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string filetype
        {
            get { return _filetype; }
            set { _filetype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "extension", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string extension
        {
            get { return _extension; }
            set { _extension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fileno", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public Guid ? fileno
        {
            get { return _fileno; }
            set { _fileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_familyresidentvisa))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_familyresidentvisaEntity():base()
        {
        }
        
        public hr_familyresidentvisaEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_familyresidentvisaEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyResidentID"))) _familyresidentid = reader.GetInt64(reader.GetOrdinal("FamilyResidentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportID"))) _familypassportid = reader.GetInt64(reader.GetOrdinal("FamilyPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResidencyNumber"))) _residencynumber = reader.GetString(reader.GetOrdinal("ResidencyNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("IssueDate"))) _issuedate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _expirydate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyVISA"))) _isfamilyvisa = reader.GetBoolean(reader.GetOrdinal("IsFamilyVISA"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileDescription"))) _filedescription = reader.GetString(reader.GetOrdinal("FileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileNo"))) _fileno = reader.GetGuid(reader.GetOrdinal("FileNo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyResidentID"))) _familyresidentid = reader.GetInt64(reader.GetOrdinal("FamilyResidentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportID"))) _familypassportid = reader.GetInt64(reader.GetOrdinal("FamilyPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResidencyNumber"))) _residencynumber = reader.GetString(reader.GetOrdinal("ResidencyNumber"));
                if (!reader.IsDBNull(reader.GetOrdinal("IssueDate"))) _issuedate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _expirydate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyVISA"))) _isfamilyvisa = reader.GetBoolean(reader.GetOrdinal("IsFamilyVISA"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileDescription"))) _filedescription = reader.GetString(reader.GetOrdinal("FileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FilePath"))) _filepath = reader.GetString(reader.GetOrdinal("FilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileName"))) _filename = reader.GetString(reader.GetOrdinal("FileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileType"))) _filetype = reader.GetString(reader.GetOrdinal("FileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("Extension"))) _extension = reader.GetString(reader.GetOrdinal("Extension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FileNo"))) _fileno = reader.GetGuid(reader.GetOrdinal("FileNo"));
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
