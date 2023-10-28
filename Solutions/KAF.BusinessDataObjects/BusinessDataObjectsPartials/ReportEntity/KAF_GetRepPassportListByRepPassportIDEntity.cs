using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetRepPassportListByRepPassportIDEntity:  BaseEntity
	{
		protected Int64? _MilNoKW;
		protected Int64? _HRBasicID;
		protected Int64? _HrSvcID;
		protected Int64? _CivilID;
		protected String _FullName;
		protected DateTime? _DateofBirth;
		protected Int64? _ReligionID;
		protected Int64? _BloodGroupId;
		protected Int64? _MaritalStatusID;
		protected Int64? _GenderID;
		protected Int64? _NationalityID;
		protected Int64? _KWGovID;
		protected Int64? _BuildingID;
		protected Int64? _KWAreaID;
		protected String _KWBlockNo;
		protected String _KWStreet;
		protected String _KWHouseNo;
		protected String _KWFlatNo;
		protected String _KWMobile;
		protected String _KWViber;
		protected String _PersonalEmail;
		protected String _OfficialEmail;
		protected Int64? _BDCurDivID;
		protected Int64? _BDCurCityID;
		protected Int64? _BDCurThanaID;
		protected String _BDCurPostOffice;
		protected String _BDCurRoad;
		protected String _BDCurFlatNo;
		protected String _BDCurHouse;
		protected String _BDMob1;
		protected String _BDMob2;
		protected String _BDHomePhone;
		protected Int64? _BDPerDivID;
		protected Int64? _BDPerCityID;
		protected Int64? _BDPerThanaID;
		protected String _BDPerPostOffice;
		protected String _BDPerRoad;
		protected String _BDPerHouse;
		protected String _BDPerFlatNo;
		protected Int64? _RankIDKW;
		protected String _KuwaitiRank;
		protected Int64? _TradeIDKW;
		protected String _KuwaitiTrade;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected String _NewName1;
		protected String _NewName2;
		protected String _NewFullName;
		protected String _PassportNoNew;
		protected Int64? _VisaDemandDetlID;
		protected Int64? _RepPassportDetlID;
		protected Int64? _RepPassportID;
		protected DateTime? _PassportRecvDate;
		protected DateTime? _PassportLetterDate;
		protected String _PassportLetterNo;
		protected Int64? _NewHrBasicID;
		protected Int64? _NewHrSvcID;
		protected Int64? _IsAll;

        public Int64? VisaDemandID { get; set; }
        public string LetterStatus { get; set; }
        public Int64? DemandID { get; set; }
        public Int64? DemandTypeID { get; set; }

        [DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public Int64? HRBasicID
		{
			get { return _HRBasicID; }
			set {_HRBasicID=value; }
		}
		[DataMember]
		public Int64? HrSvcID
		{
			get { return _HrSvcID; }
			set {_HrSvcID=value; }
		}
		[DataMember]
		public Int64? CivilID
		{
			get { return _CivilID; }
			set {_CivilID=value; }
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
		[DataMember]
		public Int64? GenderID
		{
			get { return _GenderID; }
			set {_GenderID=value; }
		}
		[DataMember]
		public Int64? NationalityID
		{
			get { return _NationalityID; }
			set {_NationalityID=value; }
		}
		[DataMember]
		public Int64? KWGovID
		{
			get { return _KWGovID; }
			set {_KWGovID=value; }
		}
		[DataMember]
		public Int64? BuildingID
		{
			get { return _BuildingID; }
			set {_BuildingID=value; }
		}
		[DataMember]
		public Int64? KWAreaID
		{
			get { return _KWAreaID; }
			set {_KWAreaID=value; }
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
		public String BDCurFlatNo
		{
			get { return _BDCurFlatNo; }
			set {_BDCurFlatNo=value; }
		}
		[DataMember]
		public String BDCurHouse
		{
			get { return _BDCurHouse; }
			set {_BDCurHouse=value; }
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
		public String BDPerPostOffice
		{
			get { return _BDPerPostOffice; }
			set {_BDPerPostOffice=value; }
		}
		[DataMember]
		public String BDPerRoad
		{
			get { return _BDPerRoad; }
			set {_BDPerRoad=value; }
		}
		[DataMember]
		public String BDPerHouse
		{
			get { return _BDPerHouse; }
			set {_BDPerHouse=value; }
		}
		[DataMember]
		public String BDPerFlatNo
		{
			get { return _BDPerFlatNo; }
			set {_BDPerFlatNo=value; }
		}
		[DataMember]
		public Int64? RankIDKW
		{
			get { return _RankIDKW; }
			set {_RankIDKW=value; }
		}
		[DataMember]
		public String KuwaitiRank
		{
			get { return _KuwaitiRank; }
			set {_KuwaitiRank=value; }
		}
		[DataMember]
		public Int64? TradeIDKW
		{
			get { return _TradeIDKW; }
			set {_TradeIDKW=value; }
		}
		[DataMember]
		public String KuwaitiTrade
		{
			get { return _KuwaitiTrade; }
			set {_KuwaitiTrade=value; }
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
		public String NewName1
		{
			get { return _NewName1; }
			set {_NewName1=value; }
		}
		[DataMember]
		public String NewName2
		{
			get { return _NewName2; }
			set {_NewName2=value; }
		}
		[DataMember]
		public String NewFullName
		{
			get { return _NewFullName; }
			set {_NewFullName=value; }
		}
		[DataMember]
		public String PassportNoNew
		{
			get { return _PassportNoNew; }
			set {_PassportNoNew=value; }
		}
		[DataMember]
		public Int64? VisaDemandDetlID
		{
			get { return _VisaDemandDetlID; }
			set {_VisaDemandDetlID=value; }
		}
		[DataMember]
		public Int64? RepPassportDetlID
		{
			get { return _RepPassportDetlID; }
			set {_RepPassportDetlID=value; }
		}
		[DataMember]
		public Int64? RepPassportID
		{
			get { return _RepPassportID; }
			set {_RepPassportID=value; }
		}
		[DataMember]
		public DateTime? PassportRecvDate
		{
			get { return _PassportRecvDate; }
			set {_PassportRecvDate=value; }
		}
		[DataMember]
		public DateTime? PassportLetterDate
		{
			get { return _PassportLetterDate; }
			set {_PassportLetterDate=value; }
		}
		[DataMember]
		public String PassportLetterNo
		{
			get { return _PassportLetterNo; }
			set {_PassportLetterNo=value; }
		}
		[DataMember]
		public Int64? NewHrBasicID
		{
			get { return _NewHrBasicID; }
			set {_NewHrBasicID=value; }
		}
		[DataMember]
		public Int64? NewHrSvcID
		{
			get { return _NewHrSvcID; }
			set {_NewHrSvcID=value; }
		}
		[DataMember]
		public Int64? IsAll
		{
			get { return _IsAll; }
			set {_IsAll=value; }
		}
		public KAF_GetRepPassportListByRepPassportIDEntity():base()
		{

		}

		public KAF_GetRepPassportListByRepPassportIDEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _HRBasicID = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _HrSvcID = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _CivilID = reader.GetInt64(reader.GetOrdinal("CivilID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _DateofBirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReligionID"))) _ReligionID = reader.GetInt64(reader.GetOrdinal("ReligionID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupId"))) _BloodGroupId = reader.GetInt64(reader.GetOrdinal("BloodGroupId"));
			if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _MaritalStatusID = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _GenderID = reader.GetInt64(reader.GetOrdinal("GenderID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _NationalityID = reader.GetInt64(reader.GetOrdinal("NationalityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _KWGovID = reader.GetInt64(reader.GetOrdinal("KWGovID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _BuildingID = reader.GetInt64(reader.GetOrdinal("BuildingID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _KWAreaID = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _KWBlockNo = reader.GetString(reader.GetOrdinal("KWBlockNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _KWStreet = reader.GetString(reader.GetOrdinal("KWStreet"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _KWHouseNo = reader.GetString(reader.GetOrdinal("KWHouseNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _KWFlatNo = reader.GetString(reader.GetOrdinal("KWFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _KWMobile = reader.GetString(reader.GetOrdinal("KWMobile"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _KWViber = reader.GetString(reader.GetOrdinal("KWViber"));
			if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _PersonalEmail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _OfficialEmail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _BDCurDivID = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _BDCurCityID = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _BDCurThanaID = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _BDCurPostOffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _BDCurRoad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _BDCurFlatNo = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _BDCurHouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _BDMob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _BDMob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _BDHomePhone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _BDPerDivID = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _BDPerCityID = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _BDPerThanaID = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _BDPerPostOffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _BDPerRoad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _BDPerHouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _BDPerFlatNo = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KuwaitiRank"))) _KuwaitiRank = reader.GetString(reader.GetOrdinal("KuwaitiRank"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _TradeIDKW = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KuwaitiTrade"))) _KuwaitiTrade = reader.GetString(reader.GetOrdinal("KuwaitiTrade"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewName1"))) _NewName1 = reader.GetString(reader.GetOrdinal("NewName1"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewName2"))) _NewName2 = reader.GetString(reader.GetOrdinal("NewName2"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewFullName"))) _NewFullName = reader.GetString(reader.GetOrdinal("NewFullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportNoNew"))) _PassportNoNew = reader.GetString(reader.GetOrdinal("PassportNoNew"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDetlID"))) _VisaDemandDetlID = reader.GetInt64(reader.GetOrdinal("VisaDemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportDetlID"))) _RepPassportDetlID = reader.GetInt64(reader.GetOrdinal("RepPassportDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportID"))) _RepPassportID = reader.GetInt64(reader.GetOrdinal("RepPassportID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _PassportRecvDate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterDate"))) _PassportLetterDate = reader.GetDateTime(reader.GetOrdinal("PassportLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterNo"))) _PassportLetterNo = reader.GetString(reader.GetOrdinal("PassportLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrBasicID"))) _NewHrBasicID = reader.GetInt64(reader.GetOrdinal("NewHrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrSvcID"))) _NewHrSvcID = reader.GetInt64(reader.GetOrdinal("NewHrSvcID"));
            if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));

            if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) VisaDemandID = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));

        }
    }
}

