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
    #region KAFParamsListGeneric
    /// <summary>
    /// This object represents the properties and methods of a KAFParamsListGeneric.
    /// </summary>
    [Serializable]
    [DataContract(Name = "KAFParamsListGeneric", Namespace = "http://www.KAF.com/types")]
    public class KAFParamsListGeneric : BaseEntity
    {
        protected string _paramname;
        protected string _paramnamear;
        protected string _paramvalue;
        public KAFParamsListGeneric()
        {
        }


        #region Public Properties
        [DataMember]
        public string paramname
        {
            get { return _paramname; }
            set { _paramname = value; }
        }
        [DataMember]
        public string paramnamear
        {
            get { return _paramnamear; }
            set { _paramnamear = value; }
        }
        [DataMember]
        public string paramvalue
        {
            get { return _paramvalue; }
            set { _paramvalue = value; }
        }

        #endregion

        public KAFParamsListGeneric(IDataReader reader, string what)
        {
            this.LoadFromReader(reader, what);
        }

        protected void LoadFromReader(IDataReader reader, string what)
        {
            if (what == "OVERLAPPED")
            {
                if (reader != null && !reader.IsClosed)
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("OverLapCounter"))) PageSize = reader.GetInt32(reader.GetOrdinal("OverLapCounter"));
                    if (!reader.IsDBNull(reader.GetOrdinal("OverLappedDate"))) FromDate1 = reader.GetDateTime(reader.GetOrdinal("OverLappedDate"));
                }
            }

            else if (what == "PRESCHEDULE")
            {
                if (reader != null && !reader.IsClosed)
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("FromUserNumber"))) lonVal1 = reader.GetInt64(reader.GetOrdinal("FromUserNumber"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ToUserNumber"))) lonVal2 = reader.GetInt64(reader.GetOrdinal("ToUserNumber"));
                    if (!reader.IsDBNull(reader.GetOrdinal("Amount"))) FromDecimal = reader.GetDecimal(reader.GetOrdinal("Amount"));
                    if (!reader.IsDBNull(reader.GetOrdinal("TransactionType"))) strValue1 = reader.GetString(reader.GetOrdinal("TransactionType"));
                    if (!reader.IsDBNull(reader.GetOrdinal("IsProcessed"))) blValue1 = reader.GetBoolean(reader.GetOrdinal("IsProcessed"));
                    if (!reader.IsDBNull(reader.GetOrdinal("OverLappedDate"))) FromDate1 = reader.GetDateTime(reader.GetOrdinal("OverLappedDate"));
                }
            }
        }

    }
    #endregion
}
