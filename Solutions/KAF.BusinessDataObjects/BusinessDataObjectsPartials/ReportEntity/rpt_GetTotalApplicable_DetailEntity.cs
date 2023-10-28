using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_GetTotalApplicable_DetailEntity:  BaseEntity
	{
		protected Int64? _HRBasicID;
		protected DateTime? _JoinDateKw;
		protected Int64? _MilNoKW;
		protected Int64? _RankID;
		protected Int64? _GroupID;
		protected Int32? _BasicSalary;
		protected Decimal? _GovtCutting;
		protected Int32? _RegimentalCutting;
		protected Decimal? _PrevBalRegCutting;

		protected Int64? _OKPID;
		protected Int64? _PayAllceID;
		protected DateTime? _ProcessDate;

		[DataMember]
		public Int64? HRBasicID
		{
			get { return _HRBasicID; }
			set {_HRBasicID=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public Int64? RankID
		{
			get { return _RankID; }
			set {_RankID=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public Int32? BasicSalary
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
		public Int32? RegimentalCutting
		{
			get { return _RegimentalCutting; }
			set {_RegimentalCutting=value; }
		}
		[DataMember]
		public Decimal? PrevBalRegCutting
		{
			get { return _PrevBalRegCutting; }
			set {_PrevBalRegCutting=value; }
		}
		
		[DataMember]
		public Int64? OKPID
		{
			get { return _OKPID; }
			set {_OKPID=value; }
		}
		[DataMember]
		public Int64? PayAllceID
		{
			get { return _PayAllceID; }
			set {_PayAllceID=value; }
		}
		[DataMember]
		public DateTime? ProcessDate
		{
			get { return _ProcessDate; }
			set {_ProcessDate=value; }
		}
		public rpt_GetTotalApplicable_DetailEntity():base()
		{

		}

		public rpt_GetTotalApplicable_DetailEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _HRBasicID = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _RankID = reader.GetInt64(reader.GetOrdinal("RankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _BasicSalary = reader.GetInt32(reader.GetOrdinal("BasicSalary"));
			if (!reader.IsDBNull(reader.GetOrdinal("GovtCutting"))) _GovtCutting = reader.GetDecimal(reader.GetOrdinal("GovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("RegimentalCutting"))) _RegimentalCutting = reader.GetInt32(reader.GetOrdinal("RegimentalCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevBalRegCutting"))) _PrevBalRegCutting = reader.GetDecimal(reader.GetOrdinal("PrevBalRegCutting"));
			}
	}
}

