using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_visademandinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_visademandinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _visademandid;
        protected long ? _demandtype;
        protected long ? _passportinfoid;
        protected DateTime ? _visademanddate;
        protected DateTime ? _visademandletterdate;
        protected string _visademandletterno;
        protected string _remarks;
                
        
        [DataMember]
        public long ? visademandid
        {
            get { return _visademandid; }
            set { _visademandid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "demandtype", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_visademandinfo), ErrorMessageResourceName = "demandtypeRequired")]
        public long ? demandtype
        {
            get { return _demandtype; }
            set { _demandtype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passportinfoid", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_visademandinfo), ErrorMessageResourceName = "passportinfoidRequired")]
        public long ? passportinfoid
        {
            get { return _passportinfoid; }
            set { _passportinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "visademanddate", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_visademandinfo), ErrorMessageResourceName = "visademanddateRequired")]
        public DateTime ? visademanddate
        {
            get { return _visademanddate; }
            set { _visademanddate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "visademandletterdate", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_visademandinfo), ErrorMessageResourceName = "visademandletterdateRequired")]
        public DateTime ? visademandletterdate
        {
            get { return _visademandletterdate; }
            set { _visademandletterdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "visademandletterno", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_visademandinfo), ErrorMessageResourceName = "visademandletternoRequired")]
        public string visademandletterno
        {
            get { return _visademandletterno; }
            set { _visademandletterno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_visademandinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_visademandinfoEntity():base()
        {
        }
        
        public hr_visademandinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_visademandinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) _visademandid = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandType"))) _demandtype = reader.GetInt64(reader.GetOrdinal("DemandType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportInfoID"))) _passportinfoid = reader.GetInt64(reader.GetOrdinal("PassportInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDate"))) _visademanddate = reader.GetDateTime(reader.GetOrdinal("VisaDemandDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterDate"))) _visademandletterdate = reader.GetDateTime(reader.GetOrdinal("VisaDemandLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterNo"))) _visademandletterno = reader.GetString(reader.GetOrdinal("VisaDemandLetterNo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandID"))) _visademandid = reader.GetInt64(reader.GetOrdinal("VisaDemandID"));
                if (!reader.IsDBNull(reader.GetOrdinal("DemandType"))) _demandtype = reader.GetInt64(reader.GetOrdinal("DemandType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportInfoID"))) _passportinfoid = reader.GetInt64(reader.GetOrdinal("PassportInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandDate"))) _visademanddate = reader.GetDateTime(reader.GetOrdinal("VisaDemandDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterDate"))) _visademandletterdate = reader.GetDateTime(reader.GetOrdinal("VisaDemandLetterDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VisaDemandLetterNo"))) _visademandletterno = reader.GetString(reader.GetOrdinal("VisaDemandLetterNo"));
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
