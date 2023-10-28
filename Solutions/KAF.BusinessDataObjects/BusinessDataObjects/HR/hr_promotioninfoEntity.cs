using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_promotioninfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_promotioninfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _promotionid;
        protected long ? _hrbasicid;
        protected DateTime ? _promotiondate;
        protected long ? _promotiontypeid;
        protected long ? _torankid;
        protected long ? _promotionno;
        protected long ? _promotiondesignation;
        protected string _promotiondelayreason;
        protected string _promotiondelaydocno;
        protected DateTime ? _promotiondelaydocdate;
        protected DateTime ? _promotiondelaystartdate;
        protected long ? _promotiondelayperiod;
        protected string _orderno;
        protected DateTime ? _orderdate;
        protected string _orderfiledescription;
        protected string _orderfilepath;
        protected string _orderfilename;
        protected string _orderfiletype;
        protected string _orderextension;
        protected Guid ? _orderfileno;
        protected string _remarks;
                
        
        [DataMember]
        public long ? promotionid
        {
            get { return _promotionid; }
            set { _promotionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_promotioninfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiondate", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_promotioninfo), ErrorMessageResourceName = "promotiondateRequired")]
        public DateTime ? promotiondate
        {
            get { return _promotiondate; }
            set { _promotiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiontypeid", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_promotioninfo), ErrorMessageResourceName = "promotiontypeidRequired")]
        public long ? promotiontypeid
        {
            get { return _promotiontypeid; }
            set { _promotiontypeid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "torankid", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_promotioninfo), ErrorMessageResourceName = "torankidRequired")]
        public long ? torankid
        {
            get { return _torankid; }
            set { _torankid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotionno", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public long ? promotionno
        {
            get { return _promotionno; }
            set { _promotionno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiondesignation", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public long ? promotiondesignation
        {
            get { return _promotiondesignation; }
            set { _promotiondesignation = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "promotiondelayreason", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string promotiondelayreason
        {
            get { return _promotiondelayreason; }
            set { _promotiondelayreason = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "promotiondelaydocno", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string promotiondelaydocno
        {
            get { return _promotiondelaydocno; }
            set { _promotiondelaydocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiondelaydocdate", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public DateTime ? promotiondelaydocdate
        {
            get { return _promotiondelaydocdate; }
            set { _promotiondelaydocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiondelaystartdate", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public DateTime ? promotiondelaystartdate
        {
            get { return _promotiondelaystartdate; }
            set { _promotiondelaystartdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "promotiondelayperiod", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public long ? promotiondelayperiod
        {
            get { return _promotiondelayperiod; }
            set { _promotiondelayperiod = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "orderno", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderno
        {
            get { return _orderno; }
            set { _orderno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "orderdate", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public DateTime ? orderdate
        {
            get { return _orderdate; }
            set { _orderdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "orderfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderfiledescription
        {
            get { return _orderfiledescription; }
            set { _orderfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "orderfilepath", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderfilepath
        {
            get { return _orderfilepath; }
            set { _orderfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "orderfilename", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderfilename
        {
            get { return _orderfilename; }
            set { _orderfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "orderfiletype", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderfiletype
        {
            get { return _orderfiletype; }
            set { _orderfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "orderextension", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string orderextension
        {
            get { return _orderextension; }
            set { _orderextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "orderfileno", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public Guid ? orderfileno
        {
            get { return _orderfileno; }
            set { _orderfileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_promotioninfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_promotioninfoEntity():base()
        {
        }
        
        public hr_promotioninfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_promotioninfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionID"))) _promotionid = reader.GetInt64(reader.GetOrdinal("PromotionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDate"))) _promotiondate = reader.GetDateTime(reader.GetOrdinal("PromotionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionTypeID"))) _promotiontypeid = reader.GetInt64(reader.GetOrdinal("PromotionTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToRankId"))) _torankid = reader.GetInt64(reader.GetOrdinal("ToRankId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionNo"))) _promotionno = reader.GetInt64(reader.GetOrdinal("PromotionNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDesignation"))) _promotiondesignation = reader.GetInt64(reader.GetOrdinal("PromotionDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayReason"))) _promotiondelayreason = reader.GetString(reader.GetOrdinal("PromotionDelayReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayDocNo"))) _promotiondelaydocno = reader.GetString(reader.GetOrdinal("PromotionDelayDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayDocDate"))) _promotiondelaydocdate = reader.GetDateTime(reader.GetOrdinal("PromotionDelayDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayStartDate"))) _promotiondelaystartdate = reader.GetDateTime(reader.GetOrdinal("PromotionDelayStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayPeriod"))) _promotiondelayperiod = reader.GetInt64(reader.GetOrdinal("PromotionDelayPeriod"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) _orderno = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) _orderdate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileDescription"))) _orderfiledescription = reader.GetString(reader.GetOrdinal("OrderFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFilePath"))) _orderfilepath = reader.GetString(reader.GetOrdinal("OrderFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileName"))) _orderfilename = reader.GetString(reader.GetOrdinal("OrderFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileType"))) _orderfiletype = reader.GetString(reader.GetOrdinal("OrderFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderExtension"))) _orderextension = reader.GetString(reader.GetOrdinal("OrderExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileNo"))) _orderfileno = reader.GetGuid(reader.GetOrdinal("OrderFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionID"))) _promotionid = reader.GetInt64(reader.GetOrdinal("PromotionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDate"))) _promotiondate = reader.GetDateTime(reader.GetOrdinal("PromotionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionTypeID"))) _promotiontypeid = reader.GetInt64(reader.GetOrdinal("PromotionTypeID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ToRankId"))) _torankid = reader.GetInt64(reader.GetOrdinal("ToRankId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionNo"))) _promotionno = reader.GetInt64(reader.GetOrdinal("PromotionNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDesignation"))) _promotiondesignation = reader.GetInt64(reader.GetOrdinal("PromotionDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayReason"))) _promotiondelayreason = reader.GetString(reader.GetOrdinal("PromotionDelayReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayDocNo"))) _promotiondelaydocno = reader.GetString(reader.GetOrdinal("PromotionDelayDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayDocDate"))) _promotiondelaydocdate = reader.GetDateTime(reader.GetOrdinal("PromotionDelayDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayStartDate"))) _promotiondelaystartdate = reader.GetDateTime(reader.GetOrdinal("PromotionDelayStartDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PromotionDelayPeriod"))) _promotiondelayperiod = reader.GetInt64(reader.GetOrdinal("PromotionDelayPeriod"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderNo"))) _orderno = reader.GetString(reader.GetOrdinal("OrderNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) _orderdate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileDescription"))) _orderfiledescription = reader.GetString(reader.GetOrdinal("OrderFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFilePath"))) _orderfilepath = reader.GetString(reader.GetOrdinal("OrderFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileName"))) _orderfilename = reader.GetString(reader.GetOrdinal("OrderFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileType"))) _orderfiletype = reader.GetString(reader.GetOrdinal("OrderFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderExtension"))) _orderextension = reader.GetString(reader.GetOrdinal("OrderExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrderFileNo"))) _orderfileno = reader.GetGuid(reader.GetOrdinal("OrderFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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
