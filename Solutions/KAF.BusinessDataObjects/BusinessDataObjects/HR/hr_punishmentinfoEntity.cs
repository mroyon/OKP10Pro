using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_punishmentinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_punishmentinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _punishmentid;
        protected long ? _hrbasicid;
        protected long ? _punishmenttype;
        protected DateTime ? _punishmentdate;
        protected string _offence;
        protected string _punishment;
        protected string _punishmentdetails;
        protected string _remarks;
                
        
        [DataMember]
        public long ? punishmentid
        {
            get { return _punishmentid; }
            set { _punishmentid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "punishmenttype", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo), ErrorMessageResourceName = "punishmenttypeRequired")]
        public long ? punishmenttype
        {
            get { return _punishmenttype; }
            set { _punishmenttype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "punishmentdate", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo), ErrorMessageResourceName = "punishmentdateRequired")]
        public DateTime ? punishmentdate
        {
            get { return _punishmentdate; }
            set { _punishmentdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "offence", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        public string offence
        {
            get { return _offence; }
            set { _offence = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "punishment", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        public string punishment
        {
            get { return _punishment; }
            set { _punishment = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(-1)]
        [Display(Name = "punishmentdetails", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        public string punishmentdetails
        {
            get { return _punishmentdetails; }
            set { _punishmentdetails = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_punishmentinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_punishmentinfoEntity():base()
        {
        }
        
        public hr_punishmentinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_punishmentinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentID"))) _punishmentid = reader.GetInt64(reader.GetOrdinal("PunishmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentType"))) _punishmenttype = reader.GetInt64(reader.GetOrdinal("PunishmentType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDate"))) _punishmentdate = reader.GetDateTime(reader.GetOrdinal("PunishmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Offence"))) _offence = reader.GetString(reader.GetOrdinal("Offence"));
                if (!reader.IsDBNull(reader.GetOrdinal("Punishment"))) _punishment = reader.GetString(reader.GetOrdinal("Punishment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDetails"))) _punishmentdetails = reader.GetString(reader.GetOrdinal("PunishmentDetails"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentID"))) _punishmentid = reader.GetInt64(reader.GetOrdinal("PunishmentID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicId"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicId"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentType"))) _punishmenttype = reader.GetInt64(reader.GetOrdinal("PunishmentType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDate"))) _punishmentdate = reader.GetDateTime(reader.GetOrdinal("PunishmentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Offence"))) _offence = reader.GetString(reader.GetOrdinal("Offence"));
                if (!reader.IsDBNull(reader.GetOrdinal("Punishment"))) _punishment = reader.GetString(reader.GetOrdinal("Punishment"));
                if (!reader.IsDBNull(reader.GetOrdinal("PunishmentDetails"))) _punishmentdetails = reader.GetString(reader.GetOrdinal("PunishmentDetails"));
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
