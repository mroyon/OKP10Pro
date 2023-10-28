using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetLeaveBalanceEntity:  BaseEntity
	{
		protected Int64? _TotalBalance;
		protected Int64? _HRBasicID;
		protected Int64? _LeaveTypeID;
		protected DateTime? _LeaveStartDate;

		[DataMember]
		public Int64? TotalBalance
		{
			get { return _TotalBalance; }
			set {_TotalBalance=value; }
		}
		[DataMember]
		public Int64? HRBasicID
		{
			get { return _HRBasicID; }
			set {_HRBasicID=value; }
		}
		[DataMember]
		public Int64? LeaveTypeID
		{
			get { return _LeaveTypeID; }
			set {_LeaveTypeID=value; }
		}
		[DataMember]
		public DateTime? LeaveStartDate
		{
			get { return _LeaveStartDate; }
			set {_LeaveStartDate=value; }
		}
		public KAF_GetLeaveBalanceEntity():base()
		{

		}

		public KAF_GetLeaveBalanceEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("TotalBalance"))) _TotalBalance = reader.GetInt64(reader.GetOrdinal("TotalBalance"));
		}
	}
}

