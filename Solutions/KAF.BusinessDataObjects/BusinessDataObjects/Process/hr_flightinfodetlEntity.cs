using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_flightinfodetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_flightinfodetlEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _flightdetlid;
        protected bool? _reissued;
        protected long ? _flightid;
        protected long ? _ptidetlid;
        protected long ? _hrbasicid;
        protected long ? _hrsvcid;
        protected long? _prevflightdetlid;
        protected string _remarks;
        protected bool ? _iscancel;
        protected DateTime ? _canceldate;
        protected DateTime ? _cancelletterdate;
        protected string _cancelletterno;
        protected string _reason;


        [DataMember]
        public bool? reissued
        {
            get { return _reissued; }
            set { _reissued = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? prevflightdetlid
        {
            get { return _prevflightdetlid; }
            set { _prevflightdetlid = value; this.OnChnaged(); }
        }


        [DataMember]
        public long ? flightdetlid
        {
            get { return _flightdetlid; }
            set { _flightdetlid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "flightid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl), ErrorMessageResourceName = "flightidRequired")]
        public long ? flightid
        {
            get { return _flightid; }
            set { _flightid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ptidetlid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl), ErrorMessageResourceName = "ptidetlidRequired")]
        public long ? ptidetlid
        {
            get { return _ptidetlid; }
            set { _ptidetlid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrsvcid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl), ErrorMessageResourceName = "hrsvcidRequired")]
        public long ? hrsvcid
        {
            get { return _hrsvcid; }
            set { _hrsvcid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "iscancel", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public bool ? iscancel
        {
            get { return _iscancel; }
            set { _iscancel = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "canceldate", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public DateTime ? canceldate
        {
            get { return _canceldate; }
            set { _canceldate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "cancelletterdate", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public DateTime ? cancelletterdate
        {
            get { return _cancelletterdate; }
            set { _cancelletterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "cancelletterno", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public string cancelletterno
        {
            get { return _cancelletterno; }
            set { _cancelletterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reason", ResourceType = typeof(KAF.MsgContainer._hr_flightinfodetl))]
        public string reason
        {
            get { return _reason; }
            set { _reason = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_flightinfodetlEntity():base()
        {
        }
        
        public hr_flightinfodetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_flightinfodetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDetlID"))) _flightdetlid = reader.GetInt64(reader.GetOrdinal("FlightDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _flightid = reader.GetInt64(reader.GetOrdinal("FlightID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIDetlID"))) _ptidetlid = reader.GetInt64(reader.GetOrdinal("PTIDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCancel"))) _iscancel = reader.GetBoolean(reader.GetOrdinal("IsCancel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelDate"))) _canceldate = reader.GetDateTime(reader.GetOrdinal("CancelDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterDate"))) _cancelletterdate = reader.GetDateTime(reader.GetOrdinal("CancelLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterNo"))) _cancelletterno = reader.GetString(reader.GetOrdinal("CancelLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
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

                if (!reader.IsDBNull(reader.GetOrdinal("PrevFlightDetlID"))) _prevflightdetlid = reader.GetInt64(reader.GetOrdinal("PrevFlightDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReIssued"))) _reissued = reader.GetBoolean(reader.GetOrdinal("ReIssued"));

                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDetlID"))) _flightdetlid = reader.GetInt64(reader.GetOrdinal("FlightDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _flightid = reader.GetInt64(reader.GetOrdinal("FlightID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIDetlID"))) _ptidetlid = reader.GetInt64(reader.GetOrdinal("PTIDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCancel"))) _iscancel = reader.GetBoolean(reader.GetOrdinal("IsCancel"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelDate"))) _canceldate = reader.GetDateTime(reader.GetOrdinal("CancelDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterDate"))) _cancelletterdate = reader.GetDateTime(reader.GetOrdinal("CancelLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterNo"))) _cancelletterno = reader.GetString(reader.GetOrdinal("CancelLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _reason = reader.GetString(reader.GetOrdinal("Reason"));
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

                if (!reader.IsDBNull(reader.GetOrdinal("PrevFlightDetlID"))) _prevflightdetlid = reader.GetInt64(reader.GetOrdinal("PrevFlightDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReIssued"))) _reissued = reader.GetBoolean(reader.GetOrdinal("ReIssued"));

                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
