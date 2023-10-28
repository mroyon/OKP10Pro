using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_OkpSummaryOkpwiseEntity:  BaseEntity
	{
		protected Int64? _okpid;

		public Int64? Total { get; set; }
		public string Title { get; set; }
		public string OkpName { get; set; }

		[DataMember]
		public Int64? okpid
		{
			get { return _okpid; }
			set {_okpid=value; }
		}
		public rpt_OkpSummaryOkpwiseEntity():base()
		{

		}

		public rpt_OkpSummaryOkpwiseEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("Total"))) Total = reader.GetInt64(reader.GetOrdinal("Total"));
			
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("Title"))) Title = reader.GetString(reader.GetOrdinal("Title"));
		}
	}
}

