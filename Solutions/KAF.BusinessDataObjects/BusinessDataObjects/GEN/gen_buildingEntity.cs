using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "gen_buildingEntity", Namespace = "http://www.KAF.com/types")]
    public partial class gen_buildingEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _buildingid;
        protected string _buildingname;
        protected long ? _kwgovid;
        protected long ? _kwareaid;
        protected string _kwblockno;
        protected string _kwstreet;
        protected string _kwhouseno;
        protected bool ? _isactive;
        protected string _remarks;
                
        
        [DataMember]
        public long ? buildingid
        {
            get { return _buildingid; }
            set { _buildingid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "buildingname", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "buildingnameRequired")]
        public string buildingname
        {
            get { return _buildingname; }
            set { _buildingname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "kwgovid", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "kwgovidRequired")]
        public long ? kwgovid
        {
            get { return _kwgovid; }
            set { _kwgovid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "kwareaid", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "kwareaidRequired")]
        public long ? kwareaid
        {
            get { return _kwareaid; }
            set { _kwareaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwblockno", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "kwblocknoRequired")]
        public string kwblockno
        {
            get { return _kwblockno; }
            set { _kwblockno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "kwstreet", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "kwstreetRequired")]
        public string kwstreet
        {
            get { return _kwstreet; }
            set { _kwstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "kwhouseno", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._gen_building), ErrorMessageResourceName = "kwhousenoRequired")]
        public string kwhouseno
        {
            get { return _kwhouseno; }
            set { _kwhouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isactive", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        public bool ? isactive
        {
            get { return _isactive; }
            set { _isactive = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._gen_building))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public gen_buildingEntity():base()
        {
        }
        
        public gen_buildingEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public gen_buildingEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _buildingid = reader.GetInt64(reader.GetOrdinal("BuildingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingName"))) _buildingname = reader.GetString(reader.GetOrdinal("BuildingName"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("KWGovID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _kwblockno = reader.GetString(reader.GetOrdinal("KWBlockNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("KWStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _kwhouseno = reader.GetString(reader.GetOrdinal("KWHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _buildingid = reader.GetInt64(reader.GetOrdinal("BuildingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingName"))) _buildingname = reader.GetString(reader.GetOrdinal("BuildingName"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("KWGovID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _kwblockno = reader.GetString(reader.GetOrdinal("KWBlockNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("KWStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _kwhouseno = reader.GetString(reader.GetOrdinal("KWHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) _isactive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
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
