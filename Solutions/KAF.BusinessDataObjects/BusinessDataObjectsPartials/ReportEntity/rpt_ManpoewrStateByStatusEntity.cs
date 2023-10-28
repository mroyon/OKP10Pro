using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_ManpoewrStateByStatusEntity:  BaseEntity
	{
		protected String _FullName;
		protected Int64? _MilNoKW;
		protected String _RankName;
		protected String _OkpName;
		protected DateTime? _ManpowerStateDate;
		protected String _SubUnit;
		protected String _CampName;
		protected String _ManPowerStatus;
		protected Boolean? _IsPrepared;
		protected Int64? _PreparedBy;
		protected DateTime? _PreparedDate;
		protected Boolean? _IsReviewed;
		protected Int64? _ReviewedBy;
		protected DateTime? _ReviewDate;
		protected String _ReviewRemarks;
		protected Boolean? _IsApproved;
		protected Int64? _ApproveBy;
		protected DateTime? _ApproveDate;
		protected String _ApproveRemarks;
		protected Int64? _ManpowerStateID;
		protected Int64? _ManpowerStatusID;
		

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
		public DateTime? ManpowerStateDate
		{
			get { return _ManpowerStateDate; }
			set {_ManpowerStateDate=value; }
		}
		[DataMember]
		public String SubUnit
		{
			get { return _SubUnit; }
			set {_SubUnit=value; }
		}
		[DataMember]
		public String CampName
		{
			get { return _CampName; }
			set {_CampName=value; }
		}
		[DataMember]
		public String ManPowerStatus
		{
			get { return _ManPowerStatus; }
			set {_ManPowerStatus=value; }
		}
		[DataMember]
		public Boolean? IsPrepared
		{
			get { return _IsPrepared; }
			set {_IsPrepared=value; }
		}
		[DataMember]
		public Int64? PreparedBy
		{
			get { return _PreparedBy; }
			set {_PreparedBy=value; }
		}
		[DataMember]
		public DateTime? PreparedDate
		{
			get { return _PreparedDate; }
			set {_PreparedDate=value; }
		}
		[DataMember]
		public Boolean? IsReviewed
		{
			get { return _IsReviewed; }
			set {_IsReviewed=value; }
		}
		[DataMember]
		public Int64? ReviewedBy
		{
			get { return _ReviewedBy; }
			set {_ReviewedBy=value; }
		}
		[DataMember]
		public DateTime? ReviewDate
		{
			get { return _ReviewDate; }
			set {_ReviewDate=value; }
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
		public Int64? ApproveBy
		{
			get { return _ApproveBy; }
			set {_ApproveBy=value; }
		}
		[DataMember]
		public DateTime? ApproveDate
		{
			get { return _ApproveDate; }
			set {_ApproveDate=value; }
		}
		[DataMember]
		public String ApproveRemarks
		{
			get { return _ApproveRemarks; }
			set {_ApproveRemarks=value; }
		}
		[DataMember]
		public Int64? ManpowerStateID
		{
			get { return _ManpowerStateID; }
			set {_ManpowerStateID=value; }
		}
		[DataMember]
		public Int64? ManpowerStatusID
		{
			get { return _ManpowerStatusID; }
			set {_ManpowerStatusID=value; }
		}
		
		public rpt_ManpoewrStateByStatusEntity():base()
		{

		}

		public rpt_ManpoewrStateByStatusEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDate"))) _ManpowerStateDate = reader.GetDateTime(reader.GetOrdinal("ManpowerStateDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("SubUnit"))) _SubUnit = reader.GetString(reader.GetOrdinal("SubUnit"));
			if (!reader.IsDBNull(reader.GetOrdinal("CampName"))) _CampName = reader.GetString(reader.GetOrdinal("CampName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ManPowerStatus"))) _ManPowerStatus = reader.GetString(reader.GetOrdinal("ManPowerStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsPrepared"))) _IsPrepared = reader.GetBoolean(reader.GetOrdinal("IsPrepared"));
			if (!reader.IsDBNull(reader.GetOrdinal("PreparedBy"))) _PreparedBy = reader.GetInt64(reader.GetOrdinal("PreparedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("PreparedDate"))) _PreparedDate = reader.GetDateTime(reader.GetOrdinal("PreparedDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _IsReviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _ReviewedBy = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _ReviewDate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _ReviewRemarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsApproved"))) _IsApproved = reader.GetBoolean(reader.GetOrdinal("IsApproved"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _ApproveBy = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _ApproveDate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _ApproveRemarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
		}
	}
}

