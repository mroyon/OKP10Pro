

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Irptm_allreportinfoFacadeObjects")]
    public partial interface Irptm_allreportinfoFacadeObjects : IDisposable
    {
        #region Save Update Delete List 


        [OperationContract]
        long Add(rptm_allreportinfoEntity rptm_allreportinfo);

        [OperationContract]
        long Update(rptm_allreportinfoEntity rptm_allreportinfo);

        [OperationContract]
        long Delete(rptm_allreportinfoEntity rptm_allreportinfo);

        [OperationContract]
        long SaveList(List<rptm_allreportinfoEntity> list);


        #endregion Save Update Delete List

        #region GetAll	

        [OperationContract]
        IList<rptm_allreportinfoEntity> GetAll(rptm_allreportinfoEntity rptm_allreportinfo);

        [OperationContract]
        IList<rptm_allreportinfoEntity> GetAllByPages(rptm_allreportinfoEntity rptm_allreportinfo);

        #endregion GetAll

        #region Save Master/Details	

        [OperationContract]
        long SaveMasterDetrptm_reportdatasource(rptm_allreportinfoEntity Master, List<rptm_reportdatasourceEntity> DetailList);

        [OperationContract]
        long SaveMasterDetrptm_reportparameter(rptm_allreportinfoEntity Master, List<rptm_reportparameterEntity> DetailList);

        [OperationContract]
        long SaveMasterDetrptm_allreportinfo(rptm_allreportinfoEntity Master, List<rptm_reportdatasourceEntity> DetailList, List<rptm_reportparameterEntity> SecondDetailList);

        #endregion Save Master/Details	

        #region Simple load Single Row
        [OperationContract]
        rptm_allreportinfoEntity GetSingle(rptm_allreportinfoEntity rptm_allreportinfo);
        #endregion

        #region ForListView Paged Method
        [OperationContract]
        IList<rptm_allreportinfoEntity> GAPgListView(rptm_allreportinfoEntity rptm_allreportinfo);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion
    }
}
