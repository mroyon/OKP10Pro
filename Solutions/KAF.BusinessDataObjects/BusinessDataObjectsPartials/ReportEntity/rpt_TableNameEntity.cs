using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_TableNameEntity:BaseEntity
	{
		protected Int64? _TableID;
		protected string _TableName;
		protected String _TableName_Alias;
		protected String _strColumns;
        public string strWhere { get; set; }

		[DataMember]
		public string strColumns
		{
			get { return _strColumns; }
			set { _strColumns = value; }
		}
		[DataMember]
		public Int64? TableIDName
		{
			get { return _TableID; }
			set { _TableID = value; }
		}
		[DataMember]
		public string TableName
		{
			get { return _TableName; }
			set { _TableName = value; }
		}
		[DataMember]
		public string TableName_Alias
		{
			get { return _TableName_Alias; }
			set { _TableName_Alias = value; }
		}
		public rpt_TableNameEntity()
		{

		}

		public rpt_TableNameEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			

        }
    }
}

