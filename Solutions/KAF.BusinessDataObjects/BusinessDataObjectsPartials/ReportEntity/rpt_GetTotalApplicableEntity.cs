using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_GetTotalApplicableEntity:  BaseEntity
	{
		protected Int32? _TotalCount;
		protected Int64? _OKPID;
		protected Int64? _PayAllceID;
		protected DateTime? _ProcessDate;

		[DataMember]
		public Int32? TotalCount
		{
			get { return _TotalCount; }
			set {_TotalCount=value; }
		}
		[DataMember]
		public Int64? OKPID
		{
			get { return _OKPID; }
			set {_OKPID=value; }
		}
		[DataMember]
		public Int64? PayAllceID
		{
			get { return _PayAllceID; }
			set {_PayAllceID=value; }
		}
		[DataMember]
		public DateTime? ProcessDate
		{
			get { return _ProcessDate; }
			set {_ProcessDate=value; }
		}
		public rpt_GetTotalApplicableEntity():base()
		{

		}

		public rpt_GetTotalApplicableEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("TotalCount"))) _TotalCount = reader.GetInt32(reader.GetOrdinal("TotalCount"));
		}
	}
}

