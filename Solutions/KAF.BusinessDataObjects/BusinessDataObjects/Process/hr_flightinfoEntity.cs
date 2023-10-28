using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_flightinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_flightinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _flightid;
        protected long ? _ptademandid;
        protected DateTime ? _flightdate;
        protected DateTime ? _flightletterdate;
        protected string _flightletterno;
        protected long ? _airlinesid;
        protected string _remarks;
                
        
        [DataMember]
        public long ? flightid
        {
            get { return _flightid; }
            set { _flightid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ptademandid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfo), ErrorMessageResourceName = "ptademandidRequired")]
        public long ? ptademandid
        {
            get { return _ptademandid; }
            set { _ptademandid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "flightdate", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfo), ErrorMessageResourceName = "flightdateRequired")]
        public DateTime ? flightdate
        {
            get { return _flightdate; }
            set { _flightdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "flightletterdate", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfo), ErrorMessageResourceName = "flightletterdateRequired")]
        public DateTime ? flightletterdate
        {
            get { return _flightletterdate; }
            set { _flightletterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "flightletterno", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfo), ErrorMessageResourceName = "flightletternoRequired")]
        public string flightletterno
        {
            get { return _flightletterno; }
            set { _flightletterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "airlinesid", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_flightinfo), ErrorMessageResourceName = "airlinesidRequired")]
        public long ? airlinesid
        {
            get { return _airlinesid; }
            set { _airlinesid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_flightinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_flightinfoEntity():base()
        {
        }
        
        public hr_flightinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_flightinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _flightid = reader.GetInt64(reader.GetOrdinal("FlightID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIID"))) _ptademandid = reader.GetInt64(reader.GetOrdinal("PTIID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _flightdate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterDate"))) _flightletterdate = reader.GetDateTime(reader.GetOrdinal("FlightLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterNo"))) _flightletterno = reader.GetString(reader.GetOrdinal("FlightLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("AirlinesID"))) _airlinesid = reader.GetInt64(reader.GetOrdinal("AirlinesID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _flightid = reader.GetInt64(reader.GetOrdinal("FlightID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIID"))) _ptademandid = reader.GetInt64(reader.GetOrdinal("PTIID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _flightdate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterDate"))) _flightletterdate = reader.GetDateTime(reader.GetOrdinal("FlightLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterNo"))) _flightletterno = reader.GetString(reader.GetOrdinal("FlightLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("AirlinesID"))) _airlinesid = reader.GetInt64(reader.GetOrdinal("AirlinesID"));
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
