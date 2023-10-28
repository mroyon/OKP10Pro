using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_newdemandEntity
    {
        #region Properties
    
        protected long ? _totalperson;

        public string LetterStatus { get; set; }

        [DataMember]
        public long ? totalperson
        {
            get { return _totalperson; }
            set { _totalperson = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor

        public hr_newdemandEntity(IDataReader reader, bool IsListViewShow, bool IsExt)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow);
        }
        
        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandID"))) _newdemandid = reader.GetInt64(reader.GetOrdinal("NewDemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterNo"))) _demandletterno = reader.GetString(reader.GetOrdinal("DemandLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterDate"))) _demandletterdate = reader.GetDateTime(reader.GetOrdinal("DemandLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalPerson"))) _totalperson = reader.GetInt64(reader.GetOrdinal("TotalPerson"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));

                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
