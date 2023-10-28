using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_CampWiseManpowerStateHeldEntity
	{
		public static List<rpt_CampWiseManpowerStateHeldEntity> GetDetails()
		{
			List<rpt_CampWiseManpowerStateHeldEntity> coll = new List<rpt_CampWiseManpowerStateHeldEntity>();
			return coll;


		}
		protected Int64? _CampID;
		protected String _CampName;
		protected Int32? _AnnualLeaveNo;
		protected Int32? _OmrahLeaveNo;
		protected Int32? _EmergencyLeaveNo;
		protected Int32? _HospitalTotal;
		protected Int32? _HospitalOther;
		protected Int32? _HeldSupportOfficerNo;
		protected Int32? _HeldSupportJcoNo;
		protected Int32? _HeldSupportOrNo;
		protected Int32? _HeldSupportMeheniNo;
		protected Int32? _HeldTechnicalOfficerNo;
		protected Int32? _HeldTechnicalWONo;
		protected Int32? _HeldTechnicalSgtNo;
		protected Int32? _HeldTechnicalCplNo;
		protected Int32? _HeldTechnicalLCplNo;
		protected Int32? _HeldTechnicalPvtNo;
		protected Int32? _HeldTechnicalMeheniNo;
		protected DateTime? _StateDate;

		[DataMember]
		public Int64? CampID
		{
			get { return _CampID; }
			set {_CampID=value; }
		}
		[DataMember]
		public String CampName
		{
			get { return _CampName; }
			set {_CampName=value; }
		}
		[DataMember]
		public Int32? AnnualLeaveNo
		{
			get { return _AnnualLeaveNo; }
			set {_AnnualLeaveNo=value; }
		}
		[DataMember]
		public Int32? OmrahLeaveNo
		{
			get { return _OmrahLeaveNo; }
			set {_OmrahLeaveNo=value; }
		}
		[DataMember]
		public Int32? EmergencyLeaveNo
		{
			get { return _EmergencyLeaveNo; }
			set {_EmergencyLeaveNo=value; }
		}
		[DataMember]
		public Int32? HospitalTotal
		{
			get { return _HospitalTotal; }
			set {_HospitalTotal=value; }
		}
		[DataMember]
		public Int32? HospitalOther
		{
			get { return _HospitalOther; }
			set {_HospitalOther=value; }
		}
		[DataMember]
		public Int32? HeldSupportOfficerNo
		{
			get { return _HeldSupportOfficerNo; }
			set {_HeldSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? HeldSupportJcoNo
		{
			get { return _HeldSupportJcoNo; }
			set {_HeldSupportJcoNo=value; }
		}
		[DataMember]
		public Int32? HeldSupportOrNo
		{
			get { return _HeldSupportOrNo; }
			set {_HeldSupportOrNo=value; }
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
		public Int32? HeldTechnicalWONo
		{
			get { return _HeldTechnicalWONo; }
			set {_HeldTechnicalWONo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalSgtNo
		{
			get { return _HeldTechnicalSgtNo; }
			set {_HeldTechnicalSgtNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalCplNo
		{
			get { return _HeldTechnicalCplNo; }
			set {_HeldTechnicalCplNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalLCplNo
		{
			get { return _HeldTechnicalLCplNo; }
			set {_HeldTechnicalLCplNo=value; }
		}
		[DataMember]
		public Int32? HeldTechnicalPvtNo
		{
			get { return _HeldTechnicalPvtNo; }
			set {_HeldTechnicalPvtNo=value; }
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
		public rpt_CampWiseManpowerStateHeldEntity():base()
		{

		}

		public rpt_CampWiseManpowerStateHeldEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _CampID = reader.GetInt64(reader.GetOrdinal("CampID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CampName"))) _CampName = reader.GetString(reader.GetOrdinal("CampName"));
			if (!reader.IsDBNull(reader.GetOrdinal("AnnualLeaveNo"))) _AnnualLeaveNo = reader.GetInt32(reader.GetOrdinal("AnnualLeaveNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("OmrahLeaveNo"))) _OmrahLeaveNo = reader.GetInt32(reader.GetOrdinal("OmrahLeaveNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("EmergencyLeaveNo"))) _EmergencyLeaveNo = reader.GetInt32(reader.GetOrdinal("EmergencyLeaveNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalTotal"))) _HospitalTotal = reader.GetInt32(reader.GetOrdinal("HospitalTotal"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalOther"))) _HospitalOther = reader.GetInt32(reader.GetOrdinal("HospitalOther"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportOfficerNo"))) _HeldSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportJcoNo"))) _HeldSupportJcoNo = reader.GetInt32(reader.GetOrdinal("HeldSupportJcoNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportOrNo"))) _HeldSupportOrNo = reader.GetInt32(reader.GetOrdinal("HeldSupportOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportMeheniNo"))) _HeldSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalOfficerNo"))) _HeldTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalWONo"))) _HeldTechnicalWONo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalWONo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalSgtNo"))) _HeldTechnicalSgtNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalSgtNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalCplNo"))) _HeldTechnicalCplNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalCplNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalLCplNo"))) _HeldTechnicalLCplNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalLCplNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalPvtNo"))) _HeldTechnicalPvtNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalPvtNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalMeheniNo"))) _HeldTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalMeheniNo"));
		}
	}
}

