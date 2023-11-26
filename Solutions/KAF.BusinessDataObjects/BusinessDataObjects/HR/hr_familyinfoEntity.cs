using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_familyinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_familyinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _hrfamilyid;
        protected long ? _hrbasicid;
        protected long ? _relationshipid;
        protected long ? _parenthrfamilyid;
        protected long ? _familycivilid;
        protected string _familynationalid;
        protected string _familyname1;
        protected string _familyname2;
        protected string _familyname3;
        protected string _familyname4;
        protected string _familyname5;
        protected string _familyfullname;
        protected long ? _familygenderid;
        protected long ? _familyreligionid;
        protected long ? _familybloodgroupid;
        protected DateTime ? _familybirthdate;
        protected string _familybirthdocno;
        protected DateTime ? _familybirthdocdate;
        protected long ? _familycountryid;
        protected long ? _familynationalityid;
        protected long ? _familymaritalstatusid;
        protected string _familycuraddressflatno;
        protected string _familycuraddresshouseno;
        protected string _familycuraddressstreet;
        protected string _familycuradrressblock;
        protected long ? _familycurcountryid;
        protected long ? _familycurgovnerid;
        protected long ? _familycurareaid;
        protected string _familymobile1;
        protected string _familytelephone1;
        protected string _familyperaddressflatno;
        protected string _familyperaddresshouseno;
        protected string _familyperaddressstreet;
        protected long ? _familyperadrresspo;
        protected long ? _familyperadrressps;
        protected long ? _familyperaddressdist;
        protected long ? _familyperaddresscountryid;
        protected DateTime ? _familymarriagedate;
        protected string _familymarriagedocno;
        protected DateTime ? _familymarriagedocdate;
        protected string _marriagefiledescription;
        protected string _marriagefilepath;
        protected string _marriagefilename;
        protected string _marriagefiletype;
        protected string _marriagefileextension;
        protected long ? _marriageserialno;
        protected DateTime ? _divorcedate;
        protected string _divorcedocno;
        protected DateTime ? _divorcedocdate;
        protected string _divorcefiledescription;
        protected string _divorcefilepath;
        protected string _divorcefilename;
        protected string _divorcefiletype;
        protected string _divorcefileextension;
        protected long ? _fatherstatusid;
        protected bool ? _isservedinmilitary;
        protected long ? _fathermilitarynokw;
        protected string _fathermilitarynobd;
        protected string _workplace;
        protected string _workdesignation;
        protected DateTime ? _familydeathdate;
        protected string _familydeathdocno;
        protected DateTime ? _familydeathdocdate;
        protected string _familydeathfiledescription;
        protected string _familydeathfilepath;
        protected string _familydeathfilename;
        protected string _familydeathfiletype;
        protected string _familydeathfileextension;
        protected DateTime ? _separetiondate;
        protected string _separetionreason;
        protected string _separetiondocno;
        protected DateTime ? _separetiondocdate;
        protected string _remarks;
        protected int ? _forreview;
                
        
        [DataMember]
        public long ? hrfamilyid
        {
            get { return _hrfamilyid; }
            set { _hrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "relationshipid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "relationshipidRequired")]
        public long ? relationshipid
        {
            get { return _relationshipid; }
            set { _relationshipid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "parenthrfamilyid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? parenthrfamilyid
        {
            get { return _parenthrfamilyid; }
            set { _parenthrfamilyid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycivilid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familycivilid
        {
            get { return _familycivilid; }
            set { _familycivilid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "familynationalid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familynationalid
        {
            get { return _familynationalid; }
            set { _familynationalid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyname1", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "familyname1Required")]
        public string familyname1
        {
            get { return _familyname1; }
            set { _familyname1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyname2", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        //[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "familyname2Required")]
        public string familyname2
        {
            get { return _familyname2; }
            set { _familyname2 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyname3", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyname3
        {
            get { return _familyname3; }
            set { _familyname3 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyname4", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyname4
        {
            get { return _familyname4; }
            set { _familyname4 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyname5", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyname5
        {
            get { return _familyname5; }
            set { _familyname5 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "familyfullname", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "familyfullnameRequired")]
        public string familyfullname
        {
            get { return _familyfullname; }
            set { _familyfullname = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familygenderid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_familyinfo), ErrorMessageResourceName = "familygenderidRequired")]
        public long ? familygenderid
        {
            get { return _familygenderid; }
            set { _familygenderid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyreligionid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familyreligionid
        {
            get { return _familyreligionid; }
            set { _familyreligionid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familybloodgroupid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familybloodgroupid
        {
            get { return _familybloodgroupid; }
            set { _familybloodgroupid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familybirthdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familybirthdate
        {
            get { return _familybirthdate; }
            set { _familybirthdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familybirthdocno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familybirthdocno
        {
            get { return _familybirthdocno; }
            set { _familybirthdocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familybirthdocdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familybirthdocdate
        {
            get { return _familybirthdocdate; }
            set { _familybirthdocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycountryid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familycountryid
        {
            get { return _familycountryid; }
            set { _familycountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familynationalityid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familynationalityid
        {
            get { return _familynationalityid; }
            set { _familynationalityid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familymaritalstatusid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familymaritalstatusid
        {
            get { return _familymaritalstatusid; }
            set { _familymaritalstatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familycuraddressflatno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familycuraddressflatno
        {
            get { return _familycuraddressflatno; }
            set { _familycuraddressflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familycuraddresshouseno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familycuraddresshouseno
        {
            get { return _familycuraddresshouseno; }
            set { _familycuraddresshouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familycuraddressstreet", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familycuraddressstreet
        {
            get { return _familycuraddressstreet; }
            set { _familycuraddressstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familycuradrressblock", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familycuradrressblock
        {
            get { return _familycuradrressblock; }
            set { _familycuradrressblock = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycurcountryid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familycurcountryid
        {
            get { return _familycurcountryid; }
            set { _familycurcountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycurgovnerid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familycurgovnerid
        {
            get { return _familycurgovnerid; }
            set { _familycurgovnerid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familycurareaid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familycurareaid
        {
            get { return _familycurareaid; }
            set { _familycurareaid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(15)]
        [Display(Name = "familymobile1", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familymobile1
        {
            get { return _familymobile1; }
            set { _familymobile1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familytelephone1", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familytelephone1
        {
            get { return _familytelephone1; }
            set { _familytelephone1 = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familyperaddressflatno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyperaddressflatno
        {
            get { return _familyperaddressflatno; }
            set { _familyperaddressflatno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familyperaddresshouseno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyperaddresshouseno
        {
            get { return _familyperaddresshouseno; }
            set { _familyperaddresshouseno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "familyperaddressstreet", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familyperaddressstreet
        {
            get { return _familyperaddressstreet; }
            set { _familyperaddressstreet = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyperadrresspo", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familyperadrresspo
        {
            get { return _familyperadrresspo; }
            set { _familyperadrresspo = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyperadrressps", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familyperadrressps
        {
            get { return _familyperadrressps; }
            set { _familyperadrressps = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyperaddressdist", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familyperaddressdist
        {
            get { return _familyperaddressdist; }
            set { _familyperaddressdist = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familyperaddresscountryid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? familyperaddresscountryid
        {
            get { return _familyperaddresscountryid; }
            set { _familyperaddresscountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familymarriagedate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familymarriagedate
        {
            get { return _familymarriagedate; }
            set { _familymarriagedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familymarriagedocno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familymarriagedocno
        {
            get { return _familymarriagedocno; }
            set { _familymarriagedocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familymarriagedocdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familymarriagedocdate
        {
            get { return _familymarriagedocdate; }
            set { _familymarriagedocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "marriagefiledescription", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string marriagefiledescription
        {
            get { return _marriagefiledescription; }
            set { _marriagefiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "marriagefilepath", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string marriagefilepath
        {
            get { return _marriagefilepath; }
            set { _marriagefilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "marriagefilename", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string marriagefilename
        {
            get { return _marriagefilename; }
            set { _marriagefilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "marriagefiletype", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string marriagefiletype
        {
            get { return _marriagefiletype; }
            set { _marriagefiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "marriagefileextension", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string marriagefileextension
        {
            get { return _marriagefileextension; }
            set { _marriagefileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "marriageserialno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? marriageserialno
        {
            get { return _marriageserialno; }
            set { _marriageserialno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "divorcedate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? divorcedate
        {
            get { return _divorcedate; }
            set { _divorcedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "divorcedocno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcedocno
        {
            get { return _divorcedocno; }
            set { _divorcedocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "divorcedocdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? divorcedocdate
        {
            get { return _divorcedocdate; }
            set { _divorcedocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "divorcefiledescription", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcefiledescription
        {
            get { return _divorcefiledescription; }
            set { _divorcefiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "divorcefilepath", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcefilepath
        {
            get { return _divorcefilepath; }
            set { _divorcefilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "divorcefilename", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcefilename
        {
            get { return _divorcefilename; }
            set { _divorcefilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "divorcefiletype", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcefiletype
        {
            get { return _divorcefiletype; }
            set { _divorcefiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "divorcefileextension", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string divorcefileextension
        {
            get { return _divorcefileextension; }
            set { _divorcefileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fatherstatusid", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? fatherstatusid
        {
            get { return _fatherstatusid; }
            set { _fatherstatusid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isservedinmilitary", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public bool ? isservedinmilitary
        {
            get { return _isservedinmilitary; }
            set { _isservedinmilitary = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "fathermilitarynokw", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public long ? fathermilitarynokw
        {
            get { return _fathermilitarynokw; }
            set { _fathermilitarynokw = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(10)]
        [Display(Name = "fathermilitarynobd", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string fathermilitarynobd
        {
            get { return _fathermilitarynobd; }
            set { _fathermilitarynobd = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "workplace", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string workplace
        {
            get { return _workplace; }
            set { _workplace = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(150)]
        [Display(Name = "workdesignation", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string workdesignation
        {
            get { return _workdesignation; }
            set { _workdesignation = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familydeathdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familydeathdate
        {
            get { return _familydeathdate; }
            set { _familydeathdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "familydeathdocno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathdocno
        {
            get { return _familydeathdocno; }
            set { _familydeathdocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "familydeathdocdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? familydeathdocdate
        {
            get { return _familydeathdocdate; }
            set { _familydeathdocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "familydeathfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathfiledescription
        {
            get { return _familydeathfiledescription; }
            set { _familydeathfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familydeathfilepath", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathfilepath
        {
            get { return _familydeathfilepath; }
            set { _familydeathfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familydeathfilename", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathfilename
        {
            get { return _familydeathfilename; }
            set { _familydeathfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familydeathfiletype", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathfiletype
        {
            get { return _familydeathfiletype; }
            set { _familydeathfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "familydeathfileextension", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string familydeathfileextension
        {
            get { return _familydeathfileextension; }
            set { _familydeathfileextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "separetiondate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? separetiondate
        {
            get { return _separetiondate; }
            set { _separetiondate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(350)]
        [Display(Name = "separetionreason", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string separetionreason
        {
            get { return _separetionreason; }
            set { _separetionreason = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(50)]
        [Display(Name = "separetiondocno", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string separetiondocno
        {
            get { return _separetiondocno; }
            set { _separetiondocno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "separetiondocdate", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public DateTime ? separetiondocdate
        {
            get { return _separetiondocdate; }
            set { _separetiondocdate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_familyinfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_familyinfoEntity():base()
        {
        }
        
        public hr_familyinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_familyinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentHrFamilyID"))) _parenthrfamilyid = reader.GetInt64(reader.GetOrdinal("ParentHrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilID"))) _familycivilid = reader.GetInt64(reader.GetOrdinal("FamilyCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyNationalID"))) _familynationalid = reader.GetString(reader.GetOrdinal("FamilyNationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName1"))) _familyname1 = reader.GetString(reader.GetOrdinal("FamilyName1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName2"))) _familyname2 = reader.GetString(reader.GetOrdinal("FamilyName2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName3"))) _familyname3 = reader.GetString(reader.GetOrdinal("FamilyName3"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName4"))) _familyname4 = reader.GetString(reader.GetOrdinal("FamilyName4"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName5"))) _familyname5 = reader.GetString(reader.GetOrdinal("FamilyName5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyFullName"))) _familyfullname = reader.GetString(reader.GetOrdinal("FamilyFullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyGenderID"))) _familygenderid = reader.GetInt64(reader.GetOrdinal("FamilyGenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyReligionID"))) _familyreligionid = reader.GetInt64(reader.GetOrdinal("FamilyReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBloodGroupID"))) _familybloodgroupid = reader.GetInt64(reader.GetOrdinal("FamilyBloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDate"))) _familybirthdate = reader.GetDateTime(reader.GetOrdinal("FamilyBirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDocNo"))) _familybirthdocno = reader.GetString(reader.GetOrdinal("FamilyBirthDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDocDate"))) _familybirthdocdate = reader.GetDateTime(reader.GetOrdinal("FamilyBirthDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCountryID"))) _familycountryid = reader.GetInt64(reader.GetOrdinal("FamilyCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyNationalityID"))) _familynationalityid = reader.GetInt64(reader.GetOrdinal("FamilyNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMaritalStatusID"))) _familymaritalstatusid = reader.GetInt64(reader.GetOrdinal("FamilyMaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressFlatNo"))) _familycuraddressflatno = reader.GetString(reader.GetOrdinal("FamilyCurAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressHouseNo"))) _familycuraddresshouseno = reader.GetString(reader.GetOrdinal("FamilyCurAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressStreet"))) _familycuraddressstreet = reader.GetString(reader.GetOrdinal("FamilyCurAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAdrressBlock"))) _familycuradrressblock = reader.GetString(reader.GetOrdinal("FamilyCurAdrressBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurCountryID"))) _familycurcountryid = reader.GetInt64(reader.GetOrdinal("FamilyCurCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurGovnerID"))) _familycurgovnerid = reader.GetInt64(reader.GetOrdinal("FamilyCurGovnerID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAreaID"))) _familycurareaid = reader.GetInt64(reader.GetOrdinal("FamilyCurAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMobile1"))) _familymobile1 = reader.GetString(reader.GetOrdinal("FamilyMobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyTelephone1"))) _familytelephone1 = reader.GetString(reader.GetOrdinal("FamilyTelephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressFlatNo"))) _familyperaddressflatno = reader.GetString(reader.GetOrdinal("FamilyPerAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressHouseNo"))) _familyperaddresshouseno = reader.GetString(reader.GetOrdinal("FamilyPerAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressStreet"))) _familyperaddressstreet = reader.GetString(reader.GetOrdinal("FamilyPerAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAdrressPO"))) _familyperadrresspo = reader.GetInt64(reader.GetOrdinal("FamilyPerAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAdrressPS"))) _familyperadrressps = reader.GetInt64(reader.GetOrdinal("FamilyPerAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressDist"))) _familyperaddressdist = reader.GetInt64(reader.GetOrdinal("FamilyPerAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressCountryID"))) _familyperaddresscountryid = reader.GetInt64(reader.GetOrdinal("FamilyPerAddressCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDate"))) _familymarriagedate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocNo"))) _familymarriagedocno = reader.GetString(reader.GetOrdinal("FamilyMarriageDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocDate"))) _familymarriagedocdate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileDescription"))) _marriagefiledescription = reader.GetString(reader.GetOrdinal("MarriageFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFilePath"))) _marriagefilepath = reader.GetString(reader.GetOrdinal("MarriageFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileName"))) _marriagefilename = reader.GetString(reader.GetOrdinal("MarriageFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileType"))) _marriagefiletype = reader.GetString(reader.GetOrdinal("MarriageFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileExtension"))) _marriagefileextension = reader.GetString(reader.GetOrdinal("MarriageFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageSerialNo"))) _marriageserialno = reader.GetInt64(reader.GetOrdinal("MarriageSerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDate"))) _divorcedate = reader.GetDateTime(reader.GetOrdinal("DivorceDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDocNo"))) _divorcedocno = reader.GetString(reader.GetOrdinal("DivorceDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDocDate"))) _divorcedocdate = reader.GetDateTime(reader.GetOrdinal("DivorceDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileDescription"))) _divorcefiledescription = reader.GetString(reader.GetOrdinal("DivorceFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFilePath"))) _divorcefilepath = reader.GetString(reader.GetOrdinal("DivorceFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileName"))) _divorcefilename = reader.GetString(reader.GetOrdinal("DivorceFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileType"))) _divorcefiletype = reader.GetString(reader.GetOrdinal("DivorceFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileExtension"))) _divorcefileextension = reader.GetString(reader.GetOrdinal("DivorceFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherStatusID"))) _fatherstatusid = reader.GetInt64(reader.GetOrdinal("FatherStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServedInMilitary"))) _isservedinmilitary = reader.GetBoolean(reader.GetOrdinal("IsServedInMilitary"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherMilitaryNoKW"))) _fathermilitarynokw = reader.GetInt64(reader.GetOrdinal("FatherMilitaryNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherMilitaryNoBD"))) _fathermilitarynobd = reader.GetString(reader.GetOrdinal("FatherMilitaryNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlace"))) _workplace = reader.GetString(reader.GetOrdinal("WorkPlace"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkDesignation"))) _workdesignation = reader.GetString(reader.GetOrdinal("WorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDate"))) _familydeathdate = reader.GetDateTime(reader.GetOrdinal("FamilyDeathDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDocNo"))) _familydeathdocno = reader.GetString(reader.GetOrdinal("FamilyDeathDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDocDate"))) _familydeathdocdate = reader.GetDateTime(reader.GetOrdinal("FamilyDeathDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileDescription"))) _familydeathfiledescription = reader.GetString(reader.GetOrdinal("FamilyDeathFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFilePath"))) _familydeathfilepath = reader.GetString(reader.GetOrdinal("FamilyDeathFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileName"))) _familydeathfilename = reader.GetString(reader.GetOrdinal("FamilyDeathFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileType"))) _familydeathfiletype = reader.GetString(reader.GetOrdinal("FamilyDeathFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileExtension"))) _familydeathfileextension = reader.GetString(reader.GetOrdinal("FamilyDeathFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDate"))) _separetiondate = reader.GetDateTime(reader.GetOrdinal("SeparetionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionReason"))) _separetionreason = reader.GetString(reader.GetOrdinal("SeparetionReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDocNo"))) _separetiondocno = reader.GetString(reader.GetOrdinal("SeparetionDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDocDate"))) _separetiondocdate = reader.GetDateTime(reader.GetOrdinal("SeparetionDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("HrFamilyID"))) _hrfamilyid = reader.GetInt64(reader.GetOrdinal("HrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RelationshipID"))) _relationshipid = reader.GetInt64(reader.GetOrdinal("RelationshipID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ParentHrFamilyID"))) _parenthrfamilyid = reader.GetInt64(reader.GetOrdinal("ParentHrFamilyID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCivilID"))) _familycivilid = reader.GetInt64(reader.GetOrdinal("FamilyCivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyNationalID"))) _familynationalid = reader.GetString(reader.GetOrdinal("FamilyNationalID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName1"))) _familyname1 = reader.GetString(reader.GetOrdinal("FamilyName1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName2"))) _familyname2 = reader.GetString(reader.GetOrdinal("FamilyName2"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName3"))) _familyname3 = reader.GetString(reader.GetOrdinal("FamilyName3"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName4"))) _familyname4 = reader.GetString(reader.GetOrdinal("FamilyName4"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyName5"))) _familyname5 = reader.GetString(reader.GetOrdinal("FamilyName5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyFullName"))) _familyfullname = reader.GetString(reader.GetOrdinal("FamilyFullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyGenderID"))) _familygenderid = reader.GetInt64(reader.GetOrdinal("FamilyGenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyReligionID"))) _familyreligionid = reader.GetInt64(reader.GetOrdinal("FamilyReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBloodGroupID"))) _familybloodgroupid = reader.GetInt64(reader.GetOrdinal("FamilyBloodGroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDate"))) _familybirthdate = reader.GetDateTime(reader.GetOrdinal("FamilyBirthDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDocNo"))) _familybirthdocno = reader.GetString(reader.GetOrdinal("FamilyBirthDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyBirthDocDate"))) _familybirthdocdate = reader.GetDateTime(reader.GetOrdinal("FamilyBirthDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCountryID"))) _familycountryid = reader.GetInt64(reader.GetOrdinal("FamilyCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyNationalityID"))) _familynationalityid = reader.GetInt64(reader.GetOrdinal("FamilyNationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMaritalStatusID"))) _familymaritalstatusid = reader.GetInt64(reader.GetOrdinal("FamilyMaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressFlatNo"))) _familycuraddressflatno = reader.GetString(reader.GetOrdinal("FamilyCurAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressHouseNo"))) _familycuraddresshouseno = reader.GetString(reader.GetOrdinal("FamilyCurAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAddressStreet"))) _familycuraddressstreet = reader.GetString(reader.GetOrdinal("FamilyCurAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAdrressBlock"))) _familycuradrressblock = reader.GetString(reader.GetOrdinal("FamilyCurAdrressBlock"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurCountryID"))) _familycurcountryid = reader.GetInt64(reader.GetOrdinal("FamilyCurCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurGovnerID"))) _familycurgovnerid = reader.GetInt64(reader.GetOrdinal("FamilyCurGovnerID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyCurAreaID"))) _familycurareaid = reader.GetInt64(reader.GetOrdinal("FamilyCurAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMobile1"))) _familymobile1 = reader.GetString(reader.GetOrdinal("FamilyMobile1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyTelephone1"))) _familytelephone1 = reader.GetString(reader.GetOrdinal("FamilyTelephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressFlatNo"))) _familyperaddressflatno = reader.GetString(reader.GetOrdinal("FamilyPerAddressFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressHouseNo"))) _familyperaddresshouseno = reader.GetString(reader.GetOrdinal("FamilyPerAddressHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressStreet"))) _familyperaddressstreet = reader.GetString(reader.GetOrdinal("FamilyPerAddressStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAdrressPO"))) _familyperadrresspo = reader.GetInt64(reader.GetOrdinal("FamilyPerAdrressPO"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAdrressPS"))) _familyperadrressps = reader.GetInt64(reader.GetOrdinal("FamilyPerAdrressPS"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressDist"))) _familyperaddressdist = reader.GetInt64(reader.GetOrdinal("FamilyPerAddressDist"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyPerAddressCountryID"))) _familyperaddresscountryid = reader.GetInt64(reader.GetOrdinal("FamilyPerAddressCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDate"))) _familymarriagedate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocNo"))) _familymarriagedocno = reader.GetString(reader.GetOrdinal("FamilyMarriageDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyMarriageDocDate"))) _familymarriagedocdate = reader.GetDateTime(reader.GetOrdinal("FamilyMarriageDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileDescription"))) _marriagefiledescription = reader.GetString(reader.GetOrdinal("MarriageFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFilePath"))) _marriagefilepath = reader.GetString(reader.GetOrdinal("MarriageFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileName"))) _marriagefilename = reader.GetString(reader.GetOrdinal("MarriageFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileType"))) _marriagefiletype = reader.GetString(reader.GetOrdinal("MarriageFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageFileExtension"))) _marriagefileextension = reader.GetString(reader.GetOrdinal("MarriageFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("MarriageSerialNo"))) _marriageserialno = reader.GetInt64(reader.GetOrdinal("MarriageSerialNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDate"))) _divorcedate = reader.GetDateTime(reader.GetOrdinal("DivorceDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDocNo"))) _divorcedocno = reader.GetString(reader.GetOrdinal("DivorceDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceDocDate"))) _divorcedocdate = reader.GetDateTime(reader.GetOrdinal("DivorceDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileDescription"))) _divorcefiledescription = reader.GetString(reader.GetOrdinal("DivorceFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFilePath"))) _divorcefilepath = reader.GetString(reader.GetOrdinal("DivorceFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileName"))) _divorcefilename = reader.GetString(reader.GetOrdinal("DivorceFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileType"))) _divorcefiletype = reader.GetString(reader.GetOrdinal("DivorceFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("DivorceFileExtension"))) _divorcefileextension = reader.GetString(reader.GetOrdinal("DivorceFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherStatusID"))) _fatherstatusid = reader.GetInt64(reader.GetOrdinal("FatherStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsServedInMilitary"))) _isservedinmilitary = reader.GetBoolean(reader.GetOrdinal("IsServedInMilitary"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherMilitaryNoKW"))) _fathermilitarynokw = reader.GetInt64(reader.GetOrdinal("FatherMilitaryNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("FatherMilitaryNoBD"))) _fathermilitarynobd = reader.GetString(reader.GetOrdinal("FatherMilitaryNoBD"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkPlace"))) _workplace = reader.GetString(reader.GetOrdinal("WorkPlace"));
                if (!reader.IsDBNull(reader.GetOrdinal("WorkDesignation"))) _workdesignation = reader.GetString(reader.GetOrdinal("WorkDesignation"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDate"))) _familydeathdate = reader.GetDateTime(reader.GetOrdinal("FamilyDeathDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDocNo"))) _familydeathdocno = reader.GetString(reader.GetOrdinal("FamilyDeathDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathDocDate"))) _familydeathdocdate = reader.GetDateTime(reader.GetOrdinal("FamilyDeathDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileDescription"))) _familydeathfiledescription = reader.GetString(reader.GetOrdinal("FamilyDeathFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFilePath"))) _familydeathfilepath = reader.GetString(reader.GetOrdinal("FamilyDeathFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileName"))) _familydeathfilename = reader.GetString(reader.GetOrdinal("FamilyDeathFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileType"))) _familydeathfiletype = reader.GetString(reader.GetOrdinal("FamilyDeathFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("FamilyDeathFileExtension"))) _familydeathfileextension = reader.GetString(reader.GetOrdinal("FamilyDeathFileExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDate"))) _separetiondate = reader.GetDateTime(reader.GetOrdinal("SeparetionDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionReason"))) _separetionreason = reader.GetString(reader.GetOrdinal("SeparetionReason"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDocNo"))) _separetiondocno = reader.GetString(reader.GetOrdinal("SeparetionDocNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("SeparetionDocDate"))) _separetiondocdate = reader.GetDateTime(reader.GetOrdinal("SeparetionDocDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
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
