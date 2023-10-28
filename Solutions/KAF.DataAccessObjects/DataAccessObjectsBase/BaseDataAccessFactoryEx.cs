using System.Diagnostics;
using System;
using KAF.AppConfiguration.Configuration;
using KAF.IDataAccessObjects;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;

namespace KAF.DataAccessObjects
{
    public abstract partial class BaseDataAccessFactory
    {

        #region IKAFUserSecurityDataAccess
        public abstract IKAFUserSecurityDataAccess CreateKAFUserSecurityDataAccess();
        #endregion IKAFUserSecurityDataAccess


        #region ISelectTwoDataAccessObjects
        public abstract ISelectTwoDataAccessObjects CreateSelectTwoDataAccessObjects();
        #endregion ISelectTwoDataAccessObjects

        #region IKAFDataCacheDataAccessObjects
        public abstract IKAFDataCacheDataAccessObjects CreateKAFDataCacheDataAccessObjects();
        #endregion IKAFDataCacheDataAccessObjects

        #region IReportExtensionDataAccess
        public abstract IReportExtensionDataAccess CreateReportExtensionDataAccess();
        #endregion IReportExtensionDataAccess

    }
}
