using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_basicprofileEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_basicprofileEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrbasicid;
        protected long ? _civilid;
        protected DateTime ? _civilidexpiredate;
        protected string _passportno;
        protected string _nationalid;
        protected long ? _bdsmartcardid;
        protected string _name1;
        protected string _name2;
        protected string _name3;
        protected string _fullname;
        protected string _name1ar;
        protected string _name2ar;
        protected string _name3ar;
        protected string _fullnamear;
        protected DateTime ? _dateofbirth;
        protected DateTime ? _joindatebd;
        protected string _remarks;
        protected string _profilephoto;
        protected string _profilephotofilepath;
        protected string _profilephotofilename;
        protected string _profilephotofiletype;
        protected string _profilephotofileextension;
        protected int ? _forreview;
        protected long ? _status;
        protected Guid? _userid;


        [DataMember]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long ? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "civilidexpiredate", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public DateTime ? civilidexpiredate
        {
            get { return _civilidexpiredate; }
            set { _civilidexpiredate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "passportno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "nationalid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string nationalid
        {
            get { return _nationalid; }
            set { _nationalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdsmartcardid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long ? bdsmartcardid
        {
            get { return _bdsmartcardid; }
            set { _bdsmartcardid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name1", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "name1Required")]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name2", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "name2Required")]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name3", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string name3
        {
            get { return _name3; }
            set { _name3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "fullname", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
       // [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name1ar", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string name1ar
        {
            get { return _name1ar; }
            set { _name1ar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name2ar", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string name2ar
        {
            get { return _name2ar; }
            set { _name2ar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name3ar", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string name3ar
        {
            get { return _name3ar; }
            set { _name3ar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fullnamear", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string fullnamear
        {
            get { return _fullnamear; }
            set { _fullnamear = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "dateofbirth", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public DateTime ? dateofbirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "joindatebd", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public DateTime ? joindatebd
        {
            get { return _joindatebd; }
            set { _joindatebd = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "profilephoto", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string profilephoto
        {
            get { return _profilephoto; }
            set { _profilephoto = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "profilephotofilepath", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string profilephotofilepath
        {
            get { return _profilephotofilepath; }
            set { _profilephotofilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "profilephotofilename", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string profilephotofilename
        {
            get { return _profilephotofilename; }
            set { _profilephotofilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "profilephotofiletype", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string profilephotofiletype
        {
            get { return _profilephotofiletype; }
            set { _profilephotofiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "profilephotofileextension", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string profilephotofileextension
        {
            get { return _profilephotofileextension; }
            set { _profilephotofileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "status", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long ? status
        {
            get { return _status; }
            set { _status = value; this.OnChnaged(); }
        }

        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        #endregion

        #region Constructor

        public hr_basicprofileEntity():base()
        {
        }
        
        public hr_basicprofileEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_basicprofileEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpireDate"))) _civilidexpiredate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpireDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDSmartCardID"))) _bdsmartcardid = reader.GetInt64(reader.GetOrdinal("BDSmartCardID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1Ar"))) _name1ar = reader.GetString(reader.GetOrdinal("Name1Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2Ar"))) _name2ar = reader.GetString(reader.GetOrdinal("Name2Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3Ar"))) _name3ar = reader.GetString(reader.GetOrdinal("Name3Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameAr"))) _fullnamear = reader.GetString(reader.GetOrdinal("FullNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDateBD"))) _joindatebd = reader.GetDateTime(reader.GetOrdinal("JoinDateBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto"))) _profilephoto = reader.GetString(reader.GetOrdinal("ProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFilePath"))) _profilephotofilepath = reader.GetString(reader.GetOrdinal("ProfilePhotoFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileName"))) _profilephotofilename = reader.GetString(reader.GetOrdinal("ProfilePhotoFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileType"))) _profilephotofiletype = reader.GetString(reader.GetOrdinal("ProfilePhotoFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileExtension"))) _profilephotofileextension = reader.GetString(reader.GetOrdinal("ProfilePhotoFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));

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
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpireDate"))) _civilidexpiredate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpireDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalID"))) _nationalid = reader.GetString(reader.GetOrdinal("NationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDSmartCardID"))) _bdsmartcardid = reader.GetInt64(reader.GetOrdinal("BDSmartCardID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1Ar"))) _name1ar = reader.GetString(reader.GetOrdinal("Name1Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2Ar"))) _name2ar = reader.GetString(reader.GetOrdinal("Name2Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3Ar"))) _name3ar = reader.GetString(reader.GetOrdinal("Name3Ar"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullNameAr"))) _fullnamear = reader.GetString(reader.GetOrdinal("FullNameAr"));
                if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("JoinDateBD"))) _joindatebd = reader.GetDateTime(reader.GetOrdinal("JoinDateBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto"))) _profilephoto = reader.GetString(reader.GetOrdinal("ProfilePhoto"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFilePath"))) _profilephotofilepath = reader.GetString(reader.GetOrdinal("ProfilePhotoFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileName"))) _profilephotofilename = reader.GetString(reader.GetOrdinal("ProfilePhotoFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileType"))) _profilephotofiletype = reader.GetString(reader.GetOrdinal("ProfilePhotoFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileExtension"))) _profilephotofileextension = reader.GetString(reader.GetOrdinal("ProfilePhotoFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));
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
