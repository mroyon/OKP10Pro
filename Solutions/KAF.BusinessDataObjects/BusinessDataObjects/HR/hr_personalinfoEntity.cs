using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_personalinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_personalinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrpersonalinfoid;
        protected long ? _hrbasicid;
        protected long ? _religionid;
        protected long ? _bloodgroupid;
        protected long ? _maritalstatusid;
        protected long ? _genderid;
        protected long ? _nationalityid;
        protected long ? _buildingid;
        protected long ? _kwgovid;
        protected long ? _kwareaid;
        protected string _kwblockno;
        protected string _kwstreet;
        protected string _kwhouseno;
        protected string _kwflatno;
        protected string _kwmobile;
        protected string _kwviber;
        protected string _personalemail;
        protected string _officialemail;
        protected long ? _bdcurdivid;
        protected long ? _bdcurcityid;
        protected long ? _bdcurthanaid;
        protected string _bdcurpostoffice;
        protected string _bdcurroad;
        protected string _bdcurhouse;
        protected string _bdcurflatno;
        protected string _bdmob1;
        protected string _bdmob2;
        protected string _bdhomephone;
        protected long ? _bdperdivid;
        protected long ? _bdpercityid;
        protected long ? _bdperthanaid;
        protected string _bdperpostoffice;
        protected string _bdperroad;
        protected string _bdperhouse;
        protected string _bdperflatno;
        protected string _remarks;
                
        
        [DataMember]
        public long ? hrpersonalinfoid
        {
            get { return _hrpersonalinfoid; }
            set { _hrpersonalinfoid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "religionid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "religionidRequired")]
        public long ? religionid
        {
            get { return _religionid; }
            set { _religionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bloodgroupid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bloodgroupidRequired")]
        public long ? bloodgroupid
        {
            get { return _bloodgroupid; }
            set { _bloodgroupid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "maritalstatusid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "maritalstatusidRequired")]
        public long ? maritalstatusid
        {
            get { return _maritalstatusid; }
            set { _maritalstatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "genderid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "genderidRequired")]
        public long ? genderid
        {
            get { return _genderid; }
            set { _genderid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "nationalityid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "nationalityidRequired")]
        public long ? nationalityid
        {
            get { return _nationalityid; }
            set { _nationalityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "buildingid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public long ? buildingid
        {
            get { return _buildingid; }
            set { _buildingid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "kwgovid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public long ? kwgovid
        {
            get { return _kwgovid; }
            set { _kwgovid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "kwareaid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public long ? kwareaid
        {
            get { return _kwareaid; }
            set { _kwareaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwblockno", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string kwblockno
        {
            get { return _kwblockno; }
            set { _kwblockno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "kwstreet", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string kwstreet
        {
            get { return _kwstreet; }
            set { _kwstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwhouseno", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string kwhouseno
        {
            get { return _kwhouseno; }
            set { _kwhouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwflatno", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string kwflatno
        {
            get { return _kwflatno; }
            set { _kwflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwmobile", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string kwmobile
        {
            get { return _kwmobile; }
            set { _kwmobile = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwviber", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "kwviberRequired")]
        public string kwviber
        {
            get { return _kwviber; }
            set { _kwviber = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "personalemail", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string personalemail
        {
            get { return _personalemail; }
            set { _personalemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "officialemail", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string officialemail
        {
            get { return _officialemail; }
            set { _officialemail = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdcurdivid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdcurdividRequired")]
        public long ? bdcurdivid
        {
            get { return _bdcurdivid; }
            set { _bdcurdivid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdcurcityid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdcurcityidRequired")]
        public long ? bdcurcityid
        {
            get { return _bdcurcityid; }
            set { _bdcurcityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdcurthanaid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdcurthanaidRequired")]
        public long ? bdcurthanaid
        {
            get { return _bdcurthanaid; }
            set { _bdcurthanaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdcurpostoffice", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdcurpostoffice
        {
            get { return _bdcurpostoffice; }
            set { _bdcurpostoffice = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdcurroad", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdcurroad
        {
            get { return _bdcurroad; }
            set { _bdcurroad = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdcurhouse", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdcurhouse
        {
            get { return _bdcurhouse; }
            set { _bdcurhouse = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdcurflatno", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdcurflatno
        {
            get { return _bdcurflatno; }
            set { _bdcurflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "bdmob1", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdmob1
        {
            get { return _bdmob1; }
            set { _bdmob1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "bdmob2", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdmob2
        {
            get { return _bdmob2; }
            set { _bdmob2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "bdhomephone", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdhomephone
        {
            get { return _bdhomephone; }
            set { _bdhomephone = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdperdivid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdperdividRequired")]
        public long ? bdperdivid
        {
            get { return _bdperdivid; }
            set { _bdperdivid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdpercityid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdpercityidRequired")]
        public long ? bdpercityid
        {
            get { return _bdpercityid; }
            set { _bdpercityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "bdperthanaid", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_personalinfo), ErrorMessageResourceName = "bdperthanaidRequired")]
        public long ? bdperthanaid
        {
            get { return _bdperthanaid; }
            set { _bdperthanaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdperpostoffice", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdperpostoffice
        {
            get { return _bdperpostoffice; }
            set { _bdperpostoffice = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdperroad", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdperroad
        {
            get { return _bdperroad; }
            set { _bdperroad = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdperhouse", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdperhouse
        {
            get { return _bdperhouse; }
            set { _bdperhouse = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "bdperflatno", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string bdperflatno
        {
            get { return _bdperflatno; }
            set { _bdperflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_personalinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_personalinfoEntity():base()
        {
        }
        
        public hr_personalinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_personalinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrPersonalInfoID"))) _hrpersonalinfoid = reader.GetInt64(reader.GetOrdinal("HrPersonalInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionID"))) _religionid = reader.GetInt64(reader.GetOrdinal("ReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupId"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("BloodGroupId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _genderid = reader.GetInt64(reader.GetOrdinal("GenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _buildingid = reader.GetInt64(reader.GetOrdinal("BuildingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("KWGovID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _kwblockno = reader.GetString(reader.GetOrdinal("KWBlockNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("KWStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _kwhouseno = reader.GetString(reader.GetOrdinal("KWHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _kwflatno = reader.GetString(reader.GetOrdinal("KWFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _kwmobile = reader.GetString(reader.GetOrdinal("KWMobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _kwviber = reader.GetString(reader.GetOrdinal("KWViber"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _personalemail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _officialemail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _bdcurdivid = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _bdcurcityid = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _bdcurthanaid = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _bdcurpostoffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _bdcurroad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _bdcurhouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _bdcurflatno = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _bdmob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _bdmob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _bdhomephone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _bdperdivid = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _bdpercityid = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _bdperthanaid = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _bdperpostoffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _bdperroad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _bdperhouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _bdperflatno = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("HrPersonalInfoID"))) _hrpersonalinfoid = reader.GetInt64(reader.GetOrdinal("HrPersonalInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionID"))) _religionid = reader.GetInt64(reader.GetOrdinal("ReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupId"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("BloodGroupId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _genderid = reader.GetInt64(reader.GetOrdinal("GenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _buildingid = reader.GetInt64(reader.GetOrdinal("BuildingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("KWGovID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _kwblockno = reader.GetString(reader.GetOrdinal("KWBlockNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("KWStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _kwhouseno = reader.GetString(reader.GetOrdinal("KWHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _kwflatno = reader.GetString(reader.GetOrdinal("KWFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _kwmobile = reader.GetString(reader.GetOrdinal("KWMobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _kwviber = reader.GetString(reader.GetOrdinal("KWViber"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _personalemail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _officialemail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _bdcurdivid = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _bdcurcityid = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _bdcurthanaid = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _bdcurpostoffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _bdcurroad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _bdcurhouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _bdcurflatno = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _bdmob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _bdmob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _bdhomephone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _bdperdivid = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _bdpercityid = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _bdperthanaid = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _bdperpostoffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _bdperroad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _bdperhouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _bdperflatno = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
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
