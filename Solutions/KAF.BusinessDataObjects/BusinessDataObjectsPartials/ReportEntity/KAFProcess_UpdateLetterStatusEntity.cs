using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAFProcess_UpdateLetterStatusEntity:  BaseEntity
	{
		protected Int64? _LetterID;
		protected Int64? _LetterType;
		protected Int64? _LetterStatus;
		protected DateTime? _Ex_Date1;
		protected DateTime? _Ex_Date2;
		protected String _Ex_Nvarchar1;
		protected String _Ex_Nvarchar2;
		protected Int64? _Ex_Bigint1;
		protected Int64? _Ex_Bigint2;
		protected Decimal? _Ex_Decimal1;
		protected Decimal? _Ex_Decimal2;
		protected Int64? _RETURN_KEY;
		protected Int64? _CreatedBy;
		protected String _CreatedByUserName;
		protected Int64? _UpdatedBy;
		protected String _UpdatedByUserName;
		protected DateTime? _CreatedDate;
		protected DateTime? _UpdatedDate;
		protected Int64? _FormID;
		protected String _IPAddress;
		protected String _TransID;
		protected Int64? _UserOrganizationKey;
		protected Int64? _UserEntityKey;
		protected Int64? _Ts;

		[DataMember]
		public Int64? LetterID
		{
			get { return _LetterID; }
			set {_LetterID=value; }
		}
		[DataMember]
		public Int64? LetterType
		{
			get { return _LetterType; }
			set {_LetterType=value; }
		}
		[DataMember]
		public Int64? LetterStatus
		{
			get { return _LetterStatus; }
			set {_LetterStatus=value; }
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
		public Int64? RETURN_KEY
		{
			get { return _RETURN_KEY; }
			set {_RETURN_KEY=value; }
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
		public DateTime? CreatedDate
		{
			get { return _CreatedDate; }
			set {_CreatedDate=value; }
		}
		[DataMember]
		public DateTime? UpdatedDate
		{
			get { return _UpdatedDate; }
			set {_UpdatedDate=value; }
		}
		[DataMember]
		public Int64? FormID
		{
			get { return _FormID; }
			set {_FormID=value; }
		}
		[DataMember]
		public String IPAddress
		{
			get { return _IPAddress; }
			set {_IPAddress=value; }
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
		public Int64? Ts
		{
			get { return _Ts; }
			set {_Ts=value; }
		}
		public KAFProcess_UpdateLetterStatusEntity():base()
		{

		}

		public KAFProcess_UpdateLetterStatusEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
		}
	}
}

