using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_TableColumn:BaseEntity
	{
		
		protected string _ColumnName;
		protected String _ColumnName_Alias;

		protected string _ColumnType;

		[DataMember]
		public string DATA_TYPE
		{
			get { return _ColumnType; }
			set { _ColumnType = value; }
		}

		[DataMember]
		public string COLUMN_NAME
		{
			get { return _ColumnName; }
			set { _ColumnName = value; }
		}
		[DataMember]
		public string COLUMN_NAME_Alias
		{
			get { return _ColumnName_Alias; }
			set { _ColumnName_Alias = value; }
		}
		public rpt_TableColumn()
		{

		}

		public rpt_TableColumn(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			

        }
    }
}

