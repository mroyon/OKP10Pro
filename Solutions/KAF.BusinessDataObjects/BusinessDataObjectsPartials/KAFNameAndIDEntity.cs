using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "KAFNameAndIDEntity", Namespace = "http://www.KAF.com/types")]
    public class KAFNameAndIDEntity : BaseEntity
    {
        protected string _fk_table;
        [DataMember]
        public string fk_table
        {
            get { return _fk_table; }
            set { _fk_table = value; this.OnChnaged(); }
        }

        protected string _fk_column;
        [DataMember]
        public string fk_column
        {
            get { return _fk_column; }
            set { _fk_column = value; this.OnChnaged(); }
        }

        protected string _pk_column;
        [DataMember]
        public string pk_column
        {
            get { return _pk_column; }
            set { _pk_column = value; this.OnChnaged(); }
        }

        protected string _pk_table;
        [DataMember]
        public string pk_table
        {
            get { return _pk_table; }
            set { _pk_table = value; this.OnChnaged(); }
        }

        protected string _constraint_name;
        [DataMember]
        public string constraint_name
        {
            get { return _constraint_name; }
            set { _constraint_name = value; this.OnChnaged(); }
        }    
            
        public KAFNameAndIDEntity()
            : base()
        {
        }

        public KAFNameAndIDEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("FK_Table"))) _fk_table = reader.GetString(reader.GetOrdinal("FK_Table"));
                if (!reader.IsDBNull(reader.GetOrdinal("FK_Column"))) _fk_column = reader.GetString(reader.GetOrdinal("FK_Column"));
                if (!reader.IsDBNull(reader.GetOrdinal("PK_Table"))) _pk_table = reader.GetString(reader.GetOrdinal("PK_Table"));
                if (!reader.IsDBNull(reader.GetOrdinal("PK_Column"))) _pk_column = reader.GetString(reader.GetOrdinal("PK_Column"));
                if (!reader.IsDBNull(reader.GetOrdinal("Constraint_Name"))) _constraint_name = reader.GetString(reader.GetOrdinal("Constraint_Name"));

                CurrentState = EntityState.Unchanged;
            }
        }



    }
}
