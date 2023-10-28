using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_DeploymentStateEntity:  BaseEntity
	{
		public static List<rpt_DeploymentStateEntity> GetDetails()
		{
			List<rpt_DeploymentStateEntity> coll = new List<rpt_DeploymentStateEntity>();
			return coll;
		}
		protected Int64? _MilNoKW;
		protected String _FullName;
		protected String _RankName;
		protected String _TradeName;
		protected DateTime? _JoinDateKw;
		protected String _FromCamp;
		protected String _FromSubUNit;
		protected String _ToCamp;
		protected String _ToSubUNit;
		protected String _OkpName;
		protected Int64? _OkpID;
		protected Boolean? _IsDeployed;
		protected Int64? _DeployedSubUNitID;
		protected Int64? _DeployedCampID;

		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
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
		public String TradeName
		{
			get { return _TradeName; }
			set {_TradeName=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public String FromCamp
		{
			get { return _FromCamp; }
			set {_FromCamp=value; }
		}
		[DataMember]
		public String FromSubUNit
		{
			get { return _FromSubUNit; }
			set {_FromSubUNit=value; }
		}
		[DataMember]
		public String ToCamp
		{
			get { return _ToCamp; }
			set {_ToCamp=value; }
		}
		[DataMember]
		public String ToSubUNit
		{
			get { return _ToSubUNit; }
			set {_ToSubUNit=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public Boolean? IsDeployed
		{
			get { return _IsDeployed; }
			set {_IsDeployed=value; }
		}
		[DataMember]
		public Int64? DeployedSubUNitID
		{
			get { return _DeployedSubUNitID; }
			set {_DeployedSubUNitID=value; }
		}
		[DataMember]
		public Int64? DeployedCampID
		{
			get { return _DeployedCampID; }
			set {_DeployedCampID=value; }
		}
		public rpt_DeploymentStateEntity():base()
		{

		}

		public rpt_DeploymentStateEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("FromCamp"))) _FromCamp = reader.GetString(reader.GetOrdinal("FromCamp"));
			if (!reader.IsDBNull(reader.GetOrdinal("FromSubUNit"))) _FromSubUNit = reader.GetString(reader.GetOrdinal("FromSubUNit"));
			if (!reader.IsDBNull(reader.GetOrdinal("ToCamp"))) _ToCamp = reader.GetString(reader.GetOrdinal("ToCamp"));
			if (!reader.IsDBNull(reader.GetOrdinal("ToSubUNit"))) _ToSubUNit = reader.GetString(reader.GetOrdinal("ToSubUNit"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
		}
	}
}

