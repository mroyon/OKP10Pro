using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_hospitaladmissioninfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_hospitaladmissioninfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hospitaladmissionid;
        protected long ? _hrbasicid;
        protected string _hospitalname;
        protected string _diseasename;
        protected DateTime ? _hospitaladmissiondate;
        protected DateTime ? _hospitalreleasedate;
        protected long ? _hospitalcountryid;
        protected string _description;
        protected string _releasenote;
        protected string _remarks;
                
        
        [DataMember]
        public long ? hospitaladmissionid
        {
            get { return _hospitaladmissionid; }
            set { _hospitaladmissionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "hospitalname", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo), ErrorMessageResourceName = "hospitalnameRequired")]
        public string hospitalname
        {
            get { return _hospitalname; }
            set { _hospitalname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "diseasename", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo), ErrorMessageResourceName = "diseasenameRequired")]
        public string diseasename
        {
            get { return _diseasename; }
            set { _diseasename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hospitaladmissiondate", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo), ErrorMessageResourceName = "hospitaladmissiondateRequired")]
        public DateTime ? hospitaladmissiondate
        {
            get { return _hospitaladmissiondate; }
            set { _hospitaladmissiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hospitalreleasedate", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        public DateTime ? hospitalreleasedate
        {
            get { return _hospitalreleasedate; }
            set { _hospitalreleasedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hospitalcountryid", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo), ErrorMessageResourceName = "hospitalcountryidRequired")]
        public long ? hospitalcountryid
        {
            get { return _hospitalcountryid; }
            set { _hospitalcountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "description", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        public string description
        {
            get { return _description; }
            set { _description = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "releasenote", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        public string releasenote
        {
            get { return _releasenote; }
            set { _releasenote = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_hospitaladmissioninfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_hospitaladmissioninfoEntity():base()
        {
        }
        
        public hr_hospitaladmissioninfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_hospitaladmissioninfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionID"))) _hospitaladmissionid = reader.GetInt64(reader.GetOrdinal("HospitalAdmissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalName"))) _hospitalname = reader.GetString(reader.GetOrdinal("HospitalName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiseaseName"))) _diseasename = reader.GetString(reader.GetOrdinal("DiseaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionDate"))) _hospitaladmissiondate = reader.GetDateTime(reader.GetOrdinal("HospitalAdmissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalReleaseDate"))) _hospitalreleasedate = reader.GetDateTime(reader.GetOrdinal("HospitalReleaseDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalCountryID"))) _hospitalcountryid = reader.GetInt64(reader.GetOrdinal("HospitalCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReleaseNote"))) _releasenote = reader.GetString(reader.GetOrdinal("ReleaseNote"));
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
                //if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionID"))) _hospitaladmissionid = reader.GetInt64(reader.GetOrdinal("HospitalAdmissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalName"))) _hospitalname = reader.GetString(reader.GetOrdinal("HospitalName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiseaseName"))) _diseasename = reader.GetString(reader.GetOrdinal("DiseaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionDate"))) _hospitaladmissiondate = reader.GetDateTime(reader.GetOrdinal("HospitalAdmissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalReleaseDate"))) _hospitalreleasedate = reader.GetDateTime(reader.GetOrdinal("HospitalReleaseDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalCountryID"))) _hospitalcountryid = reader.GetInt64(reader.GetOrdinal("HospitalCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReleaseNote"))) _releasenote = reader.GetString(reader.GetOrdinal("ReleaseNote"));
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
