using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.ComponentModel.DataAnnotations;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    [Serializable]
    public class KAF_CuttingInsertEntity : BaseEntity
    {
        protected Int64? _CuttingInfoID;
        protected Int64? _PayAllceID;
        protected Int64? _OkpID;
        protected Int64? _MonthID;
        protected Int64? _Year;
        protected DateTime? _ProcessDate;
        protected Boolean? _IsReviewed;
        protected DateTime? _ReviewDate;
        protected Int64? _ReviewedBy;
        protected String _ReviewRemarks;
        protected Boolean? _IsApproved;
        protected DateTime? _ApproveDate;
        protected Int64? _ApproveBy;
        protected String _ApproveRemarks;
        protected String _Remarks;

        protected Int64? _PaidBy;
        protected String _UnPaidRemarks;

        protected Int64? _MilNoKW;
        protected Int64? _RankID;
        protected Int64? _GroupID;

        [DataMember]
        public Int64? MilNoKW
        {
            get { return _MilNoKW; }
            set { _MilNoKW = value; }
        }
        [DataMember]
        public Int64? RankID
        {
            get { return _RankID; }
            set { _RankID = value; }
        }
        [DataMember]
        public Int64? GroupID
        {
            get { return _GroupID; }
            set { _GroupID = value; }
        }

        [DataMember]
        [Required]
        public Int64? PayAllceID
        {
            get { return _PayAllceID; }
            set { _PayAllceID = value; }
        }
        [DataMember]
        public Int64? CuttingInfoID
        {
            get { return _CuttingInfoID; }
            set { _CuttingInfoID = value; }
        }
        [DataMember]
        [Required]
        public Int64? OkpID
        {
            get { return _OkpID; }
            set { _OkpID = value; }
        }
        [DataMember]
        [Required]
        public Int64? MonthID
        {
            get { return _MonthID; }
            set { _MonthID = value; }
        }
        [DataMember]
        [Required]
        public Int64? Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        [DataMember]
        [Required]
        public DateTime? ProcessDate
        {
            get { return _ProcessDate; }
            set { _ProcessDate = value; }
        }
        [DataMember]
        public Boolean? IsReviewed
        {
            get { return _IsReviewed; }
            set { _IsReviewed = value; }
        }
        [DataMember]
        public DateTime? ReviewDate
        {
            get { return _ReviewDate; }
            set { _ReviewDate = value; }
        }
        [DataMember]
        public Int64? ReviewedBy
        {
            get { return _ReviewedBy; }
            set { _ReviewedBy = value; }
        }
        [DataMember]
        public String ReviewRemarks
        {
            get { return _ReviewRemarks; }
            set { _ReviewRemarks = value; }
        }
        [DataMember]
        public Boolean? IsApproved
        {
            get { return _IsApproved; }
            set { _IsApproved = value; }
        }
        [DataMember]
        public DateTime? ApproveDate
        {
            get { return _ApproveDate; }
            set { _ApproveDate = value; }
        }
        [DataMember]
        public Int64? ApproveBy
        {
            get { return _ApproveBy; }
            set { _ApproveBy = value; }
        }
        [DataMember]
        public String ApproveRemarks
        {
            get { return _ApproveRemarks; }
            set { _ApproveRemarks = value; }
        }
        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64? PaidBy
        {
            get { return _PaidBy; }
            set { _PaidBy = value; }
        }
        [DataMember]
        public String UnPaidRemarks
        {
            get { return _UnPaidRemarks; }
            set { _UnPaidRemarks = value; }
        }

        public KAF_CuttingInsertEntity() : base()
        {

        }

        public KAF_CuttingInsertEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
        }
    }
}

