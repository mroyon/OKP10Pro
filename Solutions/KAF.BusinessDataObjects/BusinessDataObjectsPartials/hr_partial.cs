using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.Collections.Generic;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Web;

namespace KAF.BusinessDataObjects
{

    public partial class hr_basicprofileEntity
    {
        public bool isSearch { get; set; }

        public owin_userEntity owin_userEntity { get; set; }

        public hr_militarysvcinfoEntity hr_militarysvcinfoEntity { get; set; }

        public hr_civilsvcinfoEntity hr_civilsvcinfoEntity { get; set; }
        public hr_recruitmentsvcinfoEntity hr_recruitmentsvcinfoEntity { get; set; }
        public hr_volunteersvcinfoEntity hr_volunteersvcinfoEntity { get; set; }

        public hr_volunteermedicalEntity hr_volunteermedicalEntity { get; set; }

        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }


        public hr_passportinfoEntity hr_passportinfoEntity { get; set; }


        public cor_folderstructureEntity hr_folderobj { get; set; }



        //public GetMilShortInfoByBasicMilEntity hr_objShortProfile { get; set; }

        //public GetCivilShortInfoByBasicCivEntity hr_objShortProfileCivil { get; set; }

        //public GetRecruitmenthortInfoByBasicRecEntity hr_objShortProfileRec { get; set; }

        //public GetVolunteerShortInfoByBasicVolEntity hr_objShortProfileVol { get; set; }


    }



    public partial class hr_familyinfoEntity
    {
        public string strgender { get; set; }

        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public hr_familypassportinfoEntity hr_familypassportinfo { get; set; }
        public hr_familycivilidinfoEntity hr_familycivilidinfo { get; set; }
        public hr_familyresidentvisaEntity hr_familyresidentvisa { get; set; }
    }



    public partial class hr_eduqualificationEntity
    {
        public string strCertificate { get; set; }
        public string strCertificateProf { get; set; }
        public string strCountry { get; set; }

        public string strInstitute { get; set; }
        public string strGrade { get; set; }


        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_residentvisaEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }


        protected long? _militarynokw;
        protected string _militarynobd;
        protected long? _civilid;
        protected string _fullname;


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
        //[Display(Name = "militaryno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public string militarynobd
        {
            get { return _militarynobd; }
            set { _militarynobd = value; this.OnChnaged(); }
        }

    }
    public partial class hr_militarycoursesEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryescapeEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarymedicalinfoEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryreserviceEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }

        public hr_militaryretirementEntity hr_militaryretirementEntity { get; set; }
    }
    public partial class hr_militarytrailEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryvacationEntity
    {

        public string strgender { get; set; }
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }


    public partial class hr_civilacrEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilcontractEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilrecontractEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilcoursesEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilendsrvcinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilexpcertificateEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civiljobpenaltiesEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilmovementEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilprevjobsEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class KAF_ReserveInfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_civilpromotionEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilsvcinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civiltrialsEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilvacationEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilvacationmodificationEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_civilvacationdeductEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_emergencycontactEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_languageproficiencyEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryacrEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_militarycoursestopsEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_militaryidcardEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarymedalEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_militarymovementEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarypromotionEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarypunishmentEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryrecommendationEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryrenewEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_militaryreservicecancelEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public hr_militaryreserviceEntity hr_militaryreserviceEntity { get; set; }
    }
    public partial class hr_militaryretirementEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryretirementcancelEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarysecurityEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarysvcinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }


    public partial class hr_militaryvacationbalanceextraEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryvacationdeductEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militaryvacationmodificationEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_passportinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public HttpPostedFileBase file1 { get; set; }
        public HttpPostedFileBase file2 { get; set; }

    }
    public partial class hr_relativesworkinginmodEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_passportreceivedispatchEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_recruitmentbatchEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_recruitmentbatchdetlEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_recruitmentdelayEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_recruitmentmedicalEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_recruitmentsvcinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_volunteermedicalEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_volunteernomineeinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_volunteersvcinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class hr_militarysvcbenifitsEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class KAF_VolunteerMovementOrderEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }
    public partial class stp_organizationentityEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_replacementinfoEntity
    {
        public List<hr_replacementinfodetlEntity> hr_replacementList { get; set; }

        public string totalperson { get; set; }
    }
    public partial class hr_flightinfoEntity
    {
        public List<hr_flightinfodetlEntity> hr_flightList { get; set; }

        public string totalperson { get; set; }

        public string strdemandtype { get; set; }

        public bool? iscancel { get; set; }


        public bool? reissued { get; set; }
    }

    public partial class hr_flightinfodetlEntity
    {
        public bool? iscancelremove { get; set; }
    }
    public partial class hr_reppassportinfoEntity
    {
        public List<hr_reppassportinfodetlEntity> hr_passportList { get; set; }

        public string totalperson { get; set; }

    }

    public partial class hr_visademandinfoEntity
    {
        public List<hr_visademandinfodetlEntity> hr_visademandList { get; set; }

        public string totalperson { get; set; }

        public string strdemandtype { get; set; }

    }


    public partial class hr_visaissueinfoEntity
    {
        public List<hr_visaissueinfodetlEntity> hr_visaissueList { get; set; }

        public string totalperson { get; set; }

        public string strdemandtype { get; set; }

    }

    public partial class hr_ptademandEntity
    {
        public List<hr_ptademanddetlEntity> hr_ptademandList { get; set; }

        public string totalperson { get; set; }

        public string strdemandtype { get; set; }

    }

    public partial class hr_ptareceivedEntity
    {
        public List<hr_ptareceiveddetlEntity> hr_ptareceivedList { get; set; }

        public string totalperson { get; set; }

        public string strdemandtype { get; set; }

    }

    public partial class hr_arrivalinfoEntity
    {
        public List<hr_arrivalinfodetlEntity> hr_arrivalList { get; set; }

        public string strdemandtype { get; set; }
        public string totalperson { get; set; }

    }


    public partial class hr_visasentinfoEntity
    {
        public List<hr_visasentinfodetlEntity> hr_visasentList { get; set; }

        public string totalperson { get; set; }

    }

    public partial class hr_reppassportinfodetlEntity
    {
        public string firstname { get; set; }
        public string surname { get; set; }

    }


    public partial class gen_okpcoEntity
    {
        public hr_svcinfoEntity hr_svcinfo { get; set; }
    }

    public partial class hr_newdemandEntity
    {
        public hr_newdemanddetlEntity hr_newdemanddetl { get; set; }
    }


    public partial class cnf_rankpayconfigEntity
    {
        public List<KAF_GetRankByGroupEntity> RankByGroupList { get; set; }
    }

    public partial class hr_documentuploadEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
    }

    public partial class hr_civilidinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public HttpPostedFileBase file1 { get; set; }
        public HttpPostedFileBase file2 { get; set; }
    }

    public partial class hr_familypassportinfoEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public HttpPostedFileBase formfile { get; set; }
    }
    public partial class hr_familyresidentvisaEntity
    {
        public List<cor_foldercontentsEntity> cor_foldercontentsList { get; set; }
        public HttpPostedFileBase formfile { get; set; }
    }
}
