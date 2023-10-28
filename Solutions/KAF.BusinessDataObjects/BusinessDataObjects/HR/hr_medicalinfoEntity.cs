using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_medicalinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_medicalinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _miltmedicalid;
        protected long ? _hrbasicid;
        protected string _medcommissionno;
        protected DateTime ? _medcommsisiondate;
        protected string _medcommissionfiledescription;
        protected string _medcommissionfilepath;
        protected string _medcommissionfilename;
        protected string _medcommissionfiletype;
        protected string _medcommissionextension;
        protected Guid ? _medcommissionfileno;
        protected string _medcommissiondesc;
        protected string _docno;
        protected DateTime ? _docdate;
        protected string _docfiledescription;
        protected string _docfilepath;
        protected string _docfilename;
        protected string _docfiletype;
        protected string _docextension;
        protected Guid ? _docfileno;
        protected string _medaction;
        protected string _remarks;
                
        
        [DataMember]
        public long ? miltmedicalid
        {
            get { return _miltmedicalid; }
            set { _miltmedicalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_medicalinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "medcommissionno", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_medicalinfo), ErrorMessageResourceName = "medcommissionnoRequired")]
        public string medcommissionno
        {
            get { return _medcommissionno; }
            set { _medcommissionno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "medcommsisiondate", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_medicalinfo), ErrorMessageResourceName = "medcommsisiondateRequired")]
        public DateTime ? medcommsisiondate
        {
            get { return _medcommsisiondate; }
            set { _medcommsisiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "medcommissionfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissionfiledescription
        {
            get { return _medcommissionfiledescription; }
            set { _medcommissionfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "medcommissionfilepath", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissionfilepath
        {
            get { return _medcommissionfilepath; }
            set { _medcommissionfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "medcommissionfilename", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissionfilename
        {
            get { return _medcommissionfilename; }
            set { _medcommissionfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "medcommissionfiletype", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissionfiletype
        {
            get { return _medcommissionfiletype; }
            set { _medcommissionfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "medcommissionextension", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissionextension
        {
            get { return _medcommissionextension; }
            set { _medcommissionextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "medcommissionfileno", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public Guid ? medcommissionfileno
        {
            get { return _medcommissionfileno; }
            set { _medcommissionfileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "medcommissiondesc", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medcommissiondesc
        {
            get { return _medcommissiondesc; }
            set { _medcommissiondesc = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "docno", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docno
        {
            get { return _docno; }
            set { _docno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "docdate", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public DateTime ? docdate
        {
            get { return _docdate; }
            set { _docdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "docfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docfiledescription
        {
            get { return _docfiledescription; }
            set { _docfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "docfilepath", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docfilepath
        {
            get { return _docfilepath; }
            set { _docfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "docfilename", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docfilename
        {
            get { return _docfilename; }
            set { _docfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "docfiletype", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docfiletype
        {
            get { return _docfiletype; }
            set { _docfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "docextension", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string docextension
        {
            get { return _docextension; }
            set { _docextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "docfileno", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public Guid ? docfileno
        {
            get { return _docfileno; }
            set { _docfileno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "medaction", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string medaction
        {
            get { return _medaction; }
            set { _medaction = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_medicalinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_medicalinfoEntity():base()
        {
        }
        
        public hr_medicalinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_medicalinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("MiltMedicalID"))) _miltmedicalid = reader.GetInt64(reader.GetOrdinal("MiltMedicalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionNo"))) _medcommissionno = reader.GetString(reader.GetOrdinal("MedCommissionNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommsisionDate"))) _medcommsisiondate = reader.GetDateTime(reader.GetOrdinal("MedCommsisionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileDescription"))) _medcommissionfiledescription = reader.GetString(reader.GetOrdinal("MedCommissionFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFilePath"))) _medcommissionfilepath = reader.GetString(reader.GetOrdinal("MedCommissionFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileName"))) _medcommissionfilename = reader.GetString(reader.GetOrdinal("MedCommissionFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileType"))) _medcommissionfiletype = reader.GetString(reader.GetOrdinal("MedCommissionFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionExtension"))) _medcommissionextension = reader.GetString(reader.GetOrdinal("MedCommissionExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileNo"))) _medcommissionfileno = reader.GetGuid(reader.GetOrdinal("MedCommissionFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionDesc"))) _medcommissiondesc = reader.GetString(reader.GetOrdinal("MedCommissionDesc"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocNo"))) _docno = reader.GetString(reader.GetOrdinal("DocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocDate"))) _docdate = reader.GetDateTime(reader.GetOrdinal("DocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileDescription"))) _docfiledescription = reader.GetString(reader.GetOrdinal("DocFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFilePath"))) _docfilepath = reader.GetString(reader.GetOrdinal("DocFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileName"))) _docfilename = reader.GetString(reader.GetOrdinal("DocFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileType"))) _docfiletype = reader.GetString(reader.GetOrdinal("DocFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocExtension"))) _docextension = reader.GetString(reader.GetOrdinal("DocExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileNo"))) _docfileno = reader.GetGuid(reader.GetOrdinal("DocFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedAction"))) _medaction = reader.GetString(reader.GetOrdinal("MedAction"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("MiltMedicalID"))) _miltmedicalid = reader.GetInt64(reader.GetOrdinal("MiltMedicalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionNo"))) _medcommissionno = reader.GetString(reader.GetOrdinal("MedCommissionNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommsisionDate"))) _medcommsisiondate = reader.GetDateTime(reader.GetOrdinal("MedCommsisionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileDescription"))) _medcommissionfiledescription = reader.GetString(reader.GetOrdinal("MedCommissionFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFilePath"))) _medcommissionfilepath = reader.GetString(reader.GetOrdinal("MedCommissionFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileName"))) _medcommissionfilename = reader.GetString(reader.GetOrdinal("MedCommissionFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileType"))) _medcommissionfiletype = reader.GetString(reader.GetOrdinal("MedCommissionFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionExtension"))) _medcommissionextension = reader.GetString(reader.GetOrdinal("MedCommissionExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionFileNo"))) _medcommissionfileno = reader.GetGuid(reader.GetOrdinal("MedCommissionFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedCommissionDesc"))) _medcommissiondesc = reader.GetString(reader.GetOrdinal("MedCommissionDesc"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocNo"))) _docno = reader.GetString(reader.GetOrdinal("DocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocDate"))) _docdate = reader.GetDateTime(reader.GetOrdinal("DocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileDescription"))) _docfiledescription = reader.GetString(reader.GetOrdinal("DocFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFilePath"))) _docfilepath = reader.GetString(reader.GetOrdinal("DocFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileName"))) _docfilename = reader.GetString(reader.GetOrdinal("DocFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileType"))) _docfiletype = reader.GetString(reader.GetOrdinal("DocFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocExtension"))) _docextension = reader.GetString(reader.GetOrdinal("DocExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("DocFileNo"))) _docfileno = reader.GetGuid(reader.GetOrdinal("DocFileNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedAction"))) _medaction = reader.GetString(reader.GetOrdinal("MedAction"));
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
