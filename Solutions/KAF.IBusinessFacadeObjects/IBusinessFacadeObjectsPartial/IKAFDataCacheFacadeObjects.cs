using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using KAF.BusinessDataObjects;

using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial
{
    [ServiceContract(Name = "IKAFDataCacheFacadeObjects")]
    public interface IKAFDataCacheFacadeObjects : IDisposable
    {
        #region Small Data Set For LoadCombo
        [OperationContract]
        IList<owin_roleEntity> GetforCache_roleEntity(owin_roleEntity objEntity);

        [OperationContract]
        IList<owin_reportroleEntity> GetforCache_reportroleEntity(owin_reportroleEntity objEntity);

        [OperationContract]
        IList<owin_formactionEntity> GetforCache_formactionEntity(owin_formactionEntity objEntity);
        [OperationContract]
        IList<owin_forminfoEntity> GetforCache_forminfoEntity(owin_forminfoEntity objEntity);



        //[OperationContract]
        //IList<workflow_processinfoEntity> GetforCache_workflow_processinfoEntity(workflow_processinfoEntity objEntity);

        [OperationContract]
        IList<gen_airlinesEntity> GetforCache_gen_airlinesEntity(gen_airlinesEntity objEntity);

        [OperationContract]
        IList<gen_buildingEntity> GetforCache_gen_buildingEntity(gen_buildingEntity objEntity);

        [OperationContract]
        IList<gen_okpEntity> GetforCache_gen_okpEntity(gen_okpEntity objEntity);


        [OperationContract]
        IList<gen_armsEntity> GetforCache_gen_armsEntity(gen_armsEntity objEntity);

        [OperationContract]
        IList<stp_organizationentitytypeEntity> GetforCache_stp_organizationentitytypeEntity(stp_organizationentitytypeEntity objEntity);

        [OperationContract]
        IList<stp_organizationEntity> GetforCache_stp_organizationEntity(stp_organizationEntity objEntity);

        [OperationContract]
        IList<gen_bankEntity> GetforCache_gen_bankEntity(gen_bankEntity objEntity);
        [OperationContract]
        IList<gen_bankbranchEntity> GetforCache_gen_bankbranchEntity(gen_bankbranchEntity objEntity);
        [OperationContract]
        IList<gen_filetypeEntity> GetforCache_gen_filetypeEntity(gen_filetypeEntity objEntity);


        [OperationContract]
        IList<gen_relationshipEntity> GetforCache_gen_relationshipEntity(gen_relationshipEntity objEntity);

        [OperationContract]
        IList<gen_bloodgroupEntity> GetforCache_gen_bloodgroupEntity(gen_bloodgroupEntity objEntity);

        [OperationContract]
        IList<gen_freedomfighttypeEntity> GetforCache_gen_freedomfighttypeEntity(gen_freedomfighttypeEntity objEntity);

        [OperationContract]
        IList<gen_genderEntity> GetforCache_gen_genderEntity(gen_genderEntity objEntity);

        [OperationContract]
        IList<gen_issuetypeEntity> GetforCache_gen_issuetypeEntity(gen_issuetypeEntity objEntity);

        [OperationContract]
        IList<gen_languageEntity> GetforCache_gen_languageEntity(gen_languageEntity objEntity);

        [OperationContract]
        IList<gen_languageproficiencyEntity> GetforCache_gen_languageproficiencyEntity(gen_languageproficiencyEntity objEntity);

        [OperationContract]
        IList<gen_maritalstatusEntity> GetforCache_gen_maritalstatusEntity(gen_maritalstatusEntity objEntity);

        [OperationContract]
        IList<gen_movementtypeEntity> GetforCache_gen_movementtypeEntity(gen_movementtypeEntity objEntity);

        [OperationContract]
        IList<gen_penaltytypeEntity> GetforCache_gen_penaltytypeEntity(gen_penaltytypeEntity objEntity);

        [OperationContract]
        IList<gen_promotiontypeEntity> GetforCache_gen_promotiontypeEntity(gen_promotiontypeEntity objEntity);

        [OperationContract]
        IList<gen_ranktypeEntity> GetforCache_gen_ranktypeEntity(gen_ranktypeEntity objEntity);

        [OperationContract]
        IList<gen_religionEntity> GetforCache_gen_religionEntity(gen_religionEntity objEntity);

        [OperationContract]
        IList<gen_servicestatusEntity> GetforCache_gen_servicestatusEntity(gen_servicestatusEntity objEntity);
        [OperationContract]
        IList<gen_leavetypeEntity> GetforCache_gen_leavetypeEntity(gen_leavetypeEntity objEntity);

        #endregion
    }
}
