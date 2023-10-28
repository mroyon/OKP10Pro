using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_passportheldbyspabEntity:  BaseEntity
	{
		protected Int64? _MilNoKW;
		protected Int64? _CivilID;
		protected String _FullName;
		protected DateTime? _DateofBirth;
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
		protected DateTime? _VisaIssueLetterDate;
		protected String _VisaIssueLetterNo;
		protected Int64? _VisaIssueDetlID;
		protected Int64? _VisaDemandID;
		protected DateTime? _VisaDemandDate;
		protected DateTime? _VisaDemandLetterDate;
		protected String _VisaDemandLetterNo;
		protected String _LetterStatus;
		protected String _GroupName;
		protected Int64? _DemandType;
		protected DateTime? _FromDate;
		protected DateTime? _ToDate;

		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
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
		public String LetterStatus
		{
			get { return _LetterStatus; }
			set {_LetterStatus=value; }
		}
		[DataMember]
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}
		[DataMember]
		public Int64? DemandType
		{
			get { return _DemandType; }
			set {_DemandType=value; }
		}
		[DataMember]
		public DateTime? FromDate
		{
			get { return _FromDate; }
			set {_FromDate=value; }
		}
		[DataMember]
		public DateTime? ToDate
		{
			get { return _ToDate; }
			set {_ToDate=value; }
		}
		public rpt_passportheldbyspabEntity():base()
		{

		}

		public rpt_passportheldbyspabEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _MilNoKW = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _CivilID = reader.GetInt64(reader.GetOrdinal("CivilID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _DateofBirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
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
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterDate"))) _VisaIssueLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaIssueLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterNo"))) _VisaIssueLetterNo = reader.GetString(reader.GetOrdinal("VisaIssueLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueDetlID"))) _VisaIssueDetlID = reader.GetInt64(reader.GetOrdinal("VisaIssueDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) _VisaDemandID = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDate"))) _VisaDemandDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterDate"))) _VisaDemandLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterNo"))) _VisaDemandLetterNo = reader.GetString(reader.GetOrdinal("VisaDemandLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandType"))) _DemandType = reader.GetInt64(reader.GetOrdinal("DemandType"));
		}
	}
}

