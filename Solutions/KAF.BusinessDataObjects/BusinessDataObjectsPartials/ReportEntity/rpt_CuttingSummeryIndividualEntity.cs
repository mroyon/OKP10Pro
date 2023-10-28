using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_CuttingSummeryIndividualEntity:  BaseEntity
	{
		protected String _FullName;
		protected Int64? _MilNoKW;
		protected String _MilNoBD;
		protected String _RankName;
		protected String _OkpName;
		protected String _ItemName;
		protected DateTime? _JoinDateKw;
		protected DateTime? _SalaryReceivedTillDate;
		protected Decimal? _TotalGovtCutting;
		protected Decimal? _TotalPaidAmount;
		protected Decimal? _TotalUnPaidAmount;
		protected Decimal? _Rate;
		protected Int64? _MilitaryNoKW;
		protected Int64? _PayAllceID;

		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public String MilNoBD
		{
			get { return _MilNoBD; }
			set {_MilNoBD=value; }
		}
		[DataMember]
		public String RankName
		{
			get { return _RankName; }
			set {_RankName=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public String ItemName
		{
			get { return _ItemName; }
			set {_ItemName=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public DateTime? SalaryReceivedTillDate
		{
			get { return _SalaryReceivedTillDate; }
			set {_SalaryReceivedTillDate=value; }
		}
		[DataMember]
		public Decimal? TotalGovtCutting
		{
			get { return _TotalGovtCutting; }
			set {_TotalGovtCutting=value; }
		}
		[DataMember]
		public Decimal? TotalPaidAmount
		{
			get { return _TotalPaidAmount; }
			set {_TotalPaidAmount=value; }
		}
		[DataMember]
		public Decimal? TotalUnPaidAmount
		{
			get { return _TotalUnPaidAmount; }
			set {_TotalUnPaidAmount=value; }
		}
		[DataMember]
		public Decimal? Rate
		{
			get { return _Rate; }
			set {_Rate=value; }
		}
		[DataMember]
		public Int64? MilitaryNoKW
		{
			get { return _MilitaryNoKW; }
			set {_MilitaryNoKW=value; }
		}
		[DataMember]
		public Int64? PayAllceID
		{
			get { return _PayAllceID; }
			set {_PayAllceID=value; }
		}
		public rpt_CuttingSummeryIndividualEntity():base()
		{

		}

		public rpt_CuttingSummeryIndividualEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ItemName"))) _ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("SalaryReceivedTillDate"))) _SalaryReceivedTillDate = reader.GetDateTime(reader.GetOrdinal("SalaryReceivedTillDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalGovtCutting"))) _TotalGovtCutting = reader.GetDecimal(reader.GetOrdinal("TotalGovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalPaidAmount"))) _TotalPaidAmount = reader.GetDecimal(reader.GetOrdinal("TotalPaidAmount"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalUnPaidAmount"))) _TotalUnPaidAmount = reader.GetDecimal(reader.GetOrdinal("TotalUnPaidAmount"));
			if (!reader.IsDBNull(reader.GetOrdinal("Rate"))) _Rate = reader.GetDecimal(reader.GetOrdinal("Rate"));
		}
	}
}

