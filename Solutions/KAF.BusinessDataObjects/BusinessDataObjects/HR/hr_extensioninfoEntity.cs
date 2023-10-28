using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_extensioninfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_extensioninfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrextensionid;
        protected long ? _hrbasicid;
        protected DateTime ? _repatriationdate;
        protected DateTime ? _extensiontill;
        protected DateTime ? _letterdate;
        protected string _letterno;
        protected string _letternofilepath;
        protected string _letternofilename;
        protected string _letternofiletype;
        protected string _letternofileextension;
        protected string _remarks;
                
        
        [DataMember]
        public long ? hrextensionid
        {
            get { return _hrextensionid; }
            set { _hrextensionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_extensioninfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "repatriationdate", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_extensioninfo), ErrorMessageResourceName = "repatriationdateRequired")]
        public DateTime ? repatriationdate
        {
            get { return _repatriationdate; }
            set { _repatriationdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "extensiontill", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_extensioninfo), ErrorMessageResourceName = "extensiontillRequired")]
        public DateTime ? extensiontill
        {
            get { return _extensiontill; }
            set { _extensiontill = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "letterdate", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_extensioninfo), ErrorMessageResourceName = "letterdateRequired")]
        public DateTime ? letterdate
        {
            get { return _letterdate; }
            set { _letterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "letterno", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_extensioninfo), ErrorMessageResourceName = "letternoRequired")]
        public string letterno
        {
            get { return _letterno; }
            set { _letterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "letternofilepath", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        public string letternofilepath
        {
            get { return _letternofilepath; }
            set { _letternofilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "letternofilename", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        public string letternofilename
        {
            get { return _letternofilename; }
            set { _letternofilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "letternofiletype", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        public string letternofiletype
        {
            get { return _letternofiletype; }
            set { _letternofiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "letternofileextension", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        public string letternofileextension
        {
            get { return _letternofileextension; }
            set { _letternofileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_extensioninfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_extensioninfoEntity():base()
        {
        }
        
        public hr_extensioninfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_extensioninfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrExtensionID"))) _hrextensionid = reader.GetInt64(reader.GetOrdinal("HrExtensionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepatriationDate"))) _repatriationdate = reader.GetDateTime(reader.GetOrdinal("RepatriationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExtensionTill"))) _extensiontill = reader.GetDateTime(reader.GetOrdinal("ExtensionTill"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFilePath"))) _letternofilepath = reader.GetString(reader.GetOrdinal("LetterNoFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileName"))) _letternofilename = reader.GetString(reader.GetOrdinal("LetterNoFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileType"))) _letternofiletype = reader.GetString(reader.GetOrdinal("LetterNoFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileExtension"))) _letternofileextension = reader.GetString(reader.GetOrdinal("LetterNoFileExtension"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("HrExtensionID"))) _hrextensionid = reader.GetInt64(reader.GetOrdinal("HrExtensionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RepatriationDate"))) _repatriationdate = reader.GetDateTime(reader.GetOrdinal("RepatriationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExtensionTill"))) _extensiontill = reader.GetDateTime(reader.GetOrdinal("ExtensionTill"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFilePath"))) _letternofilepath = reader.GetString(reader.GetOrdinal("LetterNoFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileName"))) _letternofilename = reader.GetString(reader.GetOrdinal("LetterNoFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileType"))) _letternofiletype = reader.GetString(reader.GetOrdinal("LetterNoFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNoFileExtension"))) _letternofileextension = reader.GetString(reader.GetOrdinal("LetterNoFileExtension"));
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
