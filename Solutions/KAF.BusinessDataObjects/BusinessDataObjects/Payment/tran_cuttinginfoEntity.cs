using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "tran_cuttinginfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_cuttinginfoEntity : BaseEntity
    {
        #region Properties
        public int? paymenttype { get; set; }
        protected long ? _cuttinginfoid;
        protected long? _payallceid;
        protected long ? _okpid;
        protected long ? _monthid;
        protected long ? _year;
        protected DateTime ? _processdate;
        protected bool ? _isreviewed;
        protected DateTime ? _reviewdate;
        protected long ? _reviewedby;
        protected string _reviewremarks;
        protected bool ? _isapproved;
        protected DateTime ? _approvedate;
        protected long ? _approveby;
        protected string _approveremarks;
        protected bool? _isrollback;
        protected DateTime? _rollbackdate;
        protected long? _rollbackby;
        protected string _rollbackremarks;
        protected bool? _isfinal;
        protected DateTime? _finaldate;
        protected long? _finalby;
        public bool? isReject { get; set; }
        public bool? isProcess { get; set; }

        [DataMember]
        public long? payallceid
        {
            get { return _payallceid; }
            set { _payallceid = value; this.OnChnaged(); }
        }
        [DataMember]
        public long ? cuttinginfoid
        {
            get { return _cuttinginfoid; }
            set { _cuttinginfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "okpid")]
        [Required(ErrorMessage= "OKP Required")]
        public long ? okpid
        {
            get { return _okpid; }
            set { _okpid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Month")]
        [Required(ErrorMessage= "Month Required")]
        public long ? monthid
        {
            get { return _monthid; }
            set { _monthid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Year")]
        [Required(ErrorMessage= "Year Required")]
        public long ? year
        {
            get { return _year; }
            set { _year = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Process Date")]
        [Required(ErrorMessage= "Process Date Required")]
        public DateTime ? processdate
        {
            get { return _processdate; }
            set { _processdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Is Reviewed")]
        public bool ? isreviewed
        {
            get { return _isreviewed; }
            set { _isreviewed = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Review Date")]
        public DateTime ? reviewdate
        {
            get { return _reviewdate; }
            set { _reviewdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Reviewed By")]
        public long ? reviewedby
        {
            get { return _reviewedby; }
            set { _reviewedby = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Is Reviewed")]
        public bool? isfinal
        {
            get { return _isfinal; }
            set { _isfinal = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Review Date")]
        public DateTime? finaldate
        {
            get { return _finaldate; }
            set { _finaldate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Reviewed By")]
        public long? finalby
        {
            get { return _finalby; }
            set { _finalby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "Review Remarks")]
        public string reviewremarks
        {
            get { return _reviewremarks; }
            set { _reviewremarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Is Approved")]
        public bool ? isapproved
        {
            get { return _isapproved; }
            set { _isapproved = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Approved Date")]
        public DateTime ? approvedate
        {
            get { return _approvedate; }
            set { _approvedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "Aapproved By")]
        public long ? approveby
        {
            get { return _approveby; }
            set { _approveby = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "Approve Remarks")]
        public string approveremarks
        {
            get { return _approveremarks; }
            set { _approveremarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Is Rollback")]
        public bool? isrollback
        {
            get { return _isrollback; }
            set { _isrollback = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Rollback Date")]
        public DateTime? rollbackdate
        {
            get { return _rollbackdate; }
            set { _rollbackdate = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "Rollback By")]
        public long? rollbackby
        {
            get { return _rollbackby; }
            set { _rollbackby = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "Rollback Remarks")]
        public string rollbackremarks
        {
            get { return _rollbackremarks; }
            set { _rollbackremarks = value; this.OnChnaged(); }
        }


        #endregion

        #region Constructor

        public tran_cuttinginfoEntity():base()
        {
        }
        
        public tran_cuttinginfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_cuttinginfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _cuttinginfoid = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayAllceID"))) _payallceid = reader.GetInt64(reader.GetOrdinal("PayAllceID"));

                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MonthID"))) _monthid = reader.GetInt64(reader.GetOrdinal("MonthID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Year"))) _year = reader.GetInt64(reader.GetOrdinal("Year"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _processdate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));

                if (!reader.IsDBNull(reader.GetOrdinal("IsRollback"))) _isrollback = reader.GetBoolean(reader.GetOrdinal("IsRollback"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackDate"))) _rollbackdate = reader.GetDateTime(reader.GetOrdinal("RollbackDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackBy"))) _rollbackby = reader.GetInt64(reader.GetOrdinal("RollbackBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("RollbackRemarks"))) _rollbackremarks = reader.GetString(reader.GetOrdinal("RollbackRemarks"));


                if (!reader.IsDBNull(reader.GetOrdinal("isfinal"))) _isfinal = reader.GetBoolean(reader.GetOrdinal("isfinal"));
                if (!reader.IsDBNull(reader.GetOrdinal("finaldate"))) _finaldate = reader.GetDateTime(reader.GetOrdinal("finaldate"));
                if (!reader.IsDBNull(reader.GetOrdinal("finalby"))) _finalby = reader.GetInt64(reader.GetOrdinal("finalby"));

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
                if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _cuttinginfoid = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PayAllceID"))) _payallceid = reader.GetInt64(reader.GetOrdinal("PayAllceID"));

                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MonthID"))) _monthid = reader.GetInt64(reader.GetOrdinal("MonthID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Year"))) _year = reader.GetInt64(reader.GetOrdinal("Year"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _processdate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _approveby = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));

                if (!reader.IsDBNull(reader.GetOrdinal("isfinal"))) _isfinal = reader.GetBoolean(reader.GetOrdinal("isfinal"));
                if (!reader.IsDBNull(reader.GetOrdinal("finaldate"))) _finaldate = reader.GetDateTime(reader.GetOrdinal("finaldate"));
                if (!reader.IsDBNull(reader.GetOrdinal("finalby"))) _finalby = reader.GetInt64(reader.GetOrdinal("finalby"));


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
