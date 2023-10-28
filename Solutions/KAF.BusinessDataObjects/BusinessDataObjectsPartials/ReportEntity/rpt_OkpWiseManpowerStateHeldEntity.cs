using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_OkpWiseManpowerStateHeldEntity
	{
		public static List<rpt_OkpWiseManpowerStateHeldEntity> GetDetails()
		{
			List<rpt_OkpWiseManpowerStateHeldEntity> coll = new List<rpt_OkpWiseManpowerStateHeldEntity>();
			return coll;

		}
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Int32? _LeaveSupportOfficerNo;
		protected Int32? _LeaveSupportJcoOrNo;
		protected Int32? _LeaveSupportMeheniNo;
		protected Int32? _LeaveTechnicalOfficerNo;
		protected Int32? _LeaveTechnicalJcoOrNo;
		protected Int32? _LeaveTechnicalMeheniNo;
		protected Int32? _HospitalSupportOfficerNo;
		protected Int32? _HospitalSupportJcoOrNo;
		protected Int32? _HospitalSupportMeheniNo;
		protected Int32? _HospitalTechnicalOfficerNo;
		protected Int32? _HospitalTechnicalJcoOrNo;
		protected Int32? _HospitalTechnicalMeheniNo;
		protected Int32? _DeplSupportNo;
		protected Int32? _DeplTechnicalNo;
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
		public Int32? LeaveSupportOfficerNo
		{
			get { return _LeaveSupportOfficerNo; }
			set {_LeaveSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? LeaveSupportJcoOrNo
		{
			get { return _LeaveSupportJcoOrNo; }
			set {_LeaveSupportJcoOrNo=value; }
		}
		[DataMember]
		public Int32? LeaveSupportMeheniNo
		{
			get { return _LeaveSupportMeheniNo; }
			set {_LeaveSupportMeheniNo=value; }
		}
		[DataMember]
		public Int32? LeaveTechnicalOfficerNo
		{
			get { return _LeaveTechnicalOfficerNo; }
			set {_LeaveTechnicalOfficerNo=value; }
		}
		[DataMember]
		public Int32? LeaveTechnicalJcoOrNo
		{
			get { return _LeaveTechnicalJcoOrNo; }
			set {_LeaveTechnicalJcoOrNo=value; }
		}
		[DataMember]
		public Int32? LeaveTechnicalMeheniNo
		{
			get { return _LeaveTechnicalMeheniNo; }
			set {_LeaveTechnicalMeheniNo=value; }
		}
		[DataMember]
		public Int32? HospitalSupportOfficerNo
		{
			get { return _HospitalSupportOfficerNo; }
			set {_HospitalSupportOfficerNo=value; }
		}
		[DataMember]
		public Int32? HospitalSupportJcoOrNo
		{
			get { return _HospitalSupportJcoOrNo; }
			set {_HospitalSupportJcoOrNo=value; }
		}
		[DataMember]
		public Int32? HospitalSupportMeheniNo
		{
			get { return _HospitalSupportMeheniNo; }
			set {_HospitalSupportMeheniNo=value; }
		}
		[DataMember]
		public Int32? HospitalTechnicalOfficerNo
		{
			get { return _HospitalTechnicalOfficerNo; }
			set {_HospitalTechnicalOfficerNo=value; }
		}
		[DataMember]
		public Int32? HospitalTechnicalJcoOrNo
		{
			get { return _HospitalTechnicalJcoOrNo; }
			set {_HospitalTechnicalJcoOrNo=value; }
		}
		[DataMember]
		public Int32? HospitalTechnicalMeheniNo
		{
			get { return _HospitalTechnicalMeheniNo; }
			set {_HospitalTechnicalMeheniNo=value; }
		}
		[DataMember]
		public Int32? DeplSupportNo
		{
			get { return _DeplSupportNo; }
			set {_DeplSupportNo=value; }
		}
		[DataMember]
		public Int32? DeplTechnicalNo
		{
			get { return _DeplTechnicalNo; }
			set {_DeplTechnicalNo=value; }
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
		public rpt_OkpWiseManpowerStateHeldEntity():base()
		{

		}

		public rpt_OkpWiseManpowerStateHeldEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveSupportOfficerNo"))) _LeaveSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("LeaveSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveSupportJcoOrNo"))) _LeaveSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("LeaveSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveSupportMeheniNo"))) _LeaveSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("LeaveSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveTechnicalOfficerNo"))) _LeaveTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("LeaveTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveTechnicalJcoOrNo"))) _LeaveTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("LeaveTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LeaveTechnicalMeheniNo"))) _LeaveTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("LeaveTechnicalMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalSupportOfficerNo"))) _HospitalSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("HospitalSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalSupportJcoOrNo"))) _HospitalSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("HospitalSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalSupportMeheniNo"))) _HospitalSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("HospitalSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalTechnicalOfficerNo"))) _HospitalTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("HospitalTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalTechnicalJcoOrNo"))) _HospitalTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("HospitalTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalTechnicalMeheniNo"))) _HospitalTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("HospitalTechnicalMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("DeplSupportNo"))) _DeplSupportNo = reader.GetInt32(reader.GetOrdinal("DeplSupportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("DeplTechnicalNo"))) _DeplTechnicalNo = reader.GetInt32(reader.GetOrdinal("DeplTechnicalNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportOfficerNo"))) _HeldSupportOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldSupportOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportJcoOrNo"))) _HeldSupportJcoOrNo = reader.GetInt32(reader.GetOrdinal("HeldSupportJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldSupportMeheniNo"))) _HeldSupportMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldSupportMeheniNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalOfficerNo"))) _HeldTechnicalOfficerNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalOfficerNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalJcoOrNo"))) _HeldTechnicalJcoOrNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalJcoOrNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HeldTechnicalMeheniNo"))) _HeldTechnicalMeheniNo = reader.GetInt32(reader.GetOrdinal("HeldTechnicalMeheniNo"));
		}
	}
}

