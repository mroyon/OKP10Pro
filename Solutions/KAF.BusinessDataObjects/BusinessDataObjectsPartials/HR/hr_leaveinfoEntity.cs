using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_leaveinfoEntity : BaseEntity
    {
        #region Properties

        protected long? _militarynokw;
        protected string _militarynobd;
        protected long? _civilid;
        protected string _fullname;
        protected string _passportno;
        protected DateTime? _dateofbirth;
        public long? isExt { get; set; }
        public long? modificationtype { get; set; }
        public hr_leavemodificationEntity objModifiedLeave { get; set; }



        [DataMember]
        public long ? militarynokw
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


        public hr_leaveinfoEntity(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, isExtension);
        }
        
        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
             
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _militarynobd = reader.GetString(reader.GetOrdinal("MilNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
               
            }
        }
        
        #endregion
    }
}
