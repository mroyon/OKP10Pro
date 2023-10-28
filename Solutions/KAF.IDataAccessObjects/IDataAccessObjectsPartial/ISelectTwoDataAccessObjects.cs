using System;
using System.Collections.Generic;
using KAF.BusinessDataObjects;
using System.Data;
using System.Data.SqlClient;

using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;



namespace KAF.IDataAccessObjects.IDataAccessObjectsPartial
{
    public interface ISelectTwoDataAccessObjects
    {

        #region LARGE DATA SET FOR SELECT - 2

        IList<stp_organizationentityEntity> GetPaged_Stp_OrganizationEntity(stp_organizationentityEntity objEntity);
        IList<gen_govcityEntity> GetPaged_Gen_GovCity(gen_govcityEntity objEntity);
        IList<gen_countryEntity> GetPaged_Gen_Country(gen_countryEntity objEntity);
        IList<gen_divisiondistrictEntity> GetPaged_Gen_District(gen_divisiondistrictEntity objEntity);

        IList<gen_rankEntity> GetPaged_Gen_Rank(gen_rankEntity objEntity);
        IList<gen_tradeEntity> GetPaged_Gen_Trade(gen_tradeEntity objEntity);

        IList<gen_thanaEntity> GetPaged_Gen_Thana(gen_thanaEntity objEntity);

        IList<stp_organizationEntity> GetPaged_Stp_Organization(stp_organizationEntity objEntity);

        #endregion LARGE DATA SET FOR SELECT - 2

    }
}
