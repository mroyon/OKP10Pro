using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class hr_flightcancelinfo_GAPgListView_ExtEntity:  BaseEntity
	{
	
		protected Int64? _FlightID;
		protected DateTime? _FlightDate;
		protected DateTime? _FlightLetterDate;
		protected String _FlightLetterNo;
		protected Int32? _totalperson;
		protected Int64? _RowNumber;
		protected Int64? _PTIID;
		protected Int64? _AirlinesID;
		protected String _Remarks;
		
		[DataMember]
		public Int64? FlightID
		{
			get { return _FlightID; }
			set {_FlightID=value; }
		}
		[DataMember]
		public DateTime? FlightDate
		{
			get { return _FlightDate; }
			set {_FlightDate=value; }
		}
		[DataMember]
		public DateTime? FlightLetterDate
		{
			get { return _FlightLetterDate; }
			set {_FlightLetterDate=value; }
		}
		[DataMember]
		public String FlightLetterNo
		{
			get { return _FlightLetterNo; }
			set {_FlightLetterNo=value; }
		}
		[DataMember]
		public Int32? totalperson
		{
			get { return _totalperson; }
			set {_totalperson=value; }
		}
		
		[DataMember]
		public Int64? PTIID
		{
			get { return _PTIID; }
			set {_PTIID=value; }
		}
		[DataMember]
		public Int64? AirlinesID
		{
			get { return _AirlinesID; }
			set {_AirlinesID=value; }
		}
		[DataMember]
		public String Remarks
		{
			get { return _Remarks; }
			set {_Remarks=value; }
		}
        public string LetterStatus { get; set; }
        public hr_flightcancelinfo_GAPgListView_ExtEntity():base()
		{

		}

		public hr_flightcancelinfo_GAPgListView_ExtEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _FlightID = reader.GetInt64(reader.GetOrdinal("FlightID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _FlightDate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterDate"))) _FlightLetterDate = reader.GetDateTime(reader.GetOrdinal("FlightLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterNo"))) _FlightLetterNo = reader.GetString(reader.GetOrdinal("FlightLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("totalperson"))) _totalperson = reader.GetInt32(reader.GetOrdinal("totalperson"));
			if (!reader.IsDBNull(reader.GetOrdinal("RowNumber"))) _RowNumber = reader.GetInt64(reader.GetOrdinal("RowNumber"));
            if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
        }
	}
}

