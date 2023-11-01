using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.AppConfiguration.Configuration;
using System.Diagnostics;
using KAF.IDataAccessObjects;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;

namespace KAF.DataAccessObjects
{
    public abstract partial class BaseDataAccessFactory
    {
        #region Static Variables
        private static readonly TypeInfo _typeInfo = Settings.TypeInfo;
        #endregion

        #region Instance Variables
        private Context _context;
        #endregion

        #region Property
        protected virtual Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_context == null)
                {
                    _context = new Context();
                }
                return _context;
            }
        }

        #endregion

        #region Constructer
        [DebuggerStepThrough()]
        public BaseDataAccessFactory(Context context)
        {
            _context = context;
        }

        public BaseDataAccessFactory() : base()
        {

        }

        #endregion

        #region Static Methods

        [DebuggerStepThrough()]
        public static BaseDataAccessFactory Create(Context context)
        {
            //BaseDataAccessFactory dataAccessFactory = new DataAccessFactory(context);
            return (BaseDataAccessFactory)new DataAccessFactory(context);
            /*
            return (BaseDataAccessFactory)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(
                                                                                           _typeInfo.AssemblyName,
                                                                                           _typeInfo.TypeName
                                                                                       );
            */
        }
        #endregion

        #region Factory Methods 

        #region hr_civilidinfo
        public abstract Ihr_civilidinfoDataAccessObjects Createhr_civilidinfoDataAccess();
        #endregion hr_civilidinfo

        #region hr_attachmentinfo
        public abstract Ihr_attachmentinfoDataAccessObjects Createhr_attachmentinfoDataAccess();
        #endregion hr_attachmentinfo

        #region hr_okptransferinfo
        public abstract Ihr_okptransferinfoDataAccessObjects Createhr_okptransferinfoDataAccess();
        #endregion hr_okptransferinfo

        #region hr_deathinfo
        public abstract Ihr_deathinfoDataAccessObjects Createhr_deathinfoDataAccess();
        #endregion hr_deathinfo

        #region hr_extensioninfo
        public abstract Ihr_extensioninfoDataAccessObjects Createhr_extensioninfoDataAccess();
        #endregion hr_extensioninfo

        #region hr_hospitaladmissioninfo
        public abstract Ihr_hospitaladmissioninfoDataAccessObjects Createhr_hospitaladmissioninfoDataAccess();
        #endregion hr_hospitaladmissioninfo

        #region hr_leaveinfo
        public abstract Ihr_leaveinfoDataAccessObjects Createhr_leaveinfoDataAccess();
        #endregion hr_leaveinfo

        #region hr_leavemodification
        public abstract Ihr_leavemodificationDataAccessObjects Createhr_leavemodificationDataAccess();
        #endregion hr_leavemodification

        #region hr_medicalinfo
        public abstract Ihr_medicalinfoDataAccessObjects Createhr_medicalinfoDataAccess();
        #endregion hr_medicalinfo

        #region hr_repatriationinfo
        public abstract Ihr_repatriationinfoDataAccessObjects Createhr_repatriationinfoDataAccess();
        #endregion hr_repatriationinfo

        #region cnf_paymentitem
        public abstract Icnf_paymentitemDataAccessObjects Createcnf_paymentitemDataAccess();
        #endregion cnf_paymentitem

        #region gen_month
        public abstract Igen_monthDataAccessObjects Creategen_monthDataAccess();
        #endregion gen_month

        #region gen_grouprank
        public abstract Igen_grouprankDataAccessObjects Creategen_grouprankDataAccess();
        #endregion gen_grouprank

        #region cnf_rankpayconfig
        public abstract Icnf_rankpayconfigDataAccessObjects Createcnf_rankpayconfigDataAccess();
        #endregion cnf_rankpayconfig

        #region tran_cuttinginfo
        public abstract Itran_cuttinginfoDataAccessObjects Createtran_cuttinginfoDataAccess();
        #endregion tran_cuttinginfo


        #region tran_cuttinginfodetl
        public abstract Itran_cuttinginfodetlDataAccessObjects Createtran_cuttinginfodetlDataAccess();
        #endregion tran_cuttinginfodetl

        #region owin_formaction
        public abstract Iowin_formactionDataAccessObjects Createowin_formactionDataAccess();
        #endregion owin_formaction

        #region owin_forminfo
        public abstract Iowin_forminfoDataAccessObjects Createowin_forminfoDataAccess();
        #endregion owin_forminfo

        #region owin_lastworkingpage
        public abstract Iowin_lastworkingpageDataAccessObjects Createowin_lastworkingpageDataAccess();
        #endregion owin_lastworkingpage

        #region owin_role
        public abstract Iowin_roleDataAccessObjects Createowin_roleDataAccess();
        #endregion owin_role

        #region owin_rolepermission
        public abstract Iowin_rolepermissionDataAccessObjects Createowin_rolepermissionDataAccess();
        #endregion owin_rolepermission

        #region owin_user
        public abstract Iowin_userDataAccessObjects Createowin_userDataAccess();
        #endregion owin_user

        #region owin_userlogintrail
        public abstract Iowin_userlogintrailDataAccessObjects Createowin_userlogintrailDataAccess();
        #endregion owin_userlogintrail

        #region owin_userpasswordresetinfo
        public abstract Iowin_userpasswordresetinfoDataAccessObjects Createowin_userpasswordresetinfoDataAccess();
        #endregion owin_userpasswordresetinfo

        #region owin_userprefferencessettings
        public abstract Iowin_userprefferencessettingsDataAccessObjects Createowin_userprefferencessettingsDataAccess();
        #endregion owin_userprefferencessettings

        #region owin_userrole
        public abstract Iowin_userroleDataAccessObjects Createowin_userroleDataAccess();
        #endregion owin_userrole



        #region stp_country
        public abstract Istp_countryDataAccessObjects Createstp_countryDataAccess();
        #endregion stp_country

        #region stp_countrycity
        public abstract Istp_countrycityDataAccessObjects Createstp_countrycityDataAccess();
        #endregion stp_countrycity

        #region stp_organization
        public abstract Istp_organizationDataAccessObjects Createstp_organizationDataAccess();
        #endregion stp_organization

        #region stp_organizationentity
        public abstract Istp_organizationentityDataAccessObjects Createstp_organizationentityDataAccess();
        #endregion stp_organizationentity

        #region stp_organizationentitytype
        public abstract Istp_organizationentitytypeDataAccessObjects Createstp_organizationentitytypeDataAccess();
        #endregion stp_organizationentitytype
        
        #region gen_country
        public abstract Igen_countryDataAccessObjects Creategen_countryDataAccess();
        #endregion gen_country


        #region gen_govcity
        public abstract Igen_govcityDataAccessObjects Creategen_govcityDataAccess();
        #endregion gen_govcity



        #region owin_userstatuschangehistory
        public abstract Iowin_userstatuschangehistoryDataAccessObjects Createowin_userstatuschangehistoryDataAccess();
        #endregion owin_userstatuschangehistory


        #region gen_airlines
        public abstract Igen_airlinesDataAccessObjects Creategen_airlinesDataAccess();
        #endregion gen_airlines


        #region gen_arms
        public abstract Igen_armsDataAccessObjects Creategen_armsDataAccess();
        #endregion gen_arms

        #region gen_authorizestrength
        public abstract Igen_authorizestrengthDataAccessObjects Creategen_authorizestrengthDataAccess();
        #endregion gen_authorizestrength

        #region gen_bank
        public abstract Igen_bankDataAccessObjects Creategen_bankDataAccess();
        #endregion gen_bank

      
        public abstract Igen_currencyexchagerateDataAccessObjects Creategen_currencyexchagerateDataAccess();
   


        #region gen_bankbranch
        public abstract Igen_bankbranchDataAccessObjects Creategen_bankbranchDataAccess();
        #endregion gen_bankbranch


        #region gen_bloodgroup
        public abstract Igen_bloodgroupDataAccessObjects Creategen_bloodgroupDataAccess();
        #endregion gen_bloodgroup


        #region gen_building
        public abstract Igen_buildingDataAccessObjects Creategen_buildingDataAccess();
        #endregion gen_building

        #region gen_camp
        public abstract Igen_campDataAccessObjects Creategen_campDataAccess();
        #endregion gen_camp

        #region gen_divisiondistrict
        public abstract Igen_divisiondistrictDataAccessObjects Creategen_divisiondistrictDataAccess();
        #endregion gen_divisiondistrict


        #region gen_filetype
        public abstract Igen_filetypeDataAccessObjects Creategen_filetypeDataAccess();
        #endregion gen_filetype


        #region gen_freedomfighttype
        public abstract Igen_freedomfighttypeDataAccessObjects Creategen_freedomfighttypeDataAccess();
        #endregion gen_freedomfighttype


        #region gen_gender
        public abstract Igen_genderDataAccessObjects Creategen_genderDataAccess();
        #endregion gen_gender
        


        #region gen_issuetype
        public abstract Igen_issuetypeDataAccessObjects Creategen_issuetypeDataAccess();
        #endregion gen_issuetype


        #region gen_language
        public abstract Igen_languageDataAccessObjects Creategen_languageDataAccess();
        #endregion gen_language


        #region gen_languageproficiency
        public abstract Igen_languageproficiencyDataAccessObjects Creategen_languageproficiencyDataAccess();
        #endregion gen_languageproficiency

        #region gen_leaveconfig
        public abstract Igen_leaveconfigDataAccessObjects Creategen_leaveconfigDataAccess();
        #endregion gen_leaveconfig

        #region gen_leavetype
        public abstract Igen_leavetypeDataAccessObjects Creategen_leavetypeDataAccess();
        #endregion gen_leavetype

        #region gen_maritalstatus
        public abstract Igen_maritalstatusDataAccessObjects Creategen_maritalstatusDataAccess();
        #endregion gen_maritalstatus


        #region gen_movementtype
        public abstract Igen_movementtypeDataAccessObjects Creategen_movementtypeDataAccess();
        #endregion gen_movementtype


        #region gen_okp
        public abstract Igen_okpDataAccessObjects Creategen_okpDataAccess();
        #endregion gen_okp


        #region gen_okpco
        public abstract Igen_okpcoDataAccessObjects Creategen_okpcoDataAccess();
        #endregion gen_okpco


        #region gen_penaltytype
        public abstract Igen_penaltytypeDataAccessObjects Creategen_penaltytypeDataAccess();
        #endregion gen_penaltytype


        #region gen_postoffice
        public abstract Igen_postofficeDataAccessObjects Creategen_postofficeDataAccess();
        #endregion gen_postoffice


        #region gen_promotiontype
        public abstract Igen_promotiontypeDataAccessObjects Creategen_promotiontypeDataAccess();
        #endregion gen_promotiontype


        #region gen_rank
        public abstract Igen_rankDataAccessObjects Creategen_rankDataAccess();
        #endregion gen_rank


        #region gen_ranktype
        public abstract Igen_ranktypeDataAccessObjects Creategen_ranktypeDataAccess();
        #endregion gen_ranktype


        #region gen_relationship
        public abstract Igen_relationshipDataAccessObjects Creategen_relationshipDataAccess();
        #endregion gen_relationship


        #region gen_religion
        public abstract Igen_religionDataAccessObjects Creategen_religionDataAccess();
        #endregion gen_religion


        #region gen_servicestatus
        public abstract Igen_servicestatusDataAccessObjects Creategen_servicestatusDataAccess();
        #endregion gen_servicestatus

        #region gen_subunit
        public abstract Igen_subunitDataAccessObjects Creategen_subunitDataAccess();
        #endregion gen_subunit

        #region gen_thana
        public abstract Igen_thanaDataAccessObjects Creategen_thanaDataAccess();
        #endregion gen_thana


        #region gen_trade
        public abstract Igen_tradeDataAccessObjects Creategen_tradeDataAccess();
        #endregion gen_trade

        #region hr_addresschange
        public abstract Ihr_addresschangeDataAccessObjects Createhr_addresschangeDataAccess();
        #endregion hr_addresschange


        #region hr_arrivalinfo
        public abstract Ihr_arrivalinfoDataAccessObjects Createhr_arrivalinfoDataAccess();
        #endregion hr_arrivalinfo


        #region hr_arrivalinfodetl
        public abstract Ihr_arrivalinfodetlDataAccessObjects Createhr_arrivalinfodetlDataAccess();
        #endregion hr_arrivalinfodetl


        #region hr_bankaccountinfo
        public abstract Ihr_bankaccountinfoDataAccessObjects Createhr_bankaccountinfoDataAccess();
        #endregion hr_bankaccountinfo


        #region hr_bankloaninfo
        public abstract Ihr_bankloaninfoDataAccessObjects Createhr_bankloaninfoDataAccess();
        #endregion hr_bankloaninfo


        #region hr_basicfile
        public abstract Ihr_basicfileDataAccessObjects Createhr_basicfileDataAccess();
        #endregion hr_basicfile


        #region hr_basicprofile
        public abstract Ihr_basicprofileDataAccessObjects Createhr_basicprofileDataAccess();
        #endregion hr_basicprofile


        #region hr_demanddetlpassport
        public abstract Ihr_demanddetlpassportDataAccessObjects Createhr_demanddetlpassportDataAccess();
        #endregion hr_demanddetlpassport


        #region hr_emergencycontact
        public abstract Ihr_emergencycontactDataAccessObjects Createhr_emergencycontactDataAccess();
        #endregion hr_emergencycontact


     


        #region hr_familyinfo
        public abstract Ihr_familyinfoDataAccessObjects Createhr_familyinfoDataAccess();
        #endregion hr_familyinfo


        #region hr_familyjobinfo
        public abstract Ihr_familyjobinfoDataAccessObjects Createhr_familyjobinfoDataAccess();
        #endregion hr_familyjobinfo


        #region hr_flightinfo
        public abstract Ihr_flightinfoDataAccessObjects Createhr_flightinfoDataAccess();
        #endregion hr_flightinfo


        #region hr_flightinfodetl
        public abstract Ihr_flightinfodetlDataAccessObjects Createhr_flightinfodetlDataAccess();
        #endregion hr_flightinfodetl


    


        #region hr_languageproficiency
        public abstract Ihr_languageproficiencyDataAccessObjects Createhr_languageproficiencyDataAccess();
        #endregion hr_languageproficiency


      

        #region hr_newdemand
        public abstract Ihr_newdemandDataAccessObjects Createhr_newdemandDataAccess();
        #endregion hr_newdemand


        #region hr_newdemanddetl
        public abstract Ihr_newdemanddetlDataAccessObjects Createhr_newdemanddetlDataAccess();
        #endregion hr_newdemanddetl


        #region hr_passportinfo
        public abstract Ihr_passportinfoDataAccessObjects Createhr_passportinfoDataAccess();
        #endregion hr_passportinfo


        #region hr_personalinfo
        public abstract Ihr_personalinfoDataAccessObjects Createhr_personalinfoDataAccess();
        #endregion hr_personalinfo


        #region hr_promotioninfo
        public abstract Ihr_promotioninfoDataAccessObjects Createhr_promotioninfoDataAccess();
        #endregion hr_promotioninfo


        #region hr_ptademand
        public abstract Ihr_ptademandDataAccessObjects Createhr_ptademandDataAccess();
        #endregion hr_ptademand


        #region hr_ptademanddetl
        public abstract Ihr_ptademanddetlDataAccessObjects Createhr_ptademanddetlDataAccess();
        #endregion hr_ptademanddetl


        #region hr_ptareceived
        public abstract Ihr_ptareceivedDataAccessObjects Createhr_ptareceivedDataAccess();
        #endregion hr_ptareceived


        #region hr_ptareceiveddetl
        public abstract Ihr_ptareceiveddetlDataAccessObjects Createhr_ptareceiveddetlDataAccess();
        #endregion hr_ptareceiveddetl


        #region hr_punishmentinfo
        public abstract Ihr_punishmentinfoDataAccessObjects Createhr_punishmentinfoDataAccess();
        #endregion hr_punishmentinfo


  


        #region hr_replacementinfo
        public abstract Ihr_replacementinfoDataAccessObjects Createhr_replacementinfoDataAccess();
        #endregion hr_replacementinfo


        #region hr_replacementinfodetl
        public abstract Ihr_replacementinfodetlDataAccessObjects Createhr_replacementinfodetlDataAccess();
        #endregion hr_replacementinfodetl


        #region hr_reppassportinfo
        public abstract Ihr_reppassportinfoDataAccessObjects Createhr_reppassportinfoDataAccess();
        #endregion hr_reppassportinfo


        #region hr_reppassportinfodetl
        public abstract Ihr_reppassportinfodetlDataAccessObjects Createhr_reppassportinfodetlDataAccess();
        #endregion hr_reppassportinfodetl


        #region hr_residentvisa
        public abstract Ihr_residentvisaDataAccessObjects Createhr_residentvisaDataAccess();
        #endregion hr_residentvisa


        #region hr_rewardinfo
        public abstract Ihr_rewardinfoDataAccessObjects Createhr_rewardinfoDataAccess();
        #endregion hr_rewardinfo


        #region hr_svcinfo
        public abstract Ihr_svcinfoDataAccessObjects Createhr_svcinfoDataAccess();
        #endregion hr_svcinfo


        #region hr_visademandinfo
        public abstract Ihr_visademandinfoDataAccessObjects Createhr_visademandinfoDataAccess();
        #endregion hr_visademandinfo


        #region hr_visademandinfodetl
        public abstract Ihr_visademandinfodetlDataAccessObjects Createhr_visademandinfodetlDataAccess();
        #endregion hr_visademandinfodetl


        #region hr_visaissueinfo
        public abstract Ihr_visaissueinfoDataAccessObjects Createhr_visaissueinfoDataAccess();
        #endregion hr_visaissueinfo


        #region hr_visaissueinfodetl
        public abstract Ihr_visaissueinfodetlDataAccessObjects Createhr_visaissueinfodetlDataAccess();
        #endregion hr_visaissueinfodetl


        #region hr_visasentinfo
        public abstract Ihr_visasentinfoDataAccessObjects Createhr_visasentinfoDataAccess();
        #endregion hr_visasentinfo


        #region hr_visasentinfodetl
        public abstract Ihr_visasentinfodetlDataAccessObjects Createhr_visasentinfodetlDataAccess();
        #endregion hr_visasentinfodetl



        #region owin_reportpermission
        public abstract Iowin_reportpermissionDataAccessObjects Createowin_reportpermissionDataAccess();
        #endregion owin_reportpermission


        #region owin_reportrole
        public abstract Iowin_reportroleDataAccessObjects Createowin_reportroleDataAccess();
        #endregion owin_reportrole


        #region owin_reportroletemplate
        public abstract Iowin_reportroletemplateDataAccessObjects Createowin_reportroletemplateDataAccess();
        #endregion owin_reportroletemplate

        

        #region owin_tsv
        public abstract Iowin_tsvDataAccessObjects Createowin_tsvDataAccess();
        #endregion owin_tsv

        
        #region owin_userroledetl
        public abstract Iowin_userroledetlDataAccessObjects Createowin_userroledetlDataAccess();
        #endregion owin_userroledetl


        #region owin_userroledetlentitymap
        public abstract Iowin_userroledetlentitymapDataAccessObjects Createowin_userroledetlentitymapDataAccess();
        #endregion owin_userroledetlentitymap


        #region owin_userroledetlentityprofilemap
        public abstract Iowin_userroledetlentityprofilemapDataAccessObjects Createowin_userroledetlentityprofilemapDataAccess();
        #endregion owin_userroledetlentityprofilemap
        

        #region stp_passpolicy
        public abstract Istp_passpolicyDataAccessObjects Createstp_passpolicyDataAccess();
        #endregion stp_passpolicy


        #region useraccountsprof
        public abstract IuseraccountsprofDataAccessObjects CreateuseraccountsprofDataAccess();
        #endregion useraccountsprof

        #region rptm_allreportinfo
        public abstract Irptm_allreportinfoDataAccessObjects Createrptm_allreportinfoDataAccess();
        #endregion rptm_allreportinfo


        #region rptm_reportdatasource
        public abstract Irptm_reportdatasourceDataAccessObjects Createrptm_reportdatasourceDataAccess();
        #endregion rptm_reportdatasource


        #region rptm_reportparameter
        public abstract Irptm_reportparameterDataAccessObjects Createrptm_reportparameterDataAccess();

        #endregion rptm_reportparameter

        #region tran_manpowerstate
        public abstract Itran_manpowerstateDataAccessObjects Createtran_manpowerstateDataAccess();
        #endregion tran_manpowerstate


        #region tran_manpowerstate_history
        public abstract Itran_manpowerstate_historyDataAccessObjects Createtran_manpowerstate_historyDataAccess();
        #endregion tran_manpowerstate_history


        #region tran_manpowerstatedetl
        public abstract Itran_manpowerstatedetlDataAccessObjects Createtran_manpowerstatedetlDataAccess();
        #endregion tran_manpowerstatedetl


        #region tran_manpowerstatedetl_history
        public abstract Itran_manpowerstatedetl_historyDataAccessObjects Createtran_manpowerstatedetl_historyDataAccess();
        #endregion tran_manpowerstatedetl_history

        #region hr_documentupload
        public abstract Ihr_documentuploadDataAccessObjects Createhr_documentuploadDataAccess();
        #endregion hr_documentupload

        #region gen_documenttype
        public abstract Igen_documenttypeDataAccessObjects Creategen_documenttypeDataAccess();
        #endregion gen_documenttype
        #endregion

    }
}
