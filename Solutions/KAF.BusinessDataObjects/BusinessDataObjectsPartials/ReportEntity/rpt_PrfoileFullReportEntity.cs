using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_PrfoileFullReportEntity:  BaseEntity
	{
		protected Int64? _MilNoKW;
		protected DateTime? _JoinDateKw;
		protected DateTime? _ExpectedRetireDateKw;
		protected String _StatusName;
		protected String _OrganizationName;
		protected String _EntityName;
		protected String _ArmsName;
		protected String _OkpName;
		protected String _RankNameKW;
		protected String _RankNameBD;
		protected String _TradeNameKW;
		protected String _TradeNameBD;
		protected String _GroupName;
		protected String _BloodGroup;
		protected String _Religion;
		protected String _MaritalStatus;
		protected String _CountryName;
		protected String _Gender;
		protected String _BuildingName;
		protected String _KWGovName;
		protected String _KWAreaName;
		protected String _BDCurDivName;
		protected String _BDCurCityName;
		protected String _BDCurThanaName;
		protected String _BDPerDivName;
		protected String _BDPerCityName;
		protected String _BDPerThanaName;
		protected Int64? _ArmsID;
		protected Int64? _OkpID;
		protected Int64? _RankIDKW;
		protected Int64? _RankIDBD;
		protected Int64? _TradeIDBD;
		protected Int64? _TradeIDKW;
		protected Int64? _GroupID;
		protected Int64? _GenderID;
		protected Int64? _KWGovID;
		protected Int64? _KWAreaID;
		protected Int64? _BDCurDivID;
		protected Int64? _BDCurCityID;
		protected Int64? _BDCurThanaID;
		protected Int64? _BDPerDivID;
		protected Int64? _BDPerCityID;
		protected Int64? _BDPerThanaID;
		protected String _FullName;
		protected DateTime? _DateofBirth;
		protected Int64? _CivilID;
		protected String _PassportNo;
		protected String _KWBlockNo;
		protected String _KWStreet;
		protected String _KWHouseNo;
		protected String _KWFlatNo;
		protected String _KWMobile;
		protected String _KWViber;
		protected String _PersonalEmail;
		protected String _OfficialEmail;
		protected String _BDCurPostOffice;
		protected String _BDCurRoad;
		protected String _BDCurHouse;
		protected String _BDCurFlatNo;
		protected String _BDMob1;
		protected String _BDMob2;
		protected String _BDHomePhone;
		protected String _BDPerPostOffice;
		protected String _BDPerHouse;
		protected String _BDPerRoad;
		protected String _BDPerFlatNo;
		protected String _MilNoBD;
		protected DateTime? _DobFrom;
		protected DateTime? _DobTo;
		protected DateTime? _JoinDateFrom;
		protected DateTime? _JoinDateTo;
		protected DateTime? _ExpRepatDateFrom;
		protected DateTime? _ExpRepatDateTo;
		protected Int64? _UnitID;
		protected Int64? _ReligionID;
		protected Int64? _BloodGroupId;
		protected Int64? _MaritalStatusID;

		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public DateTime? JoinDateKw
		{
			get { return _JoinDateKw; }
			set {_JoinDateKw=value; }
		}
		[DataMember]
		public DateTime? ExpectedRetireDateKw
		{
			get { return _ExpectedRetireDateKw; }
			set {_ExpectedRetireDateKw=value; }
		}
		[DataMember]
		public String StatusName
		{
			get { return _StatusName; }
			set {_StatusName=value; }
		}
		[DataMember]
		public String OrganizationName
		{
			get { return _OrganizationName; }
			set {_OrganizationName=value; }
		}
		[DataMember]
		public String EntityName
		{
			get { return _EntityName; }
			set {_EntityName=value; }
		}
		[DataMember]
		public String ArmsName
		{
			get { return _ArmsName; }
			set {_ArmsName=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public String RankNameKW
		{
			get { return _RankNameKW; }
			set {_RankNameKW=value; }
		}
		[DataMember]
		public String RankNameBD
		{
			get { return _RankNameBD; }
			set {_RankNameBD=value; }
		}
		[DataMember]
		public String TradeNameKW
		{
			get { return _TradeNameKW; }
			set {_TradeNameKW=value; }
		}
		[DataMember]
		public String TradeNameBD
		{
			get { return _TradeNameBD; }
			set {_TradeNameBD=value; }
		}
		[DataMember]
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}
		[DataMember]
		public String BloodGroup
		{
			get { return _BloodGroup; }
			set {_BloodGroup=value; }
		}
		[DataMember]
		public String Religion
		{
			get { return _Religion; }
			set {_Religion=value; }
		}
		[DataMember]
		public String MaritalStatus
		{
			get { return _MaritalStatus; }
			set {_MaritalStatus=value; }
		}
		[DataMember]
		public String CountryName
		{
			get { return _CountryName; }
			set {_CountryName=value; }
		}
		[DataMember]
		public String Gender
		{
			get { return _Gender; }
			set {_Gender=value; }
		}
		[DataMember]
		public String BuildingName
		{
			get { return _BuildingName; }
			set {_BuildingName=value; }
		}
		[DataMember]
		public String KWGovName
		{
			get { return _KWGovName; }
			set {_KWGovName=value; }
		}
		[DataMember]
		public String KWAreaName
		{
			get { return _KWAreaName; }
			set {_KWAreaName=value; }
		}
		[DataMember]
		public String BDCurDivName
		{
			get { return _BDCurDivName; }
			set {_BDCurDivName=value; }
		}
		[DataMember]
		public String BDCurCityName
		{
			get { return _BDCurCityName; }
			set {_BDCurCityName=value; }
		}
		[DataMember]
		public String BDCurThanaName
		{
			get { return _BDCurThanaName; }
			set {_BDCurThanaName=value; }
		}
		[DataMember]
		public String BDPerDivName
		{
			get { return _BDPerDivName; }
			set {_BDPerDivName=value; }
		}
		[DataMember]
		public String BDPerCityName
		{
			get { return _BDPerCityName; }
			set {_BDPerCityName=value; }
		}
		[DataMember]
		public String BDPerThanaName
		{
			get { return _BDPerThanaName; }
			set {_BDPerThanaName=value; }
		}
		[DataMember]
		public Int64? ArmsID
		{
			get { return _ArmsID; }
			set {_ArmsID=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public Int64? RankIDKW
		{
			get { return _RankIDKW; }
			set {_RankIDKW=value; }
		}
		[DataMember]
		public Int64? RankIDBD
		{
			get { return _RankIDBD; }
			set {_RankIDBD=value; }
		}
		[DataMember]
		public Int64? TradeIDBD
		{
			get { return _TradeIDBD; }
			set {_TradeIDBD=value; }
		}
		[DataMember]
		public Int64? TradeIDKW
		{
			get { return _TradeIDKW; }
			set {_TradeIDKW=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public Int64? GenderID
		{
			get { return _GenderID; }
			set {_GenderID=value; }
		}
		[DataMember]
		public Int64? KWGovID
		{
			get { return _KWGovID; }
			set {_KWGovID=value; }
		}
		[DataMember]
		public Int64? KWAreaID
		{
			get { return _KWAreaID; }
			set {_KWAreaID=value; }
		}
		[DataMember]
		public Int64? BDCurDivID
		{
			get { return _BDCurDivID; }
			set {_BDCurDivID=value; }
		}
		[DataMember]
		public Int64? BDCurCityID
		{
			get { return _BDCurCityID; }
			set {_BDCurCityID=value; }
		}
		[DataMember]
		public Int64? BDCurThanaID
		{
			get { return _BDCurThanaID; }
			set {_BDCurThanaID=value; }
		}
		[DataMember]
		public Int64? BDPerDivID
		{
			get { return _BDPerDivID; }
			set {_BDPerDivID=value; }
		}
		[DataMember]
		public Int64? BDPerCityID
		{
			get { return _BDPerCityID; }
			set {_BDPerCityID=value; }
		}
		[DataMember]
		public Int64? BDPerThanaID
		{
			get { return _BDPerThanaID; }
			set {_BDPerThanaID=value; }
		}
		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
		}
		[DataMember]
		public DateTime? DateofBirth
		{
			get { return _DateofBirth; }
			set {_DateofBirth=value; }
		}
		[DataMember]
		public Int64? CivilID
		{
			get { return _CivilID; }
			set {_CivilID=value; }
		}
		[DataMember]
		public String PassportNo
		{
			get { return _PassportNo; }
			set {_PassportNo=value; }
		}
		[DataMember]
		public String KWBlockNo
		{
			get { return _KWBlockNo; }
			set {_KWBlockNo=value; }
		}
		[DataMember]
		public String KWStreet
		{
			get { return _KWStreet; }
			set {_KWStreet=value; }
		}
		[DataMember]
		public String KWHouseNo
		{
			get { return _KWHouseNo; }
			set {_KWHouseNo=value; }
		}
		[DataMember]
		public String KWFlatNo
		{
			get { return _KWFlatNo; }
			set {_KWFlatNo=value; }
		}
		[DataMember]
		public String KWMobile
		{
			get { return _KWMobile; }
			set {_KWMobile=value; }
		}
		[DataMember]
		public String KWViber
		{
			get { return _KWViber; }
			set {_KWViber=value; }
		}
		[DataMember]
		public String PersonalEmail
		{
			get { return _PersonalEmail; }
			set {_PersonalEmail=value; }
		}
		[DataMember]
		public String OfficialEmail
		{
			get { return _OfficialEmail; }
			set {_OfficialEmail=value; }
		}
		[DataMember]
		public String BDCurPostOffice
		{
			get { return _BDCurPostOffice; }
			set {_BDCurPostOffice=value; }
		}
		[DataMember]
		public String BDCurRoad
		{
			get { return _BDCurRoad; }
			set {_BDCurRoad=value; }
		}
		[DataMember]
		public String BDCurHouse
		{
			get { return _BDCurHouse; }
			set {_BDCurHouse=value; }
		}
		[DataMember]
		public String BDCurFlatNo
		{
			get { return _BDCurFlatNo; }
			set {_BDCurFlatNo=value; }
		}
		[DataMember]
		public String BDMob1
		{
			get { return _BDMob1; }
			set {_BDMob1=value; }
		}
		[DataMember]
		public String BDMob2
		{
			get { return _BDMob2; }
			set {_BDMob2=value; }
		}
		[DataMember]
		public String BDHomePhone
		{
			get { return _BDHomePhone; }
			set {_BDHomePhone=value; }
		}
		[DataMember]
		public String BDPerPostOffice
		{
			get { return _BDPerPostOffice; }
			set {_BDPerPostOffice=value; }
		}
		[DataMember]
		public String BDPerHouse
		{
			get { return _BDPerHouse; }
			set {_BDPerHouse=value; }
		}
		[DataMember]
		public String BDPerRoad
		{
			get { return _BDPerRoad; }
			set {_BDPerRoad=value; }
		}
		[DataMember]
		public String BDPerFlatNo
		{
			get { return _BDPerFlatNo; }
			set {_BDPerFlatNo=value; }
		}
		[DataMember]
		public String MilNoBD
		{
			get { return _MilNoBD; }
			set {_MilNoBD=value; }
		}
		[DataMember]
		public DateTime? DobFrom
		{
			get { return _DobFrom; }
			set {_DobFrom=value; }
		}
		[DataMember]
		public DateTime? DobTo
		{
			get { return _DobTo; }
			set {_DobTo=value; }
		}
		[DataMember]
		public DateTime? JoinDateFrom
		{
			get { return _JoinDateFrom; }
			set {_JoinDateFrom=value; }
		}
		[DataMember]
		public DateTime? JoinDateTo
		{
			get { return _JoinDateTo; }
			set {_JoinDateTo=value; }
		}
		[DataMember]
		public DateTime? ExpRepatDateFrom
		{
			get { return _ExpRepatDateFrom; }
			set {_ExpRepatDateFrom=value; }
		}
		[DataMember]
		public DateTime? ExpRepatDateTo
		{
			get { return _ExpRepatDateTo; }
			set {_ExpRepatDateTo=value; }
		}
		[DataMember]
		public Int64? UnitID
		{
			get { return _UnitID; }
			set {_UnitID=value; }
		}
		[DataMember]
		public Int64? ReligionID
		{
			get { return _ReligionID; }
			set {_ReligionID=value; }
		}
		[DataMember]
		public Int64? BloodGroupId
		{
			get { return _BloodGroupId; }
			set {_BloodGroupId=value; }
		}
		[DataMember]
		public Int64? MaritalStatusID
		{
			get { return _MaritalStatusID; }
			set {_MaritalStatusID=value; }
		}
		public rpt_PrfoileFullReportEntity():base()
		{

		}

		public rpt_PrfoileFullReportEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _ExpectedRetireDateKw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("StatusName"))) _StatusName = reader.GetString(reader.GetOrdinal("StatusName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _OrganizationName = reader.GetString(reader.GetOrdinal("OrganizationName"));
			if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _EntityName = reader.GetString(reader.GetOrdinal("EntityName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArmsName"))) _ArmsName = reader.GetString(reader.GetOrdinal("ArmsName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankNameKW"))) _RankNameKW = reader.GetString(reader.GetOrdinal("RankNameKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankNameBD"))) _RankNameBD = reader.GetString(reader.GetOrdinal("RankNameBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeNameKW"))) _TradeNameKW = reader.GetString(reader.GetOrdinal("TradeNameKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeNameBD"))) _TradeNameBD = reader.GetString(reader.GetOrdinal("TradeNameBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BloodGroup"))) _BloodGroup = reader.GetString(reader.GetOrdinal("BloodGroup"));
			if (!reader.IsDBNull(reader.GetOrdinal("Religion"))) _Religion = reader.GetString(reader.GetOrdinal("Religion"));
			if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) _MaritalStatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("CountryName"))) _CountryName = reader.GetString(reader.GetOrdinal("CountryName"));
			if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _Gender = reader.GetString(reader.GetOrdinal("Gender"));
			if (!reader.IsDBNull(reader.GetOrdinal("BuildingName"))) _BuildingName = reader.GetString(reader.GetOrdinal("BuildingName"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWGovName"))) _KWGovName = reader.GetString(reader.GetOrdinal("KWGovName"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWAreaName"))) _KWAreaName = reader.GetString(reader.GetOrdinal("KWAreaName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivName"))) _BDCurDivName = reader.GetString(reader.GetOrdinal("BDCurDivName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityName"))) _BDCurCityName = reader.GetString(reader.GetOrdinal("BDCurCityName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaName"))) _BDCurThanaName = reader.GetString(reader.GetOrdinal("BDCurThanaName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivName"))) _BDPerDivName = reader.GetString(reader.GetOrdinal("BDPerDivName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityName"))) _BDPerCityName = reader.GetString(reader.GetOrdinal("BDPerCityName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaName"))) _BDPerThanaName = reader.GetString(reader.GetOrdinal("BDPerThanaName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _ArmsID = reader.GetInt64(reader.GetOrdinal("ArmsID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _RankIDBD = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _TradeIDBD = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _TradeIDKW = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _GenderID = reader.GetInt64(reader.GetOrdinal("GenderID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _KWGovID = reader.GetInt64(reader.GetOrdinal("KWGovID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _KWAreaID = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _BDCurDivID = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _BDCurCityID = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _BDCurThanaID = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _BDPerDivID = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _BDPerCityID = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _BDPerThanaID = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _DateofBirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _CivilID = reader.GetInt64(reader.GetOrdinal("CivilID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _KWBlockNo = reader.GetString(reader.GetOrdinal("KWBlockNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _KWStreet = reader.GetString(reader.GetOrdinal("KWStreet"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _KWHouseNo = reader.GetString(reader.GetOrdinal("KWHouseNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _KWFlatNo = reader.GetString(reader.GetOrdinal("KWFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _KWMobile = reader.GetString(reader.GetOrdinal("KWMobile"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _KWViber = reader.GetString(reader.GetOrdinal("KWViber"));
			if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _PersonalEmail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _OfficialEmail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _BDCurPostOffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _BDCurRoad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _BDCurHouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _BDCurFlatNo = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _BDMob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _BDMob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _BDHomePhone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _BDPerPostOffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _BDPerHouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _BDPerRoad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _BDPerFlatNo = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
		}
	}
}

