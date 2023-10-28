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
    [ServiceContract(Name = "ISelectTwoFacadeObjects")]
    public interface ISelectTwoFacadeObjects : IDisposable
    {

        //[OperationContract]
        //IList<gen_militarypossitiondetlEntity> GetPaged_Gen_MilitaryPossitionDetl(gen_militarypossitiondetlEntity objEntity);



        [OperationContract]
        IList<stp_organizationentityEntity> GetPaged_Stp_OrganizationEntity(stp_organizationentityEntity objEntity);

        [OperationContract]
        IList<gen_govcityEntity> GetPaged_Gen_GovCity(gen_govcityEntity objEntity);

        [OperationContract]
        IList<gen_countryEntity> GetPaged_Gen_Country(gen_countryEntity objEntity);

        [OperationContract]
        IList<gen_divisiondistrictEntity> GetPaged_Gen_District(gen_divisiondistrictEntity objEntity);

        [OperationContract]
        IList<gen_rankEntity> GetPaged_Gen_Rank(gen_rankEntity objEntity);

        [OperationContract]
        IList<gen_tradeEntity> GetPaged_Gen_Trade(gen_tradeEntity objEntity);

        [OperationContract]
        IList<gen_thanaEntity> GetPaged_Gen_Thana(gen_thanaEntity objEntity);

        [OperationContract]
        IList<stp_organizationEntity> GetPaged_Stp_Organization(stp_organizationEntity objEntity);
    }
}