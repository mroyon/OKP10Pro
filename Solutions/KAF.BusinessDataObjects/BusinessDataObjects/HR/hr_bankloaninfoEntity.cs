using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_bankloaninfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_bankloaninfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrbankloanid;
        protected long ? _hrbasicid;
        protected long ? _bankid;
        protected long ? _branchid;
        protected decimal ? _loanamount;
        protected DateTime ? _lastpaiddate;
        protected bool ? _islastinstallmentpaid;
        protected string _description;
        protected string _remarks;
        protected int ? _forreview;
                
        
        [DataMember]
        public long ? hrbankloanid
        {
            get { return _hrbankloanid; }
            set { _hrbankloanid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bankid", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo), ErrorMessageResourceName = "bankidRequired")]
        public long ? bankid
        {
            get { return _bankid; }
            set { _bankid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "branchid", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo), ErrorMessageResourceName = "branchidRequired")]
        public long ? branchid
        {
            get { return _branchid; }
            set { _branchid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "loanamount", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo), ErrorMessageResourceName = "loanamountRequired")]
        public decimal ? loanamount
        {
            get { return _loanamount; }
            set { _loanamount = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "lastpaiddate", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo), ErrorMessageResourceName = "lastpaiddateRequired")]
        public DateTime ? lastpaiddate
        {
            get { return _lastpaiddate; }
            set { _lastpaiddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "islastinstallmentpaid", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        public bool ? islastinstallmentpaid
        {
            get { return _islastinstallmentpaid; }
            set { _islastinstallmentpaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "description", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_bankloaninfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_bankloaninfoEntity():base()
        {
        }
        
        public hr_bankloaninfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_bankloaninfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrBankLoanID"))) _hrbankloanid = reader.GetInt64(reader.GetOrdinal("HrBankLoanID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BankID"))) _bankid = reader.GetInt64(reader.GetOrdinal("BankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BranchID"))) _branchid = reader.GetInt64(reader.GetOrdinal("BranchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoanAmount"))) _loanamount = reader.GetDecimal(reader.GetOrdinal("LoanAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPaidDate"))) _lastpaiddate = reader.GetDateTime(reader.GetOrdinal("LastPaidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsLastInstallmentPaid"))) _islastinstallmentpaid = reader.GetBoolean(reader.GetOrdinal("IsLastInstallmentPaid"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("HrBankLoanID"))) _hrbankloanid = reader.GetInt64(reader.GetOrdinal("HrBankLoanID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BankID"))) _bankid = reader.GetInt64(reader.GetOrdinal("BankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BranchID"))) _branchid = reader.GetInt64(reader.GetOrdinal("BranchID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LoanAmount"))) _loanamount = reader.GetDecimal(reader.GetOrdinal("LoanAmount"));
                if (!reader.IsDBNull(reader.GetOrdinal("LastPaidDate"))) _lastpaiddate = reader.GetDateTime(reader.GetOrdinal("LastPaidDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsLastInstallmentPaid"))) _islastinstallmentpaid = reader.GetBoolean(reader.GetOrdinal("IsLastInstallmentPaid"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
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
