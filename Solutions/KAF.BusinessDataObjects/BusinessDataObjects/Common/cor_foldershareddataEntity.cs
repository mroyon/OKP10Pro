using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "cor_foldershareddataEntity", Namespace = "http://www.KAF.com/types")]
    public partial class cor_foldershareddataEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _sharedmappingid;
        protected long ? _foldersharedid;
        protected string _hashtbname;
        protected long ? _taskid;
        protected long ? _correspondenceid;
        protected Guid ? _userid;
        protected long ? _meetingid;
        protected long ? _notificationid;
                
        
        [DataMember]
        public long ? sharedmappingid
        {
            get { return _sharedmappingid; }
            set { _sharedmappingid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "foldersharedid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldershareddata), ErrorMessageResourceName = "foldersharedidRequired")]
        public long ? foldersharedid
        {
            get { return _foldersharedid; }
            set { _foldersharedid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        //[Display(Name = "hashtbname", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        public string hashtbname
        {
            get { return _hashtbname; }
            set { _hashtbname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "taskid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        public long ? taskid
        {
            get { return _taskid; }
            set { _taskid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "correspondenceid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        public long ? correspondenceid
        {
            get { return _correspondenceid; }
            set { _correspondenceid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "userid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._cor_foldershareddata), ErrorMessageResourceName = "useridRequired")]
        public Guid ? userid
        {
            get { return _userid; }
            set { _userid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "meetingid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        public long ? meetingid
        {
            get { return _meetingid; }
            set { _meetingid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        //[Display(Name = "notificationid", ResourceType = typeof(KAF.MsgContainer._cor_foldershareddata))]
        public long ? notificationid
        {
            get { return _notificationid; }
            set { _notificationid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public cor_foldershareddataEntity():base()
        {
        }
        
        public cor_foldershareddataEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public cor_foldershareddataEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("SharedMappingID"))) _sharedmappingid = reader.GetInt64(reader.GetOrdinal("SharedMappingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderSharedID"))) _foldersharedid = reader.GetInt64(reader.GetOrdinal("FolderSharedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HashTBName"))) _hashtbname = reader.GetString(reader.GetOrdinal("HashTBName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TaskID"))) _taskid = reader.GetInt64(reader.GetOrdinal("TaskID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CorrespondenceID"))) _correspondenceid = reader.GetInt64(reader.GetOrdinal("CorrespondenceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MeetingID"))) _meetingid = reader.GetInt64(reader.GetOrdinal("MeetingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationID"))) _notificationid = reader.GetInt64(reader.GetOrdinal("NotificationID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("SharedMappingID"))) _sharedmappingid = reader.GetInt64(reader.GetOrdinal("SharedMappingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FolderSharedID"))) _foldersharedid = reader.GetInt64(reader.GetOrdinal("FolderSharedID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HashTBName"))) _hashtbname = reader.GetString(reader.GetOrdinal("HashTBName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TaskID"))) _taskid = reader.GetInt64(reader.GetOrdinal("TaskID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CorrespondenceID"))) _correspondenceid = reader.GetInt64(reader.GetOrdinal("CorrespondenceID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MeetingID"))) _meetingid = reader.GetInt64(reader.GetOrdinal("MeetingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationID"))) _notificationid = reader.GetInt64(reader.GetOrdinal("NotificationID"));
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
