using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class tran_cuttinginfodetl_GAPgListView_ExtEntity:  BaseEntity
	{
		protected Int64? _CuttingInfoDetlID;
		protected Int64? _CuttingInfoID;
		protected Int64? _HrBasicID;
		protected String _FullName;
		protected Int64? _RankID;
		protected String _RankName;
		protected Int64? _GroupID;
		protected String _GroupName;
		protected DateTime? _ProcessDate;
		protected Decimal? _PrevBalGovtCutting;
		protected Decimal? _PrevBalRegCutting;
		protected Decimal? _BasicSalary;
		protected Decimal? _RegimentalCutting;
		protected Decimal? _GovtCutting;
		protected String _Remarks;
		protected Boolean? _IsPaid;
		protected DateTime? _PaidDate;
		protected Int64? _PaidBy;
		protected String _UnPaidRemarks;
		protected Boolean? _IsReviewed;
		protected DateTime? _ReviewDate;
		protected Int64? _ReviewedBy;
		protected String _ReviewRemarks;
		protected Boolean? _IsApprove;
		protected DateTime? _ApproveDate;
		protected Int64? _ApproveBy;
		protected String _ApproveRemarks;
		protected Boolean? _IsRollBack;
		protected Int64? _RollbackBy;
		protected DateTime? _RollBackDate;
		protected String _RollBackRemarks;
		protected DateTime? _Ex_Date1;
		protected DateTime? _Ex_Date2;
		protected String _Ex_Nvarchar1;
		protected String _Ex_Nvarchar2;
		protected Int64? _Ex_Bigint1;
		protected Int64? _Ex_Bigint2;
		protected Decimal? _Ex_Decimal1;
		protected Decimal? _Ex_Decimal2;
		protected String _TransID;
		protected Int64? _UserOrganizationKey;
		protected Int64? _UserEntityKey;
		protected Int64? _CreatedBy;
		protected String _CreatedByUserName;
		protected DateTime? _CreatedDate;
		protected Int64? _UpdatedBy;
		protected String _UpdatedByUserName;
		protected DateTime? _UpdatedDate;
		protected String _IPAddress;
		protected Int64? _FormID;
		protected Int64? _TS;
		protected Int64? _RowNumber;
		protected String _CommonSerachParam;
		protected Int64? _TotalRecord;
		protected String _SortExpression;
		protected Int64? _PageSize;
		protected Int64? _CurrentPage;

		[DataMember]
		public Int64? CuttingInfoDetlID
		{
			get { return _CuttingInfoDetlID; }
			set {_CuttingInfoDetlID=value; }
		}
		[DataMember]
		public Int64? CuttingInfoID
		{
			get { return _CuttingInfoID; }
			set {_CuttingInfoID=value; }
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
		public DateTime? ProcessDate
		{
			get { return _ProcessDate; }
			set {_ProcessDate=value; }
		}
		[DataMember]
		public Decimal? PrevBalGovtCutting
		{
			get { return _PrevBalGovtCutting; }
			set {_PrevBalGovtCutting=value; }
		}
		[DataMember]
		public Decimal? PrevBalRegCutting
		{
			get { return _PrevBalRegCutting; }
			set {_PrevBalRegCutting=value; }
		}
		[DataMember]
		public Decimal? BasicSalary
		{
			get { return _BasicSalary; }
			set {_BasicSalary=value; }
		}
		[DataMember]
		public Decimal? RegimentalCutting
		{
			get { return _RegimentalCutting; }
			set {_RegimentalCutting=value; }
		}
		[DataMember]
		public Decimal? GovtCutting
		{
			get { return _GovtCutting; }
			set {_GovtCutting=value; }
		}
		[DataMember]
		public String Remarks
		{
			get { return _Remarks; }
			set {_Remarks=value; }
		}
		[DataMember]
		public Boolean? IsPaid
		{
			get { return _IsPaid; }
			set {_IsPaid=value; }
		}
		[DataMember]
		public DateTime? PaidDate
		{
			get { return _PaidDate; }
			set {_PaidDate=value; }
		}
		[DataMember]
		public Int64? PaidBy
		{
			get { return _PaidBy; }
			set {_PaidBy=value; }
		}
		[DataMember]
		public String UnPaidRemarks
		{
			get { return _UnPaidRemarks; }
			set {_UnPaidRemarks=value; }
		}
		[DataMember]
		public Boolean? IsReviewed
		{
			get { return _IsReviewed; }
			set {_IsReviewed=value; }
		}
		[DataMember]
		public DateTime? ReviewDate
		{
			get { return _ReviewDate; }
			set {_ReviewDate=value; }
		}
		[DataMember]
		public Int64? ReviewedBy
		{
			get { return _ReviewedBy; }
			set {_ReviewedBy=value; }
		}
		[DataMember]
		public String ReviewRemarks
		{
			get { return _ReviewRemarks; }
			set {_ReviewRemarks=value; }
		}
		[DataMember]
		public Boolean? IsApprove
		{
			get { return _IsApprove; }
			set {_IsApprove=value; }
		}
		[DataMember]
		public DateTime? ApproveDate
		{
			get { return _ApproveDate; }
			set {_ApproveDate=value; }
		}
		[DataMember]
		public Int64? ApproveBy
		{
			get { return _ApproveBy; }
			set {_ApproveBy=value; }
		}
		[DataMember]
		public String ApproveRemarks
		{
			get { return _ApproveRemarks; }
			set {_ApproveRemarks=value; }
		}
		[DataMember]
		public Boolean? IsRollBack
		{
			get { return _IsRollBack; }
			set {_IsRollBack=value; }
		}
		[DataMember]
		public Int64? RollbackBy
		{
			get { return _RollbackBy; }
			set {_RollbackBy=value; }
		}
		[DataMember]
		public DateTime? RollBackDate
		{
			get { return _RollBackDate; }
			set {_RollBackDate=value; }
		}
		[DataMember]
		public String RollBackRemarks
		{
			get { return _RollBackRemarks; }
			set {_RollBackRemarks=value; }
		}
		[DataMember]
		public DateTime? Ex_Date1
		{
			get { return _Ex_Date1; }
			set {_Ex_Date1=value; }
		}
		[DataMember]
		public DateTime? Ex_Date2
		{
			get { return _Ex_Date2; }
			set {_Ex_Date2=value; }
		}
		[DataMember]
		public String Ex_Nvarchar1
		{
			get { return _Ex_Nvarchar1; }
			set {_Ex_Nvarchar1=value; }
		}
		[DataMember]
		public String Ex_Nvarchar2
		{
			get { return _Ex_Nvarchar2; }
			set {_Ex_Nvarchar2=value; }
		}
		[DataMember]
		public Int64? Ex_Bigint1
		{
			get { return _Ex_Bigint1; }
			set {_Ex_Bigint1=value; }
		}
		[DataMember]
		public Int64? Ex_Bigint2
		{
			get { return _Ex_Bigint2; }
			set {_Ex_Bigint2=value; }
		}
		[DataMember]
		public Decimal? Ex_Decimal1
		{
			get { return _Ex_Decimal1; }
			set {_Ex_Decimal1=value; }
		}
		[DataMember]
		public Decimal? Ex_Decimal2
		{
			get { return _Ex_Decimal2; }
			set {_Ex_Decimal2=value; }
		}
		[DataMember]
		public String TransID
		{
			get { return _TransID; }
			set {_TransID=value; }
		}
		[DataMember]
		public Int64? UserOrganizationKey
		{
			get { return _UserOrganizationKey; }
			set {_UserOrganizationKey=value; }
		}
		[DataMember]
		public Int64? UserEntityKey
		{
			get { return _UserEntityKey; }
			set {_UserEntityKey=value; }
		}
		[DataMember]
		public Int64? CreatedBy
		{
			get { return _CreatedBy; }
			set {_CreatedBy=value; }
		}
		[DataMember]
		public String CreatedByUserName
		{
			get { return _CreatedByUserName; }
			set {_CreatedByUserName=value; }
		}
		[DataMember]
		public DateTime? CreatedDate
		{
			get { return _CreatedDate; }
			set {_CreatedDate=value; }
		}
		[DataMember]
		public Int64? UpdatedBy
		{
			get { return _UpdatedBy; }
			set {_UpdatedBy=value; }
		}
		[DataMember]
		public String UpdatedByUserName
		{
			get { return _UpdatedByUserName; }
			set {_UpdatedByUserName=value; }
		}
		[DataMember]
		public DateTime? UpdatedDate
		{
			get { return _UpdatedDate; }
			set {_UpdatedDate=value; }
		}
		[DataMember]
		public String IPAddress
		{
			get { return _IPAddress; }
			set {_IPAddress=value; }
		}
		[DataMember]
		public Int64? FormID
		{
			get { return _FormID; }
			set {_FormID=value; }
		}
		[DataMember]
		public Int64? TS
		{
			get { return _TS; }
			set {_TS=value; }
		}
		[DataMember]
		public Int64? RowNumber
		{
			get { return _RowNumber; }
			set {_RowNumber=value; }
		}
		[DataMember]
		public String CommonSerachParam
		{
			get { return _CommonSerachParam; }
			set {_CommonSerachParam=value; }
		}
		[DataMember]
		public Int64? TotalRecord
		{
			get { return _TotalRecord; }
			set {_TotalRecord=value; }
		}
		[DataMember]
		public String SortExpression
		{
			get { return _SortExpression; }
			set {_SortExpression=value; }
		}
		[DataMember]
		public Int64? PageSize
		{
			get { return _PageSize; }
			set {_PageSize=value; }
		}
		[DataMember]
		public Int64? CurrentPage
		{
			get { return _CurrentPage; }
			set {_CurrentPage=value; }
		}
		public tran_cuttinginfodetl_GAPgListView_ExtEntity():base()
		{

		}

		public tran_cuttinginfodetl_GAPgListView_ExtEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoDetlID"))) _CuttingInfoDetlID = reader.GetInt64(reader.GetOrdinal("CuttingInfoDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoID"))) _CuttingInfoID = reader.GetInt64(reader.GetOrdinal("CuttingInfoID"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _HrBasicID = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _FullName = reader.GetString(reader.GetOrdinal("FullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _RankID = reader.GetInt64(reader.GetOrdinal("RankID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _GroupID = reader.GetInt64(reader.GetOrdinal("GroupID"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ProcessDate"))) _ProcessDate = reader.GetDateTime(reader.GetOrdinal("ProcessDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevBalGovtCutting"))) _PrevBalGovtCutting = reader.GetDecimal(reader.GetOrdinal("PrevBalGovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("PrevBalRegCutting"))) _PrevBalRegCutting = reader.GetDecimal(reader.GetOrdinal("PrevBalRegCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _BasicSalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
			if (!reader.IsDBNull(reader.GetOrdinal("RegimentalCutting"))) _RegimentalCutting = reader.GetDecimal(reader.GetOrdinal("RegimentalCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("GovtCutting"))) _GovtCutting = reader.GetDecimal(reader.GetOrdinal("GovtCutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsPaid"))) _IsPaid = reader.GetBoolean(reader.GetOrdinal("IsPaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("PaidDate"))) _PaidDate = reader.GetDateTime(reader.GetOrdinal("PaidDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PaidBy"))) _PaidBy = reader.GetInt64(reader.GetOrdinal("PaidBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("UnPaidRemarks"))) _UnPaidRemarks = reader.GetString(reader.GetOrdinal("UnPaidRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsReviewed"))) _IsReviewed = reader.GetBoolean(reader.GetOrdinal("IsReviewed"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewDate"))) _ReviewDate = reader.GetDateTime(reader.GetOrdinal("ReviewDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewedBy"))) _ReviewedBy = reader.GetInt64(reader.GetOrdinal("ReviewedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReviewRemarks"))) _ReviewRemarks = reader.GetString(reader.GetOrdinal("ReviewRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsApprove"))) _IsApprove = reader.GetBoolean(reader.GetOrdinal("IsApprove"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveDate"))) _ApproveDate = reader.GetDateTime(reader.GetOrdinal("ApproveDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveBy"))) _ApproveBy = reader.GetInt64(reader.GetOrdinal("ApproveBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("ApproveRemarks"))) _ApproveRemarks = reader.GetString(reader.GetOrdinal("ApproveRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("IsRollBack"))) _IsRollBack = reader.GetBoolean(reader.GetOrdinal("IsRollBack"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollbackBy"))) _RollbackBy = reader.GetInt64(reader.GetOrdinal("RollbackBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollBackDate"))) _RollBackDate = reader.GetDateTime(reader.GetOrdinal("RollBackDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("RollBackRemarks"))) _RollBackRemarks = reader.GetString(reader.GetOrdinal("RollBackRemarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _Ex_Date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _Ex_Date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _Ex_Nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _Ex_Nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _Ex_Bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _Ex_Bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _Ex_Decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
			if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _Ex_Decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
			if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) _TransID = reader.GetString(reader.GetOrdinal("TransID"));
			if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) _UserOrganizationKey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
			if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) _UserEntityKey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
			if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) _CreatedBy = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _CreatedByUserName = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
			if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) _CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) _UpdatedBy = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
			if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _UpdatedByUserName = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
			if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) _UpdatedDate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) _IPAddress = reader.GetString(reader.GetOrdinal("IPAddress"));
			if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) _FormID = reader.GetInt64(reader.GetOrdinal("FormID"));
			if (!reader.IsDBNull(reader.GetOrdinal("TS"))) _TS = reader.GetInt64(reader.GetOrdinal("TS"));
			if (!reader.IsDBNull(reader.GetOrdinal("RowNumber"))) _RowNumber = reader.GetInt64(reader.GetOrdinal("RowNumber"));
		}
	}
}

