﻿using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_civilidinfoEntity 
    {
        protected long? _militarynokw;
        protected string _militarynobd;
        protected string _fullname;
        protected DateTime? _dateofbirth;
        protected string _passportno;

        [DataMember]
        public long? militarynokw
        {
            get { return _militarynokw; }
            set { _militarynokw = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(550)]
        [Display(Name = "fullname", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "dateofbirth", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public DateTime? dateofbirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; this.OnChnaged(); }
        }

        [DataMember]
        public string militarynobd
        {
            get { return _militarynobd; }
            set { _militarynobd = value; this.OnChnaged(); }
        }

        [DataMember]
        [MaxLength(100)]
        [Display(Name = "passportno", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }

        public hr_civilidinfoEntity(IDataReader reader, int Ext)
        {
            this.LoadFromReader_Ext(reader);
        }

        protected void LoadFromReader_Ext(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDNo"))) _civilidno = reader.GetString(reader.GetOrdinal("CivilIDNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SerialNo"))) _serialno = reader.GetInt64(reader.GetOrdinal("SerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDIssueDate"))) _civilidissuedate = reader.GetDateTime(reader.GetOrdinal("CivilIDIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExpiryDate"))) _civilidexpirydate = reader.GetDateTime(reader.GetOrdinal("CivilIDExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription"))) _civilidfiledescription = reader.GetString(reader.GetOrdinal("CivilIDFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath"))) _civilidfilepath = reader.GetString(reader.GetOrdinal("CivilIDFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName"))) _civilidfilename = reader.GetString(reader.GetOrdinal("CivilIDFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType"))) _civilidfiletype = reader.GetString(reader.GetOrdinal("CivilIDFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension"))) _civilidextension = reader.GetString(reader.GetOrdinal("CivilIDExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID"))) _civilidfileid = reader.GetGuid(reader.GetOrdinal("CivilIDFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileDescription_2"))) _civilidfiledescription_2 = reader.GetString(reader.GetOrdinal("CivilIDFileDescription_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFilePath_2"))) _civilidfilepath_2 = reader.GetString(reader.GetOrdinal("CivilIDFilePath_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileName_2"))) _civilidfilename_2 = reader.GetString(reader.GetOrdinal("CivilIDFileName_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileType_2"))) _civilidfiletype_2 = reader.GetString(reader.GetOrdinal("CivilIDFileType_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDExtension_2"))) _civilidextension_2 = reader.GetString(reader.GetOrdinal("CivilIDExtension_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilIDFileID_2"))) _civilidfileid_2 = reader.GetGuid(reader.GetOrdinal("CivilIDFileID_2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
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
    }
}
