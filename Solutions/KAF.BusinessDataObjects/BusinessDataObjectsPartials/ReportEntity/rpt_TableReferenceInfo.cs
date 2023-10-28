using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_TableReferenceInfo : BaseEntity
	{
		protected string _Referenced_Column;
		protected string _ColumnName;
		protected string _TableName;
		protected String _Referenced_TableName;
		protected String _ReferencedTextColumn;

		[DataMember]
		public string ReferencedTextColumn
		{
			get { return _ReferencedTextColumn; }
			set { _ReferencedTextColumn = value; }
		}
		[DataMember]
		public string ColumnName
		{
			get { return _ColumnName; }
			set { _ColumnName = value; }
		}
		[DataMember]
		public string Referenced_Column
		{
			get { return _Referenced_Column; }
			set { _Referenced_Column = value; }
		}
		[DataMember]
		public string TableName
		{
			get { return _TableName; }
			set { _TableName = value; }
		}
		[DataMember]
		public string Referenced_TableName
		{
			get { return _Referenced_TableName; }
			set { _Referenced_TableName = value; }
		}
		public rpt_TableReferenceInfo()
		{

		}

		public rpt_TableReferenceInfo(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			

        }
    }
}

