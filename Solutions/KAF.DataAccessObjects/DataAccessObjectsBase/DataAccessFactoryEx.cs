using System.Diagnostics;
using KAF.AppConfiguration.Configuration;
using KAF.IDataAccessObjects;
using KAF.DataAccessObjects;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;
using KAF.DataAccessObjects.DataAccessObjectsPartial;

namespace KAF.DataAccessObjects
{
    public partial class DataAccessFactory
    {

        #region SecKAFUserSecurityDataAccess
        [DebuggerStepThrough()]
        public override IKAFUserSecurityDataAccess CreateKAFUserSecurityDataAccess()
        {
            string type = typeof(KAFUserSecurityDataAccess).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KAFUserSecurityDataAccess(CurrentContext);
            }
            return (IKAFUserSecurityDataAccess)CurrentContext[type];
        }
        #endregion SecKAFUserSecurityDataAccess

        #region SelectTwoDataAccessObjects
        [DebuggerStepThrough()]
        public override ISelectTwoDataAccessObjects CreateSelectTwoDataAccessObjects()
        {
            string type = typeof(SelectTwoDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new SelectTwoDataAccessObjects(CurrentContext);
            }
            return (ISelectTwoDataAccessObjects)CurrentContext[type];
        }
        #endregion SelectTwoDataAccessObjects

        #region KAFDataCacheDataAccessObjects
        [DebuggerStepThrough()]
        public override IKAFDataCacheDataAccessObjects CreateKAFDataCacheDataAccessObjects()
        {
            string type = typeof(KAFDataCacheDataAccessObjects).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KAFDataCacheDataAccessObjects(CurrentContext);
            }
            return (IKAFDataCacheDataAccessObjects)CurrentContext[type];
        }
        #endregion KAFDataCacheDataAccessObjects


        #region ReportingExtension
        [DebuggerStepThrough()]
        public override IReportExtensionDataAccess CreateReportExtensionDataAccess()
        {
            string type = typeof(ReportExtensionDataAccess).ToString();
            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ReportExtensionDataAccess(CurrentContext);
            }
            return (ReportExtensionDataAccess)CurrentContext[type];
        }
        #endregion ReportingExtension
    }
}
