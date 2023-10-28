

using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;


namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "clsTableAndFormRelationEntity", Namespace = "http://www.KAF.com/types")]
    public class clsTableAndFormRelationEntity : BaseEntity
    {
        public string entrytype { get; set; }
        public int? requireddata { get; set; }
        public int? entereddate { get; set; }
        public long? linkid { get; set; }

        public clsTableAndFormRelationEntity()
            : base()
        {
        }

        public clsTableAndFormRelationEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                 if (!reader.IsDBNull(reader.GetOrdinal("EntryType"))) entrytype = reader.GetString(reader.GetOrdinal("EntryType"));
				    if (!reader.IsDBNull(reader.GetOrdinal("RequiredData"))) requireddata = reader.GetInt32(reader.GetOrdinal("RequiredData"));
				    if (!reader.IsDBNull(reader.GetOrdinal("EnteredDate"))) entereddate = reader.GetInt32(reader.GetOrdinal("EnteredDate"));
                    if (!reader.IsDBNull(reader.GetOrdinal("LinkID"))) linkid = reader.GetInt64(reader.GetOrdinal("LinkID"));
            }
        }


        
    }
}
