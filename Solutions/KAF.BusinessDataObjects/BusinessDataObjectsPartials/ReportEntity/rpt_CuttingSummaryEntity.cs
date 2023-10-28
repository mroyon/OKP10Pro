using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

    [Serializable]
    public class rpt_CuttingSummaryEntity : BaseEntity
    {
        protected Int64? _Ex_Bigint1;
        protected String _OkpName;
        protected Int64? _MonthID;
        protected Int64? _Year;
        protected Decimal? _PaidAmount;
        protected Decimal? _NotPaidAmount;
        protected String _ItemName;
        protected String _MonthName;
        protected Int64? _PayAllceID;
        protected Int64? _PaidCount;
        protected Int64? _NotPaidCount;
        protected Int64? _TotalCount;
        [DataMember]
        public Int64? TotalCount
        {
            get { return _TotalCount; }
            set { _TotalCount = value; }
        }
        [DataMember]
        public Int64? PaidCount
        {
            get { return _PaidCount; }
            set { _PaidCount = value; }
        }
        [DataMember]
        public Int64? NotPaidCount
        {
            get { return _NotPaidCount; }
            set { _NotPaidCount = value; }
        }
        [DataMember]
        public Int64? Ex_Bigint1
        {
            get { return _Ex_Bigint1; }
            set { _Ex_Bigint1 = value; }
        }
        [DataMember]
        public String OkpName
        {
            get { return _OkpName; }
            set { _OkpName = value; }
        }
        [DataMember]
        public Int64? MonthID
        {
            get { return _MonthID; }
            set { _MonthID = value; }
        }
        [DataMember]
        public Int64? Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        [DataMember]
        public Decimal? PaidAmount
        {
            get { return _PaidAmount; }
            set { _PaidAmount = value; }
        }
        [DataMember]
        public Decimal? NotPaidAmount
        {
            get { return _NotPaidAmount; }
            set { _NotPaidAmount = value; }
        }
        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }
        [DataMember]
        public String MonthName
        {
            get { return _MonthName; }
            set { _MonthName = value; }
        }
        [DataMember]
        public Int64? PayAllceID
        {
            get { return _PayAllceID; }
            set { _PayAllceID = value; }
        }
        public rpt_CuttingSummaryEntity() : base()
        {

        }

        public rpt_CuttingSummaryEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            _TotalCount = 0;
            if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _Ex_Bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
            if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
            if (!reader.IsDBNull(reader.GetOrdinal("MonthID"))) _MonthID = reader.GetInt64(reader.GetOrdinal("MonthID"));
            if (!reader.IsDBNull(reader.GetOrdinal("Year"))) _Year = reader.GetInt64(reader.GetOrdinal("Year"));
            if (!reader.IsDBNull(reader.GetOrdinal("PaidAmount"))) _PaidAmount = reader.GetDecimal(reader.GetOrdinal("PaidAmount"));
            if (!reader.IsDBNull(reader.GetOrdinal("NotPaidAmount"))) _NotPaidAmount = reader.GetDecimal(reader.GetOrdinal("NotPaidAmount"));
            if (!reader.IsDBNull(reader.GetOrdinal("ItemName"))) _ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
            if (!reader.IsDBNull(reader.GetOrdinal("MonthName"))) _MonthName = reader.GetString(reader.GetOrdinal("MonthName"));
            
            if (!reader.IsDBNull(reader.GetOrdinal("PaidCount")))
            {
                _PaidCount = reader.GetInt64(reader.GetOrdinal("PaidCount"));
                _TotalCount += _PaidCount;
            }

            if (!reader.IsDBNull(reader.GetOrdinal("NotPaidCount")))
            {
                _NotPaidCount = reader.GetInt64(reader.GetOrdinal("NotPaidCount"));
                _TotalCount += _NotPaidCount;
            }

        }
    }
}

