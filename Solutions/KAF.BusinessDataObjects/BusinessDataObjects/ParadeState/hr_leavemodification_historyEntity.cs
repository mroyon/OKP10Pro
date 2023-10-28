using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_leavemodification_historyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_leavemodification_historyEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hr_leavemodification_historyid;
        protected long ? _leavemodificationid;
        protected long ? _leaveinfoid;
        protected long ? _hrbasicid;
        protected long ? _leavetypeid;
        protected DateTime ? _modificationdate;
        protected DateTime ? _startdate;
        protected DateTime ? _enddate;
        protected long ? _noofdays;
        protected DateTime ? _leavestartdate;
        protected DateTime ? _leaveenddate;
        protected DateTime ? _leavedays;
        protected string _letterno;
        protected DateTime ? _letterdate;
        protected bool ? _withgovtticket;
        protected long ? _modificationtype;
        protected string _remarks;
                
        
        [DataMember]
        public long ? hr_leavemodification_historyid
        {
            get { return _hr_leavemodification_historyid; }
            set { _hr_leavemodification_historyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leavemodificationid", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leavemodificationidRequired")]
        public long ? leavemodificationid
        {
            get { return _leavemodificationid; }
            set { _leavemodificationid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leaveinfoid", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leaveinfoidRequired")]
        public long ? leaveinfoid
        {
            get { return _leaveinfoid; }
            set { _leaveinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leavetypeid", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leavetypeidRequired")]
        public long ? leavetypeid
        {
            get { return _leavetypeid; }
            set { _leavetypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "modificationdate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "modificationdateRequired")]
        public DateTime ? modificationdate
        {
            get { return _modificationdate; }
            set { _modificationdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "startdate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "startdateRequired")]
        public DateTime ? startdate
        {
            get { return _startdate; }
            set { _startdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "enddate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "enddateRequired")]
        public DateTime ? enddate
        {
            get { return _enddate; }
            set { _enddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "noofdays", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "noofdaysRequired")]
        public long ? noofdays
        {
            get { return _noofdays; }
            set { _noofdays = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leavestartdate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leavestartdateRequired")]
        public DateTime ? leavestartdate
        {
            get { return _leavestartdate; }
            set { _leavestartdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leaveenddate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leaveenddateRequired")]
        public DateTime ? leaveenddate
        {
            get { return _leaveenddate; }
            set { _leaveenddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "leavedays", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "leavedaysRequired")]
        public DateTime ? leavedays
        {
            get { return _leavedays; }
            set { _leavedays = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "letterno", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        public string letterno
        {
            get { return _letterno; }
            set { _letterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "letterdate", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        public DateTime ? letterdate
        {
            get { return _letterdate; }
            set { _letterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "withgovtticket", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "withgovtticketRequired")]
        public bool ? withgovtticket
        {
            get { return _withgovtticket; }
            set { _withgovtticket = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "modificationtype", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history), ErrorMessageResourceName = "modificationtypeRequired")]
        public long ? modificationtype
        {
            get { return _modificationtype; }
            set { _modificationtype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1100)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_leavemodification_history))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_leavemodification_historyEntity():base()
        {
        }
        
        public hr_leavemodification_historyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_leavemodification_historyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Hr_LeaveModification_HistoryID"))) _hr_leavemodification_historyid = reader.GetInt64(reader.GetOrdinal("Hr_LeaveModification_HistoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveModificationID"))) _leavemodificationid = reader.GetInt64(reader.GetOrdinal("LeaveModificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveInfoID"))) _leaveinfoid = reader.GetInt64(reader.GetOrdinal("LeaveInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveTypeID"))) _leavetypeid = reader.GetInt64(reader.GetOrdinal("LeaveTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModificationDate"))) _modificationdate = reader.GetDateTime(reader.GetOrdinal("ModificationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoOfDays"))) _noofdays = reader.GetInt64(reader.GetOrdinal("NoOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveStartDate"))) _leavestartdate = reader.GetDateTime(reader.GetOrdinal("LeaveStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveEndDate"))) _leaveenddate = reader.GetDateTime(reader.GetOrdinal("LeaveEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveDays"))) _leavedays = reader.GetDateTime(reader.GetOrdinal("LeaveDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("WithGovtTicket"))) _withgovtticket = reader.GetBoolean(reader.GetOrdinal("WithGovtTicket"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModificationType"))) _modificationtype = reader.GetInt64(reader.GetOrdinal("ModificationType"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("Hr_LeaveModification_HistoryID"))) _hr_leavemodification_historyid = reader.GetInt64(reader.GetOrdinal("Hr_LeaveModification_HistoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveModificationID"))) _leavemodificationid = reader.GetInt64(reader.GetOrdinal("LeaveModificationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveInfoID"))) _leaveinfoid = reader.GetInt64(reader.GetOrdinal("LeaveInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveTypeID"))) _leavetypeid = reader.GetInt64(reader.GetOrdinal("LeaveTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModificationDate"))) _modificationdate = reader.GetDateTime(reader.GetOrdinal("ModificationDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _startdate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _enddate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("NoOfDays"))) _noofdays = reader.GetInt64(reader.GetOrdinal("NoOfDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveStartDate"))) _leavestartdate = reader.GetDateTime(reader.GetOrdinal("LeaveStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveEndDate"))) _leaveenddate = reader.GetDateTime(reader.GetOrdinal("LeaveEndDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LeaveDays"))) _leavedays = reader.GetDateTime(reader.GetOrdinal("LeaveDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("WithGovtTicket"))) _withgovtticket = reader.GetBoolean(reader.GetOrdinal("WithGovtTicket"));
                if (!reader.IsDBNull(reader.GetOrdinal("ModificationType"))) _modificationtype = reader.GetInt64(reader.GetOrdinal("ModificationType"));
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
