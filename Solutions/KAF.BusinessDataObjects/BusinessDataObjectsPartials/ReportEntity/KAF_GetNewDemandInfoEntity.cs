using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    [Serializable]
    public class KAF_GetNewDemandInfoEntity : BaseEntity
    {
        protected Int64? _NewDemandID;
        protected String _DemandLetterNo;
        protected DateTime? _DemandLetterDate;
        protected Int64? _NewDemandDetlID;
        protected Int64? _RankID;
        protected String _RankName;
        protected Int64? _TradeID;
        protected String _TradeName;
        protected Int64? _GroupID;
        protected String _GroupName;
        protected Int64? _OkpID;
        protected String _OkpName;
        protected Int64? _NoOfVacancies;
        protected Int64? _NewDemandPassportID;
        protected Int64? _HrBasicID;
        protected String _FullName;
        protected String _PassportNo;
        protected Int64? _SerialNo;
        protected Int64? _HrSvcID;
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
        protected String _Reason;
        protected String _FlightCancelStatus;
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
        public Int64? MilNoKW { get; set;}

		[DataMember]
		public Int64? NewDemandID
		{
			get { return _NewDemandID; }
			set {_NewDemandID=value; }
		}
		[DataMember]
		public String DemandLetterNo
		{
			get { return _DemandLetterNo; }
			set {_DemandLetterNo=value; }
		}
		[DataMember]
		public DateTime? DemandLetterDate
		{
			get { return _DemandLetterDate; }
			set {_DemandLetterDate=value; }
		}
		[DataMember]
		public Int64? NewDemandDetlID
		{
			get { return _NewDemandDetlID; }
			set {_NewDemandDetlID=value; }
		}
		[DataMember]
		public Int64? RankID
		{
			get { return _RankID; }
			set {_RankID=value; }
		}
		[DataMember]
		public String RankName
		{
			get { return _RankName; }
			set {_RankName=value; }
		}
		[DataMember]
		public Int64? TradeID
		{
			get { return _TradeID; }
			set {_TradeID=value; }
		}
		[DataMember]
		public String TradeName
		{
			get { return _TradeName; }
			set {_TradeName=value; }
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
		public Int64? NoOfVacancies
		{
			get { return _NoOfVacancies; }
			set {_NoOfVacancies=value; }
		}
		[DataMember]
		public Int64? NewDemandPassportID
		{
			get { return _NewDemandPassportID; }
			set {_NewDemandPassportID=value; }
		}
		[DataMember]
		public Int64? HrBasicID
		{
			get { return _HrBasicID; }
			set {_HrBasicID=value; }
		}
		[DataMember]
		public String FullName
		{
			get { return _FullName; }
			set {_FullName=value; }
		}
		[DataMember]
		public String PassportNo
		{
			get { return _PassportNo; }
			set {_PassportNo=value; }
		}
		[DataMember]
		public Int64? SerialNo
		{
			get { return _SerialNo; }
			set {_SerialNo=value; }
		}
		[DataMember]
		public Int64? HrSvcID
		{
			get { return _HrSvcID; }
			set {_HrSvcID=value; }
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
		public String Reason
		{
			get { return _Reason; }
			set {_Reason=value; }
		}
		[DataMember]
		public String FlightCancelStatus
		{
			get { return _FlightCancelStatus; }
			set {_FlightCancelStatus=value; }
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
		public KAF_GetNewDemandInfoEntity():base()
		{

		}

		public KAF_GetNewDemandInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("NewDemandID"))) _NewDemandID = reader.GetInt64(reader.GetOrdinal("NewDemandID"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterNo"))) _DemandLetterNo = reader.GetString(reader.GetOrdinal("DemandLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterDate"))) _DemandLetterDate = reader.GetDateTime(reader.GetOrdinal("DemandLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewDemandDetlID"))) _NewDemandDetlID = reader.GetInt64(reader.GetOrdinal("NewDemandDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _RankID = reader.GetInt64(reader.GetOrdinal("RankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeID"))) _TradeID = reader.GetInt64(reader.GetOrdinal("TradeID"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("NoOfVacancies"))) _NoOfVacancies = reader.GetInt64(reader.GetOrdinal("NoOfVacancies"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewDemandPassportID"))) _NewDemandPassportID = reader.GetInt64(reader.GetOrdinal("NewDemandPassportID"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _SerialNo = reader.GetInt64(reader.GetOrdinal("SerialNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _HrSvcID = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
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
			if (!reader.IsDBNull(reader.GetOrdinal("Reason"))) _Reason = reader.GetString(reader.GetOrdinal("Reason"));
			if (!reader.IsDBNull(reader.GetOrdinal("FlightCancelStatus"))) _FlightCancelStatus = reader.GetString(reader.GetOrdinal("FlightCancelStatus"));
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

