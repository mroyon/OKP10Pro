using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_repatriationinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_repatriationinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _repatriationid;
        protected long ? _hrbasicid;
        protected long ? _hrsvcid;
        protected DateTime ? _soddate;
        protected DateTime ? _flightdate;
        protected DateTime ? _salaryreceivedtilldate;
        protected DateTime ? _rewardavaildate;
        protected DateTime ? _letterdate;
        protected string _letterno;
        protected string _remarks;
                
        
        [DataMember]
        public long ? repatriationid
        {
            get { return _repatriationid; }
            set { _repatriationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrsvcid", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo), ErrorMessageResourceName = "hrsvcidRequired")]
        public long ? hrsvcid
        {
            get { return _hrsvcid; }
            set { _hrsvcid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "soddate", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        [Required]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo), ErrorMessageResourceName = "soddateRequired")]
        public DateTime ? soddate
        {
            get { return _soddate; }
            set { _soddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "flightdate", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        [Required]
        public DateTime ? flightdate
        {
            get { return _flightdate; }
            set { _flightdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "salaryreceivedtilldate", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        public DateTime ? salaryreceivedtilldate
        {
            get { return _salaryreceivedtilldate; }
            set { _salaryreceivedtilldate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "rewardavaildate", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        public DateTime ? rewardavaildate
        {
            get { return _rewardavaildate; }
            set { _rewardavaildate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "letterdate", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo), ErrorMessageResourceName = "letterdateRequired")]
        public DateTime ? letterdate
        {
            get { return _letterdate; }
            set { _letterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "letterno", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo), ErrorMessageResourceName = "letternoRequired")]
        public string letterno
        {
            get { return _letterno; }
            set { _letterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_repatriationinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_repatriationinfoEntity():base()
        {
        }
        
        public hr_repatriationinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_repatriationinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("RepatriationID"))) _repatriationid = reader.GetInt64(reader.GetOrdinal("RepatriationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SODDate"))) _soddate = reader.GetDateTime(reader.GetOrdinal("SODDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _flightdate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SalaryReceivedTillDate"))) _salaryreceivedtilldate = reader.GetDateTime(reader.GetOrdinal("SalaryReceivedTillDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RewardAvailDate"))) _rewardavaildate = reader.GetDateTime(reader.GetOrdinal("RewardAvailDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("RepatriationID"))) _repatriationid = reader.GetInt64(reader.GetOrdinal("RepatriationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SODDate"))) _soddate = reader.GetDateTime(reader.GetOrdinal("SODDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _flightdate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SalaryReceivedTillDate"))) _salaryreceivedtilldate = reader.GetDateTime(reader.GetOrdinal("SalaryReceivedTillDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RewardAvailDate"))) _rewardavaildate = reader.GetDateTime(reader.GetOrdinal("RewardAvailDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
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
