using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetRankByGroupEntity:  BaseEntity
	{
		protected Int64? _RankID;
		protected String _RankName;
		protected Int64? _RankTypeID;
		protected Int64? _GroupID;
		protected Int64? _RankSL;

		[DataMember]
		public Int64? RankID
		{
			get { return _RankID; }
			set {_RankID=value; }
		}
		[DataMember]
		public String RankName
		{
			get { return _RankName; }
			set {_RankName=value; }
		}
		[DataMember]
		public Int64? RankTypeID
		{
			get { return _RankTypeID; }
			set {_RankTypeID=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public Int64? RankSL
		{
			get { return _RankSL; }
			set {_RankSL=value; }
		}
		public KAF_GetRankByGroupEntity():base()
		{

		}

		public KAF_GetRankByGroupEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _RankID = reader.GetInt64(reader.GetOrdinal("RankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankTypeID"))) _RankTypeID = reader.GetInt64(reader.GetOrdinal("RankTypeID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankSL"))) _RankSL = reader.GetInt64(reader.GetOrdinal("RankSL"));
		}
	}
}

