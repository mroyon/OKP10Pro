using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    [Serializable]
    public class KAFProcess_ManpoewrStateEntity : BaseEntity
    {
        protected String _ManPowerStatus;
        protected Int64? _ManpowerStatusID;
        protected Int64? _Total;
        protected Int64? _OkpID;
        protected DateTime? _ManpowerStateDate;
        public Int64? IsProcess { get; set; }
        public List<KAFProcess_ManpoewrStateEntity> List {get; set;}

        public Int64? ManpowerStateID { get; set; }

        [DataMember]
        public String ManPowerStatus
        {
            get { return _ManPowerStatus; }
            set { _ManPowerStatus = value; }
        }
        [DataMember]
        public Int64? ManpowerStatusID
        {
            get { return _ManpowerStatusID; }
            set { _ManpowerStatusID = value; }
        }
        [DataMember]
        public Int64? Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        [DataMember]
        public Int64? OkpID
        {
            get { return _OkpID; }
            set { _OkpID = value; }
        }
        [DataMember]
        public DateTime? ManpowerStateDate
        {
            get { return _ManpowerStateDate; }
            set { _ManpowerStateDate = value; }
        }

        public KAFProcess_ManpoewrStateEntity() : base()
        {

        }

        public KAFProcess_ManpoewrStateEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (!reader.IsDBNull(reader.GetOrdinal("ManPowerStatus"))) _ManPowerStatus = reader.GetString(reader.GetOrdinal("ManPowerStatus"));
            if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStatusID"))) _ManpowerStatusID = reader.GetInt64(reader.GetOrdinal("ManpowerStatusID"));
            if (!reader.IsDBNull(reader.GetOrdinal("Total"))) _Total = reader.GetInt64(reader.GetOrdinal("Total"));
            if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) ManpowerStateID = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
        }
    }

   
}

