using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_ptareceivedwithflightinfoEntity
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
		protected DateTime? _VisaIssueDate;
		protected DateTime? _VisaExpDate;
		protected DateTime? _VisaIssueLetterDate;
		protected String _VisaIssueLetterNo;
		protected Int64? _VisaIssueDetlID;
		protected Int64? _VisaDemandID;
		protected DateTime? _VisaDemandDate;
		protected DateTime? _VisaDemandLetterDate;
		protected String _VisaDemandLetterNo;
		protected DateTime? _VisaSentDate;
		protected DateTime? _VisaSentLetterDate;
		protected String _VisaSentLetterNo;
		protected Int64? _VisaSentID;
		protected Int64? _VisaSentDetlID;
		protected DateTime? _PTIDate;
		protected String _PTILetterNo;
		protected DateTime? _PTILetterDate;
		protected Int64? _PTADemandID;
		protected Int64? _PTIDemandDetlID;
		protected Int64? _FlightID;
		protected DateTime? _FlightDate;
		protected String _FlightLetterNo;
		protected DateTime? _FlightLetterDate;
		protected Int64? _FlightDetlID;
		protected Boolean? _IsCancel;
		protected DateTime? _CancelDate;
		protected DateTime? _CancelLetterDate;
		protected String _CancelLetterNo;
		protected String _Reason;
		protected Int32? _ArrivalDetllD;
		protected Int32? _ReIssued;
		protected DateTime? _PTAReceivedDate;
		protected DateTime? _PTAReceivedLetterDate;
		protected String _PTAReceivedLetterNo;
		protected Int64? _PTIDetlID;
		protected Int64? _PTIID;
		protected String _LetterStatus;
		protected Int64? _PTAReceivedID;
        public String GroupName { get; set; }

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
		public DateTime? VisaIssueDate
		{
			get { return _VisaIssueDate; }
			set {_VisaIssueDate=value; }
		}
		[DataMember]
		public DateTime? VisaExpDate
		{
			get { return _VisaExpDate; }
			set {_VisaExpDate=value; }
		}
		[DataMember]
		public DateTime? VisaIssueLetterDate
		{
			get { return _VisaIssueLetterDate; }
			set {_VisaIssueLetterDate=value; }
		}
		[DataMember]
		public String VisaIssueLetterNo
		{
			get { return _VisaIssueLetterNo; }
			set {_VisaIssueLetterNo=value; }
		}
		[DataMember]
		public Int64? VisaIssueDetlID
		{
			get { return _VisaIssueDetlID; }
			set {_VisaIssueDetlID=value; }
		}
		[DataMember]
		public Int64? VisaDemandID
		{
			get { return _VisaDemandID; }
			set {_VisaDemandID=value; }
		}
		[DataMember]
		public DateTime? VisaDemandDate
		{
			get { return _VisaDemandDate; }
			set {_VisaDemandDate=value; }
		}
		[DataMember]
		public DateTime? VisaDemandLetterDate
		{
			get { return _VisaDemandLetterDate; }
			set {_VisaDemandLetterDate=value; }
		}
		[DataMember]
		public String VisaDemandLetterNo
		{
			get { return _VisaDemandLetterNo; }
			set {_VisaDemandLetterNo=value; }
		}
		[DataMember]
		public DateTime? VisaSentDate
		{
			get { return _VisaSentDate; }
			set {_VisaSentDate=value; }
		}
		[DataMember]
		public DateTime? VisaSentLetterDate
		{
			get { return _VisaSentLetterDate; }
			set {_VisaSentLetterDate=value; }
		}
		[DataMember]
		public String VisaSentLetterNo
		{
			get { return _VisaSentLetterNo; }
			set {_VisaSentLetterNo=value; }
		}
		[DataMember]
		public Int64? VisaSentID
		{
			get { return _VisaSentID; }
			set {_VisaSentID=value; }
		}
		[DataMember]
		public Int64? VisaSentDetlID
		{
			get { return _VisaSentDetlID; }
			set {_VisaSentDetlID=value; }
		}
		[DataMember]
		public DateTime? PTIDate
		{
			get { return _PTIDate; }
			set {_PTIDate=value; }
		}
		[DataMember]
		public String PTILetterNo
		{
			get { return _PTILetterNo; }
			set {_PTILetterNo=value; }
		}
		[DataMember]
		public DateTime? PTILetterDate
		{
			get { return _PTILetterDate; }
			set {_PTILetterDate=value; }
		}
		[DataMember]
		public Int64? PTADemandID
		{
			get { return _PTADemandID; }
			set {_PTADemandID=value; }
		}
		[DataMember]
		public Int64? PTIDemandDetlID
		{
			get { return _PTIDemandDetlID; }
			set {_PTIDemandDetlID=value; }
		}
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
		public String FlightLetterNo
		{
			get { return _FlightLetterNo; }
			set {_FlightLetterNo=value; }
		}
		[DataMember]
		public DateTime? FlightLetterDate
		{
			get { return _FlightLetterDate; }
			set {_FlightLetterDate=value; }
		}
		[DataMember]
		public Int64? FlightDetlID
		{
			get { return _FlightDetlID; }
			set {_FlightDetlID=value; }
		}
		[DataMember]
		public Boolean? IsCancel
		{
			get { return _IsCancel; }
			set {_IsCancel=value; }
		}
		[DataMember]
		public DateTime? CancelDate
		{
			get { return _CancelDate; }
			set {_CancelDate=value; }
		}
		[DataMember]
		public DateTime? CancelLetterDate
		{
			get { return _CancelLetterDate; }
			set {_CancelLetterDate=value; }
		}
		[DataMember]
		public String CancelLetterNo
		{
			get { return _CancelLetterNo; }
			set {_CancelLetterNo=value; }
		}
		[DataMember]
		public String Reason
		{
			get { return _Reason; }
			set {_Reason=value; }
		}
		[DataMember]
		public Int32? ArrivalDetllD
		{
			get { return _ArrivalDetllD; }
			set {_ArrivalDetllD=value; }
		}
		[DataMember]
		public Int32? ReIssued
		{
			get { return _ReIssued; }
			set {_ReIssued=value; }
		}
		[DataMember]
		public DateTime? PTAReceivedDate
		{
			get { return _PTAReceivedDate; }
			set {_PTAReceivedDate=value; }
		}
		[DataMember]
		public DateTime? PTAReceivedLetterDate
		{
			get { return _PTAReceivedLetterDate; }
			set {_PTAReceivedLetterDate=value; }
		}
		[DataMember]
		public String PTAReceivedLetterNo
		{
			get { return _PTAReceivedLetterNo; }
			set {_PTAReceivedLetterNo=value; }
		}
		[DataMember]
		public Int64? PTIDetlID
		{
			get { return _PTIDetlID; }
			set {_PTIDetlID=value; }
		}
		[DataMember]
		public Int64? PTIID
		{
			get { return _PTIID; }
			set {_PTIID=value; }
		}
		[DataMember]
		public String LetterStatus
		{
			get { return _LetterStatus; }
			set {_LetterStatus=value; }
		}
		[DataMember]
		public Int64? PTAReceivedID
		{
			get { return _PTAReceivedID; }
			set {_PTAReceivedID=value; }
		}
		public rpt_ptareceivedwithflightinfoEntity():base()
		{

		}

		public rpt_ptareceivedwithflightinfoEntity(IDataReader reader)
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
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueDate"))) _VisaIssueDate = reader.GetDateTime(reader.GetOrdinal("VisaIssueDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaExpDate"))) _VisaExpDate = reader.GetDateTime(reader.GetOrdinal("VisaExpDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterDate"))) _VisaIssueLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaIssueLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterNo"))) _VisaIssueLetterNo = reader.GetString(reader.GetOrdinal("VisaIssueLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueDetlID"))) _VisaIssueDetlID = reader.GetInt64(reader.GetOrdinal("VisaIssueDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) _VisaDemandID = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDate"))) _VisaDemandDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterDate"))) _VisaDemandLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterNo"))) _VisaDemandLetterNo = reader.GetString(reader.GetOrdinal("VisaDemandLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentDate"))) _VisaSentDate = reader.GetDateTime(reader.GetOrdinal("VisaSentDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentLetterDate"))) _VisaSentLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaSentLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentLetterNo"))) _VisaSentLetterNo = reader.GetString(reader.GetOrdinal("VisaSentLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentID"))) _VisaSentID = reader.GetInt64(reader.GetOrdinal("VisaSentID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentDetlID"))) _VisaSentDetlID = reader.GetInt64(reader.GetOrdinal("VisaSentDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTIDate"))) _PTIDate = reader.GetDateTime(reader.GetOrdinal("PTIDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTILetterNo"))) _PTILetterNo = reader.GetString(reader.GetOrdinal("PTILetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTILetterDate"))) _PTILetterDate = reader.GetDateTime(reader.GetOrdinal("PTILetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandID"))) _PTADemandID = reader.GetInt64(reader.GetOrdinal("PTADemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTIDemandDetlID"))) _PTIDemandDetlID = reader.GetInt64(reader.GetOrdinal("PTIDemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _FlightID = reader.GetInt64(reader.GetOrdinal("FlightID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _FlightDate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterNo"))) _FlightLetterNo = reader.GetString(reader.GetOrdinal("FlightLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterDate"))) _FlightLetterDate = reader.GetDateTime(reader.GetOrdinal("FlightLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDetlID"))) _FlightDetlID = reader.GetInt64(reader.GetOrdinal("FlightDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsCancel"))) _IsCancel = reader.GetBoolean(reader.GetOrdinal("IsCancel"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelDate"))) _CancelDate = reader.GetDateTime(reader.GetOrdinal("CancelDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterDate"))) _CancelLetterDate = reader.GetDateTime(reader.GetOrdinal("CancelLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterNo"))) _CancelLetterNo = reader.GetString(reader.GetOrdinal("CancelLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _Reason = reader.GetString(reader.GetOrdinal("Reason"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalDetllD"))) _ArrivalDetllD = reader.GetInt32(reader.GetOrdinal("ArrivalDetllD"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReIssued"))) _ReIssued = reader.GetInt32(reader.GetOrdinal("ReIssued"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedDate"))) _PTAReceivedDate = reader.GetDateTime(reader.GetOrdinal("PTAReceivedDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedLetterDate"))) _PTAReceivedLetterDate = reader.GetDateTime(reader.GetOrdinal("PTAReceivedLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedLetterNo"))) _PTAReceivedLetterNo = reader.GetString(reader.GetOrdinal("PTAReceivedLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTIDetlID"))) _PTIDetlID = reader.GetInt64(reader.GetOrdinal("PTIDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTIID"))) _PTIID = reader.GetInt64(reader.GetOrdinal("PTIID"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
            if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) GroupName = reader.GetString(reader.GetOrdinal("GroupName"));

        }
    }
}

