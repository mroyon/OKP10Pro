using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_GetCuttingInfoEntity:  BaseEntity
	{
		protected Int64? _OkpID;
		protected Int64? _CuttingInfoDetlID;
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
		protected String _OkpName;
		protected String _Month;
		protected Int64? _MilNoKW;
		protected String _PassportNo;
		protected DateTime? _JoinDateKw;
		protected DateTime? _ExpectedRetireDateKw;
		protected Int64? _GroupID;
		protected String _RankName;
		protected String _RankType;
		protected String _FullName;
		protected Int64? _CivilID;
		protected Decimal? _PrevBalGovtCutting;
		
		protected Decimal? _BasicSalary;
		protected Decimal? _GovtCutting;
		
		protected String _Remarks;
		protected Boolean? _IsPaid;
		protected DateTime? _PaidDate;
		protected String _UnPaidRemarks;
		protected Int64? _cuttingid;
		protected String _ItemName;
		protected Decimal? _Total;

		public long? PayAllceID { get; set; }

		public long? okpsequesnce { get; set; }


		[DataMember]
		public String ItemName
		{
			get { return _ItemName; }
			set { _ItemName = value; }
		}
		[DataMember]
		public Decimal? Total
		{
			get { return _Total; }
			set { _Total = value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set { _OkpID = value; }
		}
		[DataMember]
		public Int64? CuttingInfoDetlID
		{
			get { return _CuttingInfoDetlID; }
			set { _CuttingInfoDetlID = value; }
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
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public String Month
		{
			get { return _Month; }
			set {_Month=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public String PassportNo
		{
			get { return _PassportNo; }
			set {_PassportNo=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public DateTime? ExpectedRetireDateKw
		{
			get { return _ExpectedRetireDateKw; }
			set {_ExpectedRetireDateKw=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public String RankName
		{
			get { return _RankName; }
			set {_RankName=value; }
		}
		[DataMember]
		public String RankType
		{
			get { return _RankType; }
			set {_RankType=value; }
		}
		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
		}
		[DataMember]
		public Int64? CivilID
		{
			get { return _CivilID; }
			set {_CivilID=value; }
		}
		[DataMember]
		public Decimal? PrevBalGovtCutting
		{
			get { return _PrevBalGovtCutting; }
			set {_PrevBalGovtCutting=value; }
		}
		
		[DataMember]
		public Decimal? BasicSalary
		{
			get { return _BasicSalary; }
			set {_BasicSalary=value; }
		}
		[DataMember]
		public Decimal? GovtCutting
		{
			get { return _GovtCutting; }
			set {_GovtCutting=value; }
		}
		
		[DataMember]
		public String Remarks
		{
			get { return _Remarks; }
			set {_Remarks=value; }
		}
		[DataMember]
		public Boolean? IsPaid
		{
			get { return _IsPaid; }
			set {_IsPaid=value; }
		}
		[DataMember]
		public DateTime? PaidDate
		{
			get { return _PaidDate; }
			set {_PaidDate=value; }
		}
		[DataMember]
		public String UnPaidRemarks
		{
			get { return _UnPaidRemarks; }
			set {_UnPaidRemarks=value; }
		}
		[DataMember]
		public Int64? cuttingid
		{
			get { return _cuttingid; }
			set {_cuttingid=value; }
		}
		public rpt_GetCuttingInfoEntity():base()
		{

		}

		public rpt_GetCuttingInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoDetlID"))) _CuttingInfoDetlID = reader.GetInt64(reader.GetOrdinal("CuttingInfoDetlID"));
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
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("Month"))) _Month = reader.GetString(reader.GetOrdinal("Month"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _ExpectedRetireDateKw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankType"))) _RankType = reader.GetString(reader.GetOrdinal("RankType"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _CivilID = reader.GetInt64(reader.GetOrdinal("CivilID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevBalGovtCutting"))) _PrevBalGovtCutting = reader.GetDecimal(reader.GetOrdinal("PrevBalGovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _BasicSalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
			if (!reader.IsDBNull(reader.GetOrdinal("GovtCutting"))) _GovtCutting = reader.GetDecimal(reader.GetOrdinal("GovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsPaid"))) _IsPaid = reader.GetBoolean(reader.GetOrdinal("IsPaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("PaidDate"))) _PaidDate = reader.GetDateTime(reader.GetOrdinal("PaidDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("UnPaidRemarks"))) _UnPaidRemarks = reader.GetString(reader.GetOrdinal("UnPaidRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("ItemName"))) _ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
			if (!reader.IsDBNull(reader.GetOrdinal("okpsequesnce"))) okpsequesnce = reader.GetInt64(reader.GetOrdinal("okpsequesnce"));

			if (!reader.IsDBNull(reader.GetOrdinal("Total"))) _Total = reader.GetDecimal(reader.GetOrdinal("Total"));

		}
	}
}

