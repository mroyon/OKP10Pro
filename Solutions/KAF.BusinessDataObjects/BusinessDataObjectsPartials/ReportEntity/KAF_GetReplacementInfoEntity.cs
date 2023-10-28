using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetReplacementInfoEntity:  BaseEntity
	{
		protected Int64? _ReplacementID;
		protected String _LetterNo;
		protected DateTime? _LetterDate;
		protected Int64? _ReplacementDetlID;
		protected Int64? _ReplacedBasicID;
		protected Int64? _ReplacedSvcID;
		protected String _RepFullName;
		protected String _RepPassportNo;
		protected Int64? _RepKWRankID;
		protected String _RepKWRank;
		protected Int64? _RepKWTradeID;
		protected String _RepKWTradeName;
		protected Int64? _RepGroupID;
		protected String _RepGroupName;
		protected Int64? _RepOkpID;
		protected String _RepOkpName;
		protected Int64? _RepPassportID;
		protected DateTime? _PassportRecvDate;
		protected DateTime? _PassportLetterDate;
		protected String _PassportLetterNo;
		protected Int64? _RepPassportDetlID;
		protected Int64? _RepPassBasicID;
		protected Int64? _RepPassSvcID;
		protected Int64? _NewHrBasicID;
		protected Int64? _NewHrSvcID;
		protected String _NewFullName;
		protected String _NewPassportNo;
		protected Int64? _VisaDemandID;
		protected String _DemandType;
		protected DateTime? _VisaDemandDate;
		protected DateTime? _VisaDemandLetterDate;
		protected String _VisaDemandLetterNo;
		protected Int64? _VisaDemandDetlID;
		protected Int64? _DemandDetlDemandType;
		protected Int64? _DemandBasicID;
		protected Int64? _DemandSvcID;
		protected Int64? _VisaIssueID;
		protected DateTime? _VisaIssueDate;
		protected DateTime? _VisaIssueLetterDate;
		protected String _VisaIssueLetterNo;
		protected Int64? _VisaIssueDetlID;
		protected Int64? _VisaIssueBasicID;
		protected Int64? _VisaIssueSvcID;
		protected Int64? _VisaSentDetlID;
		protected Int64? _VisaSentBasicID;
		protected Int64? _VisaSentSvcID;
		protected Int64? _VisaSentID;
		protected DateTime? _VisaSentDate;
		protected DateTime? _VisaSentLetterDate;
		protected String _VisaSentLetterNo;
		protected Int64? _PTADemandDetlID;
		protected Int64? _PTADemandBasicID;
		protected Int64? _PTADemandSvcID;
		protected Int64? _PTADemandID;
		protected DateTime? _PTADemandDate;
		protected DateTime? _PTADemandLetterDate;
		protected String _PTADemandLetterNo;
		protected Int64? _PTAReceivedDetlID;
		protected Int64? _PTAReceivedBasicID;
		protected Int64? _PTAReceivedSvcID;
		protected Int64? _PTIID;
		protected DateTime? _PTAReceivedDate;
		protected DateTime? _PTAReceivedLetterDate;
		protected String _PTAReceivedLetterNo;
		protected Int64? _FlightDetlID;
		protected Int64? _FlightBasicID;
		protected Int64? _FlightSvcID;
		protected Boolean? _IsCancel;
		protected DateTime? _CancelDate;
		protected DateTime? _CancelLetterDate;
		protected String _CancelLetterNo;
		protected String _FlightCancelStatus;
		protected String _Reason;
		protected Int64? _FlightID;
		protected DateTime? _FlightDate;
		protected DateTime? _FlightLetterDate;
		protected String _FlightLetterNo;
		protected Int64? _AirlinesID;
		protected Int64? _ArrivalDetllD;
		protected Int64? _ArrivalBasicID;
		protected Int64? _ArrivalSvcID;
		protected Int64? _ArrivallD;
		protected DateTime? _ArrivalDate;
		protected DateTime? _ArrivalLetterDate;
		protected String _ArrivalLetterNo;
		protected String _ReplacementLetterNo;
		protected String _PassportNo;
		protected Int64? _MilNoKW;

		[DataMember]
		public Int64? ReplacementID
		{
			get { return _ReplacementID; }
			set {_ReplacementID=value; }
		}
		[DataMember]
		public String LetterNo
		{
			get { return _LetterNo; }
			set {_LetterNo=value; }
		}
		[DataMember]
		public DateTime? LetterDate
		{
			get { return _LetterDate; }
			set {_LetterDate=value; }
		}
		[DataMember]
		public Int64? ReplacementDetlID
		{
			get { return _ReplacementDetlID; }
			set {_ReplacementDetlID=value; }
		}
		[DataMember]
		public Int64? ReplacedBasicID
		{
			get { return _ReplacedBasicID; }
			set {_ReplacedBasicID=value; }
		}
		[DataMember]
		public Int64? ReplacedSvcID
		{
			get { return _ReplacedSvcID; }
			set {_ReplacedSvcID=value; }
		}
		[DataMember]
		public String RepFullName
		{
			get { return _RepFullName; }
			set {_RepFullName=value; }
		}
		[DataMember]
		public String RepPassportNo
		{
			get { return _RepPassportNo; }
			set {_RepPassportNo=value; }
		}
		[DataMember]
		public Int64? RepKWRankID
		{
			get { return _RepKWRankID; }
			set {_RepKWRankID=value; }
		}
		[DataMember]
		public String RepKWRank
		{
			get { return _RepKWRank; }
			set {_RepKWRank=value; }
		}
		[DataMember]
		public Int64? RepKWTradeID
		{
			get { return _RepKWTradeID; }
			set {_RepKWTradeID=value; }
		}
		[DataMember]
		public String RepKWTradeName
		{
			get { return _RepKWTradeName; }
			set {_RepKWTradeName=value; }
		}
		[DataMember]
		public Int64? RepGroupID
		{
			get { return _RepGroupID; }
			set {_RepGroupID=value; }
		}
		[DataMember]
		public String RepGroupName
		{
			get { return _RepGroupName; }
			set {_RepGroupName=value; }
		}
		[DataMember]
		public Int64? RepOkpID
		{
			get { return _RepOkpID; }
			set {_RepOkpID=value; }
		}
		[DataMember]
		public String RepOkpName
		{
			get { return _RepOkpName; }
			set {_RepOkpName=value; }
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
		public Int64? RepPassportDetlID
		{
			get { return _RepPassportDetlID; }
			set {_RepPassportDetlID=value; }
		}
		[DataMember]
		public Int64? RepPassBasicID
		{
			get { return _RepPassBasicID; }
			set {_RepPassBasicID=value; }
		}
		[DataMember]
		public Int64? RepPassSvcID
		{
			get { return _RepPassSvcID; }
			set {_RepPassSvcID=value; }
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
		public String NewFullName
		{
			get { return _NewFullName; }
			set {_NewFullName=value; }
		}
		[DataMember]
		public String NewPassportNo
		{
			get { return _NewPassportNo; }
			set {_NewPassportNo=value; }
		}
		[DataMember]
		public Int64? VisaDemandID
		{
			get { return _VisaDemandID; }
			set {_VisaDemandID=value; }
		}
		[DataMember]
		public String DemandType
		{
			get { return _DemandType; }
			set {_DemandType=value; }
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
		public Int64? VisaDemandDetlID
		{
			get { return _VisaDemandDetlID; }
			set {_VisaDemandDetlID=value; }
		}
		[DataMember]
		public Int64? DemandDetlDemandType
		{
			get { return _DemandDetlDemandType; }
			set {_DemandDetlDemandType=value; }
		}
		[DataMember]
		public Int64? DemandBasicID
		{
			get { return _DemandBasicID; }
			set {_DemandBasicID=value; }
		}
		[DataMember]
		public Int64? DemandSvcID
		{
			get { return _DemandSvcID; }
			set {_DemandSvcID=value; }
		}
		[DataMember]
		public Int64? VisaIssueID
		{
			get { return _VisaIssueID; }
			set {_VisaIssueID=value; }
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
		public Int64? VisaIssueBasicID
		{
			get { return _VisaIssueBasicID; }
			set {_VisaIssueBasicID=value; }
		}
		[DataMember]
		public Int64? VisaIssueSvcID
		{
			get { return _VisaIssueSvcID; }
			set {_VisaIssueSvcID=value; }
		}
		[DataMember]
		public Int64? VisaSentDetlID
		{
			get { return _VisaSentDetlID; }
			set {_VisaSentDetlID=value; }
		}
		[DataMember]
		public Int64? VisaSentBasicID
		{
			get { return _VisaSentBasicID; }
			set {_VisaSentBasicID=value; }
		}
		[DataMember]
		public Int64? VisaSentSvcID
		{
			get { return _VisaSentSvcID; }
			set {_VisaSentSvcID=value; }
		}
		[DataMember]
		public Int64? VisaSentID
		{
			get { return _VisaSentID; }
			set {_VisaSentID=value; }
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
		public Int64? PTADemandDetlID
		{
			get { return _PTADemandDetlID; }
			set {_PTADemandDetlID=value; }
		}
		[DataMember]
		public Int64? PTADemandBasicID
		{
			get { return _PTADemandBasicID; }
			set {_PTADemandBasicID=value; }
		}
		[DataMember]
		public Int64? PTADemandSvcID
		{
			get { return _PTADemandSvcID; }
			set {_PTADemandSvcID=value; }
		}
		[DataMember]
		public Int64? PTADemandID
		{
			get { return _PTADemandID; }
			set {_PTADemandID=value; }
		}
		[DataMember]
		public DateTime? PTADemandDate
		{
			get { return _PTADemandDate; }
			set {_PTADemandDate=value; }
		}
		[DataMember]
		public DateTime? PTADemandLetterDate
		{
			get { return _PTADemandLetterDate; }
			set {_PTADemandLetterDate=value; }
		}
		[DataMember]
		public String PTADemandLetterNo
		{
			get { return _PTADemandLetterNo; }
			set {_PTADemandLetterNo=value; }
		}
		[DataMember]
		public Int64? PTAReceivedDetlID
		{
			get { return _PTAReceivedDetlID; }
			set {_PTAReceivedDetlID=value; }
		}
		[DataMember]
		public Int64? PTAReceivedBasicID
		{
			get { return _PTAReceivedBasicID; }
			set {_PTAReceivedBasicID=value; }
		}
		[DataMember]
		public Int64? PTAReceivedSvcID
		{
			get { return _PTAReceivedSvcID; }
			set {_PTAReceivedSvcID=value; }
		}
		[DataMember]
		public Int64? PTIID
		{
			get { return _PTIID; }
			set {_PTIID=value; }
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
		public Int64? FlightDetlID
		{
			get { return _FlightDetlID; }
			set {_FlightDetlID=value; }
		}
		[DataMember]
		public Int64? FlightBasicID
		{
			get { return _FlightBasicID; }
			set {_FlightBasicID=value; }
		}
		[DataMember]
		public Int64? FlightSvcID
		{
			get { return _FlightSvcID; }
			set {_FlightSvcID=value; }
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
		public String FlightCancelStatus
		{
			get { return _FlightCancelStatus; }
			set {_FlightCancelStatus=value; }
		}
		[DataMember]
		public String Reason
		{
			get { return _Reason; }
			set {_Reason=value; }
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
		public DateTime? FlightLetterDate
		{
			get { return _FlightLetterDate; }
			set {_FlightLetterDate=value; }
		}
		[DataMember]
		public String FlightLetterNo
		{
			get { return _FlightLetterNo; }
			set {_FlightLetterNo=value; }
		}
		[DataMember]
		public Int64? AirlinesID
		{
			get { return _AirlinesID; }
			set {_AirlinesID=value; }
		}
		[DataMember]
		public Int64? ArrivalDetllD
		{
			get { return _ArrivalDetllD; }
			set {_ArrivalDetllD=value; }
		}
		[DataMember]
		public Int64? ArrivalBasicID
		{
			get { return _ArrivalBasicID; }
			set {_ArrivalBasicID=value; }
		}
		[DataMember]
		public Int64? ArrivalSvcID
		{
			get { return _ArrivalSvcID; }
			set {_ArrivalSvcID=value; }
		}
		[DataMember]
		public Int64? ArrivallD
		{
			get { return _ArrivallD; }
			set {_ArrivallD=value; }
		}
		[DataMember]
		public DateTime? ArrivalDate
		{
			get { return _ArrivalDate; }
			set {_ArrivalDate=value; }
		}
		[DataMember]
		public DateTime? ArrivalLetterDate
		{
			get { return _ArrivalLetterDate; }
			set {_ArrivalLetterDate=value; }
		}
		[DataMember]
		public String ArrivalLetterNo
		{
			get { return _ArrivalLetterNo; }
			set {_ArrivalLetterNo=value; }
		}
		[DataMember]
		public String ReplacementLetterNo
		{
			get { return _ReplacementLetterNo; }
			set {_ReplacementLetterNo=value; }
		}
		[DataMember]
		public String PassportNo
		{
			get { return _PassportNo; }
			set {_PassportNo=value; }
		}
		[DataMember]
		public Int64? MilNoKW
		{
			get { return _MilNoKW; }
			set {_MilNoKW=value; }
		}
		public KAF_GetReplacementInfoEntity():base()
		{

		}

		public KAF_GetReplacementInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("ReplacementID"))) _ReplacementID = reader.GetInt64(reader.GetOrdinal("ReplacementID"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _LetterNo = reader.GetString(reader.GetOrdinal("LetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _LetterDate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReplacementDetlID"))) _ReplacementDetlID = reader.GetInt64(reader.GetOrdinal("ReplacementDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReplacedBasicID"))) _ReplacedBasicID = reader.GetInt64(reader.GetOrdinal("ReplacedBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReplacedSvcID"))) _ReplacedSvcID = reader.GetInt64(reader.GetOrdinal("ReplacedSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepFullName"))) _RepFullName = reader.GetString(reader.GetOrdinal("RepFullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportNo"))) _RepPassportNo = reader.GetString(reader.GetOrdinal("RepPassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepKWRankID"))) _RepKWRankID = reader.GetInt64(reader.GetOrdinal("RepKWRankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepKWRank"))) _RepKWRank = reader.GetString(reader.GetOrdinal("RepKWRank"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepKWTradeID"))) _RepKWTradeID = reader.GetInt64(reader.GetOrdinal("RepKWTradeID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepKWTradeName"))) _RepKWTradeName = reader.GetString(reader.GetOrdinal("RepKWTradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepGroupID"))) _RepGroupID = reader.GetInt64(reader.GetOrdinal("RepGroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepGroupName"))) _RepGroupName = reader.GetString(reader.GetOrdinal("RepGroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepOkpID"))) _RepOkpID = reader.GetInt64(reader.GetOrdinal("RepOkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepOkpName"))) _RepOkpName = reader.GetString(reader.GetOrdinal("RepOkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportID"))) _RepPassportID = reader.GetInt64(reader.GetOrdinal("RepPassportID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _PassportRecvDate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterDate"))) _PassportLetterDate = reader.GetDateTime(reader.GetOrdinal("PassportLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterNo"))) _PassportLetterNo = reader.GetString(reader.GetOrdinal("PassportLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportDetlID"))) _RepPassportDetlID = reader.GetInt64(reader.GetOrdinal("RepPassportDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassBasicID"))) _RepPassBasicID = reader.GetInt64(reader.GetOrdinal("RepPassBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassSvcID"))) _RepPassSvcID = reader.GetInt64(reader.GetOrdinal("RepPassSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrBasicID"))) _NewHrBasicID = reader.GetInt64(reader.GetOrdinal("NewHrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrSvcID"))) _NewHrSvcID = reader.GetInt64(reader.GetOrdinal("NewHrSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewFullName"))) _NewFullName = reader.GetString(reader.GetOrdinal("NewFullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewPassportNo"))) _NewPassportNo = reader.GetString(reader.GetOrdinal("NewPassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) _VisaDemandID = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandType"))) _DemandType = reader.GetString(reader.GetOrdinal("DemandType"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDate"))) _VisaDemandDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterDate"))) _VisaDemandLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaDemandLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterNo"))) _VisaDemandLetterNo = reader.GetString(reader.GetOrdinal("VisaDemandLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDetlID"))) _VisaDemandDetlID = reader.GetInt64(reader.GetOrdinal("VisaDemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandDetlDemandType"))) _DemandDetlDemandType = reader.GetInt64(reader.GetOrdinal("DemandDetlDemandType"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandBasicID"))) _DemandBasicID = reader.GetInt64(reader.GetOrdinal("DemandBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandSvcID"))) _DemandSvcID = reader.GetInt64(reader.GetOrdinal("DemandSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueID"))) _VisaIssueID = reader.GetInt64(reader.GetOrdinal("VisaIssueID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueDate"))) _VisaIssueDate = reader.GetDateTime(reader.GetOrdinal("VisaIssueDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterDate"))) _VisaIssueLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaIssueLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueLetterNo"))) _VisaIssueLetterNo = reader.GetString(reader.GetOrdinal("VisaIssueLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueDetlID"))) _VisaIssueDetlID = reader.GetInt64(reader.GetOrdinal("VisaIssueDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueBasicID"))) _VisaIssueBasicID = reader.GetInt64(reader.GetOrdinal("VisaIssueBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaIssueSvcID"))) _VisaIssueSvcID = reader.GetInt64(reader.GetOrdinal("VisaIssueSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentDetlID"))) _VisaSentDetlID = reader.GetInt64(reader.GetOrdinal("VisaSentDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentBasicID"))) _VisaSentBasicID = reader.GetInt64(reader.GetOrdinal("VisaSentBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentSvcID"))) _VisaSentSvcID = reader.GetInt64(reader.GetOrdinal("VisaSentSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentID"))) _VisaSentID = reader.GetInt64(reader.GetOrdinal("VisaSentID"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentDate"))) _VisaSentDate = reader.GetDateTime(reader.GetOrdinal("VisaSentDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentLetterDate"))) _VisaSentLetterDate = reader.GetDateTime(reader.GetOrdinal("VisaSentLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("VisaSentLetterNo"))) _VisaSentLetterNo = reader.GetString(reader.GetOrdinal("VisaSentLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandDetlID"))) _PTADemandDetlID = reader.GetInt64(reader.GetOrdinal("PTADemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandBasicID"))) _PTADemandBasicID = reader.GetInt64(reader.GetOrdinal("PTADemandBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandSvcID"))) _PTADemandSvcID = reader.GetInt64(reader.GetOrdinal("PTADemandSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandID"))) _PTADemandID = reader.GetInt64(reader.GetOrdinal("PTADemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandDate"))) _PTADemandDate = reader.GetDateTime(reader.GetOrdinal("PTADemandDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandLetterDate"))) _PTADemandLetterDate = reader.GetDateTime(reader.GetOrdinal("PTADemandLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTADemandLetterNo"))) _PTADemandLetterNo = reader.GetString(reader.GetOrdinal("PTADemandLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedDetlID"))) _PTAReceivedDetlID = reader.GetInt64(reader.GetOrdinal("PTAReceivedDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedBasicID"))) _PTAReceivedBasicID = reader.GetInt64(reader.GetOrdinal("PTAReceivedBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedSvcID"))) _PTAReceivedSvcID = reader.GetInt64(reader.GetOrdinal("PTAReceivedSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTIID"))) _PTIID = reader.GetInt64(reader.GetOrdinal("PTIID"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedDate"))) _PTAReceivedDate = reader.GetDateTime(reader.GetOrdinal("PTAReceivedDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedLetterDate"))) _PTAReceivedLetterDate = reader.GetDateTime(reader.GetOrdinal("PTAReceivedLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PTAReceivedLetterNo"))) _PTAReceivedLetterNo = reader.GetString(reader.GetOrdinal("PTAReceivedLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDetlID"))) _FlightDetlID = reader.GetInt64(reader.GetOrdinal("FlightDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightBasicID"))) _FlightBasicID = reader.GetInt64(reader.GetOrdinal("FlightBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightSvcID"))) _FlightSvcID = reader.GetInt64(reader.GetOrdinal("FlightSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsCancel"))) _IsCancel = reader.GetBoolean(reader.GetOrdinal("IsCancel"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelDate"))) _CancelDate = reader.GetDateTime(reader.GetOrdinal("CancelDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterDate"))) _CancelLetterDate = reader.GetDateTime(reader.GetOrdinal("CancelLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("CancelLetterNo"))) _CancelLetterNo = reader.GetString(reader.GetOrdinal("CancelLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightCancelStatus"))) _FlightCancelStatus = reader.GetString(reader.GetOrdinal("FlightCancelStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _Reason = reader.GetString(reader.GetOrdinal("Reason"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightID"))) _FlightID = reader.GetInt64(reader.GetOrdinal("FlightID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightDate"))) _FlightDate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterDate"))) _FlightLetterDate = reader.GetDateTime(reader.GetOrdinal("FlightLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightLetterNo"))) _FlightLetterNo = reader.GetString(reader.GetOrdinal("FlightLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("AirlinesID"))) _AirlinesID = reader.GetInt64(reader.GetOrdinal("AirlinesID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalDetllD"))) _ArrivalDetllD = reader.GetInt64(reader.GetOrdinal("ArrivalDetllD"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalBasicID"))) _ArrivalBasicID = reader.GetInt64(reader.GetOrdinal("ArrivalBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalSvcID"))) _ArrivalSvcID = reader.GetInt64(reader.GetOrdinal("ArrivalSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivallD"))) _ArrivallD = reader.GetInt64(reader.GetOrdinal("ArrivallD"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalDate"))) _ArrivalDate = reader.GetDateTime(reader.GetOrdinal("ArrivalDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalLetterDate"))) _ArrivalLetterDate = reader.GetDateTime(reader.GetOrdinal("ArrivalLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArrivalLetterNo"))) _ArrivalLetterNo = reader.GetString(reader.GetOrdinal("ArrivalLetterNo"));
		}
	}
}

