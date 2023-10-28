using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_ManpoewrStateEntity:  BaseEntity
	{

		public static List<rpt_ManpoewrStateEntity> GetDetails()
        {
			List<rpt_ManpoewrStateEntity> coll = new List<rpt_ManpoewrStateEntity>();
			return coll;


		}

		protected String _ManPowerStatus;
		protected String _FullName;
		protected String _RankName;
		protected String _OkpName;
		protected String _TradeName;
		protected String _RankType;
		protected DateTime? _ExpectedRetireDateKw;
		protected DateTime? _JoinDateKw;
		protected Int64? _MilNoKW;
		protected Int64? _ManpowerStatusID;
		protected Int64? _ManpowerStateID;
		protected Int64? _OkpID;
		protected DateTime? _ManpowerStateDate;
		protected DateTime? _Ex_Date1;
		protected DateTime? _Ex_Date2;
		protected String _Ex_Nvarchar1;
		protected String _Ex_Nvarchar2;
		protected Int64? _Ex_Bigint1;
		protected Int64? _Ex_Bigint2;
		protected Decimal? _Ex_Decimal1;
		protected Decimal? _Ex_Decimal2;
	

		[DataMember]
		public String ManPowerStatus
		{
			get { return _ManPowerStatus; }
			set {_ManPowerStatus=value; }
		}
		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
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
		public String TradeName
		{
			get { return _TradeName; }
			set {_TradeName=value; }
		}
		[DataMember]
		public String RankType
		{
			get { return _RankType; }
			set {_RankType=value; }
		}
		[DataMember]
		public DateTime? ExpectedRetireDateKw
		{
			get { return _ExpectedRetireDateKw; }
			set {_ExpectedRetireDateKw=value; }
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
		public Int64? ManpowerStatusID
		{
			get { return _ManpowerStatusID; }
			set {_ManpowerStatusID=value; }
		}
		[DataMember]
		public Int64? ManpowerStateID
		{
			get { return _ManpowerStateID; }
			set {_ManpowerStateID=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public DateTime? ManpowerStateDate
		{
			get { return _ManpowerStateDate; }
			set {_ManpowerStateDate=value; }
		}
		[DataMember]
		public DateTime? Ex_Date1
		{
			get { return _Ex_Date1; }
			set {_Ex_Date1=value; }
		}
		[DataMember]
		public DateTime? Ex_Date2
		{
			get { return _Ex_Date2; }
			set {_Ex_Date2=value; }
		}
		[DataMember]
		public String Ex_Nvarchar1
		{
			get { return _Ex_Nvarchar1; }
			set {_Ex_Nvarchar1=value; }
		}
		[DataMember]
		public String Ex_Nvarchar2
		{
			get { return _Ex_Nvarchar2; }
			set {_Ex_Nvarchar2=value; }
		}
		[DataMember]
		public Int64? Ex_Bigint1
		{
			get { return _Ex_Bigint1; }
			set {_Ex_Bigint1=value; }
		}
		[DataMember]
		public Int64? Ex_Bigint2
		{
			get { return _Ex_Bigint2; }
			set {_Ex_Bigint2=value; }
		}
		[DataMember]
		public Decimal? Ex_Decimal1
		{
			get { return _Ex_Decimal1; }
			set {_Ex_Decimal1=value; }
		}
		[DataMember]
		public Decimal? Ex_Decimal2
		{
			get { return _Ex_Decimal2; }
			set {_Ex_Decimal2=value; }
		}
		
		public rpt_ManpoewrStateEntity():base()
		{

		}

		public rpt_ManpoewrStateEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("ManPowerStatus"))) _ManPowerStatus = reader.GetString(reader.GetOrdinal("ManPowerStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankType"))) _RankType = reader.GetString(reader.GetOrdinal("RankType"));
			if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _ExpectedRetireDateKw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStatusID"))) _ManpowerStatusID = reader.GetInt64(reader.GetOrdinal("ManpowerStatusID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) _ManpowerStateID = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDate"))) _ManpowerStateDate = reader.GetDateTime(reader.GetOrdinal("ManpowerStateDate"));

		}
	}
}

