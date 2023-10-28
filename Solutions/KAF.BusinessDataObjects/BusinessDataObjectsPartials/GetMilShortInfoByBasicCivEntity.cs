
using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    #region GetMilShortInfoByBasicMil
    /// <summary>
    /// This object represents the properties and methods of a GetMilShortInfoByBasicMil.
    /// </summary>
    [Serializable]
    [DataContract(Name = "GetMilShortInfoByBasicCivEntity", Namespace = "http://www.ddd.com/types")]
    public class GetMilShortInfoByBasicCivEntity : BaseEntity
    {
        [DataMember]
        public long? empno { get; set; }
        [DataMember]
        public long? hrbasicid { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public DateTime? birthdate { get; set; }
        [DataMember]
        public long? civilid { get; set; }
        [DataMember]
        public Guid userid { get; set; }
        [DataMember]
        public long? currententitykey { get; set; }
        [DataMember]
        public string entityname { get; set; }
        [DataMember]
        public long? contracttypeid { get; set; }
        [DataMember]
        public string contracttype { get; set; }
        [DataMember]
        public long? employmenttypeid { get; set; }
        [DataMember]
        public string employmenttype { get; set; }
        [DataMember]
        public long? servicestatusid { get; set; }
        [DataMember]
        public string servicestatusname { get; set; }


        [DataMember]
        public string photo { get; set; }

        public GetMilShortInfoByBasicCivEntity()
        {
        }

        public GetMilShortInfoByBasicCivEntity(IDataReader ireader)
        {
            //LoadFromReader(ireader);
            LoadFromReaderREF(ireader);
        }

        protected void LoadFromReaderREF(IDataReader reader)
        {
            //SqlDataReader reader = (SqlDataReader)ireader;
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("BirthDate"))) birthdate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) userid = reader.GetGuid(reader.GetOrdinal("UserID"));

                if (!reader.IsDBNull(reader.GetOrdinal("CurrentEntityKey"))) currententitykey = reader.GetInt64(reader.GetOrdinal("CurrentEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityName"))) entityname = reader.GetString(reader.GetOrdinal("EntityName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ContractTypeID"))) contracttypeid = reader.GetInt64(reader.GetOrdinal("ContractTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ContractType"))) contracttype = reader.GetString(reader.GetOrdinal("ContractType"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmploymentTypeID"))) employmenttypeid = reader.GetInt64(reader.GetOrdinal("EmploymentTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("EmploymentType"))) employmenttype = reader.GetString(reader.GetOrdinal("EmploymentType"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusID"))) servicestatusid = reader.GetInt64(reader.GetOrdinal("ServiceStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ServiceStatusName"))) servicestatusname = reader.GetString(reader.GetOrdinal("ServiceStatusName"));

                if (!reader.IsDBNull(reader.GetOrdinal("Photo"))) photo = reader.GetString(reader.GetOrdinal("Photo"));
            }
        }



    }
    #endregion

}

