using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IDataAccessObjects;
using System.Diagnostics;
using KAF.AppConfiguration.Configuration;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;
using KAF.DataAccessObjects.DataAccessObjectsPartial;

namespace KAF.DataAccessObjects
{
    [DebuggerStepThrough()]
    public partial class DataAccessFactory : BaseDataAccessFactory
    {
        #region Constructer
        public DataAccessFactory(Context context)
            : base(context)
        {
        }

        public DataAccessFactory()
            : base()
        {
        }
        #endregion

        #region Factory Methods 

        #region hr_deathinfo
        [DebuggerStepThrough()]
        public override Ihr_deathinfoDataAccessObjects Createhr_deathinfoDataAccess()
        {
            string type = typeof(hr_deathinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_deathinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_deathinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_deathinfo

        #region hr_leaveinfo
        [DebuggerStepThrough()]
        public override Ihr_leaveinfoDataAccessObjects Createhr_leaveinfoDataAccess()
        {
            string type = typeof(hr_leaveinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_leaveinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_leaveinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_leaveinfo

        #region hr_leavemodification
        [DebuggerStepThrough()]
        public override Ihr_leavemodificationDataAccessObjects Createhr_leavemodificationDataAccess()
        {
            string type = typeof(hr_leavemodificationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_leavemodificationDataAccessObjects(CurrentContext);
            }
            return (Ihr_leavemodificationDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_leavemodification



        #region cnf_paymentitem
        [DebuggerStepThrough()]
        public override Icnf_paymentitemDataAccessObjects Createcnf_paymentitemDataAccess()
        {
            string type = typeof(cnf_paymentitemDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new cnf_paymentitemDataAccessObjects(CurrentContext);
            }
            return (Icnf_paymentitemDataAccessObjects)CurrentContext[type];
        }
        #endregion cnf_paymentitem

        #region gen_currencyexchagerate
        [DebuggerStepThrough()]
        public override Igen_currencyexchagerateDataAccessObjects Creategen_currencyexchagerateDataAccess()
        {
            string type = typeof(gen_currencyexchagerateDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_currencyexchagerateDataAccessObjects(CurrentContext);
            }
            return (Igen_currencyexchagerateDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_currencyexchagerate



        #region cnf_rankpayconfig
        [DebuggerStepThrough()]
        public override Icnf_rankpayconfigDataAccessObjects Createcnf_rankpayconfigDataAccess()
        {
            string type = typeof(cnf_rankpayconfigDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new cnf_rankpayconfigDataAccessObjects(CurrentContext);
            }
            return (Icnf_rankpayconfigDataAccessObjects)CurrentContext[type];
        }
        #endregion cnf_rankpayconfig

        #region gen_grouprank
        [DebuggerStepThrough()]
        public override Igen_grouprankDataAccessObjects Creategen_grouprankDataAccess()
        {
            string type = typeof(gen_grouprankDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_grouprankDataAccessObjects(CurrentContext);
            }
            return (Igen_grouprankDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_grouprank

        #region gen_month
        [DebuggerStepThrough()]
        public override Igen_monthDataAccessObjects Creategen_monthDataAccess()
        {
            string type = typeof(gen_monthDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_monthDataAccessObjects(CurrentContext);
            }
            return (Igen_monthDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_month

        #region tran_cuttinginfo
        [DebuggerStepThrough()]
        public override Itran_cuttinginfoDataAccessObjects Createtran_cuttinginfoDataAccess()
        {
            string type = typeof(tran_cuttinginfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_cuttinginfoDataAccessObjects(CurrentContext);
            }
            return (Itran_cuttinginfoDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_cuttinginfo


        #region tran_cuttinginfodetl
        [DebuggerStepThrough()]
        public override Itran_cuttinginfodetlDataAccessObjects Createtran_cuttinginfodetlDataAccess()
        {
            string type = typeof(tran_cuttinginfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_cuttinginfodetlDataAccessObjects(CurrentContext);
            }
            return (Itran_cuttinginfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_cuttinginfodetl


        #region owin_formaction
        [DebuggerStepThrough()]
        public override Iowin_formactionDataAccessObjects Createowin_formactionDataAccess()
        {
            string type = typeof(owin_formactionDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_formactionDataAccessObjects(CurrentContext);
            }
            return (Iowin_formactionDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_formaction

        #region owin_forminfo
        [DebuggerStepThrough()]
        public override Iowin_forminfoDataAccessObjects Createowin_forminfoDataAccess()
        {
            string type = typeof(owin_forminfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_forminfoDataAccessObjects(CurrentContext);
            }
            return (Iowin_forminfoDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_forminfo

        #region owin_lastworkingpage
        [DebuggerStepThrough()]
        public override Iowin_lastworkingpageDataAccessObjects Createowin_lastworkingpageDataAccess()
        {
            string type = typeof(owin_lastworkingpageDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_lastworkingpageDataAccessObjects(CurrentContext);
            }
            return (Iowin_lastworkingpageDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_lastworkingpage

        #region owin_role
        [DebuggerStepThrough()]
        public override Iowin_roleDataAccessObjects Createowin_roleDataAccess()
        {
            string type = typeof(owin_roleDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_roleDataAccessObjects(CurrentContext);
            }
            return (Iowin_roleDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_role

        #region owin_rolepermission
        [DebuggerStepThrough()]
        public override Iowin_rolepermissionDataAccessObjects Createowin_rolepermissionDataAccess()
        {
            string type = typeof(owin_rolepermissionDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_rolepermissionDataAccessObjects(CurrentContext);
            }
            return (Iowin_rolepermissionDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_rolepermission

        #region owin_user
        [DebuggerStepThrough()]
        public override Iowin_userDataAccessObjects Createowin_userDataAccess()
        {
            string type = typeof(owin_userDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userDataAccessObjects(CurrentContext);
            }
            return (Iowin_userDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_user

        #region owin_userlogintrail
        [DebuggerStepThrough()]
        public override Iowin_userlogintrailDataAccessObjects Createowin_userlogintrailDataAccess()
        {
            string type = typeof(owin_userlogintrailDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userlogintrailDataAccessObjects(CurrentContext);
            }
            return (Iowin_userlogintrailDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userlogintrail

        #region owin_userpasswordresetinfo
        [DebuggerStepThrough()]
        public override Iowin_userpasswordresetinfoDataAccessObjects Createowin_userpasswordresetinfoDataAccess()
        {
            string type = typeof(owin_userpasswordresetinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userpasswordresetinfoDataAccessObjects(CurrentContext);
            }
            return (Iowin_userpasswordresetinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userpasswordresetinfo

        #region owin_userprefferencessettings
        [DebuggerStepThrough()]
        public override Iowin_userprefferencessettingsDataAccessObjects Createowin_userprefferencessettingsDataAccess()
        {
            string type = typeof(owin_userprefferencessettingsDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userprefferencessettingsDataAccessObjects(CurrentContext);
            }
            return (Iowin_userprefferencessettingsDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userprefferencessettings

        #region owin_userrole
        [DebuggerStepThrough()]
        public override Iowin_userroleDataAccessObjects Createowin_userroleDataAccess()
        {
            string type = typeof(owin_userroleDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userroleDataAccessObjects(CurrentContext);
            }
            return (Iowin_userroleDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userrole

        #region stp_country
        [DebuggerStepThrough()]
        public override Istp_countryDataAccessObjects Createstp_countryDataAccess()
        {
            string type = typeof(stp_countryDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_countryDataAccessObjects(CurrentContext);
            }
            return (Istp_countryDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_country

        #region stp_countrycity
        [DebuggerStepThrough()]
        public override Istp_countrycityDataAccessObjects Createstp_countrycityDataAccess()
        {
            string type = typeof(stp_countrycityDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_countrycityDataAccessObjects(CurrentContext);
            }
            return (Istp_countrycityDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_countrycity

        #region stp_organization
        [DebuggerStepThrough()]
        public override Istp_organizationDataAccessObjects Createstp_organizationDataAccess()
        {
            string type = typeof(stp_organizationDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_organizationDataAccessObjects(CurrentContext);
            }
            return (Istp_organizationDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_organization

        #region stp_organizationentity
        [DebuggerStepThrough()]
        public override Istp_organizationentityDataAccessObjects Createstp_organizationentityDataAccess()
        {
            string type = typeof(stp_organizationentityDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_organizationentityDataAccessObjects(CurrentContext);
            }
            return (Istp_organizationentityDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_organizationentity

        #region stp_organizationentitytype
        [DebuggerStepThrough()]
        public override Istp_organizationentitytypeDataAccessObjects Createstp_organizationentitytypeDataAccess()
        {
            string type = typeof(stp_organizationentitytypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_organizationentitytypeDataAccessObjects(CurrentContext);
            }
            return (Istp_organizationentitytypeDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_organizationentitytype

       



        #region owin_userstatuschangehistory
        [DebuggerStepThrough()]
        public override Iowin_userstatuschangehistoryDataAccessObjects Createowin_userstatuschangehistoryDataAccess()
        {
            string type = typeof(owin_userstatuschangehistoryDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userstatuschangehistoryDataAccessObjects(CurrentContext);
            }
            return (Iowin_userstatuschangehistoryDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userstatuschangehistory



        #region gen_airlines
        [DebuggerStepThrough()]
        public override Igen_airlinesDataAccessObjects Creategen_airlinesDataAccess()
        {
            string type = typeof(gen_airlinesDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_airlinesDataAccessObjects(CurrentContext);
            }
            return (Igen_airlinesDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_airlines


        #region gen_arms
        [DebuggerStepThrough()]
        public override Igen_armsDataAccessObjects Creategen_armsDataAccess()
        {
            string type = typeof(gen_armsDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_armsDataAccessObjects(CurrentContext);
            }
            return (Igen_armsDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_arms

        #region gen_authorizestrength
        [DebuggerStepThrough()]
        public override Igen_authorizestrengthDataAccessObjects Creategen_authorizestrengthDataAccess()
        {
            string type = typeof(gen_authorizestrengthDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_authorizestrengthDataAccessObjects(CurrentContext);
            }
            return (Igen_authorizestrengthDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_authorizestrength

        #region gen_bank
        [DebuggerStepThrough()]
        public override Igen_bankDataAccessObjects Creategen_bankDataAccess()
        {
            string type = typeof(gen_bankDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_bankDataAccessObjects(CurrentContext);
            }
            return (Igen_bankDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_bank


        #region gen_bankbranch
        [DebuggerStepThrough()]
        public override Igen_bankbranchDataAccessObjects Creategen_bankbranchDataAccess()
        {
            string type = typeof(gen_bankbranchDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_bankbranchDataAccessObjects(CurrentContext);
            }
            return (Igen_bankbranchDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_bankbranch


        #region gen_bloodgroup
        [DebuggerStepThrough()]
        public override Igen_bloodgroupDataAccessObjects Creategen_bloodgroupDataAccess()
        {
            string type = typeof(gen_bloodgroupDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_bloodgroupDataAccessObjects(CurrentContext);
            }
            return (Igen_bloodgroupDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_bloodgroup


        #region gen_building
        [DebuggerStepThrough()]
        public override Igen_buildingDataAccessObjects Creategen_buildingDataAccess()
        {
            string type = typeof(gen_buildingDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_buildingDataAccessObjects(CurrentContext);
            }
            return (Igen_buildingDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_building

        #region gen_camp
        [DebuggerStepThrough()]
        public override Igen_campDataAccessObjects Creategen_campDataAccess()
        {
            string type = typeof(gen_campDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_campDataAccessObjects(CurrentContext);
            }
            return (Igen_campDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_camp


        #region gen_country
        [DebuggerStepThrough()]
        public override Igen_countryDataAccessObjects Creategen_countryDataAccess()
        {
            string type = typeof(gen_countryDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_countryDataAccessObjects(CurrentContext);
            }
            return (Igen_countryDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_country


        #region gen_divisiondistrict
        [DebuggerStepThrough()]
        public override Igen_divisiondistrictDataAccessObjects Creategen_divisiondistrictDataAccess()
        {
            string type = typeof(gen_divisiondistrictDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_divisiondistrictDataAccessObjects(CurrentContext);
            }
            return (Igen_divisiondistrictDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_divisiondistrict


        #region gen_filetype
        [DebuggerStepThrough()]
        public override Igen_filetypeDataAccessObjects Creategen_filetypeDataAccess()
        {
            string type = typeof(gen_filetypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_filetypeDataAccessObjects(CurrentContext);
            }
            return (Igen_filetypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_filetype


        #region gen_freedomfighttype
        [DebuggerStepThrough()]
        public override Igen_freedomfighttypeDataAccessObjects Creategen_freedomfighttypeDataAccess()
        {
            string type = typeof(gen_freedomfighttypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_freedomfighttypeDataAccessObjects(CurrentContext);
            }
            return (Igen_freedomfighttypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_freedomfighttype


        #region gen_gender
        [DebuggerStepThrough()]
        public override Igen_genderDataAccessObjects Creategen_genderDataAccess()
        {
            string type = typeof(gen_genderDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_genderDataAccessObjects(CurrentContext);
            }
            return (Igen_genderDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_gender


        #region gen_govcity
        [DebuggerStepThrough()]
        public override Igen_govcityDataAccessObjects Creategen_govcityDataAccess()
        {
            string type = typeof(gen_govcityDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_govcityDataAccessObjects(CurrentContext);
            }
            return (Igen_govcityDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_govcity


        #region gen_issuetype
        [DebuggerStepThrough()]
        public override Igen_issuetypeDataAccessObjects Creategen_issuetypeDataAccess()
        {
            string type = typeof(gen_issuetypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_issuetypeDataAccessObjects(CurrentContext);
            }
            return (Igen_issuetypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_issuetype


        #region gen_language
        [DebuggerStepThrough()]
        public override Igen_languageDataAccessObjects Creategen_languageDataAccess()
        {
            string type = typeof(gen_languageDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_languageDataAccessObjects(CurrentContext);
            }
            return (Igen_languageDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_language


        #region gen_languageproficiency
        [DebuggerStepThrough()]
        public override Igen_languageproficiencyDataAccessObjects Creategen_languageproficiencyDataAccess()
        {
            string type = typeof(gen_languageproficiencyDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_languageproficiencyDataAccessObjects(CurrentContext);
            }
            return (Igen_languageproficiencyDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_languageproficiency

       
        #region gen_leaveconfig
        [DebuggerStepThrough()]
        public override Igen_leaveconfigDataAccessObjects Creategen_leaveconfigDataAccess()
        {
            string type = typeof(gen_leaveconfigDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_leaveconfigDataAccessObjects(CurrentContext);
            }
            return (Igen_leaveconfigDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_leaveconfig
        
       
        #region gen_leavetype
        [DebuggerStepThrough()]
        public override Igen_leavetypeDataAccessObjects Creategen_leavetypeDataAccess()
        {
            string type = typeof(gen_leavetypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_leavetypeDataAccessObjects(CurrentContext);
            }
            return (Igen_leavetypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_leavetype


        #region gen_maritalstatus
        [DebuggerStepThrough()]
        public override Igen_maritalstatusDataAccessObjects Creategen_maritalstatusDataAccess()
        {
            string type = typeof(gen_maritalstatusDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_maritalstatusDataAccessObjects(CurrentContext);
            }
            return (Igen_maritalstatusDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_maritalstatus


        #region gen_movementtype
        [DebuggerStepThrough()]
        public override Igen_movementtypeDataAccessObjects Creategen_movementtypeDataAccess()
        {
            string type = typeof(gen_movementtypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_movementtypeDataAccessObjects(CurrentContext);
            }
            return (Igen_movementtypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_movementtype


        #region gen_okp
        [DebuggerStepThrough()]
        public override Igen_okpDataAccessObjects Creategen_okpDataAccess()
        {
            string type = typeof(gen_okpDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_okpDataAccessObjects(CurrentContext);
            }
            return (Igen_okpDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_okp


        #region gen_okpco
        [DebuggerStepThrough()]
        public override Igen_okpcoDataAccessObjects Creategen_okpcoDataAccess()
        {
            string type = typeof(gen_okpcoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_okpcoDataAccessObjects(CurrentContext);
            }
            return (Igen_okpcoDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_okpco


        #region gen_penaltytype
        [DebuggerStepThrough()]
        public override Igen_penaltytypeDataAccessObjects Creategen_penaltytypeDataAccess()
        {
            string type = typeof(gen_penaltytypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_penaltytypeDataAccessObjects(CurrentContext);
            }
            return (Igen_penaltytypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_penaltytype


        #region gen_postoffice
        [DebuggerStepThrough()]
        public override Igen_postofficeDataAccessObjects Creategen_postofficeDataAccess()
        {
            string type = typeof(gen_postofficeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_postofficeDataAccessObjects(CurrentContext);
            }
            return (Igen_postofficeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_postoffice


        #region gen_promotiontype
        [DebuggerStepThrough()]
        public override Igen_promotiontypeDataAccessObjects Creategen_promotiontypeDataAccess()
        {
            string type = typeof(gen_promotiontypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_promotiontypeDataAccessObjects(CurrentContext);
            }
            return (Igen_promotiontypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_promotiontype


        #region gen_rank
        [DebuggerStepThrough()]
        public override Igen_rankDataAccessObjects Creategen_rankDataAccess()
        {
            string type = typeof(gen_rankDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_rankDataAccessObjects(CurrentContext);
            }
            return (Igen_rankDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_rank


        #region gen_ranktype
        [DebuggerStepThrough()]
        public override Igen_ranktypeDataAccessObjects Creategen_ranktypeDataAccess()
        {
            string type = typeof(gen_ranktypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_ranktypeDataAccessObjects(CurrentContext);
            }
            return (Igen_ranktypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_ranktype


        #region gen_relationship
        [DebuggerStepThrough()]
        public override Igen_relationshipDataAccessObjects Creategen_relationshipDataAccess()
        {
            string type = typeof(gen_relationshipDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_relationshipDataAccessObjects(CurrentContext);
            }
            return (Igen_relationshipDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_relationship


        #region gen_religion
        [DebuggerStepThrough()]
        public override Igen_religionDataAccessObjects Creategen_religionDataAccess()
        {
            string type = typeof(gen_religionDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_religionDataAccessObjects(CurrentContext);
            }
            return (Igen_religionDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_religion


        #region gen_servicestatus
        [DebuggerStepThrough()]
        public override Igen_servicestatusDataAccessObjects Creategen_servicestatusDataAccess()
        {
            string type = typeof(gen_servicestatusDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_servicestatusDataAccessObjects(CurrentContext);
            }
            return (Igen_servicestatusDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_servicestatus


        #region gen_thana
        [DebuggerStepThrough()]
        public override Igen_thanaDataAccessObjects Creategen_thanaDataAccess()
        {
            string type = typeof(gen_thanaDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_thanaDataAccessObjects(CurrentContext);
            }
            return (Igen_thanaDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_thana


        #region gen_trade
        [DebuggerStepThrough()]
        public override Igen_tradeDataAccessObjects Creategen_tradeDataAccess()
        {
            string type = typeof(gen_tradeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_tradeDataAccessObjects(CurrentContext);
            }
            return (Igen_tradeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_trade


        #region hr_attachmentinfo
        [DebuggerStepThrough()]
        public override Ihr_attachmentinfoDataAccessObjects Createhr_attachmentinfoDataAccess()
        {
            string type = typeof(hr_attachmentinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_attachmentinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_attachmentinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_attachmentinfo

        #region hr_okptransferinfo
        [DebuggerStepThrough()]
        public override Ihr_okptransferinfoDataAccessObjects Createhr_okptransferinfoDataAccess()
        {
            string type = typeof(hr_okptransferinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_okptransferinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_okptransferinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_okptransferinfo


        #region hr_addresschange
        [DebuggerStepThrough()]
        public override Ihr_addresschangeDataAccessObjects Createhr_addresschangeDataAccess()
        {
            string type = typeof(hr_addresschangeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_addresschangeDataAccessObjects(CurrentContext);
            }
            return (Ihr_addresschangeDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_addresschange


        #region hr_arrivalinfo
        [DebuggerStepThrough()]
        public override Ihr_arrivalinfoDataAccessObjects Createhr_arrivalinfoDataAccess()
        {
            string type = typeof(hr_arrivalinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_arrivalinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_arrivalinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_arrivalinfo


        #region hr_arrivalinfodetl
        [DebuggerStepThrough()]
        public override Ihr_arrivalinfodetlDataAccessObjects Createhr_arrivalinfodetlDataAccess()
        {
            string type = typeof(hr_arrivalinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_arrivalinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_arrivalinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_arrivalinfodetl


        #region hr_bankaccountinfo
        [DebuggerStepThrough()]
        public override Ihr_bankaccountinfoDataAccessObjects Createhr_bankaccountinfoDataAccess()
        {
            string type = typeof(hr_bankaccountinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_bankaccountinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_bankaccountinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_bankaccountinfo


        #region hr_bankloaninfo
        [DebuggerStepThrough()]
        public override Ihr_bankloaninfoDataAccessObjects Createhr_bankloaninfoDataAccess()
        {
            string type = typeof(hr_bankloaninfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_bankloaninfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_bankloaninfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_bankloaninfo


        #region hr_basicfile
        [DebuggerStepThrough()]
        public override Ihr_basicfileDataAccessObjects Createhr_basicfileDataAccess()
        {
            string type = typeof(hr_basicfileDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_basicfileDataAccessObjects(CurrentContext);
            }
            return (Ihr_basicfileDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_basicfile


        #region hr_basicprofile
        [DebuggerStepThrough()]
        public override Ihr_basicprofileDataAccessObjects Createhr_basicprofileDataAccess()
        {
            string type = typeof(hr_basicprofileDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_basicprofileDataAccessObjects(CurrentContext);
            }
            return (Ihr_basicprofileDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_basicprofile


        #region hr_demanddetlpassport
        [DebuggerStepThrough()]
        public override Ihr_demanddetlpassportDataAccessObjects Createhr_demanddetlpassportDataAccess()
        {
            string type = typeof(hr_demanddetlpassportDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_demanddetlpassportDataAccessObjects(CurrentContext);
            }
            return (Ihr_demanddetlpassportDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_demanddetlpassport


        #region hr_emergencycontact
        [DebuggerStepThrough()]
        public override Ihr_emergencycontactDataAccessObjects Createhr_emergencycontactDataAccess()
        {
            string type = typeof(hr_emergencycontactDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_emergencycontactDataAccessObjects(CurrentContext);
            }
            return (Ihr_emergencycontactDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_emergencycontact


        #region hr_extensioninfo
        [DebuggerStepThrough()]
        public override Ihr_extensioninfoDataAccessObjects Createhr_extensioninfoDataAccess()
        {
            string type = typeof(hr_extensioninfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_extensioninfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_extensioninfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_extensioninfo


        #region hr_familyinfo
        [DebuggerStepThrough()]
        public override Ihr_familyinfoDataAccessObjects Createhr_familyinfoDataAccess()
        {
            string type = typeof(hr_familyinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_familyinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_familyinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_familyinfo


        #region hr_familyjobinfo
        [DebuggerStepThrough()]
        public override Ihr_familyjobinfoDataAccessObjects Createhr_familyjobinfoDataAccess()
        {
            string type = typeof(hr_familyjobinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_familyjobinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_familyjobinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_familyjobinfo


        #region hr_flightinfo
        [DebuggerStepThrough()]
        public override Ihr_flightinfoDataAccessObjects Createhr_flightinfoDataAccess()
        {
            string type = typeof(hr_flightinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_flightinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_flightinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_flightinfo


        #region hr_flightinfodetl
        [DebuggerStepThrough()]
        public override Ihr_flightinfodetlDataAccessObjects Createhr_flightinfodetlDataAccess()
        {
            string type = typeof(hr_flightinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_flightinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_flightinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_flightinfodetl


        #region hr_hospitaladmissioninfo
        [DebuggerStepThrough()]
        public override Ihr_hospitaladmissioninfoDataAccessObjects Createhr_hospitaladmissioninfoDataAccess()
        {
            string type = typeof(hr_hospitaladmissioninfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_hospitaladmissioninfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_hospitaladmissioninfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_hospitaladmissioninfo


        #region hr_languageproficiency
        [DebuggerStepThrough()]
        public override Ihr_languageproficiencyDataAccessObjects Createhr_languageproficiencyDataAccess()
        {
            string type = typeof(hr_languageproficiencyDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_languageproficiencyDataAccessObjects(CurrentContext);
            }
            return (Ihr_languageproficiencyDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_languageproficiency


        #region hr_medicalinfo
        [DebuggerStepThrough()]
        public override Ihr_medicalinfoDataAccessObjects Createhr_medicalinfoDataAccess()
        {
            string type = typeof(hr_medicalinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_medicalinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_medicalinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_medicalinfo


        #region hr_newdemand
        [DebuggerStepThrough()]
        public override Ihr_newdemandDataAccessObjects Createhr_newdemandDataAccess()
        {
            string type = typeof(hr_newdemandDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_newdemandDataAccessObjects(CurrentContext);
            }
            return (Ihr_newdemandDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_newdemand


        #region hr_newdemanddetl
        [DebuggerStepThrough()]
        public override Ihr_newdemanddetlDataAccessObjects Createhr_newdemanddetlDataAccess()
        {
            string type = typeof(hr_newdemanddetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_newdemanddetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_newdemanddetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_newdemanddetl


        #region hr_passportinfo
        [DebuggerStepThrough()]
        public override Ihr_passportinfoDataAccessObjects Createhr_passportinfoDataAccess()
        {
            string type = typeof(hr_passportinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_passportinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_passportinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_passportinfo


        #region hr_personalinfo
        [DebuggerStepThrough()]
        public override Ihr_personalinfoDataAccessObjects Createhr_personalinfoDataAccess()
        {
            string type = typeof(hr_personalinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_personalinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_personalinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_personalinfo


        #region hr_promotioninfo
        [DebuggerStepThrough()]
        public override Ihr_promotioninfoDataAccessObjects Createhr_promotioninfoDataAccess()
        {
            string type = typeof(hr_promotioninfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_promotioninfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_promotioninfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_promotioninfo
        #region hr_ptademand
        [DebuggerStepThrough()]
        public override Ihr_ptademandDataAccessObjects Createhr_ptademandDataAccess()
        {
            string type = typeof(hr_ptademandDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_ptademandDataAccessObjects(CurrentContext);
            }
            return (Ihr_ptademandDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_ptademand


        #region hr_ptademanddetl
        [DebuggerStepThrough()]
        public override Ihr_ptademanddetlDataAccessObjects Createhr_ptademanddetlDataAccess()
        {
            string type = typeof(hr_ptademanddetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_ptademanddetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_ptademanddetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_ptademanddetl


        #region hr_ptareceived
        [DebuggerStepThrough()]
        public override Ihr_ptareceivedDataAccessObjects Createhr_ptareceivedDataAccess()
        {
            string type = typeof(hr_ptareceivedDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_ptareceivedDataAccessObjects(CurrentContext);
            }
            return (Ihr_ptareceivedDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_ptareceived


        #region hr_ptareceiveddetl
        [DebuggerStepThrough()]
        public override Ihr_ptareceiveddetlDataAccessObjects Createhr_ptareceiveddetlDataAccess()
        {
            string type = typeof(hr_ptareceiveddetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_ptareceiveddetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_ptareceiveddetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_ptareceiveddetl


        #region hr_punishmentinfo
        [DebuggerStepThrough()]
        public override Ihr_punishmentinfoDataAccessObjects Createhr_punishmentinfoDataAccess()
        {
            string type = typeof(hr_punishmentinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_punishmentinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_punishmentinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_punishmentinfo


        #region hr_repatriationinfo
        [DebuggerStepThrough()]
        public override Ihr_repatriationinfoDataAccessObjects Createhr_repatriationinfoDataAccess()
        {
            string type = typeof(hr_repatriationinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_repatriationinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_repatriationinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_repatriationinfo


        #region hr_replacementinfo
        [DebuggerStepThrough()]
        public override Ihr_replacementinfoDataAccessObjects Createhr_replacementinfoDataAccess()
        {
            string type = typeof(hr_replacementinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_replacementinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_replacementinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_replacementinfo


        #region hr_replacementinfodetl
        [DebuggerStepThrough()]
        public override Ihr_replacementinfodetlDataAccessObjects Createhr_replacementinfodetlDataAccess()
        {
            string type = typeof(hr_replacementinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_replacementinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_replacementinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_replacementinfodetl


        #region hr_reppassportinfo
        [DebuggerStepThrough()]
        public override Ihr_reppassportinfoDataAccessObjects Createhr_reppassportinfoDataAccess()
        {
            string type = typeof(hr_reppassportinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_reppassportinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_reppassportinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_reppassportinfo


        #region hr_reppassportinfodetl
        [DebuggerStepThrough()]
        public override Ihr_reppassportinfodetlDataAccessObjects Createhr_reppassportinfodetlDataAccess()
        {
            string type = typeof(hr_reppassportinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_reppassportinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_reppassportinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_reppassportinfodetl


        #region hr_residentvisa
        [DebuggerStepThrough()]
        public override Ihr_residentvisaDataAccessObjects Createhr_residentvisaDataAccess()
        {
            string type = typeof(hr_residentvisaDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_residentvisaDataAccessObjects(CurrentContext);
            }
            return (Ihr_residentvisaDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_residentvisa


        #region hr_rewardinfo
        [DebuggerStepThrough()]
        public override Ihr_rewardinfoDataAccessObjects Createhr_rewardinfoDataAccess()
        {
            string type = typeof(hr_rewardinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_rewardinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_rewardinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_rewardinfo

        #region gen_subunit
        [DebuggerStepThrough()]
        public override Igen_subunitDataAccessObjects Creategen_subunitDataAccess()
        {
            string type = typeof(gen_subunitDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_subunitDataAccessObjects(CurrentContext);
            }
            return (Igen_subunitDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_subunit

        #region hr_svcinfo
        [DebuggerStepThrough()]
        public override Ihr_svcinfoDataAccessObjects Createhr_svcinfoDataAccess()
        {
            string type = typeof(hr_svcinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_svcinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_svcinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_svcinfo


        #region hr_visademandinfo
        [DebuggerStepThrough()]
        public override Ihr_visademandinfoDataAccessObjects Createhr_visademandinfoDataAccess()
        {
            string type = typeof(hr_visademandinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visademandinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_visademandinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visademandinfo


        #region hr_visademandinfodetl
        [DebuggerStepThrough()]
        public override Ihr_visademandinfodetlDataAccessObjects Createhr_visademandinfodetlDataAccess()
        {
            string type = typeof(hr_visademandinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visademandinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_visademandinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visademandinfodetl


        #region hr_visaissueinfo
        [DebuggerStepThrough()]
        public override Ihr_visaissueinfoDataAccessObjects Createhr_visaissueinfoDataAccess()
        {
            string type = typeof(hr_visaissueinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visaissueinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_visaissueinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visaissueinfo


        #region hr_visaissueinfodetl
        [DebuggerStepThrough()]
        public override Ihr_visaissueinfodetlDataAccessObjects Createhr_visaissueinfodetlDataAccess()
        {
            string type = typeof(hr_visaissueinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visaissueinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_visaissueinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visaissueinfodetl


        #region hr_visasentinfo
        [DebuggerStepThrough()]
        public override Ihr_visasentinfoDataAccessObjects Createhr_visasentinfoDataAccess()
        {
            string type = typeof(hr_visasentinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visasentinfoDataAccessObjects(CurrentContext);
            }
            return (Ihr_visasentinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visasentinfo


        #region hr_visasentinfodetl
        [DebuggerStepThrough()]
        public override Ihr_visasentinfodetlDataAccessObjects Createhr_visasentinfodetlDataAccess()
        {
            string type = typeof(hr_visasentinfodetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_visasentinfodetlDataAccessObjects(CurrentContext);
            }
            return (Ihr_visasentinfodetlDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_visasentinfodetl


        #region owin_reportpermission
        [DebuggerStepThrough()]
        public override Iowin_reportpermissionDataAccessObjects Createowin_reportpermissionDataAccess()
        {
            string type = typeof(owin_reportpermissionDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_reportpermissionDataAccessObjects(CurrentContext);
            }
            return (Iowin_reportpermissionDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_reportpermission


        #region owin_reportrole
        [DebuggerStepThrough()]
        public override Iowin_reportroleDataAccessObjects Createowin_reportroleDataAccess()
        {
            string type = typeof(owin_reportroleDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_reportroleDataAccessObjects(CurrentContext);
            }
            return (Iowin_reportroleDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_reportrole


        #region owin_reportroletemplate
        [DebuggerStepThrough()]
        public override Iowin_reportroletemplateDataAccessObjects Createowin_reportroletemplateDataAccess()
        {
            string type = typeof(owin_reportroletemplateDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_reportroletemplateDataAccessObjects(CurrentContext);
            }
            return (Iowin_reportroletemplateDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_reportroletemplate
        
        #region owin_tsv
        [DebuggerStepThrough()]
        public override Iowin_tsvDataAccessObjects Createowin_tsvDataAccess()
        {
            string type = typeof(owin_tsvDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_tsvDataAccessObjects(CurrentContext);
            }
            return (Iowin_tsvDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_tsv
        

        #region owin_userroledetl
        [DebuggerStepThrough()]
        public override Iowin_userroledetlDataAccessObjects Createowin_userroledetlDataAccess()
        {
            string type = typeof(owin_userroledetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userroledetlDataAccessObjects(CurrentContext);
            }
            return (Iowin_userroledetlDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userroledetl


        #region owin_userroledetlentitymap
        [DebuggerStepThrough()]
        public override Iowin_userroledetlentitymapDataAccessObjects Createowin_userroledetlentitymapDataAccess()
        {
            string type = typeof(owin_userroledetlentitymapDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userroledetlentitymapDataAccessObjects(CurrentContext);
            }
            return (Iowin_userroledetlentitymapDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userroledetlentitymap


        #region owin_userroledetlentityprofilemap
        [DebuggerStepThrough()]
        public override Iowin_userroledetlentityprofilemapDataAccessObjects Createowin_userroledetlentityprofilemapDataAccess()
        {
            string type = typeof(owin_userroledetlentityprofilemapDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new owin_userroledetlentityprofilemapDataAccessObjects(CurrentContext);
            }
            return (Iowin_userroledetlentityprofilemapDataAccessObjects)CurrentContext[type];
        }
        #endregion owin_userroledetlentityprofilemap

        

        #region stp_passpolicy
        [DebuggerStepThrough()]
        public override Istp_passpolicyDataAccessObjects Createstp_passpolicyDataAccess()
        {
            string type = typeof(stp_passpolicyDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new stp_passpolicyDataAccessObjects(CurrentContext);
            }
            return (Istp_passpolicyDataAccessObjects)CurrentContext[type];
        }
        #endregion stp_passpolicy


        #region useraccountsprof
        [DebuggerStepThrough()]
        public override IuseraccountsprofDataAccessObjects CreateuseraccountsprofDataAccess()
        {
            string type = typeof(useraccountsprofDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new useraccountsprofDataAccessObjects(CurrentContext);
            }
            return (IuseraccountsprofDataAccessObjects)CurrentContext[type];
        }
        #endregion useraccountsprof


        #region rptm_allreportinfo
        [DebuggerStepThrough()]
        public override Irptm_allreportinfoDataAccessObjects Createrptm_allreportinfoDataAccess()
        {
            string type = typeof(rptm_allreportinfoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new rptm_allreportinfoDataAccessObjects(CurrentContext);
            }
            return (Irptm_allreportinfoDataAccessObjects)CurrentContext[type];
        }
        #endregion rptm_allreportinfo


        #region rptm_reportdatasource
        [DebuggerStepThrough()]
        public override Irptm_reportdatasourceDataAccessObjects Createrptm_reportdatasourceDataAccess()
        {
            string type = typeof(rptm_reportdatasourceDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new rptm_reportdatasourceDataAccessObjects(CurrentContext);
            }
            return (Irptm_reportdatasourceDataAccessObjects)CurrentContext[type];
        }
        #endregion rptm_reportdatasource


        #region rptm_reportparameter
        [DebuggerStepThrough()]
        public override Irptm_reportparameterDataAccessObjects Createrptm_reportparameterDataAccess()
        {
            string type = typeof(rptm_reportparameterDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new rptm_reportparameterDataAccessObjects(CurrentContext);
            }
            return (Irptm_reportparameterDataAccessObjects)CurrentContext[type];
        }
        #endregion rptm_reportparameter

        #region tran_manpowerstate
        [DebuggerStepThrough()]
        public override Itran_manpowerstateDataAccessObjects Createtran_manpowerstateDataAccess()
        {
            string type = typeof(tran_manpowerstateDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_manpowerstateDataAccessObjects(CurrentContext);
            }
            return (Itran_manpowerstateDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_manpowerstate


        #region tran_manpowerstate_history
        [DebuggerStepThrough()]
        public override Itran_manpowerstate_historyDataAccessObjects Createtran_manpowerstate_historyDataAccess()
        {
            string type = typeof(tran_manpowerstate_historyDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_manpowerstate_historyDataAccessObjects(CurrentContext);
            }
            return (Itran_manpowerstate_historyDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_manpowerstate_history


        #region tran_manpowerstatedetl
        [DebuggerStepThrough()]
        public override Itran_manpowerstatedetlDataAccessObjects Createtran_manpowerstatedetlDataAccess()
        {
            string type = typeof(tran_manpowerstatedetlDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_manpowerstatedetlDataAccessObjects(CurrentContext);
            }
            return (Itran_manpowerstatedetlDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_manpowerstatedetl


        #region tran_manpowerstatedetl_history
        [DebuggerStepThrough()]
        public override Itran_manpowerstatedetl_historyDataAccessObjects Createtran_manpowerstatedetl_historyDataAccess()
        {
            string type = typeof(tran_manpowerstatedetl_historyDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new tran_manpowerstatedetl_historyDataAccessObjects(CurrentContext);
            }
            return (Itran_manpowerstatedetl_historyDataAccessObjects)CurrentContext[type];
        }
        #endregion tran_manpowerstatedetl_history



        #region hr_documentupload
        [DebuggerStepThrough()]
        public override Ihr_documentuploadDataAccessObjects Createhr_documentuploadDataAccess()
        {
            string type = typeof(hr_documentuploadDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new hr_documentuploadDataAccessObjects(CurrentContext);
            }
            return (Ihr_documentuploadDataAccessObjects)CurrentContext[type];
        }
        #endregion hr_documentupload

        #region gen_documenttype
        [DebuggerStepThrough()]
        public override Igen_documenttypeDataAccessObjects Creategen_documenttypeDataAccess()
        {
            string type = typeof(gen_documenttypeDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new gen_documenttypeDataAccessObjects(CurrentContext);
            }
            return (Igen_documenttypeDataAccessObjects)CurrentContext[type];
        }
        #endregion gen_documenttype
        #endregion Factory Methods 

    }
}
