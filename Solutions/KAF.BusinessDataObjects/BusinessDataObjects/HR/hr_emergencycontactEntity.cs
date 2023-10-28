using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_emergencycontactEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_emergencycontactEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _emergencycontactid;
        protected long ? _hrbasicid;
        protected long ? _relationshipid;
        protected string _name1;
        protected string _name2;
        protected string _name3;
        protected string _name4;
        protected string _name5;
        protected string _fullname;
        protected string _curbdaddressflatno;
        protected string _curbdaddresshouseno;
        protected string _curbdaddressstreet;
        protected long ? _curbdadrresspo;
        protected long ? _curbdadrressps;
        protected long ? _curbdaddressdist;
        protected long ? _curbdaddressdivision;
        protected string _mobilebd;
        protected string _telephonebd;
        protected string _perbdaddressflatno;
        protected string _perbdaddresshouseno;
        protected string _perbdaddressstreet;
        protected long ? _perbdadrresspo;
        protected long ? _perbdadrressps;
        protected long ? _perbdaddressdivision;
        protected long ? _perbdaddressdist;
        protected string _curkwaddressflatno;
        protected string _curkwaddresshouseno;
        protected string _curkwaddressstreet;
        protected string _curkwadrressblock;
        protected string _curkwadrressavenue;
        protected long ? _curkwgovnerid;
        protected long ? _curkwareaid;
        protected long ? _curkwpacino;
        protected string _mobilekw;
        protected string _telephonekw;
        protected string _remarks;
                
        
        [DataMember]
        public long ? emergencycontactid
        {
            get { return _emergencycontactid; }
            set { _emergencycontactid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_emergencycontact), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relationshipid", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_emergencycontact), ErrorMessageResourceName = "relationshipidRequired")]
        public long ? relationshipid
        {
            get { return _relationshipid; }
            set { _relationshipid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name1", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_emergencycontact), ErrorMessageResourceName = "name1Required")]
        public string name1
        {
            get { return _name1; }
            set { _name1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name2", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_emergencycontact), ErrorMessageResourceName = "name2Required")]
        public string name2
        {
            get { return _name2; }
            set { _name2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name3", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string name3
        {
            get { return _name3; }
            set { _name3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name4", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string name4
        {
            get { return _name4; }
            set { _name4 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "name5", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string name5
        {
            get { return _name5; }
            set { _name5 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "fullname", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curbdaddressflatno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curbdaddressflatno
        {
            get { return _curbdaddressflatno; }
            set { _curbdaddressflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curbdaddresshouseno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curbdaddresshouseno
        {
            get { return _curbdaddresshouseno; }
            set { _curbdaddresshouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "curbdaddressstreet", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curbdaddressstreet
        {
            get { return _curbdaddressstreet; }
            set { _curbdaddressstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curbdadrresspo", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curbdadrresspo
        {
            get { return _curbdadrresspo; }
            set { _curbdadrresspo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curbdadrressps", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curbdadrressps
        {
            get { return _curbdadrressps; }
            set { _curbdadrressps = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curbdaddressdist", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curbdaddressdist
        {
            get { return _curbdaddressdist; }
            set { _curbdaddressdist = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curbdaddressdivision", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curbdaddressdivision
        {
            get { return _curbdaddressdivision; }
            set { _curbdaddressdivision = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "mobilebd", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_emergencycontact), ErrorMessageResourceName = "mobilebdRequired")]
        public string mobilebd
        {
            get { return _mobilebd; }
            set { _mobilebd = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephonebd", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string telephonebd
        {
            get { return _telephonebd; }
            set { _telephonebd = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "perbdaddressflatno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string perbdaddressflatno
        {
            get { return _perbdaddressflatno; }
            set { _perbdaddressflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "perbdaddresshouseno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string perbdaddresshouseno
        {
            get { return _perbdaddresshouseno; }
            set { _perbdaddresshouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "perbdaddressstreet", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string perbdaddressstreet
        {
            get { return _perbdaddressstreet; }
            set { _perbdaddressstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "perbdadrresspo", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? perbdadrresspo
        {
            get { return _perbdadrresspo; }
            set { _perbdadrresspo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "perbdadrressps", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? perbdadrressps
        {
            get { return _perbdadrressps; }
            set { _perbdadrressps = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "perbdaddressdivision", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? perbdaddressdivision
        {
            get { return _perbdaddressdivision; }
            set { _perbdaddressdivision = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "perbdaddressdist", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? perbdaddressdist
        {
            get { return _perbdaddressdist; }
            set { _perbdaddressdist = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curkwaddressflatno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curkwaddressflatno
        {
            get { return _curkwaddressflatno; }
            set { _curkwaddressflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curkwaddresshouseno", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curkwaddresshouseno
        {
            get { return _curkwaddresshouseno; }
            set { _curkwaddresshouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "curkwaddressstreet", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curkwaddressstreet
        {
            get { return _curkwaddressstreet; }
            set { _curkwaddressstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curkwadrressblock", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curkwadrressblock
        {
            get { return _curkwadrressblock; }
            set { _curkwadrressblock = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "curkwadrressavenue", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string curkwadrressavenue
        {
            get { return _curkwadrressavenue; }
            set { _curkwadrressavenue = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curkwgovnerid", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curkwgovnerid
        {
            get { return _curkwgovnerid; }
            set { _curkwgovnerid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curkwareaid", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curkwareaid
        {
            get { return _curkwareaid; }
            set { _curkwareaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "curkwpacino", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public long ? curkwpacino
        {
            get { return _curkwpacino; }
            set { _curkwpacino = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "mobilekw", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string mobilekw
        {
            get { return _mobilekw; }
            set { _mobilekw = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "telephonekw", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string telephonekw
        {
            get { return _telephonekw; }
            set { _telephonekw = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_emergencycontact))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_emergencycontactEntity():base()
        {
        }
        
        public hr_emergencycontactEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_emergencycontactEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactID"))) _emergencycontactid = reader.GetInt64(reader.GetOrdinal("EmergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressFlatNo"))) _curbdaddressflatno = reader.GetString(reader.GetOrdinal("CurBDAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressHouseNo"))) _curbdaddresshouseno = reader.GetString(reader.GetOrdinal("CurBDAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressStreet"))) _curbdaddressstreet = reader.GetString(reader.GetOrdinal("CurBDAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAdrressPO"))) _curbdadrresspo = reader.GetInt64(reader.GetOrdinal("CurBDAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAdrressPS"))) _curbdadrressps = reader.GetInt64(reader.GetOrdinal("CurBDAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressDist"))) _curbdaddressdist = reader.GetInt64(reader.GetOrdinal("CurBDAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressDivision"))) _curbdaddressdivision = reader.GetInt64(reader.GetOrdinal("CurBDAddressDivision"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileBD"))) _mobilebd = reader.GetString(reader.GetOrdinal("MobileBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TelephoneBD"))) _telephonebd = reader.GetString(reader.GetOrdinal("TelephoneBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressFlatNo"))) _perbdaddressflatno = reader.GetString(reader.GetOrdinal("PerBDAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressHouseNo"))) _perbdaddresshouseno = reader.GetString(reader.GetOrdinal("PerBDAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressStreet"))) _perbdaddressstreet = reader.GetString(reader.GetOrdinal("PerBDAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAdrressPO"))) _perbdadrresspo = reader.GetInt64(reader.GetOrdinal("PerBDAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAdrressPS"))) _perbdadrressps = reader.GetInt64(reader.GetOrdinal("PerBDAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressDivision"))) _perbdaddressdivision = reader.GetInt64(reader.GetOrdinal("PerBDAddressDivision"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressDist"))) _perbdaddressdist = reader.GetInt64(reader.GetOrdinal("PerBDAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressFlatNo"))) _curkwaddressflatno = reader.GetString(reader.GetOrdinal("CurKWAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressHouseNo"))) _curkwaddresshouseno = reader.GetString(reader.GetOrdinal("CurKWAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressStreet"))) _curkwaddressstreet = reader.GetString(reader.GetOrdinal("CurKWAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAdrressBlock"))) _curkwadrressblock = reader.GetString(reader.GetOrdinal("CurKWAdrressBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAdrressAvenue"))) _curkwadrressavenue = reader.GetString(reader.GetOrdinal("CurKWAdrressAvenue"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWGovnerID"))) _curkwgovnerid = reader.GetInt64(reader.GetOrdinal("CurKWGovnerID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAreaID"))) _curkwareaid = reader.GetInt64(reader.GetOrdinal("CurKWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWPACINo"))) _curkwpacino = reader.GetInt64(reader.GetOrdinal("CurKWPACINo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileKW"))) _mobilekw = reader.GetString(reader.GetOrdinal("MobileKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("TelephoneKW"))) _telephonekw = reader.GetString(reader.GetOrdinal("TelephoneKW"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("EmergencyContactID"))) _emergencycontactid = reader.GetInt64(reader.GetOrdinal("EmergencyContactID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name4"))) _name4 = reader.GetString(reader.GetOrdinal("Name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("Name5"))) _name5 = reader.GetString(reader.GetOrdinal("Name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressFlatNo"))) _curbdaddressflatno = reader.GetString(reader.GetOrdinal("CurBDAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressHouseNo"))) _curbdaddresshouseno = reader.GetString(reader.GetOrdinal("CurBDAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressStreet"))) _curbdaddressstreet = reader.GetString(reader.GetOrdinal("CurBDAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAdrressPO"))) _curbdadrresspo = reader.GetInt64(reader.GetOrdinal("CurBDAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAdrressPS"))) _curbdadrressps = reader.GetInt64(reader.GetOrdinal("CurBDAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressDist"))) _curbdaddressdist = reader.GetInt64(reader.GetOrdinal("CurBDAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurBDAddressDivision"))) _curbdaddressdivision = reader.GetInt64(reader.GetOrdinal("CurBDAddressDivision"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileBD"))) _mobilebd = reader.GetString(reader.GetOrdinal("MobileBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("TelephoneBD"))) _telephonebd = reader.GetString(reader.GetOrdinal("TelephoneBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressFlatNo"))) _perbdaddressflatno = reader.GetString(reader.GetOrdinal("PerBDAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressHouseNo"))) _perbdaddresshouseno = reader.GetString(reader.GetOrdinal("PerBDAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressStreet"))) _perbdaddressstreet = reader.GetString(reader.GetOrdinal("PerBDAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAdrressPO"))) _perbdadrresspo = reader.GetInt64(reader.GetOrdinal("PerBDAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAdrressPS"))) _perbdadrressps = reader.GetInt64(reader.GetOrdinal("PerBDAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressDivision"))) _perbdaddressdivision = reader.GetInt64(reader.GetOrdinal("PerBDAddressDivision"));
                if (!reader.IsDBNull(reader.GetOrdinal("PerBDAddressDist"))) _perbdaddressdist = reader.GetInt64(reader.GetOrdinal("PerBDAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressFlatNo"))) _curkwaddressflatno = reader.GetString(reader.GetOrdinal("CurKWAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressHouseNo"))) _curkwaddresshouseno = reader.GetString(reader.GetOrdinal("CurKWAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAddressStreet"))) _curkwaddressstreet = reader.GetString(reader.GetOrdinal("CurKWAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAdrressBlock"))) _curkwadrressblock = reader.GetString(reader.GetOrdinal("CurKWAdrressBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAdrressAvenue"))) _curkwadrressavenue = reader.GetString(reader.GetOrdinal("CurKWAdrressAvenue"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWGovnerID"))) _curkwgovnerid = reader.GetInt64(reader.GetOrdinal("CurKWGovnerID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWAreaID"))) _curkwareaid = reader.GetInt64(reader.GetOrdinal("CurKWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CurKWPACINo"))) _curkwpacino = reader.GetInt64(reader.GetOrdinal("CurKWPACINo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MobileKW"))) _mobilekw = reader.GetString(reader.GetOrdinal("MobileKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("TelephoneKW"))) _telephonekw = reader.GetString(reader.GetOrdinal("TelephoneKW"));
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
