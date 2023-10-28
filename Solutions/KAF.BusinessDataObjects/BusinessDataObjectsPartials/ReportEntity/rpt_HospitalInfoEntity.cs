using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_HospitalInfoEntity
	{
		public static List<rpt_HospitalInfoEntity> GetDetails()
		{
			List<rpt_HospitalInfoEntity> coll = new List<rpt_HospitalInfoEntity>();
			return coll;


		}
		public bool? IsAdmitted { get; set; }
		protected Int64? _HrBasicID;
		protected Int64? _MilNoKW;
		protected String _MilNoBD;
		protected String _FullName;
		protected Int64? _RankIDKW;
		protected String _KW_Rank;
		protected Int64? _RankIDBD;
		protected String _BD_Rank;
		protected String _HospitalName;
		protected String _DiseaseName;
		protected DateTime? _HospitalAdmissionDate;
		protected DateTime? _HospitalReleaseDate;
		protected Int64? _HospitalCountryID;
		protected String _CountryName;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Int64? _CountryID;
		protected DateTime? _AdmissionFromDate;
		protected DateTime? _AdmissionToDate;
		protected DateTime? _ReleaseFromDate;
		protected DateTime? _ReleaseToDate;

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
		public String HospitalName
		{
			get { return _HospitalName; }
			set {_HospitalName=value; }
		}
		[DataMember]
		public String DiseaseName
		{
			get { return _DiseaseName; }
			set {_DiseaseName=value; }
		}
		[DataMember]
		public DateTime? HospitalAdmissionDate
		{
			get { return _HospitalAdmissionDate; }
			set {_HospitalAdmissionDate=value; }
		}
		[DataMember]
		public DateTime? HospitalReleaseDate
		{
			get { return _HospitalReleaseDate; }
			set {_HospitalReleaseDate=value; }
		}
		[DataMember]
		public Int64? HospitalCountryID
		{
			get { return _HospitalCountryID; }
			set {_HospitalCountryID=value; }
		}
		[DataMember]
		public String CountryName
		{
			get { return _CountryName; }
			set {_CountryName=value; }
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
		public Int64? CountryID
		{
			get { return _CountryID; }
			set {_CountryID=value; }
		}
		[DataMember]
		public DateTime? AdmissionFromDate
		{
			get { return _AdmissionFromDate; }
			set {_AdmissionFromDate=value; }
		}
		[DataMember]
		public DateTime? AdmissionToDate
		{
			get { return _AdmissionToDate; }
			set {_AdmissionToDate=value; }
		}
		[DataMember]
		public DateTime? ReleaseFromDate
		{
			get { return _ReleaseFromDate; }
			set {_ReleaseFromDate=value; }
		}
		[DataMember]
		public DateTime? ReleaseToDate
		{
			get { return _ReleaseToDate; }
			set {_ReleaseToDate=value; }
		}
		public rpt_HospitalInfoEntity():base()
		{

		}

		public rpt_HospitalInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KW_Rank"))) _KW_Rank = reader.GetString(reader.GetOrdinal("KW_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _RankIDBD = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("BD_Rank"))) _BD_Rank = reader.GetString(reader.GetOrdinal("BD_Rank"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalName"))) _HospitalName = reader.GetString(reader.GetOrdinal("HospitalName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DiseaseName"))) _DiseaseName = reader.GetString(reader.GetOrdinal("DiseaseName"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionDate"))) _HospitalAdmissionDate = reader.GetDateTime(reader.GetOrdinal("HospitalAdmissionDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalReleaseDate"))) _HospitalReleaseDate = reader.GetDateTime(reader.GetOrdinal("HospitalReleaseDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("HospitalCountryID"))) _HospitalCountryID = reader.GetInt64(reader.GetOrdinal("HospitalCountryID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CountryName"))) _CountryName = reader.GetString(reader.GetOrdinal("CountryName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
		}
	}
}

