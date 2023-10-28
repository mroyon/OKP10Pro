using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_LeaveInfoEntity:  BaseEntity
	{
		public static List<rpt_LeaveInfoEntity> GetDetails()
		{
			List<rpt_LeaveInfoEntity> coll = new List<rpt_LeaveInfoEntity>();
			return coll;


		}
		protected Int64? _LeaveTypeID;
		protected String _LeaveType;
		protected Int64? _HrBasicID;
		protected Int64? _MilNoKW;
		protected String _MilNoBD;
		protected String _FullName;
		protected Int64? _RankIDKW;
		protected String _KW_Rank;
		protected Int64? _RankIDBD;
		protected String _BD_Rank;
		protected DateTime? _StartDate;
		protected DateTime? _EndDate;
		protected Int64? _NoOfDays;
		protected DateTime? _LeaveStartDate;
		protected DateTime? _LeaveEndDate;
		protected Int64? _LeaveDays;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Boolean? _InLeave;
		protected DateTime? _LeaveStartFromDate;
		protected DateTime? _LeaveStartToDate;
		protected DateTime? _LeaveEndFromDate;
		protected DateTime? _LeaveEndToDate;
		protected DateTime? _LeaveReturnFromDate;
		protected DateTime? _LeaveReturnToDate;

		[DataMember]
		public Int64? LeaveTypeID
		{
			get { return _LeaveTypeID; }
			set {_LeaveTypeID=value; }
		}
		[DataMember]
		public String LeaveType
		{
			get { return _LeaveType; }
			set {_LeaveType=value; }
		}
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
		public DateTime? StartDate
		{
			get { return _StartDate; }
			set {_StartDate=value; }
		}
		[DataMember]
		public DateTime? EndDate
		{
			get { return _EndDate; }
			set {_EndDate=value; }
		}
		[DataMember]
		public Int64? NoOfDays
		{
			get { return _NoOfDays; }
			set {_NoOfDays=value; }
		}
		[DataMember]
		public DateTime? LeaveStartDate
		{
			get { return _LeaveStartDate; }
			set {_LeaveStartDate=value; }
		}
		[DataMember]
		public DateTime? LeaveEndDate
		{
			get { return _LeaveEndDate; }
			set {_LeaveEndDate=value; }
		}
		[DataMember]
		public Int64? LeaveDays
		{
			get { return _LeaveDays; }
			set {_LeaveDays=value; }
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
		public DateTime? LeaveStartFromDate
		{
			get { return _LeaveStartFromDate; }
			set {_LeaveStartFromDate=value; }
		}
		[DataMember]
		public DateTime? LeaveStartToDate
		{
			get { return _LeaveStartToDate; }
			set {_LeaveStartToDate=value; }
		}
		[DataMember]
		public DateTime? LeaveEndFromDate
		{
			get { return _LeaveEndFromDate; }
			set {_LeaveEndFromDate=value; }
		}
		[DataMember]
		public DateTime? LeaveEndToDate
		{
			get { return _LeaveEndToDate; }
			set {_LeaveEndToDate=value; }
		}
		[DataMember]
		public DateTime? LeaveReturnFromDate
		{
			get { return _LeaveReturnFromDate; }
			set {_LeaveReturnFromDate=value; }
		}
		[DataMember]
		public DateTime? LeaveReturnToDate
		{
			get { return _LeaveReturnToDate; }
			set {_LeaveReturnToDate=value; }
		}
		public rpt_LeaveInfoEntity():base()
		{

		}

		public rpt_LeaveInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveTypeID"))) _LeaveTypeID = reader.GetInt64(reader.GetOrdinal("LeaveTypeID"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveType"))) _LeaveType = reader.GetString(reader.GetOrdinal("LeaveType"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KW_Rank"))) _KW_Rank = reader.GetString(reader.GetOrdinal("KW_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _RankIDBD = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("BD_Rank"))) _BD_Rank = reader.GetString(reader.GetOrdinal("BD_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("StartDate"))) _StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("EndDate"))) _EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("NoOfDays"))) _NoOfDays = reader.GetInt64(reader.GetOrdinal("NoOfDays"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveStartDate"))) _LeaveStartDate = reader.GetDateTime(reader.GetOrdinal("LeaveStartDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveEndDate"))) _LeaveEndDate = reader.GetDateTime(reader.GetOrdinal("LeaveEndDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveDays"))) _LeaveDays = reader.GetInt64(reader.GetOrdinal("LeaveDays"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
		}
	}
}

