using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "KAF_VolunteerMedicalEntity", Namespace = "http://www.KAF.com/types")]
    public class KAF_VolunteerMedicalEntity : BaseEntity
    {
        protected string _fullname;
        protected long? _hrbasicid;
        protected long? _volunteerid;
        protected Guid? _userid;
        protected long? _civilid;
        protected string _reqno;
        protected DateTime? _reqdate;
        protected DateTime? _interviewdate;
        protected long? _batchno;
        protected long? _volunteermedicalid;
        protected string _medicaldocno;
        protected DateTime? _medicaldocdate;
        protected long? _medicalresultid;
        protected string _medicalresultdocno;
        protected DateTime? _medicalresultdocdate;
        protected long? _psychologicaldocno;
        protected DateTime? _psychologicaldocdate;
        protected long? _psychologicalresultid;
        protected string _psychologicalresultdocno;
        protected DateTime? _psychologicalresultdocdate;
        protected long? _securitydocno;
        protected DateTime? _securitydocdate;
        protected long? _securityresultid;
        protected string _securityresultdocno;
        protected DateTime? _securityresultdocdate;
        protected long? _finalresultid;
        protected string _medicalnote;
        protected string _psychologicalnote;
        protected string _securitynote;
        protected long? _medicalresultby;
        protected DateTime? _medicalresultdate;
        protected long? _medicalresultsentby;
        protected DateTime? _medicalresultsentdate;
        protected long? _psychologicalresultby;
        protected DateTime? _psychologicalresultdate;
        protected long? _psychologicalresultsentby;
        protected DateTime? _psychologicalresultsentdate;
        protected long? _securityresultby;
        protected DateTime? _securityresultdate;
        protected long? _securityresultsentby;
        protected DateTime? _securityresultsentdate;

        public KAF_VolunteerMedicalEntity()
        {
        }

        public KAF_VolunteerMedicalEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) _batchno = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReqNo"))) _reqno = reader.GetString(reader.GetOrdinal("ReqNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReqDate"))) _reqdate = reader.GetDateTime(reader.GetOrdinal("ReqDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("InterviewDate"))) _interviewdate = reader.GetDateTime(reader.GetOrdinal("InterviewDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerID"))) _volunteerid = reader.GetInt64(reader.GetOrdinal("VolunteerID"));
                if (!reader.IsDBNull(reader.GetOrdinal("VolunteerMedicalID"))) _volunteermedicalid = reader.GetInt64(reader.GetOrdinal("VolunteerMedicalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalDocNo"))) _medicaldocno = reader.GetString(reader.GetOrdinal("MedicalDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalDocDate"))) _medicaldocdate = reader.GetDateTime(reader.GetOrdinal("MedicalDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultID"))) _medicalresultid = reader.GetInt64(reader.GetOrdinal("MedicalResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultDocNo"))) _medicalresultdocno = reader.GetString(reader.GetOrdinal("MedicalResultDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultDocDate"))) _medicalresultdocdate = reader.GetDateTime(reader.GetOrdinal("MedicalResultDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalDocNo"))) _psychologicaldocno = reader.GetInt64(reader.GetOrdinal("PsychologicalDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalDocDate"))) _psychologicaldocdate = reader.GetDateTime(reader.GetOrdinal("PsychologicalDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultID"))) _psychologicalresultid = reader.GetInt64(reader.GetOrdinal("PsychologicalResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultDocNo"))) _psychologicalresultdocno = reader.GetString(reader.GetOrdinal("PsychologicalResultDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultDocDate"))) _psychologicalresultdocdate = reader.GetDateTime(reader.GetOrdinal("PsychologicalResultDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityDocNo"))) _securitydocno = reader.GetInt64(reader.GetOrdinal("SecurityDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityDocDate"))) _securitydocdate = reader.GetDateTime(reader.GetOrdinal("SecurityDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultID"))) _securityresultid = reader.GetInt64(reader.GetOrdinal("SecurityResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultDocNo"))) _securityresultdocno = reader.GetString(reader.GetOrdinal("SecurityResultDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultDocDate"))) _securityresultdocdate = reader.GetDateTime(reader.GetOrdinal("SecurityResultDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinalResultID"))) _finalresultid = reader.GetInt64(reader.GetOrdinal("FinalResultID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalNote"))) _medicalnote = reader.GetString(reader.GetOrdinal("MedicalNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalNote"))) _psychologicalnote = reader.GetString(reader.GetOrdinal("PsychologicalNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityNote"))) _securitynote = reader.GetString(reader.GetOrdinal("SecurityNote"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultBy"))) _medicalresultby = reader.GetInt64(reader.GetOrdinal("MedicalResultBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultDate"))) _medicalresultdate = reader.GetDateTime(reader.GetOrdinal("MedicalResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultSentBy"))) _medicalresultsentby = reader.GetInt64(reader.GetOrdinal("MedicalResultSentBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalResultSentDate"))) _medicalresultsentdate = reader.GetDateTime(reader.GetOrdinal("MedicalResultSentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultBy"))) _psychologicalresultby = reader.GetInt64(reader.GetOrdinal("PsychologicalResultBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultDate"))) _psychologicalresultdate = reader.GetDateTime(reader.GetOrdinal("PsychologicalResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultSentBy"))) _psychologicalresultsentby = reader.GetInt64(reader.GetOrdinal("PsychologicalResultSentBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("PsychologicalResultSentDate"))) _psychologicalresultsentdate = reader.GetDateTime(reader.GetOrdinal("PsychologicalResultSentDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultBy"))) _securityresultby = reader.GetInt64(reader.GetOrdinal("SecurityResultBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultDate"))) _securityresultdate = reader.GetDateTime(reader.GetOrdinal("SecurityResultDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultSentBy"))) _securityresultsentby = reader.GetInt64(reader.GetOrdinal("SecurityResultSentBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityResultSentDate"))) _securityresultsentdate = reader.GetDateTime(reader.GetOrdinal("SecurityResultSentDate"));
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

        #region Public Properties
        [DataMember]
        public long? volunteermedicalid
        {
            get { return _volunteermedicalid; }
            set { _volunteermedicalid = value; this.OnChnaged(); }
        }
        [DataMember]
        public DateTime? securityresultdate
        {
            get { return _securityresultdate; }
            set { _securityresultdate = value; this.OnChnaged(); }
        }
        [DataMember]
        public string securityresultdocno
        {
            get { return _securityresultdocno; }
            set { _securityresultdocno = value; this.OnChnaged(); }
        }
        [DataMember]
        public DateTime? psychologicalresultdate
        {
            get { return _psychologicalresultdate; }
            set { _psychologicalresultdate = value; this.OnChnaged(); }
        }
        [DataMember]
        public string psychologicalresultdocno
        {
            get { return _psychologicalresultdocno; }
            set { _psychologicalresultdocno = value; this.OnChnaged(); }
        }
        [DataMember]
        public DateTime? medicalresultdate
        {
            get { return _medicalresultdate; }
            set { _medicalresultdate = value; this.OnChnaged(); }
        }

        [DataMember]
        public string medicalresultdocno
        {
            get { return _medicalresultdocno; }
            set { _medicalresultdocno = value; this.OnChnaged(); }
        }
        [DataMember]
        public long? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; }
        }

        [DataMember]
        public long? batchno
        {
            get { return _batchno; }
            set { _batchno = value; }
        }

        [DataMember]
        public Guid? userid
        {
            get { return _userid; }
            set { _userid = value; }
        }


        [DataMember]
        public long? civilid
        {
            get { return _civilid; }
            set { _civilid = value; }
        }
        [DataMember]
        public string reqno
        {
            get { return _reqno; }
            set { _reqno = value; }
        }


        [DataMember]
        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        [DataMember]
        public DateTime? reqdate
        {
            get { return _reqdate; }
            set { _reqdate = value; }
        }
        [DataMember]
        public DateTime? interviewdate
        {
            get { return _interviewdate; }
            set { _interviewdate = value; }
        }
        [DataMember]
        public long? volunteerid
        {
            get { return _volunteerid; }
            set { _volunteerid = value; }
        }
        [DataMember]
        public string medicaldocno
        {
            get { return _medicaldocno; }
            set { _medicaldocno = value;  }
        }

        [DataMember]
        public DateTime? medicaldocdate
        {
            get { return _medicaldocdate; }
            set { _medicaldocdate = value; }
        }

       

        [DataMember]
        public long? medicalresultid
        {
            get { return _medicalresultid; }
            set { _medicalresultid = value; this.OnChnaged(); }
        }

       

        [DataMember]
        public DateTime? medicalresultdocdate
        {
            get { return _medicalresultdocdate; }
            set { _medicalresultdocdate = value; this.OnChnaged(); }
        }

        

        [DataMember]
        public long? psychologicaldocno
        {
            get { return _psychologicaldocno; }
            set { _psychologicaldocno = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? psychologicaldocdate
        {
            get { return _psychologicaldocdate; }
            set { _psychologicaldocdate = value; this.OnChnaged(); }
        }
        

        [DataMember]
        public long? psychologicalresultid
        {
            get { return _psychologicalresultid; }
            set { _psychologicalresultid = value; this.OnChnaged(); }
        }


        [DataMember]
        public DateTime? psychologicalresultdocdate
        {
            get { return _psychologicalresultdocdate; }
            set { _psychologicalresultdocdate = value; this.OnChnaged(); }
        }
        

        [DataMember]
        public long? securitydocno
        {
            get { return _securitydocno; }
            set { _securitydocno = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? securitydocdate
        {
            get { return _securitydocdate; }
            set { _securitydocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        public long? securityresultid
        {
            get { return _securityresultid; }
            set { _securityresultid = value; this.OnChnaged(); }
        }

        

        [DataMember]
        public DateTime? securityresultdocdate
        {
            get { return _securityresultdocdate; }
            set { _securityresultdocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        public long? finalresultid
        {
            get { return _finalresultid; }
            set { _finalresultid = value; this.OnChnaged(); }
        }

        [DataMember]
        public string medicalnote
        {
            get { return _medicalnote; }
            set { _medicalnote = value; this.OnChnaged(); }
        }

        [DataMember]
        public string psychologicalnote
        {
            get { return _psychologicalnote; }
            set { _psychologicalnote = value; this.OnChnaged(); }
        }

        [DataMember]
        public string securitynote
        {
            get { return _securitynote; }
            set { _securitynote = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? medicalresultby
        {
            get { return _medicalresultby; }
            set { _medicalresultby = value; this.OnChnaged(); }
        }

        

        [DataMember]
        public long? medicalresultsentby
        {
            get { return _medicalresultsentby; }
            set { _medicalresultsentby = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? medicalresultsentdate
        {
            get { return _medicalresultsentdate; }
            set { _medicalresultsentdate = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? psychologicalresultby
        {
            get { return _psychologicalresultby; }
            set { _psychologicalresultby = value; this.OnChnaged(); }
        }


        [DataMember]
        public long? psychologicalresultsentby
        {
            get { return _psychologicalresultsentby; }
            set { _psychologicalresultsentby = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? psychologicalresultsentdate
        {
            get { return _psychologicalresultsentdate; }
            set { _psychologicalresultsentdate = value; this.OnChnaged(); }
        }

        [DataMember]
        public long? securityresultby
        {
            get { return _securityresultby; }
            set { _securityresultby = value; this.OnChnaged(); }
        }

       

        [DataMember]
        public long? securityresultsentby
        {
            get { return _securityresultsentby; }
            set { _securityresultsentby = value; this.OnChnaged(); }
        }

        [DataMember]
        public DateTime? securityresultsentdate
        {
            get { return _securityresultsentdate; }
            set { _securityresultsentdate = value; this.OnChnaged(); }
        }
        #endregion
    }
}
