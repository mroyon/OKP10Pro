using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_RepatriationInfoEntity:  BaseEntity
	{
		public static List<rpt_RepatriationInfoEntity> GetDetails()
		{
			List<rpt_RepatriationInfoEntity> coll = new List<rpt_RepatriationInfoEntity>();
			return coll;

		}
		protected Int64? _HrBasicID;
		protected Int64? _MilNoKW;
		protected DateTime? _JoinDateKw;
		protected String _MilNoBD;
		protected String _FullName;
		protected Int64? _RankIDKW;
		protected String _KW_Rank;
		protected Int64? _RankIDBD;
		protected String _BD_Rank;
		protected DateTime? _SODDate;
		protected DateTime? _FlightDate;
		protected DateTime? _SalaryReceivedTillDate;
		protected DateTime? _RewardAvailDate;
		protected String _TradeName;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Boolean? _InLeave;
		protected Int64? _LeaveTypeID;
		protected DateTime? _SODFromDate;
		protected DateTime? _SODToDate;
		protected DateTime? _FlightFromDate;
		protected DateTime? _FlightToDate;
		protected DateTime? _SalaryReceivedFromDate;
		protected DateTime? _SalaryReceivedToDate;
		protected DateTime? _RewardAvailFromDate;
		protected DateTime? _RewardAvailToDate;

		[DataMember]
		public Int64? HrBasicID
		{
			get { return _HrBasicID; }
			set {_HrBasicID=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public String MilNoBD
		{
			get { return _MilNoBD; }
			set {_MilNoBD=value; }
		}
		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
		}
		[DataMember]
		public Int64? RankIDKW
		{
			get { return _RankIDKW; }
			set {_RankIDKW=value; }
		}
		[DataMember]
		public String KW_Rank
		{
			get { return _KW_Rank; }
			set {_KW_Rank=value; }
		}
		[DataMember]
		public Int64? RankIDBD
		{
			get { return _RankIDBD; }
			set {_RankIDBD=value; }
		}
		[DataMember]
		public String BD_Rank
		{
			get { return _BD_Rank; }
			set {_BD_Rank=value; }
		}
		[DataMember]
		public DateTime? SODDate
		{
			get { return _SODDate; }
			set {_SODDate=value; }
		}
		[DataMember]
		public DateTime? FlightDate
		{
			get { return _FlightDate; }
			set {_FlightDate=value; }
		}
		[DataMember]
		public DateTime? SalaryReceivedTillDate
		{
			get { return _SalaryReceivedTillDate; }
			set {_SalaryReceivedTillDate=value; }
		}
		[DataMember]
		public DateTime? RewardAvailDate
		{
			get { return _RewardAvailDate; }
			set {_RewardAvailDate=value; }
		}
		[DataMember]
		public String TradeName
		{
			get { return _TradeName; }
			set {_TradeName=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public Boolean? InLeave
		{
			get { return _InLeave; }
			set {_InLeave=value; }
		}
		[DataMember]
		public Int64? LeaveTypeID
		{
			get { return _LeaveTypeID; }
			set {_LeaveTypeID=value; }
		}
		[DataMember]
		public DateTime? SODFromDate
		{
			get { return _SODFromDate; }
			set {_SODFromDate=value; }
		}
		[DataMember]
		public DateTime? SODToDate
		{
			get { return _SODToDate; }
			set {_SODToDate=value; }
		}
		[DataMember]
		public DateTime? FlightFromDate
		{
			get { return _FlightFromDate; }
			set {_FlightFromDate=value; }
		}
		[DataMember]
		public DateTime? FlightToDate
		{
			get { return _FlightToDate; }
			set {_FlightToDate=value; }
		}
		[DataMember]
		public DateTime? SalaryReceivedFromDate
		{
			get { return _SalaryReceivedFromDate; }
			set {_SalaryReceivedFromDate=value; }
		}
		[DataMember]
		public DateTime? SalaryReceivedToDate
		{
			get { return _SalaryReceivedToDate; }
			set {_SalaryReceivedToDate=value; }
		}
		[DataMember]
		public DateTime? RewardAvailFromDate
		{
			get { return _RewardAvailFromDate; }
			set {_RewardAvailFromDate=value; }
		}
		[DataMember]
		public DateTime? RewardAvailToDate
		{
			get { return _RewardAvailToDate; }
			set {_RewardAvailToDate=value; }
		}
		public rpt_RepatriationInfoEntity():base()
		{

		}

		public rpt_RepatriationInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KW_Rank"))) _KW_Rank = reader.GetString(reader.GetOrdinal("KW_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _RankIDBD = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("BD_Rank"))) _BD_Rank = reader.GetString(reader.GetOrdinal("BD_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("SODDate"))) _SODDate = reader.GetDateTime(reader.GetOrdinal("SODDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _FlightDate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("SalaryReceivedTillDate"))) _SalaryReceivedTillDate = reader.GetDateTime(reader.GetOrdinal("SalaryReceivedTillDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("RewardAvailDate"))) _RewardAvailDate = reader.GetDateTime(reader.GetOrdinal("RewardAvailDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
		}
	}
}

