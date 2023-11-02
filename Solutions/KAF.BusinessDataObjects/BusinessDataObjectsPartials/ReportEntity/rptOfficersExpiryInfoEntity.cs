using KAF.BusinessDataObjects.BusinessDataObjectsBase;
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
    [DataContract(Name = "rptOfficersExpiryInfoEntity", Namespace = "http://www.GW2.com/types")]
    public partial class rptOfficersExpiryInfoEntity 
    {
        [DataMember]
        public int HrBasicID { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string MilNoKW { get; set; }

        [DataMember]
        public string MilNoBD { get; set; }

        [DataMember]
        public int RankIDKW { get; set; }

        [DataMember]
        public string KW_Rank { get; set; }

        [DataMember]
        public int RankIDBD { get; set; }

        [DataMember]
        public string BD_Rank { get; set; }

        [DataMember]
        public DateTime JoinDateKw { get; set; }

        [DataMember]
        public DateTime ExpectedRetireDateKw { get; set; }

        [DataMember]
        public string CivilIDNo { get; set; }

        [DataMember]
        public DateTime CivilIDIssueDate { get; set; }

        [DataMember]
        public DateTime CivilIDExpiryDate { get; set; }

        [DataMember]
        public string PassportNo { get; set; }

        [DataMember]
        public DateTime PassportIssueDate { get; set; }

        [DataMember]
        public DateTime PassportExpiryDate { get; set; }

        [DataMember]
        public string ResidencyNumber { get; set; }

        [DataMember]
        public DateTime ResidencyIssueDate { get; set; }

        [DataMember]
        public DateTime ResidencyExpiryDate { get; set; }

        [DataMember]
        public DateTime? DobFrom { get; set; }
        [DataMember]
        public DateTime? DobTo { get; set; }
        [DataMember]
        public DateTime? JoinDateFrom { get; set; }
        [DataMember]
        public DateTime? JoinDateTo { get; set; }
        [DataMember]
        public long? ExpiredWithIn { get; set; }

        [DataMember]
        public DateTime? ExpiredFrom { get; set; }
        [DataMember]
        public DateTime? ExpiredTo { get; set; }
        public rptOfficersExpiryInfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public rptOfficersExpiryInfoEntity()
        {
            
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) HrBasicID = Convert.ToInt32(reader.GetInt64(reader.GetOrdinal("HrBasicID")));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) MilNoKW = Convert.ToString(reader.GetInt64(reader.GetOrdinal("MilNoKW")));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("KW_Rank"))) KW_Rank = reader.GetString(reader.GetOrdinal("KW_Rank"));
                if (!reader.IsDBNull(reader.GetOrdinal("BD_Rank"))) BD_Rank = reader.GetString(reader.GetOrdinal("BD_Rank"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) JoinDateKw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
                if (!reader.IsDBNull(reader.GetOrdinal("EndOfTOD"))) ExpectedRetireDateKw = reader.GetDateTime(reader.GetOrdinal("EndOfTOD"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDNo"))) CivilIDNo = reader.GetString(reader.GetOrdinal("CivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDIssueDate"))) CivilIDIssueDate = reader.GetDateTime(reader.GetOrdinal("CivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpiryDate"))) CivilIDExpiryDate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) PassportNo = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueDate"))) PassportIssueDate = reader.GetDateTime(reader.GetOrdinal("PassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportExpiryDate"))) PassportExpiryDate = reader.GetDateTime(reader.GetOrdinal("PassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("ResidencyNumber"))) ResidencyNumber = reader.GetString(reader.GetOrdinal("ResidencyNumber"));                
                if (!reader.IsDBNull(reader.GetOrdinal("ResidencyIssueDate"))) ResidencyIssueDate = reader.GetDateTime(reader.GetOrdinal("ResidencyIssueDate"));                
                if (!reader.IsDBNull(reader.GetOrdinal("ResidencyExpiryDate"))) ResidencyExpiryDate = reader.GetDateTime(reader.GetOrdinal("ResidencyExpiryDate"));                
            }
        }
    }

}
/*
  SELECT Hr_BasicProfile.[HrBasicID], 
               Hr_BasicProfile.FullName, 
               Hr_SvcInfo.MilNoKW, 
               dbo.HR_BasicProfile.MilNoBD, 
               dbo.Hr_SvcInfo.RankIDKW, 
               KWGen_Rank.RankName KW_Rank, 
               dbo.Hr_SvcInfo.RankIDBD, 
               BDGen_Rank.RankName BD_Rank, 
               [JoinDateKw], 
               [ExpectedRetireDateKw], 
               vCivilID.[CivilIDNo] [CivilIDNo], 
               vCivilID.[CivilIDIssueDate] [CivilIDIssueDate], 
               vCivilID.[CivilIDExpiryDate] [CivilIDExpiryDate], 
               vPassport.[PassportNo] [PassportNo], 
               vPassport.[PassportIssueDate] [PassportIssueDate], 
               vPassport.[PassportExpiryDate] [PassportExpiryDate], 
               vResident.[ResidencyNumber] [ResidencyNumber], 
               vResident.[IssueDate] [ResidencyIssueDate], 
               vResident.[ExpiryDate] [ResidencyExpiryDate]
        FROM Hr_BasicProfile
 */