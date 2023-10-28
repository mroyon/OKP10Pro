using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_BMCStrengthSummaryEntity:  BaseEntity
	{
   
        public Int64? PresentStrength { get; set; }
        public Int64? Repatriated { get; set; }
        public Int64? Selected { get; set; }
        public Int64? Total { get; set; }
        public Int64? Cancelled { get; set; }
        public String OkpName { get; set; }

        public long? okpid { get; set; }
        public rpt_BMCStrengthSummaryEntity():base()
		{

		}

		public rpt_BMCStrengthSummaryEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
            if (!reader.IsDBNull(reader.GetOrdinal("PresentStrength"))) PresentStrength = reader.GetInt64(reader.GetOrdinal("PresentStrength"));
            if (!reader.IsDBNull(reader.GetOrdinal("Repatriated"))) Repatriated = reader.GetInt64(reader.GetOrdinal("Repatriated"));
            if (!reader.IsDBNull(reader.GetOrdinal("Selected"))) Selected = reader.GetInt64(reader.GetOrdinal("Selected"));
            if (!reader.IsDBNull(reader.GetOrdinal("Cancelled"))) Cancelled = reader.GetInt64(reader.GetOrdinal("Cancelled")); if (!reader.IsDBNull(reader.GetOrdinal("Total"))) Total = reader.GetInt64(reader.GetOrdinal("Total"));
            if (!reader.IsDBNull(reader.GetOrdinal("Total"))) Total = reader.GetInt64(reader.GetOrdinal("Total"));
            if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) OkpName = reader.GetString(reader.GetOrdinal("OkpName"));

        }
    }
}

