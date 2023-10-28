
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace KAF.CustomHelper.HelperClasses
{
    public static class clsDataCache
    {

        #region static array
        public static string[] owin_role = { "owin_roleEntity", "RoleID", "RoleName" };

        public static string[] owin_reportrole = { "owin_reportroleEntity", "ReportRoleID", "ReportRoleName" };

        public static string[] owin_formaction = { "owin_formactionEntity", "FormActionID", "ActionName" };

        public static string[] owin_formainfo = { "owin_forminfoEntity", "AppFormID", "FormName" };

        public static string[] stp_organizationentitytypeEntity = { "stp_organizationentitytypeentity", "entirytypekey", "entirytype" };

        public static string[] stp_organizationEntity = { "stp_organizationentity", "organizationkey", "organizationname" };

        public static string[] gen_bankbranchEntity = { "gen_bankbranchentity", "branchid", "branchname" };

        public static string[] gen_bankEntity = { "gen_bankentity", "bankid", "bankname" };

        public static string[] gen_filetypeEntity = { "gen_filetypeEntity", "filetypeid", "filetypename" };

        public static string[] gen_relationshipEntity = { "gen_relationshipEntity", "relationshipid", "relationshipname" };

        public static string[] gen_airlinesEntity = { "gen_airlinesEntity", "airlinesid", "airlinesname" };
        public static string[] gen_buildingEntity = { "gen_buildingEntity", "buildingid", "buildingname" };
        public static string[] gen_okpEntity = { "gen_okpEntity", "okpid", "okpname" };

        public static string[] gen_armsEntity = { "gen_armsEntity", "armsid", "armsname" };
        public static string[] gen_bloodgroupEntity = { "gen_bloodgroupEntity", "bloodgroupid", "bloodgroup" };
        public static string[] gen_freedomfighttypeEntity = { "gen_freedomfighttypeEntity", "freedomfighttype", "freedomfight" };
        public static string[] gen_genderEntity = { "gen_genderEntity", "genderid", "gender" };
        public static string[] gen_issuetypeEntity = { "gen_issuetypeEntity", "issuetypeid", "issuetype" };
        public static string[] gen_languageEntity = { "gen_languageEntity", "languageid", "languagename" };
        public static string[] gen_languageproficiencyEntity = { "gen_languageproficiencyEntity", "proficiencyid", "proficiencyname" };
        public static string[] gen_maritalstatusEntity = { "gen_maritalstatusEntity", "maritalstatusid", "maritalstatus" };
        public static string[] gen_movementtypeEntity = { "gen_movementtypeEntity", "movementtypeid", "movementtype" };
        public static string[] gen_penaltytypeEntity = { "gen_penaltytypeEntity", "penaltytypeid", "penaltytype" };
        public static string[] gen_promotiontypeEntity = { "gen_promotiontypeEntity", "promotiontypeid", "promotiontype" };
        public static string[] gen_ranktypeEntity = { "gen_ranktypeEntity", "ranktypeid", "ranktype" };
        public static string[] gen_religionEntity = { "gen_religionEntity", "religionid", "religion" };
        public static string[] gen_servicestatusEntity = { "gen_servicestatusEntity", "servicestatusid", "servicestatusname" };

        public static string[] stp_color = { "stp_color", "colorid", "colorname" };

        public static string[] gen_leavetypeEntity = { "gen_leavetypeEntity", "leavetypeid", "leavetype" };

        public static string[] gen_subunitEntity = { "gen_subunitEntity", "subunitid", "subunit" };
        public static string[] gen_campEntity = { "gen_campEntity", "campid", "campname" };

        public static string[] gen_documenttypeEntity = { "gen_documenttypeEntity", "doctypeid", "doctypename" };
        #endregion static array
        public static void LoadDataCache()
        {
            try
            {
                set_owin_roleList();
                set_owin_reportroleList();
                set_owin_formaction();
                set_owin_forminfo();
                set_stp_color();
                set_stp_organizationentitytype();
                set_stp_organization();
                set_gen_bank();
                set_gen_bankbranch();
                set_gen_filetype();
                set_gen_relationship();

                set_gen_airlines();
                set_gen_building();
                set_gen_okp();

                set_gen_arms();
                set_gen_bloodgroup();
                set_gen_freedomfighttype();
                set_gen_gender();
                set_gen_issuetype();
                set_gen_language();
                set_gen_languageproficiency();
                set_gen_maritalstatus();
                set_gen_movementtype();
                set_gen_penaltytype();
                set_gen_promotiontype();
                set_gen_ranktype();
                set_gen_religion();
                set_gen_servicestatus();
                set_gen_leavetype();

                set_gen_subunit();
                set_gen_camp();
                set_gen_documenttype();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async static Task<List<gen_airlinesEntity>> set_gen_airlines()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_airlinesEntity> gen_airlinesList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_airlinesEntity(new gen_airlinesEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_airlinesList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_airlines", objList);
            return gen_airlinesList;
        }
        public async static Task<List<gen_airlinesEntity>> get_gen_airlines()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_airlinesEntity> objlist = cacheManagerCache.Get<List<gen_airlinesEntity>>("set_gen_airlines");
            if (objlist != null)
            {
                objlist = await set_gen_airlines();
            }
            return objlist;
        }

        public async static Task<List<gen_buildingEntity>> set_gen_building()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_buildingEntity> gen_buildingList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_buildingEntity(new gen_buildingEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_buildingList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_building", objList);
            return gen_buildingList;
        }
        public async static Task<List<gen_buildingEntity>> get_gen_building()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_buildingEntity> objlist = cacheManagerCache.Get<List<gen_buildingEntity>>("set_gen_building");
            if (objlist != null)
            {
                objlist = await set_gen_building();
            }
            return objlist;
        }

        public async static Task<List<gen_okpEntity>> set_gen_okp()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_okpEntity> gen_okpList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_okpEntity(new gen_okpEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_okpList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_okp", objList);
            return gen_okpList;
        }
        public async static Task<List<gen_okpEntity>> get_gen_okp()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_okpEntity> objlist = cacheManagerCache.Get<List<gen_okpEntity>>("set_gen_okp");
            if (objlist != null)
            {
                objlist = await set_gen_okp();
            }
            return objlist;
        }
        public async static Task<List<gen_armsEntity>> set_gen_arms()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_armsEntity> gen_armsList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_armsEntity(new gen_armsEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_armsList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_arms", objList);
            return gen_armsList;
        }
        public async static Task<List<gen_armsEntity>> get_gen_arms()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_armsEntity> objlist = cacheManagerCache.Get<List<gen_armsEntity>>("set_gen_arms");
            if (objlist != null)
            {
                objlist = await set_gen_arms();
            }
            return objlist;
        }
        public async static Task<List<gen_bankEntity>> set_gen_bank()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_bankEntity> gen_bankList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_bankEntity(new gen_bankEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_bankList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_bank", objList);
            return gen_bankList;
        }
        public async static Task<List<gen_bankEntity>> get_gen_bank()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_bankEntity> objlist = cacheManagerCache.Get<List<gen_bankEntity>>("set_gen_bank");
            if (objlist != null)
            {
                objlist = await set_gen_bank();
            }
            return objlist;
        }

        public async static Task<List<gen_bankbranchEntity>> set_gen_bankbranch()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_bankbranchEntity> stp_organizationList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_bankbranchEntity(new gen_bankbranchEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in stp_organizationList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_bankbranch", objList);
            return stp_organizationList;
        }
        public async static Task<List<gen_bankbranchEntity>> get_gen_bankbranch()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_bankbranchEntity> objlist = cacheManagerCache.Get<List<gen_bankbranchEntity>>("set_gen_bankbranch");
            if (objlist != null)
            {
                objlist = await set_gen_bankbranch();
            }
            return objlist;
        }

        public async static Task<List<gen_filetypeEntity>> set_gen_filetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_filetypeEntity> gen_filetypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_filetypeEntity(new gen_filetypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_filetypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_filetype", objList);
            return gen_filetypeList;
        }
        public async static Task<List<gen_filetypeEntity>> get_gen_filetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_filetypeEntity> objlist = cacheManagerCache.Get<List<gen_filetypeEntity>>("set_gen_filetype");
            if (objlist != null)
            {
                objlist = await set_gen_filetype();
            }
            return objlist;
        }


        public async static Task<List<gen_relationshipEntity>> set_gen_relationship()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_relationshipEntity> gen_relationshipList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_relationshipEntity(new gen_relationshipEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_relationshipList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_relationship", objList);
            return gen_relationshipList;
        }
        public async static Task<List<gen_relationshipEntity>> get_gen_relationship()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_relationshipEntity> objlist = cacheManagerCache.Get<List<gen_relationshipEntity>>("set_gen_relationship");
            if (objlist != null)
            {
                objlist = await set_gen_relationship();
            }
            return objlist;
        }




        public async static Task<List<gen_bloodgroupEntity>> set_gen_bloodgroup()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_bloodgroupEntity> gen_bloodgroupList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_bloodgroupEntity(new gen_bloodgroupEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_bloodgroupList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_bloodgroup", objList);
            return gen_bloodgroupList;
        }
        public async static Task<List<gen_bloodgroupEntity>> get_gen_bloodgroup()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_bloodgroupEntity> objlist = cacheManagerCache.Get<List<gen_bloodgroupEntity>>("set_gen_bloodgroup");
            if (objlist != null)
            {
                objlist = await set_gen_bloodgroup();
            }
            return objlist;
        }


        public async static Task<List<gen_freedomfighttypeEntity>> set_gen_freedomfighttype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_freedomfighttypeEntity> gen_freedomfighttypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_freedomfighttypeEntity(new gen_freedomfighttypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_freedomfighttypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_freedomfighttype", objList);
            return gen_freedomfighttypeList;
        }
        public async static Task<List<gen_freedomfighttypeEntity>> get_gen_freedomfighttype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_freedomfighttypeEntity> objlist = cacheManagerCache.Get<List<gen_freedomfighttypeEntity>>("set_gen_freedomfighttype");
            if (objlist != null)
            {
                objlist = await set_gen_freedomfighttype();
            }
            return objlist;
        }


        public async static Task<List<gen_genderEntity>> set_gen_gender()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_genderEntity> gen_genderList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_genderEntity(new gen_genderEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_genderList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_gender", objList);
            return gen_genderList;
        }
        public async static Task<List<gen_genderEntity>> get_gen_gender()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_genderEntity> objlist = cacheManagerCache.Get<List<gen_genderEntity>>("set_gen_gender");
            if (objlist != null)
            {
                objlist = await set_gen_gender();
            }
            return objlist;
        }


        public async static Task<List<gen_issuetypeEntity>> set_gen_issuetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_issuetypeEntity> gen_issuetypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_issuetypeEntity(new gen_issuetypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_issuetypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_issuetype", objList);
            return gen_issuetypeList;
        }
        public async static Task<List<gen_issuetypeEntity>> get_gen_issuetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_issuetypeEntity> objlist = cacheManagerCache.Get<List<gen_issuetypeEntity>>("set_gen_issuetype");
            if (objlist != null)
            {
                objlist = await set_gen_issuetype();
            }
            return objlist;
        }

        public async static Task<List<gen_languageEntity>> set_gen_language()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_languageEntity> gen_languageList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_languageEntity(new gen_languageEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_languageList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_language", objList);
            return gen_languageList;
        }
        public async static Task<List<gen_languageEntity>> get_gen_language()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_languageEntity> objlist = cacheManagerCache.Get<List<gen_languageEntity>>("set_gen_language");
            if (objlist != null)
            {
                objlist = await set_gen_language();
            }
            return objlist;
        }

        public async static Task<List<gen_languageproficiencyEntity>> set_gen_languageproficiency()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_languageproficiencyEntity> gen_languageproficiencyList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_languageproficiencyEntity(new gen_languageproficiencyEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_languageproficiencyList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_languageproficiency", objList);
            return gen_languageproficiencyList;
        }
        public async static Task<List<gen_languageproficiencyEntity>> get_gen_languageproficiency()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_languageproficiencyEntity> objlist = cacheManagerCache.Get<List<gen_languageproficiencyEntity>>("set_gen_languageproficiency");
            if (objlist != null)
            {
                objlist = await set_gen_languageproficiency();
            }
            return objlist;
        }


        public async static Task<List<gen_maritalstatusEntity>> set_gen_maritalstatus()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_maritalstatusEntity> gen_maritalstatusList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_maritalstatusEntity(new gen_maritalstatusEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_maritalstatusList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_maritalstatus", objList);
            return gen_maritalstatusList;
        }
        public async static Task<List<gen_maritalstatusEntity>> get_gen_maritalstatus()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_maritalstatusEntity> objlist = cacheManagerCache.Get<List<gen_maritalstatusEntity>>("set_gen_maritalstatus");
            if (objlist != null)
            {
                objlist = await set_gen_maritalstatus();
            }
            return objlist;
        }


        public async static Task<List<gen_movementtypeEntity>> set_gen_movementtype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_movementtypeEntity> gen_movementtypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_movementtypeEntity(new gen_movementtypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_movementtypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_movementtype", objList);
            return gen_movementtypeList;
        }
        public async static Task<List<gen_movementtypeEntity>> get_gen_movementtype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_movementtypeEntity> objlist = cacheManagerCache.Get<List<gen_movementtypeEntity>>("set_gen_movementtype");
            if (objlist != null)
            {
                objlist = await set_gen_movementtype();
            }
            return objlist;
        }


        public async static Task<List<gen_penaltytypeEntity>> set_gen_penaltytype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_penaltytypeEntity> gen_penaltytypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_penaltytypeEntity(new gen_penaltytypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_penaltytypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_penaltytype", objList);
            return gen_penaltytypeList;
        }
        public async static Task<List<gen_penaltytypeEntity>> get_gen_penaltytype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_penaltytypeEntity> objlist = cacheManagerCache.Get<List<gen_penaltytypeEntity>>("set_gen_penaltytype");
            if (objlist != null)
            {
                objlist = await set_gen_penaltytype();
            }
            return objlist;
        }


        public async static Task<List<gen_promotiontypeEntity>> set_gen_promotiontype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_promotiontypeEntity> gen_promotiontypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_promotiontypeEntity(new gen_promotiontypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_promotiontypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_promotiontype", objList);
            return gen_promotiontypeList;
        }
        public async static Task<List<gen_promotiontypeEntity>> get_gen_promotiontype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_promotiontypeEntity> objlist = cacheManagerCache.Get<List<gen_promotiontypeEntity>>("set_gen_promotiontype");
            if (objlist != null)
            {
                objlist = await set_gen_promotiontype();
            }
            return objlist;
        }

        public async static Task<List<gen_ranktypeEntity>> set_gen_ranktype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_ranktypeEntity> gen_ranktypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_ranktypeEntity(new gen_ranktypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_ranktypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_ranktype", objList);
            return gen_ranktypeList;
        }
        public async static Task<List<gen_ranktypeEntity>> get_gen_ranktype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_ranktypeEntity> objlist = cacheManagerCache.Get<List<gen_ranktypeEntity>>("set_gen_ranktype");
            if (objlist != null)
            {
                objlist = await set_gen_ranktype();
            }
            return objlist;
        }

        public async static Task<List<gen_religionEntity>> set_gen_religion()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_religionEntity> gen_religionList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_religionEntity(new gen_religionEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_religionList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_religion", objList);
            return gen_religionList;
        }
        public async static Task<List<gen_religionEntity>> get_gen_religion()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_religionEntity> objlist = cacheManagerCache.Get<List<gen_religionEntity>>("set_gen_religion");
            if (objlist != null)
            {
                objlist = await set_gen_religion();
            }
            return objlist;
        }

        public async static Task<List<gen_servicestatusEntity>> set_gen_servicestatus()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_servicestatusEntity> gen_servicestatusList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_servicestatusEntity(new gen_servicestatusEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_servicestatusList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_servicestatus", objList);
            return gen_servicestatusList;
        }
        public async static Task<List<gen_servicestatusEntity>> get_gen_servicestatus()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_servicestatusEntity> objlist = cacheManagerCache.Get<List<gen_servicestatusEntity>>("set_gen_servicestatus");
            if (objlist != null)
            {
                objlist = await set_gen_servicestatus();
            }
            return objlist;
        }

        public async static Task<List<gen_leavetypeEntity>> set_gen_leavetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_leavetypeEntity> gen_leavetypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_gen_leavetypeEntity(new gen_leavetypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_leavetypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_leavetype", objList);
            return gen_leavetypeList;
        }
        public async static Task<List<gen_leavetypeEntity>> get_gen_leavetype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_leavetypeEntity> objlist = cacheManagerCache.Get<List<gen_leavetypeEntity>>("set_gen_leavetype");
            if (objlist != null)
            {
                objlist = await set_gen_leavetype();
            }
            return objlist;
        }

        public async static Task<List<owin_roleEntity>> set_owin_roleList()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_roleEntity> owin_roleList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_roleEntity(new owin_roleEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();
            List<KAFGenericComboEntity> objList = (from data in owin_roleList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_owin_role", objList);
            //  cacheManagerCache.Set("get_owin_role", owin_roleList);
            //HttpRuntime.Cache.Insert(owin_role[0], owin_roleList, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null);
            return owin_roleList;
        }
        private async static Task<List<owin_roleEntity>> get_owin_roleList()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_roleEntity> objlist = cacheManagerCache.Get<List<owin_roleEntity>>("set_owin_role");
            if (objlist != null)
            {
                objlist = await set_owin_roleList();
            }
            return objlist;
        }
        public async static Task<List<owin_reportroleEntity>> set_owin_reportroleList()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_reportroleEntity> owin_reportroleList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_reportroleEntity(new owin_reportroleEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();
            List<KAFGenericComboEntity> objList = (from data in owin_reportroleList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_owin_reportrole", objList);
            //  cacheManagerCache.Set("get_owin_reportrole", owin_reportroleList);
            //HttpRuntime.Cache.Insert(owin_reportrole[0], owin_reportroleList, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null);
            return owin_reportroleList;
        }
        private async static Task<List<owin_reportroleEntity>> get_owin_reportroleList()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_reportroleEntity> objlist = cacheManagerCache.Get<List<owin_reportroleEntity>>("set_owin_reportrole");
            if (objlist != null)
            {
                objlist = await set_owin_reportroleList();
            }
            return objlist;
        }
        public async static Task<List<owin_formactionEntity>> set_owin_formaction()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_formactionEntity> owin_formactionList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_formactionEntity(new owin_formactionEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();
            cacheManagerCache.Set("get_owin_formaction", owin_formactionList);
            //HttpRuntime.Cache.Insert(owin_formaction[0], owin_formactionList, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null);
            return owin_formactionList;
        }
        private async static Task<List<owin_formactionEntity>> get_owin_formaction()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_formactionEntity> objlist = cacheManagerCache.Get<List<owin_formactionEntity>>("get_owin_formaction");
            if (objlist != null)
            {
                objlist = await set_owin_formaction();
            }
            return objlist;
        }

        public async static Task<List<owin_forminfoEntity>> set_owin_forminfo()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_forminfoEntity> owin_forminfoList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_forminfoEntity(new owin_forminfoEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();
            cacheManagerCache.Set("set_owin_forminfo", owin_forminfoList);
            //HttpRuntime.Cache.Insert(owin_formainfo[0], owin_forminfoList, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null);
            return owin_forminfoList;
        }
        private async static Task<List<owin_forminfoEntity>> get_owin_forminfo()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<owin_forminfoEntity> objlist = cacheManagerCache.Get<List<owin_forminfoEntity>>("set_owin_forminfo");
            if (objlist != null)
            {
                objlist = await set_owin_forminfo();
            }
            return objlist;
        }


        public async static Task<List<stp_organizationEntity>> set_stp_organization()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<stp_organizationEntity> stp_organizationList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_stp_organizationEntity(new stp_organizationEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in stp_organizationList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_stp_organization", objList);
            return stp_organizationList;
        }

        public async static Task<List<stp_organizationEntity>> get_stp_organization()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<stp_organizationEntity> objlist = cacheManagerCache.Get<List<stp_organizationEntity>>("set_stp_organization");
            if (objlist != null)
            {
                objlist = await set_stp_organization();
            }
            return objlist;
        }


        public async static Task<List<stp_organizationentitytypeEntity>> set_stp_organizationentitytype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<stp_organizationentitytypeEntity> stp_organizationentitytypeList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFDataCache.GetFacadeCreate().GetforCache_stp_organizationentitytypeEntity(new stp_organizationentitytypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in stp_organizationentitytypeList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = data.comId,
                                                       comText = data.comText
                                                   }).ToList();
            cacheManagerCache.Set("set_stp_organizationentitytype", objList);
            return stp_organizationentitytypeList;
        }

        public async static Task<List<stp_organizationentitytypeEntity>> get_stp_organizationentitytype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<stp_organizationentitytypeEntity> objlist = cacheManagerCache.Get<List<stp_organizationentitytypeEntity>>("set_stp_organizationentitytype");
            if (objlist != null)
            {
                objlist = await set_stp_organizationentitytype();
            }
            return objlist;
        }


        public async static Task<List<SelectListItem>> set_stp_color()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<SelectListItem> workflow_templetsList = GetMedalForColor();
            List<KAFGenericComboEntity> objList = (from data in workflow_templetsList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = long.Parse(data.Value),
                                                       comText = data.Text
                                                   }).ToList();
            cacheManagerCache.Set("set_workflow_templets", objList);
            return workflow_templetsList;
        }

        public async static Task<List<SelectListItem>> get_stp_color()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<SelectListItem> objlist = cacheManagerCache.Get<List<SelectListItem>>("set_stp_color");
            if (objlist != null)
            {
                objlist = await set_stp_color();
            }
            return objlist;
        }


        public async static Task<List<gen_subunitEntity>> set_gen_subunit()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_subunitEntity> gen_subunitList = KAF.FacadeCreatorObjects.gen_subunitFCC.GetFacadeCreate().GetAll(new gen_subunitEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_subunitList
                                                   select new KAFGenericComboEntity
                                                   {
                                                       comId = Convert.ToInt64(data.subunitid),
                                                       comText = data.subunit,
                                                       comText2 = data.okpid.ToString()
                                                   }).ToList();
            cacheManagerCache.Set("set_gen_subunit", objList);
            return gen_subunitList;
        }
        public async static Task<List<gen_subunitEntity>> get_gen_subunit()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_subunitEntity> objlist = cacheManagerCache.Get<List<gen_subunitEntity>>("set_gen_subunit");
            if (objlist != null)
            {
                objlist = await set_gen_subunit();
            }
            return objlist;
        }


        public async static Task<List<gen_campEntity>> set_gen_camp()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_campEntity> gen_campList = KAF.FacadeCreatorObjects.gen_campFCC.GetFacadeCreate().GetAll(new gen_campEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_campList
                                            select new KAFGenericComboEntity
                                            {
                                                comId = Convert.ToInt64(data.campid),
                                                comText = data.campname,
                                                comText2 = data.okpid.ToString()
                                            }).ToList();
            cacheManagerCache.Set("set_gen_camp", objList);
            return gen_campList;
        }
        public async static Task<List<gen_campEntity>> get_gen_camp()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_campEntity> objlist = cacheManagerCache.Get<List<gen_campEntity>>("set_gen_camp");
            if (objlist != null)
            {
                objlist = await set_gen_camp();
            }
            return objlist;
        }


        public async static Task<List<gen_documenttypeEntity>> set_gen_documenttype()
        {
            ICache cacheManagerCache = new CacheManagerProvider();

            List<gen_documenttypeEntity> gen_campList = KAF.FacadeCreatorObjects.gen_documenttypeFCC.GetFacadeCreate().GetAll(new gen_documenttypeEntity { BaseSecurityParam = new SecurityCapsule() }).ToList();

            List<KAFGenericComboEntity> objList = (from data in gen_campList
                                            select new KAFGenericComboEntity
                                            {
                                                comId = Convert.ToInt64(data.doctypeid),
                                                comText = data.doctypename,
                                                //comText2 = data.okpid.ToString()
                                            }).ToList();
            cacheManagerCache.Set("set_gen_documenttype", objList);
            return gen_campList;
        }
        public async static Task<List<gen_documenttypeEntity>> get_Gen_DocumentType()
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            List<gen_documenttypeEntity> objlist = cacheManagerCache.Get<List<gen_documenttypeEntity>>("set_gen_documenttype");
            if (objlist != null)
            {
                objlist = await set_gen_documenttype();
            }
            return objlist;
        }


        public static List<SelectListItem> GetSecurityQuestions()
        {
            List<SelectListItem> obj = new List<SelectListItem>();

            obj.Add(new SelectListItem { Text = "Please Select", Value = "" });
            obj.Add(new SelectListItem { Text = "What was your favorite place?", Value = "What was your favorite place?" });
            obj.Add(new SelectListItem { Text = "Who is your favorite actor?", Value = "Who is your favorite actor?" });
            obj.Add(new SelectListItem { Text = "What is your pet name?", Value = "What is your pet name?" });


            return obj;
        }
        public static List<SelectListItem> GetProcessStatusType()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="", Text="Please Select"},
                new SelectListItem(){ Value="1", Text="Workflow Process"},
                new SelectListItem(){ Value="2", Text="Transaction"}
            };

            return list;
        }

        public static List<SelectListItem> GetUserType()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="", Text="Please Select"},
                new SelectListItem(){ Value="1", Text="Approval User"},
                new SelectListItem(){ Value="2", Text="CC User"},
                 new SelectListItem(){ Value="3", Text="Both"}
            };

            return list;
        }

        public static List<SelectListItem> GetPriorityList()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="", Text="Please Select"},
                new SelectListItem(){ Value="1", Text="Low"},
                new SelectListItem(){ Value="2", Text="Normal"},
                 new SelectListItem(){ Value="3", Text="High"}
            };

            return list;
        }

        //public static List<SelectListItem> GetMedalForList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Officer"},
        //        new SelectListItem(){ Value="2", Text="Jco/OR"},
        //         new SelectListItem(){ Value="3", Text="Civil"}
        //    };

        //    return list;
        //}

        //public static List<SelectListItem> GetNationalityDegreeForList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Mother Nationality Degree"},
        //        new SelectListItem(){ Value="2", Text="Wife Nationality Degree"}
        //    };

        //    return list;
        //}
        //public static List<SelectListItem> GetColorForList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Eye"},
        //        new SelectListItem(){ Value="2", Text="Skin"},
        //         new SelectListItem(){ Value="3", Text="Hair"}
        //    };

        //    return list;
        //}
        //public static List<SelectListItem> GetFatherStatusForList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Military Father"},
        //        new SelectListItem(){ Value="2", Text="Others Father"}
        //    };

        //    return list;
        //}

        public static List<SelectListItem> GetMedalForColor()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="", Text="Please Select"},
                new SelectListItem(){ Value="1", Text="Black"},
                new SelectListItem(){ Value="2", Text="White"},
                 new SelectListItem(){ Value="3", Text="Brown"},
                 new SelectListItem(){ Value="4", Text="Green"},
                 new SelectListItem(){ Value="5", Text="Blue"},
                 new SelectListItem(){ Value="6", Text="Dark Brown"},
            };

            return list;
        }

        //public static List<SelectListItem> GetACRForList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Military"},
        //        new SelectListItem(){ Value="2", Text="Civil"}
        //    };

        //    return list;
        //}

        //public static List<SelectListItem> GetPunishmentTypeList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="حكم"},
        //        new SelectListItem(){ Value="2", Text="عقوبة"}
        //    };

        //    return list;
        //}

        //public static List<SelectListItem> GetFatherStatusList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>() {
        //        new SelectListItem(){ Value="", Text="Please Select"},
        //        new SelectListItem(){ Value="1", Text="Father"},
        //        new SelectListItem(){ Value="2", Text="Other"}
        //    };

        //    return list;
        //}

        public static List<SelectListItem> GetModificationTypeList()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="-99", Text="Please Select"},
                new SelectListItem(){ Value="1", Text=" Extend"},
                new SelectListItem(){ Value="2", Text=" Reduce"},
                new SelectListItem(){ Value="3", Text="Cancel"}
            };

            return list;
        }
        public static List<SelectListItem> GetJoinRank()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="-99", Text="Please Select"},
                new SelectListItem(){ Value="1", Text=" Under 18"},
                new SelectListItem(){ Value="2", Text=" Above 18"}
            };

            return list;
        }
        public static List<SelectListItem> GetYearList()
        {
            List<SelectListItem> list = new List<SelectListItem>() {
                new SelectListItem(){ Value="", Text="Please Select"},
                //new SelectListItem(){ Value="1970", Text="1970"},
                //new SelectListItem(){ Value="1971", Text="1971"},
                //new SelectListItem(){ Value="1972", Text="1972"},
                //new SelectListItem(){ Value="1973", Text="1973"},
                //new SelectListItem(){ Value="1974", Text="1974"},
                //new SelectListItem(){ Value="1975", Text="1975"}, 
                //new SelectListItem(){ Value="1976", Text="1976"},
                //new SelectListItem(){ Value="1977", Text="1977"},
                //new SelectListItem(){ Value="1978", Text="1978"},
                //new SelectListItem(){ Value="1979", Text="1979"},
                new SelectListItem(){ Value="1980", Text="1980"},
                new SelectListItem(){ Value="1981", Text="1981"},
                new SelectListItem(){ Value="1982", Text="1982"},
                new SelectListItem(){ Value="1983", Text="1983"},
                new SelectListItem(){ Value="1984", Text="1984"},
                new SelectListItem(){ Value="1985", Text="1985"},
                new SelectListItem(){ Value="1986", Text="1986"},
                new SelectListItem(){ Value="1987", Text="1987"},
                new SelectListItem(){ Value="1988", Text="1988"},
                new SelectListItem(){ Value="1989", Text="1989"},
                new SelectListItem(){ Value="1990", Text="1990"},
                new SelectListItem(){ Value="1991", Text="1991"},
                new SelectListItem(){ Value="1992", Text="1992"},
                new SelectListItem(){ Value="1993", Text="1993"},
                new SelectListItem(){ Value="1994", Text="1994"},
                new SelectListItem(){ Value="1995", Text="1995"},
                new SelectListItem(){ Value="1996", Text="1996"},
                new SelectListItem(){ Value="1997", Text="1997"},
                new SelectListItem(){ Value="1998", Text="1998"},
                new SelectListItem(){ Value="1999", Text="1999"},
                new SelectListItem(){ Value="2000", Text="2000"},
                new SelectListItem(){ Value="2001", Text="2001"},
                new SelectListItem(){ Value="2002", Text="2002"},
                new SelectListItem(){ Value="2003", Text="2003"},
                new SelectListItem(){ Value="2004", Text="2004"},
                new SelectListItem(){ Value="2005", Text="2005"},
                new SelectListItem(){ Value="2006", Text="2006"},
                new SelectListItem(){ Value="2007", Text="2007"},
                new SelectListItem(){ Value="2008", Text="2008"},
                new SelectListItem(){ Value="2009", Text="2009"},
                new SelectListItem(){ Value="2010", Text="2010"},
                new SelectListItem(){ Value="2011", Text="2011"},
                new SelectListItem(){ Value="2012", Text="2012"},
                new SelectListItem(){ Value="2013", Text="2013"},
                new SelectListItem(){ Value="2014", Text="2014"},
                new SelectListItem(){ Value="2015", Text="2015"},
                new SelectListItem(){ Value="2016", Text="2016"},
                new SelectListItem(){ Value="2017", Text="2017"},
                new SelectListItem(){ Value="2018", Text="2018"},
                new SelectListItem(){ Value="2019", Text="2019"},
                new SelectListItem(){ Value="2020", Text="2020"},
                new SelectListItem(){ Value="2021", Text="2021"},
                new SelectListItem(){ Value="2022", Text="2022"},
                new SelectListItem(){ Value="2023", Text="2023"},
                new SelectListItem(){ Value="2024", Text="2024"},
                new SelectListItem(){ Value="2025", Text="2025"},
                new SelectListItem(){ Value="2026", Text="2026"},
                new SelectListItem(){ Value="2027", Text="2027"},
                new SelectListItem(){ Value="2028", Text="2028"},
                new SelectListItem(){ Value="2029", Text="2029"},
                new SelectListItem(){ Value="2030", Text="2030"},
                new SelectListItem(){ Value="2031", Text="2031"},
                new SelectListItem(){ Value="2032", Text="2032"},
                new SelectListItem(){ Value="2033", Text="2033"},
                new SelectListItem(){ Value="2034", Text="2034"},
                new SelectListItem(){ Value="2035", Text="2035"},
                new SelectListItem(){ Value="2036", Text="2036"},
                new SelectListItem(){ Value="2037", Text="2037"},
                new SelectListItem(){ Value="2038", Text="2038"},
                new SelectListItem(){ Value="2039", Text="2039"},
                new SelectListItem(){ Value="2040", Text="2040"}
            };
            return list;
        }


    }
}