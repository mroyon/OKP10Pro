using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_ptademandEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_ptademandEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _ptademandid;
        protected long ? _visasentid;
        protected DateTime ? _ptidate;
        protected DateTime ? _ptiletterdate;
        protected string _ptiletterno;
        protected string _remarks;
        protected long ? _letterstatus;
                
        
        [DataMember]
        public long ? ptademandid
        {
            get { return _ptademandid; }
            set { _ptademandid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "visasentid", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_ptademand), ErrorMessageResourceName = "visasentidRequired")]
        public long ? visasentid
        {
            get { return _visasentid; }
            set { _visasentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ptidate", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_ptademand), ErrorMessageResourceName = "ptidateRequired")]
        public DateTime ? ptidate
        {
            get { return _ptidate; }
            set { _ptidate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "ptiletterdate", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_ptademand), ErrorMessageResourceName = "ptiletterdateRequired")]
        public DateTime ? ptiletterdate
        {
            get { return _ptiletterdate; }
            set { _ptiletterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "ptiletterno", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_ptademand), ErrorMessageResourceName = "ptiletternoRequired")]
        public string ptiletterno
        {
            get { return _ptiletterno; }
            set { _ptiletterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "letterstatus", ResourceType = typeof(KAF.MsgContainer._hr_ptademand))]
        public long ? letterstatus
        {
            get { return _letterstatus; }
            set { _letterstatus = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_ptademandEntity():base()
        {
        }
        
        public hr_ptademandEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_ptademandEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PTADemandID"))) _ptademandid = reader.GetInt64(reader.GetOrdinal("PTADemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaSentID"))) _visasentid = reader.GetInt64(reader.GetOrdinal("VisaSentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIDate"))) _ptidate = reader.GetDateTime(reader.GetOrdinal("PTIDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTILetterDate"))) _ptiletterdate = reader.GetDateTime(reader.GetOrdinal("PTILetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTILetterNo"))) _ptiletterno = reader.GetString(reader.GetOrdinal("PTILetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _letterstatus = reader.GetInt64(reader.GetOrdinal("LetterStatus"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("PTADemandID"))) _ptademandid = reader.GetInt64(reader.GetOrdinal("PTADemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaSentID"))) _visasentid = reader.GetInt64(reader.GetOrdinal("VisaSentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTIDate"))) _ptidate = reader.GetDateTime(reader.GetOrdinal("PTIDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTILetterDate"))) _ptiletterdate = reader.GetDateTime(reader.GetOrdinal("PTILetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PTILetterNo"))) _ptiletterno = reader.GetString(reader.GetOrdinal("PTILetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _letterstatus = reader.GetInt64(reader.GetOrdinal("LetterStatus"));
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
