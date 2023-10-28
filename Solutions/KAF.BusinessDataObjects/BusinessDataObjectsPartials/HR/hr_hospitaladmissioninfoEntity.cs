using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_hospitaladmissioninfoEntity : BaseEntity
    {
        #region Properties

        protected long? _militarynokw;
        protected string _militarynobd;
        protected long? _civilid;
        protected string _fullname;
        protected string _passportno;
        protected DateTime? _dateofbirth;
        protected string _pageInfo;


        [DataMember]
        public string pageInfo
        {
            get { return _pageInfo; }
            set { _pageInfo = value; this.OnChnaged(); }
        }

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
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "fullnameRequired")]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; this.OnChnaged(); }
        }


        [DataMember]
        [MaxLength(550)]
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


        public hr_hospitaladmissioninfoEntity(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, isExtension);
        }

        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionID"))) _hospitaladmissionid = reader.GetInt64(reader.GetOrdinal("HospitalAdmissionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _militarynobd = reader.GetString(reader.GetOrdinal("MilNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _passportno = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalName"))) _hospitalname = reader.GetString(reader.GetOrdinal("HospitalName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiseaseName"))) _diseasename = reader.GetString(reader.GetOrdinal("DiseaseName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Description"))) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReleaseNote"))) _releasenote = reader.GetString(reader.GetOrdinal("ReleaseNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalAdmissionDate"))) _hospitaladmissiondate = reader.GetDateTime(reader.GetOrdinal("HospitalAdmissionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("HospitalReleaseDate"))) _hospitalreleasedate = reader.GetDateTime(reader.GetOrdinal("HospitalReleaseDate"));
             
                CurrentState = EntityState.Unchanged;
            }
        }

        #endregion
    }
}
