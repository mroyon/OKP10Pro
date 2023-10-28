using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class tran_cuttinginfo_GAPgListView_ExtEntity:  BaseEntity
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
		protected String _ItemName;
		protected String _OkpName;
		protected String _month;
		protected Int64? _Total;
		protected Int64? _TotalPaid;
		protected Int64? _TotalNotPaid;
		protected decimal? _TotalPaidAmount;
		protected Int64? _RowNumber;
		protected String _CommonSerachParam;
		protected Int64? _TotalRecord;
		protected String _SortExpression;
		protected Int64? _PageSize;
		protected Int64? _CurrentPage;
		protected bool? _isrollback;
		protected DateTime? _rollbackdate;
		protected long? _rollbackby;
		protected string _rollbackremarks;
		protected bool? _isfinal;
		protected DateTime? _finaldate;
		protected long? _finalby;

		[DataMember]
		public Int64? CuttingInfoID
		{
			get { return _CuttingInfoID; }
			set { _CuttingInfoID = value; }
		}
		[DataMember]
		public Int64? PayAllceID
		{
			get { return _PayAllceID; }
			set { _PayAllceID = value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public Int64? MonthID
		{
			get { return _MonthID; }
			set {_MonthID=value; }
		}
		[DataMember]
		public Int64? Year
		{
			get { return _Year; }
			set {_Year=value; }
		}
		[DataMember]
		public DateTime? ProcessDate
		{
			get { return _ProcessDate; }
			set {_ProcessDate=value; }
		}
		[DataMember]
		
		public bool? isfinal
		{
			get { return _isfinal; }
			set { _isfinal = value; this.OnChnaged(); }
		}

		[DataMember]
		
		public DateTime? finaldate
		{
			get { return _finaldate; }
			set { _finaldate = value; this.OnChnaged(); }
		}

		[DataMember]
	
		public long? finalby
		{
			get { return _finalby; }
			set { _finalby = value; this.OnChnaged(); }
		}
		[DataMember]
		public Boolean? IsReviewed
		{
			get { return _IsReviewed; }
			set {_IsReviewed=value; }
		}
		[DataMember]
		public DateTime? ReviewDate
		{
			get { return _ReviewDate; }
			set {_ReviewDate=value; }
		}
		[DataMember]
		public Int64? ReviewedBy
		{
			get { return _ReviewedBy; }
			set {_ReviewedBy=value; }
		}
		[DataMember]
		public String ReviewRemarks
		{
			get { return _ReviewRemarks; }
			set {_ReviewRemarks=value; }
		}
		[DataMember]
		public Boolean? IsApproved
		{
			get { return _IsApproved; }
			set {_IsApproved=value; }
		}
		[DataMember]
		public DateTime? ApproveDate
		{
			get { return _ApproveDate; }
			set {_ApproveDate=value; }
		}
		[DataMember]
		public Int64? ApproveBy
		{
			get { return _ApproveBy; }
			set {_ApproveBy=value; }
		}
		[DataMember]
		public String ApproveRemarks
		{
			get { return _ApproveRemarks; }
			set {_ApproveRemarks=value; }
		}
		[DataMember]
		public String ItemName
		{
			get { return _ItemName; }
			set {_ItemName=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public String month
		{
			get { return _month; }
			set {_month=value; }
		}
		[DataMember]
		public Int64? Total
		{
			get { return _Total; }
			set {_Total=value; }
		}
		[DataMember]
		public Int64? TotalPaid
		{
			get { return _TotalPaid; }
			set {_TotalPaid=value; }
		}
		[DataMember]
		public decimal? TotalPaidAmount
		{
			get { return _TotalPaidAmount; }
			set { _TotalPaidAmount = value; }
		}
		
	   [DataMember]
		public Int64? TotalNotPaid
		{
			get { return _TotalNotPaid; }
			set {_TotalNotPaid=value; }
		}
		
		[DataMember]
		public String CommonSerachParam
		{
			get { return _CommonSerachParam; }
			set {_CommonSerachParam=value; }
		}


		[DataMember]
		
		public bool? isrollback
		{
			get { return _isrollback; }
			set { _isrollback = value; this.OnChnaged(); }
		}

		[DataMember]
		
		public DateTime? rollbackdate
		{
			get { return _rollbackdate; }
			set { _rollbackdate = value; this.OnChnaged(); }
		}

		[DataMember]
	
		public long? rollbackby
		{
			get { return _rollbackby; }
			set { _rollbackby = value; this.OnChnaged(); }
		}

		[DataMember]
		
		public string rollbackremarks
		{
			get { return _rollbackremarks; }
			set { _rollbackremarks = value; this.OnChnaged(); }
		}

		public tran_cuttinginfo_GAPgListView_ExtEntity():base()
		{

		}

		public tran_cuttinginfo_GAPgListView_ExtEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}
		

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("PayAllceID"))) _PayAllceID = reader.GetInt64(reader.GetOrdinal("PayAllceID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _CuttingInfoID = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MonthID"))) _MonthID = reader.GetInt64(reader.GetOrdinal("MonthID"));
			if (!reader.IsDBNull(reader.GetOrdinal("Year"))) _Year = reader.GetInt64(reader.GetOrdinal("Year"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _ProcessDate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _IsReviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _ReviewDate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _ReviewedBy = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _ReviewRemarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _IsApproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _ApproveDate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _ApproveBy = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _ApproveRemarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("ItemName"))) _ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("month"))) _month = reader.GetString(reader.GetOrdinal("month"));
			if (!reader.IsDBNull(reader.GetOrdinal("Total"))) _Total = reader.GetInt64(reader.GetOrdinal("Total"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalPaid"))) _TotalPaid = reader.GetInt64(reader.GetOrdinal("TotalPaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalNotPaid"))) _TotalNotPaid = reader.GetInt64(reader.GetOrdinal("TotalNotPaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalPaidAmount"))) _TotalPaidAmount = reader.GetDecimal(reader.GetOrdinal("TotalPaidAmount"));
			if (!reader.IsDBNull(reader.GetOrdinal("isfinal"))) _isfinal = reader.GetBoolean(reader.GetOrdinal("isfinal"));
			if (!reader.IsDBNull(reader.GetOrdinal("finaldate"))) _finaldate = reader.GetDateTime(reader.GetOrdinal("finaldate"));
			if (!reader.IsDBNull(reader.GetOrdinal("finalby"))) _finalby = reader.GetInt64(reader.GetOrdinal("finalby"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsRollback"))) _isrollback = reader.GetBoolean(reader.GetOrdinal("IsRollback"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollbackDate"))) _rollbackdate = reader.GetDateTime(reader.GetOrdinal("RollbackDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollbackBy"))) _rollbackby = reader.GetInt64(reader.GetOrdinal("RollbackBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollbackRemarks"))) _rollbackremarks = reader.GetString(reader.GetOrdinal("RollbackRemarks"));

		}
	}
}

