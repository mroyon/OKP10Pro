using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_demanddetlpassportEntity 
    {
        #region Properties
        public long? visademanddetailid { get; set; }
        protected long? _milnokw;

        protected long? _newdemandid;
        protected string _demandletterno;
        protected DateTime? _demandletterdate;


        protected string _name1;
        protected string _name2;
        protected string _passportno;


        protected long? _okpid;
        protected long? _rankid;
        protected long? _tradeid;
        protected long? _groupid;


        protected string _rankname;
        protected string _tradename;
        protected string _okpname;
        protected string _groupname;
        protected long? _isall;
        protected long? _totalperson;
        public string LetterStatus { get; set; }

        [DataMember]
        public long? isall
        {
            get { return _isall; }
            set { _isall = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? milnokw
        {
            get { return _milnokw; }
            set { _milnokw = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? newdemandid
        {
            get { return _newdemandid; }
            set { _newdemandid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string demandletterno
        {
            get { return _demandletterno; }
            set { _demandletterno = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? demandletterdate
        {
            get { return _demandletterdate; }
            set { _demandletterdate = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? okpid
        {
            get { return _okpid; }
            set { _okpid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? rankidkw
        {
            get { return _rankid; }
            set { _rankid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        public long? tradeidkw
        {
            get { return _tradeid; }
            set { _tradeid = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? groupid
        {
            get { return _groupid; }
            set { _groupid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }

        [DataMember]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }
        [DataMember]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }

        [DataMember]
        public string rankname
        {
            get { return _rankname; }
            set { _rankname = value; this.OnChnaged(); }
        }
        [DataMember]
        public string tradename
        {
            get { return _tradename; }
            set { _tradename = value; this.OnChnaged(); }
        }
        [DataMember]
        public string okpname
        {
            get { return _okpname; }
            set { _okpname = value; this.OnChnaged(); }
        }

        [DataMember]
        public string groupname
        {
            get { return _groupname; }
            set { _groupname = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? totalperson
        {
            get { return _totalperson; }
            set { _totalperson = value; this.OnChnaged(); }
        }
        
        #endregion

        #region Constructor




        public hr_demanddetlpassportEntity(IDataReader reader, bool IsListViewShow, bool IsExtension)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, IsExtension);
        }
        public hr_demanddetlpassportEntity(IDataReader reader, bool IsListViewShow, bool IsExtension, bool IsSelect2)
        {
            this.LoadFromReader_Ext2(reader, IsListViewShow, IsExtension, IsSelect2);
        }

        public hr_demanddetlpassportEntity(IDataReader reader,int ListView)
        {
            this.LoadFromReader_Ext3(reader, ListView);
        }
        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool IsExtension)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandPassportID"))) _newdemandpassportid = reader.GetInt64(reader.GetOrdinal("NewDemandPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandID"))) _newdemandid = reader.GetInt64(reader.GetOrdinal("NewDemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandDetlID"))) _newdemanddetlid = reader.GetInt64(reader.GetOrdinal("NewDemandDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _passportrecvdate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterNo"))) _demandletterno = reader.GetString(reader.GetOrdinal("DemandLetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandLetterDate"))) _demandletterdate = reader.GetDateTime(reader.GetOrdinal("DemandLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeID"))) _tradeid = reader.GetInt64(reader.GetOrdinal("TradeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _rankname = reader.GetString(reader.GetOrdinal("RankName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _okpname = reader.GetString(reader.GetOrdinal("OkpName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _tradename = reader.GetString(reader.GetOrdinal("TradeName"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _groupname = reader.GetString(reader.GetOrdinal("GroupName"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));

                if (!reader.IsDBNull(reader.GetOrdinal("visademanddetlid"))) visademanddetailid = reader.GetInt64(reader.GetOrdinal("visademanddetlid"));

                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));

                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader_Ext2(IDataReader reader, bool IsListViewShow, bool IsExtension, bool IsSelect2)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _passportrecvdate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                CurrentState = EntityState.Unchanged;
            }
        }

        protected void LoadFromReader_Ext3(IDataReader reader, int ListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandPassportID"))) _newdemandpassportid = reader.GetInt64(reader.GetOrdinal("NewDemandPassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewDemandID"))) _newdemandid = reader.GetInt64(reader.GetOrdinal("NewDemandID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalNO"))) _totalperson = reader.GetInt32(reader.GetOrdinal("TotalNO"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _passportrecvdate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterNo"))) _letterno = reader.GetString(reader.GetOrdinal("LetterNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("LetterDate"))) _letterdate = reader.GetDateTime(reader.GetOrdinal("LetterDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                //if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
