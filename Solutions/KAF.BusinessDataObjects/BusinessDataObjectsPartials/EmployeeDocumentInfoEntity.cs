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
    [DataContract(Name = "EmployeeDocumentInfoEntity", Namespace = "http://www.GW2.com/types")]
    public partial class EmployeeDocumentInfoEntity
    {
        [DataMember]
        public string MilNoKW { get; set; }
        [DataMember]
        public string MilNoBD { get; set; }
        [DataMember]
        public string CivilID { get; set; }
        [DataMember]
        public string PassportNo { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Document { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public int HrBasicID { get; set; }
        [DataMember]
        public DateTime IssueDate { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }

        public EmployeeDocumentInfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public EmployeeDocumentInfoEntity()
        {
            
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) MilNoKW =Convert.ToString( reader.GetInt64(reader.GetOrdinal("MilNoKW")));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Document"))) Document = reader.GetString(reader.GetOrdinal("Document"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilID =Convert.ToString( reader.GetInt64(reader.GetOrdinal("CivilID")));
                if (!reader.IsDBNull(reader.GetOrdinal("Number"))) Number = reader.GetString(reader.GetOrdinal("Number"));
                if (!reader.IsDBNull(reader.GetOrdinal("IssueDate"))) IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpiryDate"))) ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate"));                
            }
        }

        // Getters and Setters
    }

}
