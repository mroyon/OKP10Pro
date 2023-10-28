using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class Kaf_tran_cuttinginfo_ProcessCountEntity:  BaseEntity
	{
		protected Int32? _Total;
		protected Int32? _TotalProcess;
		protected Int64? _CuttingInfoID;
		

		[DataMember]
		public Int32? Total
		{
			get { return _Total; }
			set {_Total=value; }
		}
		[DataMember]
		public Int32? TotalProcess
		{
			get { return _TotalProcess; }
			set {_TotalProcess=value; }
		}
		[DataMember]
		public Int64? CuttingInfoID
		{
			get { return _CuttingInfoID; }
			set {_CuttingInfoID=value; }
		}
		
		public Kaf_tran_cuttinginfo_ProcessCountEntity():base()
		{

		}

		public Kaf_tran_cuttinginfo_ProcessCountEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("Total"))) _Total = reader.GetInt32(reader.GetOrdinal("Total"));
			if (!reader.IsDBNull(reader.GetOrdinal("TotalProcess"))) _TotalProcess = reader.GetInt32(reader.GetOrdinal("TotalProcess"));
		}
	}
}

