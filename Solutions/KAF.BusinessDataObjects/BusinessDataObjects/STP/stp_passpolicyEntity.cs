using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "stp_passpolicyEntity", Namespace = "http://www.KAF.com/types")]
    public partial class stp_passpolicyEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _serialnopolicykey;
        protected long ? _categoryid;
        protected int ? _passexpiredays;
        protected bool ? _passexpiredaysis;
        protected int ? _passmaxlength;
        protected int ? _passminlength;
        protected bool ? _passmcontainchar;
        protected bool ? _passmcontainuchar;
        protected bool ? _passmcontainnum;
        protected bool ? _passmcontainspchar;
        protected bool ? _oldpasscom;
        protected int ? _newpasscomoldpass;
        protected string _regpasscontainchar;
        protected string _regpasscontainuchar;
        protected string _regpasscontainnum;
        protected string _regpasscontainspchar;
        protected long ? _organizationkey;
                
        
        [DataMember]
        public long ? serialnopolicykey
        {
            get { return _serialnopolicykey; }
            set { _serialnopolicykey = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "categoryid", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_passpolicy), ErrorMessageResourceName = "categoryidRequired")]
        public long ? categoryid
        {
            get { return _categoryid; }
            set { _categoryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passexpiredays", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public int ? passexpiredays
        {
            get { return _passexpiredays; }
            set { _passexpiredays = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passexpiredaysis", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? passexpiredaysis
        {
            get { return _passexpiredaysis; }
            set { _passexpiredaysis = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passmaxlength", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public int ? passmaxlength
        {
            get { return _passmaxlength; }
            set { _passmaxlength = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passminlength", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public int ? passminlength
        {
            get { return _passminlength; }
            set { _passminlength = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passmcontainchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? passmcontainchar
        {
            get { return _passmcontainchar; }
            set { _passmcontainchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passmcontainuchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? passmcontainuchar
        {
            get { return _passmcontainuchar; }
            set { _passmcontainuchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passmcontainnum", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? passmcontainnum
        {
            get { return _passmcontainnum; }
            set { _passmcontainnum = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passmcontainspchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? passmcontainspchar
        {
            get { return _passmcontainspchar; }
            set { _passmcontainspchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "oldpasscom", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public bool ? oldpasscom
        {
            get { return _oldpasscom; }
            set { _oldpasscom = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "newpasscomoldpass", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public int ? newpasscomoldpass
        {
            get { return _newpasscomoldpass; }
            set { _newpasscomoldpass = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "regpasscontainchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public string regpasscontainchar
        {
            get { return _regpasscontainchar; }
            set { _regpasscontainchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "regpasscontainuchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public string regpasscontainuchar
        {
            get { return _regpasscontainuchar; }
            set { _regpasscontainuchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "regpasscontainnum", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public string regpasscontainnum
        {
            get { return _regpasscontainnum; }
            set { _regpasscontainnum = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "regpasscontainspchar", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        public string regpasscontainspchar
        {
            get { return _regpasscontainspchar; }
            set { _regpasscontainspchar = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "organizationkey", ResourceType = typeof(KAF.MsgContainer._stp_passpolicy))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._stp_passpolicy), ErrorMessageResourceName = "organizationkeyRequired")]
        public long ? organizationkey
        {
            get { return _organizationkey; }
            set { _organizationkey = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public stp_passpolicyEntity():base()
        {
        }
        
        public stp_passpolicyEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public stp_passpolicyEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNoPolicyKey"))) _serialnopolicykey = reader.GetInt64(reader.GetOrdinal("SerialNoPolicyKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CategoryID"))) _categoryid = reader.GetInt64(reader.GetOrdinal("CategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassExpireDays"))) _passexpiredays = reader.GetInt32(reader.GetOrdinal("PassExpireDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassExpireDaysIs"))) _passexpiredaysis = reader.GetBoolean(reader.GetOrdinal("PassExpireDaysIs"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMaxLength"))) _passmaxlength = reader.GetInt32(reader.GetOrdinal("PassMaxLength"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMinLength"))) _passminlength = reader.GetInt32(reader.GetOrdinal("PassMinLength"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainChar"))) _passmcontainchar = reader.GetBoolean(reader.GetOrdinal("PassMContainChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainUChar"))) _passmcontainuchar = reader.GetBoolean(reader.GetOrdinal("PassMContainUChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainNum"))) _passmcontainnum = reader.GetBoolean(reader.GetOrdinal("PassMContainNum"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainSPChar"))) _passmcontainspchar = reader.GetBoolean(reader.GetOrdinal("PassMContainSPChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("OldPassCom"))) _oldpasscom = reader.GetBoolean(reader.GetOrdinal("OldPassCom"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewPassComOldPass"))) _newpasscomoldpass = reader.GetInt32(reader.GetOrdinal("NewPassComOldPass"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainChar"))) _regpasscontainchar = reader.GetString(reader.GetOrdinal("RegPassContainChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainUChar"))) _regpasscontainuchar = reader.GetString(reader.GetOrdinal("RegPassContainUChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainNum"))) _regpasscontainnum = reader.GetString(reader.GetOrdinal("RegPassContainNum"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainSPChar"))) _regpasscontainspchar = reader.GetString(reader.GetOrdinal("RegPassContainSPChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNoPolicyKey"))) _serialnopolicykey = reader.GetInt64(reader.GetOrdinal("SerialNoPolicyKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CategoryID"))) _categoryid = reader.GetInt64(reader.GetOrdinal("CategoryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassExpireDays"))) _passexpiredays = reader.GetInt32(reader.GetOrdinal("PassExpireDays"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassExpireDaysIs"))) _passexpiredaysis = reader.GetBoolean(reader.GetOrdinal("PassExpireDaysIs"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMaxLength"))) _passmaxlength = reader.GetInt32(reader.GetOrdinal("PassMaxLength"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMinLength"))) _passminlength = reader.GetInt32(reader.GetOrdinal("PassMinLength"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainChar"))) _passmcontainchar = reader.GetBoolean(reader.GetOrdinal("PassMContainChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainUChar"))) _passmcontainuchar = reader.GetBoolean(reader.GetOrdinal("PassMContainUChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainNum"))) _passmcontainnum = reader.GetBoolean(reader.GetOrdinal("PassMContainNum"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassMContainSPChar"))) _passmcontainspchar = reader.GetBoolean(reader.GetOrdinal("PassMContainSPChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("OldPassCom"))) _oldpasscom = reader.GetBoolean(reader.GetOrdinal("OldPassCom"));
                if (!reader.IsDBNull(reader.GetOrdinal("NewPassComOldPass"))) _newpasscomoldpass = reader.GetInt32(reader.GetOrdinal("NewPassComOldPass"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainChar"))) _regpasscontainchar = reader.GetString(reader.GetOrdinal("RegPassContainChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainUChar"))) _regpasscontainuchar = reader.GetString(reader.GetOrdinal("RegPassContainUChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainNum"))) _regpasscontainnum = reader.GetString(reader.GetOrdinal("RegPassContainNum"));
                if (!reader.IsDBNull(reader.GetOrdinal("RegPassContainSPChar"))) _regpasscontainspchar = reader.GetString(reader.GetOrdinal("RegPassContainSPChar"));
                if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
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
