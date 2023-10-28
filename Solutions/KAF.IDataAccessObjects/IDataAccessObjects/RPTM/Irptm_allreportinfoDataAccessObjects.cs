using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
    public partial interface Irptm_allreportinfoDataAccessObjects
    {

        #region Save Update Delete List Single Entity	

        long Add(rptm_allreportinfoEntity rptm_allreportinfo);

        long Update(rptm_allreportinfoEntity rptm_allreportinfo);

        long Delete(rptm_allreportinfoEntity rptm_allreportinfo);

        long SaveList(IList<rptm_allreportinfoEntity> listAdded, IList<rptm_allreportinfoEntity> listUpdated, IList<rptm_allreportinfoEntity> listDeleted);

        #endregion Save Update Delete List


        #region GetAll	

        IList<rptm_allreportinfoEntity> GetAll(rptm_allreportinfoEntity rptm_allreportinfo);

        IList<rptm_allreportinfoEntity> GetAllByPages(rptm_allreportinfoEntity rptm_allreportinfo);

        #endregion GetAll

        #region SaveMasterDetails
        long SaveMasterDetrptm_reportdatasource(rptm_allreportinfoEntity masterEntity, IList<rptm_reportdatasourceEntity> listAdded, IList<rptm_reportdatasourceEntity> listUpdated, IList<rptm_reportdatasourceEntity> listDeleted);

        long SaveMasterDetrptm_reportparameter(rptm_allreportinfoEntity masterEntity, IList<rptm_reportparameterEntity> listAdded, IList<rptm_reportparameterEntity> listUpdated, IList<rptm_reportparameterEntity> listDeleted);

        long SaveMasterDetrptm_allreportinfo(rptm_allreportinfoEntity masterEntity, IList<rptm_reportdatasourceEntity> listAdded, IList<rptm_reportdatasourceEntity> listUpdated, IList<rptm_reportdatasourceEntity> listDeleted, IList<rptm_reportparameterEntity> secondlistAdded, IList<rptm_reportparameterEntity> secondlistUpdated, IList<rptm_reportparameterEntity> secondlistDeleted);

        #endregion SaveMasterDetails

        #region Simple load Single Row
        rptm_allreportinfoEntity GetSingle(rptm_allreportinfoEntity rptm_allreportinfo);
        #endregion

        #region ForListView Paged Method
        IList<rptm_allreportinfoEntity> GAPgListView(rptm_allreportinfoEntity rptm_allreportinfo);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

    }
}
