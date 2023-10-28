using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessDataObjects
{

    public partial class hr_languageproficiencyEntity
    {
        protected string _languagename;
        [DataMember]
        public string languagename
        {
            get { return _languagename; }
            set { _languagename = value; this.OnChnaged(); }
        }
        public void LoadFromReader_Ext(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                //LoadFromReader(reader);
                //Aditional 

                if (!reader.IsDBNull(reader.GetOrdinal("languagename"))) _languagename = reader.GetString(reader.GetOrdinal("languagename"));
                //if (!reader.IsDBNull(reader.GetOrdinal("MiliPossitionID"))) _milipossitionid = reader.GetInt64(reader.GetOrdinal("MiliPossitionID"));
               // if (!reader.IsDBNull(reader.GetOrdinal("Comments"))) _comments = reader.GetString(reader.GetOrdinal("Comments"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
            }
        }
    }
}
