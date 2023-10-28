using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class KAF_GetChildUnitsEntity:  BaseEntity
	{
		protected String _EntityName;
		protected Int64? _EntityKey;

		[DataMember]
		public String EntityName
		{
			get { return _EntityName; }
			set {_EntityName=value; }
		}
		[DataMember]
		public Int64? EntityKey
		{
			get { return _EntityKey; }
			set {_EntityKey=value; }
		}
		public KAF_GetChildUnitsEntity():base()
		{

		}

		public KAF_GetChildUnitsEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) _EntityName = reader.GetString(reader.GetOrdinal("EntityName"));
			if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _EntityKey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
		}
	}
}

