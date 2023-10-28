using System;
using System.Collections.Generic;
using KAF.BusinessDataObjects;
using System.Data;
using System.Data.SqlClient;

using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;



namespace KAF.IDataAccessObjects.IDataAccessObjectsPartial
{
    public interface IKAFDataCacheDataAccessObjects
    {
        #region Small Data Set For LoadCombo


        IList<owin_roleEntity> GetforCache_roleEntity( owin_roleEntity objEntity);
        IList<owin_reportroleEntity> GetforCache_reportroleEntity(owin_reportroleEntity objEntity);
        IList<owin_formactionEntity> GetforCache_formactionEntity(owin_formactionEntity objEntity);
        IList<owin_forminfoEntity> GetforCache_forminfoEntity(owin_forminfoEntity objEntity);


        IList<gen_airlinesEntity> GetforCache_gen_airlinesEntity(gen_airlinesEntity objEntity);
        IList<gen_buildingEntity> GetforCache_gen_buildingEntity(gen_buildingEntity objEntity);
        IList<gen_okpEntity> GetforCache_gen_okpEntity(gen_okpEntity objEntity);


        IList<gen_armsEntity> GetforCache_gen_armsEntity(gen_armsEntity objEntity);
        IList<stp_organizationentitytypeEntity> GetforCache_stp_organizationentitytypeEntity(stp_organizationentitytypeEntity objEntity);

        IList<stp_organizationEntity> GetforCache_stp_organizationEntity(stp_organizationEntity objEntity);

        IList<gen_bankbranchEntity> GetforCache_gen_bankbranchEntity(gen_bankbranchEntity objEntity);
        IList<gen_bankEntity> GetforCache_gen_bankEntity(gen_bankEntity objEntity);
        IList<gen_filetypeEntity> GetforCache_gen_filetypeEntity(gen_filetypeEntity objEntity);
        IList<gen_relationshipEntity> GetforCache_gen_relationshipEntity(gen_relationshipEntity objEntity);


        IList<gen_bloodgroupEntity> GetforCache_gen_bloodgroupEntity(gen_bloodgroupEntity objEntity);
        IList<gen_freedomfighttypeEntity> GetforCache_gen_freedomfighttypeEntity(gen_freedomfighttypeEntity objEntity);
        IList<gen_genderEntity> GetforCache_gen_genderEntity(gen_genderEntity objEntity);
        IList<gen_issuetypeEntity> GetforCache_gen_issuetypeEntity(gen_issuetypeEntity objEntity);
        IList<gen_languageEntity> GetforCache_gen_languageEntity(gen_languageEntity objEntity);
        IList<gen_languageproficiencyEntity> GetforCache_gen_languageproficiencyEntity(gen_languageproficiencyEntity objEntity);
        IList<gen_maritalstatusEntity> GetforCache_gen_maritalstatusEntity(gen_maritalstatusEntity objEntity);
        IList<gen_movementtypeEntity> GetforCache_gen_movementtypeEntity(gen_movementtypeEntity objEntity);
        IList<gen_penaltytypeEntity> GetforCache_gen_penaltytypeEntity(gen_penaltytypeEntity objEntity);
        IList<gen_promotiontypeEntity> GetforCache_gen_promotiontypeEntity(gen_promotiontypeEntity objEntity);
        IList<gen_ranktypeEntity> GetforCache_gen_ranktypeEntity(gen_ranktypeEntity objEntity);
        IList<gen_religionEntity> GetforCache_gen_religionEntity(gen_religionEntity objEntity);
        IList<gen_servicestatusEntity> GetforCache_gen_servicestatusEntity(gen_servicestatusEntity objEntity);
        IList<gen_leavetypeEntity> GetforCache_gen_leavetypeEntity(gen_leavetypeEntity objEntity);
        #endregion
    }
}
