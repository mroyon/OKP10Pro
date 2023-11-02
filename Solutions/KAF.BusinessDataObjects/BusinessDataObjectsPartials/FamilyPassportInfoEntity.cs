using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    [Serializable]
    [DataContract(Name = "FamilyPassportInfoEntity", Namespace = "http://www.GW2.com/types")]
    public partial class FamilyPassportInfoEntity
    {
        [DataMember]
        public int FamilyPassportID { get; set; }
        [DataMember]
        public string MilNoBD { get; set; }
        [DataMember]
        public string PassportNo { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string FamilyName1 { get; set; }
        [DataMember]
        public string FamilyCivilID { get; set; }
        [DataMember]
        public string CivilID { get; set; }
        [DataMember]
        public string RelationshipName { get; set; }
        [DataMember]
        public string FamilyPassportNo { get; set; }
        [DataMember]
        public DateTime FamilyPassportIssueDate { get; set; }
        [DataMember]
        public DateTime FamilyPassportExpiryDate { get; set; }
        [DataMember]
        public string FamilyPassportFileDescription { get; set; }
        public FamilyPassportInfoEntity()
        {            
        }

        public FamilyPassportInfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName1"))) FamilyName1 = reader.GetString(reader.GetOrdinal("FamilyName1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilID"))) FamilyCivilID = reader.GetString(reader.GetOrdinal("FamilyCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipName"))) RelationshipName = reader.GetString(reader.GetOrdinal("RelationshipName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportNo"))) FamilyPassportNo = reader.GetString(reader.GetOrdinal("FamilyPassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportIssueDate"))) FamilyPassportIssueDate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportExpiryDate"))) FamilyPassportIssueDate = reader.GetDateTime(reader.GetOrdinal("FamilyPassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPassportFileDescription"))) FamilyPassportFileDescription = reader.GetString(reader.GetOrdinal("FamilyPassportFileDescription"));
            }
        }

    }
}
