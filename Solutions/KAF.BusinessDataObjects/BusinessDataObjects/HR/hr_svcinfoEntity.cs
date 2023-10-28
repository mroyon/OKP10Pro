using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_svcinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_svcinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _hrsvcid;
        protected long? _hrbasicid;
        protected long? _militarynokw;
        protected string _passportno;
        protected DateTime? _joindatekw;
        protected DateTime? _expectedretiredatekw;
        protected Guid? _userid;

        protected long? _organizationkey;
        protected long? _entitykey;
        protected long? _armsid;
        protected long? _okpid;
        protected long? _rankidkw;
        protected long? _rankidbd;
        protected long? _tradeidbd;
        protected long? _tradeidkw;
        protected long? _groupid;
        protected long? _status;
        protected string _remarks;

        protected long? _subunitid;
        protected long? _campid;

        [DataMember]
        public long? hrsvcid
        {
            get { return _hrsvcid; }
            set { _hrsvcid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_svcinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        [DataMember]
        //[Display(Name = "militaryno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long? militarynokw
        {
            get { return _militarynokw; }
            set { _militarynokw = value; this.OnChnaged(); }
        }
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportno", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "joindatekw", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public DateTime? joindatekw
        {
            get { return _joindatekw; }
            set { _joindatekw = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "expectedretiredatekw", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public DateTime? expectedretiredatekw
        {
            get { return _expectedretiredatekw; }
            set { _expectedretiredatekw = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "userid", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "entitykey", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? entitykey
        {
            get { return _entitykey; }
            set { _entitykey = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "armsid", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? armsid
        {
            get { return _armsid; }
            set { _armsid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "okpid", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? okpid
        {
            get { return _okpid; }
            set { _okpid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "rankidkw", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? rankidkw
        {
            get { return _rankidkw; }
            set { _rankidkw = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "rankidbd", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? rankidbd
        {
            get { return _rankidbd; }
            set { _rankidbd = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tradeidbd", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? tradeidbd
        {
            get { return _tradeidbd; }
            set { _tradeidbd = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "tradeidkw", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? tradeidkw
        {
            get { return _tradeidkw; }
            set { _tradeidkw = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "groupid", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? groupid
        {
            get { return _groupid; }
            set { _groupid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "status", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public long? status
        {
            get { return _status; }
            set { _status = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_svcinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "subunitid", ResourceType = typeof(KAF.MsgContainer._hr_okptransferinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_okptransferinfo), ErrorMessageResourceName = "subunitidRequired")]
        public long? subunitid
        {
            get { return _subunitid; }
            set { _subunitid = value; this.OnChnaged(); }
        }

        [DataMember]
        [Display(Name = "campid", ResourceType = typeof(KAF.MsgContainer._hr_okptransferinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_okptransferinfo), ErrorMessageResourceName = "campidRequired")]
        public long? campid
        {
            get { return _campid; }
            set { _campid = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor

        public hr_svcinfoEntity() : base()
        {
        }

        public hr_svcinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        public hr_svcinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
                //if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _joindatekw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _expectedretiredatekw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _armsid = reader.GetInt64(reader.GetOrdinal("ArmsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _rankidkw = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _rankidbd = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _tradeidbd = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _tradeidkw = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));

                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));

                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                //if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MillNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _joindatekw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
                if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _expectedretiredatekw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _armsid = reader.GetInt64(reader.GetOrdinal("ArmsID"));
                if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _rankidkw = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _rankidbd = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _tradeidbd = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _tradeidkw = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));

                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));

                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
