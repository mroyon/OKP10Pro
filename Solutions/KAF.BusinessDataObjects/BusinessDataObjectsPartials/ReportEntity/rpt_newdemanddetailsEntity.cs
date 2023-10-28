using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_newdemanddetailsEntity:  BaseEntity
	{
		protected Int64? _NewDemandDetlID;
		protected Int64? _NewDemandID;
		protected Int64? _RankID;
		protected Int64? _TradeID;
		protected Int64? _GroupID;
		protected Int64? _OkpID;
		protected Int64? _NoOfVacancies;
		protected String _Remarks;
		protected Int64? _HrBasicID;
		protected Int32? _TotalPerson;
		protected String _LetterStatus;
		protected String _RankName;
		protected String _TradeName;
		protected String _GroupName;
        protected String _DemandLetterNo;
        protected DateTime? _DemandLetterDate;

        [DataMember]
		public Int64? NewDemandDetlID
		{
			get { return _NewDemandDetlID; }
			set {_NewDemandDetlID=value; }
		}
		[DataMember]
		public Int64? NewDemandID
		{
			get { return _NewDemandID; }
			set {_NewDemandID=value; }
		}
		[DataMember]
		public Int64? RankID
		{
			get { return _RankID; }
			set {_RankID=value; }
		}
		[DataMember]
		public Int64? TradeID
		{
			get { return _TradeID; }
			set {_TradeID=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public Int64? NoOfVacancies
		{
			get { return _NoOfVacancies; }
			set {_NoOfVacancies=value; }
		}
		[DataMember]
		public String Remarks
		{
			get { return _Remarks; }
			set {_Remarks=value; }
		}
		[DataMember]
		public Int64? HrBasicID
		{
			get { return _HrBasicID; }
			set {_HrBasicID=value; }
		}
		[DataMember]
		public Int32? TotalPerson
		{
			get { return _TotalPerson; }
			set {_TotalPerson=value; }
		}
		[DataMember]
		public String LetterStatus
		{
			get { return _LetterStatus; }
			set {_LetterStatus=value; }
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
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}

        [DataMember]
        public String DemandLetterNo
        {
            get { return _DemandLetterNo; }
            set { _DemandLetterNo = value; }
        }

        [DataMember]
        public DateTime? DemandLetterDate
        {
            get { return _DemandLetterDate; }
            set { _DemandLetterDate = value; }
        }
        public rpt_newdemanddetailsEntity():base()
		{

		}

		public rpt_newdemanddetailsEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("NewDemandDetlID"))) _NewDemandDetlID = reader.GetInt64(reader.GetOrdinal("NewDemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewDemandID"))) _NewDemandID = reader.GetInt64(reader.GetOrdinal("NewDemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _RankID = reader.GetInt64(reader.GetOrdinal("RankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeID"))) _TradeID = reader.GetInt64(reader.GetOrdinal("TradeID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NoOfVacancies"))) _NoOfVacancies = reader.GetInt64(reader.GetOrdinal("NoOfVacancies"));
			if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalPerson"))) _TotalPerson = reader.GetInt32(reader.GetOrdinal("TotalPerson"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
            if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterNo"))) _DemandLetterNo = reader.GetString(reader.GetOrdinal("DemandLetterNo"));
            if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterDate"))) _DemandLetterDate = reader.GetDateTime(reader.GetOrdinal("DemandLetterDate"));
        }
	}
}

