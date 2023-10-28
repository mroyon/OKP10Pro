using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_OkpWiseManpowerStateHeldAuthEntity
	{

		public static List<rpt_OkpWiseManpowerStateHeldAuthEntity> GetDetails()
		{
			List<rpt_OkpWiseManpowerStateHeldAuthEntity> coll = new List<rpt_OkpWiseManpowerStateHeldAuthEntity>();
			return coll;

		}
		public string OkpName { get; set; }
		protected Int64? _OkpID;
		protected String _StrengthType;
		protected String _StrengthHead;
		protected Int64? _seq;
		protected Int64? _SpBrigGen;
		protected Int64? _SpCol;
		protected Int64? _SpLtCol;
		protected Int64? _SpMajor;
		protected Int64? _SpCaptain;
		protected Int64? _SpFstLt;
		protected Int64? _SpLt;
		protected Int64? _SpFstWrntOfficer;
		protected Int64? _SpWrntOfficer;
		protected Int64? _SpFstSergeant;
		protected Int64? _SpSergeant;
		protected Int64? _SpCorporal;
		protected Int64? _SpLncCorporal;
		protected Int64? _SpPvt;
		protected Int64? _SpMeheni;
		protected Int64? _TechWrntOfficer;
		protected Int64? _TechSergeant;
		protected Int64? _TechCorporal;
		protected Int64? _TechLncCorporal;
		protected Int64? _TechPvt;
		protected Int64? _TechMeheni;
		protected DateTime? _StateDate;

		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public String StrengthType
		{
			get { return _StrengthType; }
			set {_StrengthType=value; }
		}
		[DataMember]
		public String StrengthHead
		{
			get { return _StrengthHead; }
			set {_StrengthHead=value; }
		}
		[DataMember]
		public Int64? seq
		{
			get { return _seq; }
			set {_seq=value; }
		}
		[DataMember]
		public Int64? SpBrigGen
		{
			get { return _SpBrigGen; }
			set {_SpBrigGen=value; }
		}
		[DataMember]
		public Int64? SpCol
		{
			get { return _SpCol; }
			set {_SpCol=value; }
		}
		[DataMember]
		public Int64? SpLtCol
		{
			get { return _SpLtCol; }
			set {_SpLtCol=value; }
		}
		[DataMember]
		public Int64? SpMajor
		{
			get { return _SpMajor; }
			set {_SpMajor=value; }
		}
		[DataMember]
		public Int64? SpCaptain
		{
			get { return _SpCaptain; }
			set {_SpCaptain=value; }
		}
		[DataMember]
		public Int64? SpFstLt
		{
			get { return _SpFstLt; }
			set {_SpFstLt=value; }
		}
		[DataMember]
		public Int64? SpLt
		{
			get { return _SpLt; }
			set {_SpLt=value; }
		}
		[DataMember]
		public Int64? SpFstWrntOfficer
		{
			get { return _SpFstWrntOfficer; }
			set {_SpFstWrntOfficer=value; }
		}
		[DataMember]
		public Int64? SpWrntOfficer
		{
			get { return _SpWrntOfficer; }
			set {_SpWrntOfficer=value; }
		}
		[DataMember]
		public Int64? SpFstSergeant
		{
			get { return _SpFstSergeant; }
			set {_SpFstSergeant=value; }
		}
		[DataMember]
		public Int64? SpSergeant
		{
			get { return _SpSergeant; }
			set {_SpSergeant=value; }
		}
		[DataMember]
		public Int64? SpCorporal
		{
			get { return _SpCorporal; }
			set {_SpCorporal=value; }
		}
		[DataMember]
		public Int64? SpLncCorporal
		{
			get { return _SpLncCorporal; }
			set {_SpLncCorporal=value; }
		}
		[DataMember]
		public Int64? SpPvt
		{
			get { return _SpPvt; }
			set {_SpPvt=value; }
		}
		[DataMember]
		public Int64? SpMeheni
		{
			get { return _SpMeheni; }
			set {_SpMeheni=value; }
		}
		[DataMember]
		public Int64? TechWrntOfficer
		{
			get { return _TechWrntOfficer; }
			set {_TechWrntOfficer=value; }
		}
		[DataMember]
		public Int64? TechSergeant
		{
			get { return _TechSergeant; }
			set {_TechSergeant=value; }
		}
		[DataMember]
		public Int64? TechCorporal
		{
			get { return _TechCorporal; }
			set {_TechCorporal=value; }
		}
		[DataMember]
		public Int64? TechLncCorporal
		{
			get { return _TechLncCorporal; }
			set {_TechLncCorporal=value; }
		}
		[DataMember]
		public Int64? TechPvt
		{
			get { return _TechPvt; }
			set {_TechPvt=value; }
		}
		[DataMember]
		public Int64? TechMeheni
		{
			get { return _TechMeheni; }
			set {_TechMeheni=value; }
		}
		[DataMember]
		public DateTime? StateDate
		{
			get { return _StateDate; }
			set {_StateDate=value; }
		}
		public rpt_OkpWiseManpowerStateHeldAuthEntity():base()
		{

		}

		public rpt_OkpWiseManpowerStateHeldAuthEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("StrengthType"))) _StrengthType = reader.GetString(reader.GetOrdinal("StrengthType"));
			if (!reader.IsDBNull(reader.GetOrdinal("StrengthHead"))) _StrengthHead = reader.GetString(reader.GetOrdinal("StrengthHead"));
			if (!reader.IsDBNull(reader.GetOrdinal("seq"))) _seq = reader.GetInt64(reader.GetOrdinal("seq"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpBrigGen"))) _SpBrigGen = reader.GetInt64(reader.GetOrdinal("SpBrigGen"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpCol"))) _SpCol = reader.GetInt64(reader.GetOrdinal("SpCol"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpLtCol"))) _SpLtCol = reader.GetInt64(reader.GetOrdinal("SpLtCol"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpMajor"))) _SpMajor = reader.GetInt64(reader.GetOrdinal("SpMajor"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpCaptain"))) _SpCaptain = reader.GetInt64(reader.GetOrdinal("SpCaptain"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpFstLt"))) _SpFstLt = reader.GetInt64(reader.GetOrdinal("SpFstLt"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpLt"))) _SpLt = reader.GetInt64(reader.GetOrdinal("SpLt"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpFstWrntOfficer"))) _SpFstWrntOfficer = reader.GetInt64(reader.GetOrdinal("SpFstWrntOfficer"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpWrntOfficer"))) _SpWrntOfficer = reader.GetInt64(reader.GetOrdinal("SpWrntOfficer"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpFstSergeant"))) _SpFstSergeant = reader.GetInt64(reader.GetOrdinal("SpFstSergeant"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpSergeant"))) _SpSergeant = reader.GetInt64(reader.GetOrdinal("SpSergeant"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpCorporal"))) _SpCorporal = reader.GetInt64(reader.GetOrdinal("SpCorporal"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpLncCorporal"))) _SpLncCorporal = reader.GetInt64(reader.GetOrdinal("SpLncCorporal"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpPvt"))) _SpPvt = reader.GetInt64(reader.GetOrdinal("SpPvt"));
			if (!reader.IsDBNull(reader.GetOrdinal("SpMeheni"))) _SpMeheni = reader.GetInt64(reader.GetOrdinal("SpMeheni"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechWrntOfficer"))) _TechWrntOfficer = reader.GetInt64(reader.GetOrdinal("TechWrntOfficer"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechSergeant"))) _TechSergeant = reader.GetInt64(reader.GetOrdinal("TechSergeant"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechCorporal"))) _TechCorporal = reader.GetInt64(reader.GetOrdinal("TechCorporal"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechLncCorporal"))) _TechLncCorporal = reader.GetInt64(reader.GetOrdinal("TechLncCorporal"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechPvt"))) _TechPvt = reader.GetInt64(reader.GetOrdinal("TechPvt"));
			if (!reader.IsDBNull(reader.GetOrdinal("TechMeheni"))) _TechMeheni = reader.GetInt64(reader.GetOrdinal("TechMeheni"));
		}
	}
}

