using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetProfileInfoEntity:  BaseEntity
	{
		protected Int64? _HRBasicID;
		protected string _MilNoBD;
		protected Int64? _MilNoKW;
		protected String _PassportNo;
		protected Int64? _BDSmartCardID;
		protected String _NationalID;
		protected Int64? _CivilID;
		protected DateTime? _CivilIDExpireDate;
		protected Int64? _OrganizationKey;
		protected String _OrganizationName;
		protected Int64? _EntityKey;
		protected String _EntityName;
		protected Int64? _ArmsID;
		protected String _ArmsName;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Int64? _RankIDKW;
		protected String _RankNameKW;
		protected Int64? _RankIDBD;
		protected String _RankNameBD;
		protected Int64? _TradeIDBD;
		protected String _TradeNameBD;
		protected Int64? _TradeIDKW;
		protected String _TradeNameKW;
		protected Int64? _GroupID;
		protected String _GroupName;
		protected Int64? _Status;
		protected String _Name1;
		protected String _Name2;
		protected String _Name3;
		protected String _FullName;
		protected DateTime? _DateofBirth;
		protected DateTime? _JoinDateBD;
		protected DateTime? _JoinDateKw;
		protected DateTime? _ExpectedRetireDateKw;
		protected Int64? _ReligionID;
		protected String _Religion;
		protected Int64? _BloodGroupId;
		protected String _BloodGroup;
		protected Int64? _MaritalStatusID;
		protected String _MaritalStatus;
		protected Int64? _GenderID;
		protected String _Gender;
		protected Int64? _NationalityID;
		protected String _Nationality;
		protected Int64? _BuildingID;
		protected String _BuildingName;
		protected Int64? _KWGovID;
		protected String _KWGov;
		protected Int64? _KWAreaID;
		protected String _KWArea;
		protected String _KWBlockNo;
		protected String _KWStreet;
		protected String _KWHouseNo;
		protected String _KWFlatNo;
		protected String _KWMobile;
		protected String _KWViber;
		protected String _PersonalEmail;
		protected String _OfficialEmail;
		protected Int64? _BDCurDivID;
		protected String _BDCurDiv;
		protected Int64? _BDCurCityID;
		protected String _BDCurCity;
		protected Int64? _BDCurThanaID;
		protected String _BDCurThana;
		protected String _BDCurPostOffice;
		protected String _BDCurRoad;
		protected String _BDCurHouse;
		protected String _BDCurFlatNo;
		protected String _BDMob1;
		protected String _BDMob2;
		protected String _BDHomePhone;
		protected Int64? _BDPerDivID;
		protected String _BDPerDiv;
		protected Int64? _BDPerCityID;
		protected String _BDPerCity;
		protected Int64? _BDPerThanaID;
		protected String _BDPerThana;
		protected String _BDPerPostOffice;
		protected String _BDPerRoad;
		protected String _BDPerHouse;
		protected String _BDPerFlatNo;
		protected Int64? _BankID;
		protected String _BankName;
		protected Int64? _BranchID;
		protected String _BranchName;
		protected String _AccountNo;
		protected String _AccountName;
		protected String _AccountDescription;
		protected String _ResidencyNumber;
		protected DateTime? _IssueDate;
		protected DateTime? _ExpiryDate;
		protected Boolean? _IsFamilyVISA;
		protected String _ProfilePhoto;
		protected String _ProfilePhotoFilePath;
		protected String _ProfilePhotoFileName;
		protected String _ProfilePhotoFileType;
		protected String _ProfilePhotoFileExtension;
		protected Int32? _ForReview;
		protected string _BasicProfileStatus;
		public string BasePath { get; set; }
		public string strStartus { get; set; }
        public Int64? OKPID { get; set; }
        [DataMember]
		public Int64? HRBasicID
		{
			get { return _HRBasicID; }
			set {_HRBasicID=value; }
		}
		[DataMember]
		public string MilNoBD
		{
			get { return _MilNoBD; }
			set {_MilNoBD=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		[DataMember]
		public String PassportNo
		{
			get { return _PassportNo; }
			set {_PassportNo=value; }
		}
		[DataMember]
		public Int64? BDSmartCardID
		{
			get { return _BDSmartCardID; }
			set {_BDSmartCardID=value; }
		}
		[DataMember]
		public String NationalID
		{
			get { return _NationalID; }
			set {_NationalID=value; }
		}
		[DataMember]
		public Int64? CivilID
		{
			get { return _CivilID; }
			set {_CivilID=value; }
		}
		[DataMember]
		public DateTime? CivilIDExpireDate
		{
			get { return _CivilIDExpireDate; }
			set {_CivilIDExpireDate=value; }
		}
		[DataMember]
		public Int64? OrganizationKey
		{
			get { return _OrganizationKey; }
			set {_OrganizationKey=value; }
		}
		[DataMember]
		public String OrganizationName
		{
			get { return _OrganizationName; }
			set {_OrganizationName=value; }
		}
		[DataMember]
		public Int64? EntityKey
		{
			get { return _EntityKey; }
			set {_EntityKey=value; }
		}
		[DataMember]
		public String EntityName
		{
			get { return _EntityName; }
			set {_EntityName=value; }
		}
		[DataMember]
		public Int64? ArmsID
		{
			get { return _ArmsID; }
			set {_ArmsID=value; }
		}
		[DataMember]
		public String ArmsName
		{
			get { return _ArmsName; }
			set {_ArmsName=value; }
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
		public Int64? RankIDKW
		{
			get { return _RankIDKW; }
			set {_RankIDKW=value; }
		}
		[DataMember]
		public String RankNameKW
		{
			get { return _RankNameKW; }
			set {_RankNameKW=value; }
		}
		[DataMember]
		public Int64? RankIDBD
		{
			get { return _RankIDBD; }
			set {_RankIDBD=value; }
		}
		[DataMember]
		public String RankNameBD
		{
			get { return _RankNameBD; }
			set {_RankNameBD=value; }
		}
		[DataMember]
		public Int64? TradeIDBD
		{
			get { return _TradeIDBD; }
			set {_TradeIDBD=value; }
		}
		[DataMember]
		public String TradeNameBD
		{
			get { return _TradeNameBD; }
			set {_TradeNameBD=value; }
		}
		[DataMember]
		public Int64? TradeIDKW
		{
			get { return _TradeIDKW; }
			set {_TradeIDKW=value; }
		}
		[DataMember]
		public String TradeNameKW
		{
			get { return _TradeNameKW; }
			set {_TradeNameKW=value; }
		}
		[DataMember]
		public Int64? GroupID
		{
			get { return _GroupID; }
			set {_GroupID=value; }
		}
		[DataMember]
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}
		[DataMember]
		public Int64? Status
		{
			get { return _Status; }
			set {_Status=value; }
		}
		[DataMember]
		public String Name1
		{
			get { return _Name1; }
			set {_Name1=value; }
		}
		[DataMember]
		public String Name2
		{
			get { return _Name2; }
			set {_Name2=value; }
		}
		[DataMember]
		public String Name3
		{
			get { return _Name3; }
			set {_Name3=value; }
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
		public DateTime? JoinDateBD
		{
			get { return _JoinDateBD; }
			set {_JoinDateBD=value; }
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
		public Int64? ReligionID
		{
			get { return _ReligionID; }
			set {_ReligionID=value; }
		}
		[DataMember]
		public String Religion
		{
			get { return _Religion; }
			set {_Religion=value; }
		}
		[DataMember]
		public Int64? BloodGroupId
		{
			get { return _BloodGroupId; }
			set {_BloodGroupId=value; }
		}
		[DataMember]
		public String BloodGroup
		{
			get { return _BloodGroup; }
			set {_BloodGroup=value; }
		}
		[DataMember]
		public Int64? MaritalStatusID
		{
			get { return _MaritalStatusID; }
			set {_MaritalStatusID=value; }
		}
		[DataMember]
		public String MaritalStatus
		{
			get { return _MaritalStatus; }
			set {_MaritalStatus=value; }
		}
		[DataMember]
		public Int64? GenderID
		{
			get { return _GenderID; }
			set {_GenderID=value; }
		}
		[DataMember]
		public String Gender
		{
			get { return _Gender; }
			set {_Gender=value; }
		}
		[DataMember]
		public Int64? NationalityID
		{
			get { return _NationalityID; }
			set {_NationalityID=value; }
		}
		[DataMember]
		public String Nationality
		{
			get { return _Nationality; }
			set {_Nationality=value; }
		}
		[DataMember]
		public Int64? BuildingID
		{
			get { return _BuildingID; }
			set {_BuildingID=value; }
		}
		[DataMember]
		public String BuildingName
		{
			get { return _BuildingName; }
			set {_BuildingName=value; }
		}
		[DataMember]
		public Int64? KWGovID
		{
			get { return _KWGovID; }
			set {_KWGovID=value; }
		}
		[DataMember]
		public String KWGov
		{
			get { return _KWGov; }
			set {_KWGov=value; }
		}
		[DataMember]
		public Int64? KWAreaID
		{
			get { return _KWAreaID; }
			set {_KWAreaID=value; }
		}
		[DataMember]
		public String KWArea
		{
			get { return _KWArea; }
			set {_KWArea=value; }
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
		public String BDCurDiv
		{
			get { return _BDCurDiv; }
			set {_BDCurDiv=value; }
		}
		[DataMember]
		public Int64? BDCurCityID
		{
			get { return _BDCurCityID; }
			set {_BDCurCityID=value; }
		}
		[DataMember]
		public String BDCurCity
		{
			get { return _BDCurCity; }
			set {_BDCurCity=value; }
		}
		[DataMember]
		public Int64? BDCurThanaID
		{
			get { return _BDCurThanaID; }
			set {_BDCurThanaID=value; }
		}
		[DataMember]
		public String BDCurThana
		{
			get { return _BDCurThana; }
			set {_BDCurThana=value; }
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
		public Int64? BDPerDivID
		{
			get { return _BDPerDivID; }
			set {_BDPerDivID=value; }
		}
		[DataMember]
		public String BDPerDiv
		{
			get { return _BDPerDiv; }
			set {_BDPerDiv=value; }
		}
		[DataMember]
		public Int64? BDPerCityID
		{
			get { return _BDPerCityID; }
			set {_BDPerCityID=value; }
		}
		[DataMember]
		public String BDPerCity
		{
			get { return _BDPerCity; }
			set {_BDPerCity=value; }
		}
		[DataMember]
		public Int64? BDPerThanaID
		{
			get { return _BDPerThanaID; }
			set {_BDPerThanaID=value; }
		}
		[DataMember]
		public String BDPerThana
		{
			get { return _BDPerThana; }
			set {_BDPerThana=value; }
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
		public Int64? BankID
		{
			get { return _BankID; }
			set {_BankID=value; }
		}
		[DataMember]
		public String BankName
		{
			get { return _BankName; }
			set {_BankName=value; }
		}
		[DataMember]
		public Int64? BranchID
		{
			get { return _BranchID; }
			set {_BranchID=value; }
		}
		[DataMember]
		public String BranchName
		{
			get { return _BranchName; }
			set {_BranchName=value; }
		}
		[DataMember]
		public String AccountNo
		{
			get { return _AccountNo; }
			set {_AccountNo=value; }
		}
		[DataMember]
		public String AccountName
		{
			get { return _AccountName; }
			set {_AccountName=value; }
		}
		[DataMember]
		public String AccountDescription
		{
			get { return _AccountDescription; }
			set {_AccountDescription=value; }
		}
		[DataMember]
		public String ResidencyNumber
		{
			get { return _ResidencyNumber; }
			set {_ResidencyNumber=value; }
		}
		[DataMember]
		public DateTime? IssueDate
		{
			get { return _IssueDate; }
			set {_IssueDate=value; }
		}
		[DataMember]
		public DateTime? ExpiryDate
		{
			get { return _ExpiryDate; }
			set {_ExpiryDate=value; }
		}
		[DataMember]
		public Boolean? IsFamilyVISA
		{
			get { return _IsFamilyVISA; }
			set {_IsFamilyVISA=value; }
		}
		[DataMember]
		public String ProfilePhoto
		{
			get { return _ProfilePhoto; }
			set {_ProfilePhoto=value; }
		}
		[DataMember]
		public String ProfilePhotoFilePath
		{
			get { return _ProfilePhotoFilePath; }
			set {_ProfilePhotoFilePath=value; }
		}
		[DataMember]
		public String ProfilePhotoFileName
		{
			get { return _ProfilePhotoFileName; }
			set {_ProfilePhotoFileName=value; }
		}
		[DataMember]
		public String ProfilePhotoFileType
		{
			get { return _ProfilePhotoFileType; }
			set {_ProfilePhotoFileType=value; }
		}
		[DataMember]
		public String ProfilePhotoFileExtension
		{
			get { return _ProfilePhotoFileExtension; }
			set {_ProfilePhotoFileExtension=value; }
		}
		[DataMember]
		public Int32? ForReview
		{
			get { return _ForReview; }
			set {_ForReview=value; }
		}
		[DataMember]
		public string BasicProfileStatus
		{
			get { return _BasicProfileStatus; }
			set {_BasicProfileStatus=value; }
		}
		public KAF_GetProfileInfoEntity():base()
		{

		}

		public KAF_GetProfileInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _HRBasicID = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDSmartCardID"))) _BDSmartCardID = reader.GetInt64(reader.GetOrdinal("BDSmartCardID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _NationalID = reader.GetString(reader.GetOrdinal("NationalID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _CivilID = reader.GetInt64(reader.GetOrdinal("CivilID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpireDate"))) _CivilIDExpireDate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpireDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _OrganizationKey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
			if (!reader.IsDBNull(reader.GetOrdinal("OrganizationName"))) _OrganizationName = reader.GetString(reader.GetOrdinal("OrganizationName"));
			if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _EntityKey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
			if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _EntityName = reader.GetString(reader.GetOrdinal("EntityName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _ArmsID = reader.GetInt64(reader.GetOrdinal("ArmsID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArmsName"))) _ArmsName = reader.GetString(reader.GetOrdinal("ArmsName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankNameKW"))) _RankNameKW = reader.GetString(reader.GetOrdinal("RankNameKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _RankIDBD = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankNameBD"))) _RankNameBD = reader.GetString(reader.GetOrdinal("RankNameBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _TradeIDBD = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeNameBD"))) _TradeNameBD = reader.GetString(reader.GetOrdinal("TradeNameBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _TradeIDKW = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeNameKW"))) _TradeNameKW = reader.GetString(reader.GetOrdinal("TradeNameKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _Status = reader.GetInt64(reader.GetOrdinal("Status"));
			if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _Name1 = reader.GetString(reader.GetOrdinal("Name1"));
			if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _Name2 = reader.GetString(reader.GetOrdinal("Name2"));
			if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _Name3 = reader.GetString(reader.GetOrdinal("Name3"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _DateofBirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateBD"))) _JoinDateBD = reader.GetDateTime(reader.GetOrdinal("JoinDateBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _ExpectedRetireDateKw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReligionID"))) _ReligionID = reader.GetInt64(reader.GetOrdinal("ReligionID"));
			if (!reader.IsDBNull(reader.GetOrdinal("Religion"))) _Religion = reader.GetString(reader.GetOrdinal("Religion"));
			if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupId"))) _BloodGroupId = reader.GetInt64(reader.GetOrdinal("BloodGroupId"));
			if (!reader.IsDBNull(reader.GetOrdinal("BloodGroup"))) _BloodGroup = reader.GetString(reader.GetOrdinal("BloodGroup"));
			if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _MaritalStatusID = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
			if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatus"))) _MaritalStatus = reader.GetString(reader.GetOrdinal("MaritalStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _GenderID = reader.GetInt64(reader.GetOrdinal("GenderID"));
			if (!reader.IsDBNull(reader.GetOrdinal("Gender"))) _Gender = reader.GetString(reader.GetOrdinal("Gender"));
			if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _NationalityID = reader.GetInt64(reader.GetOrdinal("NationalityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("Nationality"))) _Nationality = reader.GetString(reader.GetOrdinal("Nationality"));
			if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _BuildingID = reader.GetInt64(reader.GetOrdinal("BuildingID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BuildingName"))) _BuildingName = reader.GetString(reader.GetOrdinal("BuildingName"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _KWGovID = reader.GetInt64(reader.GetOrdinal("KWGovID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWGov"))) _KWGov = reader.GetString(reader.GetOrdinal("KWGov"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _KWAreaID = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWArea"))) _KWArea = reader.GetString(reader.GetOrdinal("KWArea"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _KWBlockNo = reader.GetString(reader.GetOrdinal("KWBlockNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _KWStreet = reader.GetString(reader.GetOrdinal("KWStreet"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _KWHouseNo = reader.GetString(reader.GetOrdinal("KWHouseNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _KWFlatNo = reader.GetString(reader.GetOrdinal("KWFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _KWMobile = reader.GetString(reader.GetOrdinal("KWMobile"));
			if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _KWViber = reader.GetString(reader.GetOrdinal("KWViber"));
			if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _PersonalEmail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _OfficialEmail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _BDCurDivID = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurDiv"))) _BDCurDiv = reader.GetString(reader.GetOrdinal("BDCurDiv"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _BDCurCityID = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurCity"))) _BDCurCity = reader.GetString(reader.GetOrdinal("BDCurCity"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _BDCurThanaID = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurThana"))) _BDCurThana = reader.GetString(reader.GetOrdinal("BDCurThana"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _BDCurPostOffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _BDCurRoad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _BDCurHouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _BDCurFlatNo = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _BDMob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _BDMob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _BDHomePhone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _BDPerDivID = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerDiv"))) _BDPerDiv = reader.GetString(reader.GetOrdinal("BDPerDiv"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _BDPerCityID = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerCity"))) _BDPerCity = reader.GetString(reader.GetOrdinal("BDPerCity"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _BDPerThanaID = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerThana"))) _BDPerThana = reader.GetString(reader.GetOrdinal("BDPerThana"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _BDPerPostOffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _BDPerRoad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _BDPerHouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _BDPerFlatNo = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("BankID"))) _BankID = reader.GetInt64(reader.GetOrdinal("BankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BankName"))) _BankName = reader.GetString(reader.GetOrdinal("BankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("BranchID"))) _BranchID = reader.GetInt64(reader.GetOrdinal("BranchID"));
			if (!reader.IsDBNull(reader.GetOrdinal("BranchName"))) _BranchName = reader.GetString(reader.GetOrdinal("BranchName"));
			if (!reader.IsDBNull(reader.GetOrdinal("AccountNo"))) _AccountNo = reader.GetString(reader.GetOrdinal("AccountNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("AccountName"))) _AccountName = reader.GetString(reader.GetOrdinal("AccountName"));
			if (!reader.IsDBNull(reader.GetOrdinal("AccountDescription"))) _AccountDescription = reader.GetString(reader.GetOrdinal("AccountDescription"));
			if (!reader.IsDBNull(reader.GetOrdinal("ResidencyNumber"))) _ResidencyNumber = reader.GetString(reader.GetOrdinal("ResidencyNumber"));
			if (!reader.IsDBNull(reader.GetOrdinal("IssueDate"))) _IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) _ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyVISA"))) _IsFamilyVISA = reader.GetBoolean(reader.GetOrdinal("IsFamilyVISA"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto"))) _ProfilePhoto = reader.GetString(reader.GetOrdinal("ProfilePhoto"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFilePath"))) _ProfilePhotoFilePath = reader.GetString(reader.GetOrdinal("ProfilePhotoFilePath"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileName"))) _ProfilePhotoFileName = reader.GetString(reader.GetOrdinal("ProfilePhotoFileName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileType"))) _ProfilePhotoFileType = reader.GetString(reader.GetOrdinal("ProfilePhotoFileType"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileExtension"))) _ProfilePhotoFileExtension = reader.GetString(reader.GetOrdinal("ProfilePhotoFileExtension"));
			if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _ForReview = reader.GetInt32(reader.GetOrdinal("ForReview"));
			if (!reader.IsDBNull(reader.GetOrdinal("BasicProfileStatus"))) _BasicProfileStatus = reader.GetString(reader.GetOrdinal("BasicProfileStatus"));
		}
	}
}

