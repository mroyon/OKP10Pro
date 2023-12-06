using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_familycivilidinfoEntity 
    {
        protected long? _militarynokw;
        protected string _militarynobd;
        protected string _fullname;
        protected long? _civilid;
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
        [Display(Name = "civilid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long? civilid
        {
            get { return _civilid; }
            set { _civilid = value; this.OnChnaged(); }
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
    }
}
