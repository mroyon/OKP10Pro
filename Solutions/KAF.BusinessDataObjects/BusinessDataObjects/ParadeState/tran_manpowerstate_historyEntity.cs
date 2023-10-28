using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "tran_manpowerstate_historyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_manpowerstate_historyEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _tran_manpowerstate_historyid;
        protected long ? _manpowerstateid;
        protected long ? _okpid;
        protected DateTime ? _manpowerstatedate;
        protected bool ? _isprepared;
        protected DateTime ? _prepareddate;
        protected long ? _preparedby;
        protected bool ? _isreviewed;
        protected DateTime ? _reviewdate;
        protected long ? _reviewedby;
        protected string _reviewremarks;
        protected bool ? _isapproved;
        protected DateTime ? _approvedate;
        protected long ? _approveby;
        protected string _approveremarks;
                
        
        [DataMember]
        public long ? tran_manpowerstate_historyid
        {
            get { return _tran_manpowerstate_historyid; }
            set { _tran_manpowerstate_historyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "manpowerstateid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history), ErrorMessageResourceName = "manpowerstateidRequired")]
        public long ? manpowerstateid
        {
            get { return _manpowerstateid; }
            set { _manpowerstateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "okpid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history), ErrorMessageResourceName = "okpidRequired")]
        public long ? okpid
        {
            get { return _okpid; }
            set { _okpid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "manpowerstatedate", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history), ErrorMessageResourceName = "manpowerstatedateRequired")]
        public DateTime ? manpowerstatedate
        {
            get { return _manpowerstatedate; }
            set { _manpowerstatedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isprepared", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public bool ? isprepared
        {
            get { return _isprepared; }
            set { _isprepared = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "prepareddate", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public DateTime ? prepareddate
        {
            get { return _prepareddate; }
            set { _prepareddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "preparedby", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public long ? preparedby
        {
            get { return _preparedby; }
            set { _preparedby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isreviewed", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public bool ? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reviewdate", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public DateTime ? reviewdate
        {
            get { return _reviewdate; }
            set { _reviewdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "reviewedby", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public long ? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1100)]
        [Display(Name = "reviewremarks", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public string reviewremarks
        {
            get { return _reviewremarks; }
            set { _reviewremarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isapproved", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public bool ? isapproved
        {
            get { return _isapproved; }
            set { _isapproved = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "approvedate", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public DateTime ? approvedate
        {
            get { return _approvedate; }
            set { _approvedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "approveby", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public long ? approveby
        {
            get { return _approveby; }
            set { _approveby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(1100)]
        [Display(Name = "approveremarks", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstate_history))]
        public string approveremarks
        {
            get { return _approveremarks; }
            set { _approveremarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_manpowerstate_historyEntity():base()
        {
        }
        
        public tran_manpowerstate_historyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_manpowerstate_historyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("Tran_ManpowerState_HistoryID"))) _tran_manpowerstate_historyid = reader.GetInt64(reader.GetOrdinal("Tran_ManpowerState_HistoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) _manpowerstateid = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDate"))) _manpowerstatedate = reader.GetDateTime(reader.GetOrdinal("ManpowerStateDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrepared"))) _isprepared = reader.GetBoolean(reader.GetOrdinal("IsPrepared"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreparedDate"))) _prepareddate = reader.GetDateTime(reader.GetOrdinal("PreparedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreparedBy"))) _preparedby = reader.GetInt64(reader.GetOrdinal("PreparedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("Tran_ManpowerState_HistoryID"))) _tran_manpowerstate_historyid = reader.GetInt64(reader.GetOrdinal("Tran_ManpowerState_HistoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) _manpowerstateid = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDate"))) _manpowerstatedate = reader.GetDateTime(reader.GetOrdinal("ManpowerStateDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPrepared"))) _isprepared = reader.GetBoolean(reader.GetOrdinal("IsPrepared"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreparedDate"))) _prepareddate = reader.GetDateTime(reader.GetOrdinal("PreparedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PreparedBy"))) _preparedby = reader.GetInt64(reader.GetOrdinal("PreparedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
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
