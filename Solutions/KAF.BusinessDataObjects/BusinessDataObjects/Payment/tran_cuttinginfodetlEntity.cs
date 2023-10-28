using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "tran_cuttinginfodetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_cuttinginfodetlEntity : BaseEntity
    {
        #region Properties
        public int? paymenttype { get; set; }
        protected long? _cuttinginfodetlid;
        protected long? _cuttinginfoid;
        protected long? _hrbasicid;
        protected long? _rankid;
        protected long? _groupid;
        protected DateTime? _processdate;
        protected decimal? _prevbalgovtcutting;
        protected decimal? _prevbalregcutting;
        protected decimal? _basicsalary;
        protected decimal? _regimentalcutting;
        protected decimal? _govtcutting;
        protected string _remarks;
        protected bool? _ispaid;
        protected DateTime? _paiddate;
        protected long? _paidby;
        protected string _unpaidremarks;
        protected bool? _isreviewed;
        protected DateTime? _reviewdate;
        protected long? _reviewedby;
        protected string _reviewremarks;
        protected bool? _isapprove;
        protected DateTime? _approvedate;
        protected long? _approveby;
        protected string _approveremarks;
        protected bool? _isrollback;
        protected long? _rollbackby;
        protected DateTime? _rollbackdate;
        protected string _rollbackremarks;

        [DataMember]

        [Required(ErrorMessage = "Groupid Required")]
        public long? groupid
        {
            get { return _groupid; }
            set { _groupid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? cuttinginfodetlid
        {
            get { return _cuttinginfodetlid; }
            set { _cuttinginfodetlid = value; this.OnChnaged(); }
        }

        [DataMember]

        [Required(ErrorMessage = "Cuttinginfoid Required")]
        public long? cuttinginfoid
        {
            get { return _cuttinginfoid; }
            set { _cuttinginfoid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "hrbasicid")]
        [Required(ErrorMessage = "hrbasicidRequired")]
        public long? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "rankid")]
        [Required(ErrorMessage = "rankidRequired")]
        public long? rankid
        {
            get { return _rankid; }
            set { _rankid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "processdate")]
        [Required(ErrorMessage = "processdateRequired")]
        public DateTime? processdate
        {
            get { return _processdate; }
            set { _processdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "prevbalgovtcutting")]
        public decimal? prevbalgovtcutting
        {
            get { return _prevbalgovtcutting; }
            set { _prevbalgovtcutting = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "prevbalregcutting")]
        public decimal? prevbalregcutting
        {
            get { return _prevbalregcutting; }
            set { _prevbalregcutting = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "basicsalary")]
        [Required(ErrorMessage = "basicsalaryRequired")]
        public decimal? basicsalary
        {
            get { return _basicsalary; }
            set { _basicsalary = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "regimentalcutting")]
        [Required(ErrorMessage = "regimentalcuttingRequired")]
        public decimal? regimentalcutting
        {
            get { return _regimentalcutting; }
            set { _regimentalcutting = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "govtcutting")]
        [Required(ErrorMessage = "govtcuttingRequired")]
        public decimal? govtcutting
        {
            get { return _govtcutting; }
            set { _govtcutting = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks")]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "ispaid")]
        public bool? ispaid
        {
            get { return _ispaid; }
            set { _ispaid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "paiddate")]
        public DateTime? paiddate
        {
            get { return _paiddate; }
            set { _paiddate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "paidby")]
        public long? paidby
        {
            get { return _paidby; }
            set { _paidby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "unpaidremarks")]
        public string unpaidremarks
        {
            get { return _unpaidremarks; }
            set { _unpaidremarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isreviewed")]
        public bool? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewdate")]
        public DateTime? reviewdate
        {
            get { return _reviewdate; }
            set { _reviewdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "reviewedby")]
        public long? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(250)]
        [Display(Name = "reviewremarks")]
        public string reviewremarks
        {
            get { return _reviewremarks; }
            set { _reviewremarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isapprove")]
        public bool? isapprove
        {
            get { return _isapprove; }
            set { _isapprove = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approvedate")]
        public DateTime? approvedate
        {
            get { return _approvedate; }
            set { _approvedate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "approveby")]
        public long? approveby
        {
            get { return _approveby; }
            set { _approveby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "approveremarks")]
        public string approveremarks
        {
            get { return _approveremarks; }
            set { _approveremarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "isrollback")]
        public bool? isrollback
        {
            get { return _isrollback; }
            set { _isrollback = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "rollbackby")]
        public long? rollbackby
        {
            get { return _rollbackby; }
            set { _rollbackby = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "rollbackdate")]
        public DateTime? rollbackdate
        {
            get { return _rollbackdate; }
            set { _rollbackdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "rollbackremarks")]
        public string rollbackremarks
        {
            get { return _rollbackremarks; }
            set { _rollbackremarks = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public tran_cuttinginfodetlEntity() : base()
        {
        }

        public tran_cuttinginfodetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public tran_cuttinginfodetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoDetlID"))) _cuttinginfodetlid = reader.GetInt64(reader.GetOrdinal("CuttingInfoDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _cuttinginfoid = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _processdate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevBalGovtCutting"))) _prevbalgovtcutting = reader.GetDecimal(reader.GetOrdinal("PrevBalGovtCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevBalRegCutting"))) _prevbalregcutting = reader.GetDecimal(reader.GetOrdinal("PrevBalRegCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _basicsalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegimentalCutting"))) _regimentalcutting = reader.GetDecimal(reader.GetOrdinal("RegimentalCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("GovtCutting"))) _govtcutting = reader.GetDecimal(reader.GetOrdinal("GovtCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPaid"))) _ispaid = reader.GetBoolean(reader.GetOrdinal("IsPaid"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaidDate"))) _paiddate = reader.GetDateTime(reader.GetOrdinal("PaidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaidBy"))) _paidby = reader.GetInt64(reader.GetOrdinal("PaidBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnPaidRemarks"))) _unpaidremarks = reader.GetString(reader.GetOrdinal("UnPaidRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApprove"))) _isapprove = reader.GetBoolean(reader.GetOrdinal("IsApprove"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRollBack"))) _isrollback = reader.GetBoolean(reader.GetOrdinal("IsRollBack"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackBy"))) _rollbackby = reader.GetInt64(reader.GetOrdinal("RollbackBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollBackDate"))) _rollbackdate = reader.GetDateTime(reader.GetOrdinal("RollBackDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollBackRemarks"))) _rollbackremarks = reader.GetString(reader.GetOrdinal("RollBackRemarks"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoDetlID"))) _cuttinginfodetlid = reader.GetInt64(reader.GetOrdinal("CuttingInfoDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _cuttinginfoid = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _processdate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevBalGovtCutting"))) _prevbalgovtcutting = reader.GetDecimal(reader.GetOrdinal("PrevBalGovtCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("PrevBalRegCutting"))) _prevbalregcutting = reader.GetDecimal(reader.GetOrdinal("PrevBalRegCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _basicsalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegimentalCutting"))) _regimentalcutting = reader.GetDecimal(reader.GetOrdinal("RegimentalCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("GovtCutting"))) _govtcutting = reader.GetDecimal(reader.GetOrdinal("GovtCutting"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsPaid"))) _ispaid = reader.GetBoolean(reader.GetOrdinal("IsPaid"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaidDate"))) _paiddate = reader.GetDateTime(reader.GetOrdinal("PaidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PaidBy"))) _paidby = reader.GetInt64(reader.GetOrdinal("PaidBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnPaidRemarks"))) _unpaidremarks = reader.GetString(reader.GetOrdinal("UnPaidRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApprove"))) _isapprove = reader.GetBoolean(reader.GetOrdinal("IsApprove"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsRollBack"))) _isrollback = reader.GetBoolean(reader.GetOrdinal("IsRollBack"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackBy"))) _rollbackby = reader.GetInt64(reader.GetOrdinal("RollbackBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollBackDate"))) _rollbackdate = reader.GetDateTime(reader.GetOrdinal("RollBackDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollBackRemarks"))) _rollbackremarks = reader.GetString(reader.GetOrdinal("RollBackRemarks"));
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
