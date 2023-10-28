using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_attachmentinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_attachmentinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _attachmentid;
        protected long ? _hrbasicid;
        protected long ? _fromsubunitid;
        protected long ? _fromcampid;
        protected long ? _subunitid;
        protected long ? _campid;
        protected DateTime ? _fromdate;
        protected DateTime ? _todate;
        protected string _reason;
        protected string _letterno;
        protected DateTime ? _letterdate;
        protected DateTime ? _returndate;
        protected string _returnletterno;
        protected DateTime ? _returnletterdate;
        protected long ? _countryid;
        protected string _remarks;
                
        
        [DataMember]
        public long ? attachmentid
        {
            get { return _attachmentid; }
            set { _attachmentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fromsubunitid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "fromsubunitidRequired")]
        public long ? fromsubunitid
        {
            get { return _fromsubunitid; }
            set { _fromsubunitid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fromcampid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "fromcampidRequired")]
        public long ? fromcampid
        {
            get { return _fromcampid; }
            set { _fromcampid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "subunitid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "subunitidRequired")]
        public long ? subunitid
        {
            get { return _subunitid; }
            set { _subunitid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "campid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "campidRequired")]
        public long ? campid
        {
            get { return _campid; }
            set { _campid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fromdate", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo), ErrorMessageResourceName = "fromdateRequired")]
        public DateTime ? fromdate
        {
            get { return _fromdate; }
            set { _fromdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "todate", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public DateTime ? todate
        {
            get { return _todate; }
            set { _todate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "reason", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public string reason
        {
            get { return _reason; }
            set { _reason = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "letterno", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public string letterno
        {
            get { return _letterno; }
            set { _letterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "letterdate", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public DateTime ? letterdate
        {
            get { return _letterdate; }
            set { _letterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "returndate", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public DateTime ? returndate
        {
            get { return _returndate; }
            set { _returndate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "returnletterno", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public string returnletterno
        {
            get { return _returnletterno; }
            set { _returnletterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "returnletterdate", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public DateTime ? returnletterdate
        {
            get { return _returnletterdate; }
            set { _returnletterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "countryid", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public long ? countryid
        {
            get { return _countryid; }
            set { _countryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_attachmentinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_attachmentinfoEntity():base()
        {
        }
        
        public hr_attachmentinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_attachmentinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("AttachmentID"))) _attachmentid = reader.GetInt64(reader.GetOrdinal("AttachmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromSubUnitID"))) _fromsubunitid = reader.GetInt64(reader.GetOrdinal("FromSubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromCampID"))) _fromcampid = reader.GetInt64(reader.GetOrdinal("FromCampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromDate"))) _fromdate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToDate"))) _todate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnDate"))) _returndate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnLetterNo"))) _returnletterno = reader.GetString(reader.GetOrdinal("ReturnLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnLetterDate"))) _returnletterdate = reader.GetDateTime(reader.GetOrdinal("ReturnLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryID"))) _countryid = reader.GetInt64(reader.GetOrdinal("CountryID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("AttachmentID"))) _attachmentid = reader.GetInt64(reader.GetOrdinal("AttachmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromSubUnitID"))) _fromsubunitid = reader.GetInt64(reader.GetOrdinal("FromSubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromCampID"))) _fromcampid = reader.GetInt64(reader.GetOrdinal("FromCampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FromDate"))) _fromdate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToDate"))) _todate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnDate"))) _returndate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnLetterNo"))) _returnletterno = reader.GetString(reader.GetOrdinal("ReturnLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReturnLetterDate"))) _returnletterdate = reader.GetDateTime(reader.GetOrdinal("ReturnLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CountryID"))) _countryid = reader.GetInt64(reader.GetOrdinal("CountryID"));
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
