using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_okptransferinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _militarynokw;
        protected string _militarynobd;
        protected long? _civilid;
        protected string _fullname;
        protected string _passportno;
        protected DateTime? _dateofbirth;


        [DataMember]
        public long? militarynokw
        {
            get { return _militarynokw; }
            set { _militarynokw = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "civilid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
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
        [MaxLength(550)]
        [Display(Name = "passportno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]

        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }
        [DataMember]
        [Display(Name = "dateofbirth", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public DateTime? dateofbirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; this.OnChnaged(); }
        }

        [DataMember]
        //[Display(Name = "militaryno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string militarynobd
        {
            get { return _militarynobd; }
            set { _militarynobd = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor


        public hr_okptransferinfoEntity(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, isExtension);
        }

        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                //if (!reader.IsDBNull(reader.GetOrdinal("PassportID"))) _passportid = reader.GetInt64(reader.GetOrdinal("PassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _militarynobd = reader.GetString(reader.GetOrdinal("MilNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                //if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueDate"))) _passportissuedate = reader.GetDateTime(reader.GetOrdinal("PassportIssueDate"));
                //if (!reader.IsDBNull(reader.GetOrdinal("PassportExpiryDate"))) _passportexpirydate = reader.GetDateTime(reader.GetOrdinal("PassportExpiryDate"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueCountryID"))) _passportissuecountryid = reader.GetInt64(reader.GetOrdinal("PassportIssueCountryID"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyPassport"))) _isfamilypassport = reader.GetBoolean(reader.GetOrdinal("IsFamilyPassport"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportFileDescription"))) _passportfiledescription = reader.GetString(reader.GetOrdinal("PassportFileDescription"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportFilePath"))) _passportfilepath = reader.GetString(reader.GetOrdinal("PassportFilePath"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportFileName"))) _passportfilename = reader.GetString(reader.GetOrdinal("PassportFileName"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportFileType"))) _passportfiletype = reader.GetString(reader.GetOrdinal("PassportFileType"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportExtension"))) _passportextension = reader.GetString(reader.GetOrdinal("PassportExtension"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("PassportFileID"))) _passportfileid = reader.GetGuid(reader.GetOrdinal("PassportFileID"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                ////if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                //CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
    }
}
