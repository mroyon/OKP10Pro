using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_OkpWiseManpowerStateEntity  
	{
		public static List<rpt_OkpWiseManpowerStateEntity> GetDetails()
		{
			List<rpt_OkpWiseManpowerStateEntity> coll = new List<rpt_OkpWiseManpowerStateEntity>();
			return coll;


		}
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Int32? _PrevSupportTotalNo;
		protected Int32? _PrevTechnicalTotalNo;
		protected Int32? _RepSupportOfficerNo;
		protected Int32? _RepSupportJcoOrNo;
		protected Int32? _RepSupportMeheniNo;
		protected Int32? _RepTechnicalOfficerNo;
		protected Int32? _RepTechnicalJcoOrNo;
		protected Int32? _RepTechnicalMeheniNo;
		protected Int32? _NewArrSupportOfficerNo;
		protected Int32? _NewArrSupportJcoOrNo;
		protected Int32? _NewArrSupportMeheniNo;
		protected Int32? _NewArrTechnicalOfficerNo;
		protected Int32? _NewArrTechnicalJcoOrNo;
		protected Int32? _NewArrTechnicalMeheniNo;
		protected Int32? _HeldSupportOfficerNo;
		protected Int32? _HeldSupportJcoOrNo;
		protected Int32? _HeldSupportMeheniNo;
		protected Int32? _HeldTechnicalOfficerNo;
		protected Int32? _HeldTechnicalJcoOrNo;
		protected Int32? _HeldTechnicalMeheniNo;
		protected DateTime? _StateDate;

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
		public Int32? PrevSupportTotalNo
		{
			get { return _PrevSupportTotalNo; }
			set {_PrevSupportTotalNo=value; }
		}
		[DataMember]
		public Int32? PrevTechnicalTotalNo
		{
			get { return _PrevTechnicalTotalNo; }
			set {_PrevTechnicalTotalNo=value; }
		}
		[DataMember]
		public Int32? RepSupportOfficerNo
		{
			get { return _RepSupportOfficerNo; }
			set {_RepSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? RepSupportJcoOrNo
		{
			get { return _RepSupportJcoOrNo; }
			set {_RepSupportJcoOrNo=value; }
		}
		[DataMember]
		public Int32? RepSupportMeheniNo
		{
			get { return _RepSupportMeheniNo; }
			set {_RepSupportMeheniNo=value; }
		}
		[DataMember]
		public Int32? RepTechnicalOfficerNo
		{
			get { return _RepTechnicalOfficerNo; }
			set {_RepTechnicalOfficerNo=value; }
		}
		[DataMember]
		public Int32? RepTechnicalJcoOrNo
		{
			get { return _RepTechnicalJcoOrNo; }
			set {_RepTechnicalJcoOrNo=value; }
		}
		[DataMember]
		public Int32? RepTechnicalMeheniNo
		{
			get { return _RepTechnicalMeheniNo; }
			set {_RepTechnicalMeheniNo=value; }
		}
		[DataMember]
		public Int32? NewArrSupportOfficerNo
		{
			get { return _NewArrSupportOfficerNo; }
			set {_NewArrSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? NewArrSupportJcoOrNo
		{
			get { return _NewArrSupportJcoOrNo; }
			set {_NewArrSupportJcoOrNo=value; }
		}
		[DataMember]
		public Int32? NewArrSupportMeheniNo
		{
			get { return _NewArrSupportMeheniNo; }
			set {_NewArrSupportMeheniNo=value; }
		}
		[DataMember]
		public Int32? NewArrTechnicalOfficerNo
		{
			get { return _NewArrTechnicalOfficerNo; }
			set {_NewArrTechnicalOfficerNo=value; }
		}
		[DataMember]
		public Int32? NewArrTechnicalJcoOrNo
		{
			get { return _NewArrTechnicalJcoOrNo; }
			set {_NewArrTechnicalJcoOrNo=value; }
		}
		[DataMember]
		public Int32? NewArrTechnicalMeheniNo
		{
			get { return _NewArrTechnicalMeheniNo; }
			set {_NewArrTechnicalMeheniNo=value; }
		}
		[DataMember]
		public Int32? HeldSupportOfficerNo
		{
			get { return _HeldSupportOfficerNo; }
			set {_HeldSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? HeldSupportJcoOrNo
		{
			get { return _HeldSupportJcoOrNo; }
			set {_HeldSupportJcoOrNo=value; }
		}
		[DataMember]
		public Int32? HeldSupportMeheniNo
		{
			get { return _HeldSupportMeheniNo; }
			set {_HeldSupportMeheniNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalOfficerNo
		{
			get { return _HeldTechnicalOfficerNo; }
			set {_HeldTechnicalOfficerNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalJcoOrNo
		{
			get { return _HeldTechnicalJcoOrNo; }
			set {_HeldTechnicalJcoOrNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalMeheniNo
		{
			get { return _HeldTechnicalMeheniNo; }
			set {_HeldTechnicalMeheniNo=value; }
		}
		[DataMember]
		public DateTime? StateDate
		{
			get { return _StateDate; }
			set {_StateDate=value; }
		}
		public rpt_OkpWiseManpowerStateEntity():base()
		{

		}

		public rpt_OkpWiseManpowerStateEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevSupportTotalNo"))) _PrevSupportTotalNo = reader.GetInt32(reader.GetOrdinal("PrevSupportTotalNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevTechnicalTotalNo"))) _PrevTechnicalTotalNo = reader.GetInt32(reader.GetOrdinal("PrevTechnicalTotalNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepSupportOfficerNo"))) _RepSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("RepSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepSupportJcoOrNo"))) _RepSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("RepSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepSupportMeheniNo"))) _RepSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("RepSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepTechnicalOfficerNo"))) _RepTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("RepTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepTechnicalJcoOrNo"))) _RepTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("RepTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepTechnicalMeheniNo"))) _RepTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("RepTechnicalMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrSupportOfficerNo"))) _NewArrSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("NewArrSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrSupportJcoOrNo"))) _NewArrSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("NewArrSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrSupportMeheniNo"))) _NewArrSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("NewArrSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrTechnicalOfficerNo"))) _NewArrTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("NewArrTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrTechnicalJcoOrNo"))) _NewArrTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("NewArrTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewArrTechnicalMeheniNo"))) _NewArrTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("NewArrTechnicalMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportOfficerNo"))) _HeldSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportJcoOrNo"))) _HeldSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("HeldSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportMeheniNo"))) _HeldSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalOfficerNo"))) _HeldTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalJcoOrNo"))) _HeldTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalMeheniNo"))) _HeldTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalMeheniNo"));
		}
	}
}

