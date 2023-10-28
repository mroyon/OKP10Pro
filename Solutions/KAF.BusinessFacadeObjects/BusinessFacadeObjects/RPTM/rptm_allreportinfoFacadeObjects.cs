
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using KAF.BusinessDataObjects;
using KAF.AppConfiguration.Configuration;
using KAF.DataAccessObjects;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
namespace KAF.BusinessFacadeObjects
{
    public sealed partial class rptm_allreportinfoFacadeObjects : BaseFacade, Irptm_allreportinfoFacadeObjects
    {

        #region Instance Variables
        private string ClassName = "rptm_allreportinfoFacadeObjects";
        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public rptm_allreportinfoFacadeObjects()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~rptm_allreportinfoFacadeObjects()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion

        #region Business Facade

        #region Save Update Delete List	

        long Irptm_allreportinfoFacadeObjects.Delete(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().Delete(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_allreportinfoFacade.Deleterptm_allreportinfo"));
            }
        }

        long Irptm_allreportinfoFacadeObjects.Update(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().Update(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_allreportinfoFacade.Updaterptm_allreportinfo"));
            }
        }

        long Irptm_allreportinfoFacadeObjects.Add(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().Add(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_allreportinfoFacade.Addrptm_allreportinfo"));
            }
        }

        long Irptm_allreportinfoFacadeObjects.SaveList(List<rptm_allreportinfoEntity> list)
        {
            try
            {
                IList<rptm_allreportinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_allreportinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_allreportinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                return DataAccessFactory.Createrptm_allreportinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_rptm_allreportinfo"));
            }
        }

        #endregion Save Update Delete List	

        #region GetAll

        IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacadeObjects.GetAll(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().GetAll(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacade.GetAllrptm_allreportinfo"));
            }
        }

        IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacadeObjects.GetAllByPages(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().GetAllByPages(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacade.GetAllByPagesrptm_allreportinfo"));
            }
        }

        #endregion GetAll

        #region FOR Master Details SAVE	

        long Irptm_allreportinfoFacadeObjects.SaveMasterDetrptm_reportdatasource(rptm_allreportinfoEntity Master, List<rptm_reportdatasourceEntity> DetailList)
        {
            try
            {
                DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                if (Master.CurrentState == BaseEntity.EntityState.Deleted)
                    DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                IList<rptm_reportdatasourceEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportdatasourceEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportdatasourceEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().SaveMasterDetrptm_reportdatasource(Master, listAdded, listUpdated, listDeleted);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetrptm_reportdatasource"));
            }
        }


        long Irptm_allreportinfoFacadeObjects.SaveMasterDetrptm_reportparameter(rptm_allreportinfoEntity Master, List<rptm_reportparameterEntity> DetailList)
        {
            try
            {
                DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                if (Master.CurrentState == BaseEntity.EntityState.Deleted)
                    DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                IList<rptm_reportparameterEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportparameterEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportparameterEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().SaveMasterDetrptm_reportparameter(Master, listAdded, listUpdated, listDeleted);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetrptm_reportparameter"));
            }
        }

        long Irptm_allreportinfoFacadeObjects.SaveMasterDetrptm_allreportinfo(rptm_allreportinfoEntity Master, List<rptm_reportdatasourceEntity> DetailList, List<rptm_reportparameterEntity> SecondDetailList)
        {
            try
            {
                DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                if (Master.CurrentState == BaseEntity.EntityState.Deleted)
                    DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                IList<rptm_reportdatasourceEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportdatasourceEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportdatasourceEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                IList<rptm_reportparameterEntity> secondlistAdded = SecondDetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportparameterEntity> secondlistUpdated = SecondDetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportparameterEntity> secondlistDeleted = SecondDetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                return DataAccessFactory.Createrptm_allreportinfoDataAccess().SaveMasterDetrptm_allreportinfo(Master, listAdded, listUpdated, listDeleted, secondlistAdded, secondlistUpdated, secondlistDeleted);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetrptm_allreportinfo"));
            }
        }


        #endregion


        #region Simple load Single Row
        rptm_allreportinfoEntity Irptm_allreportinfoFacadeObjects.GetSingle(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().GetSingle(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("rptm_allreportinfoEntity Irptm_allreportinfoFacade.GetSinglerptm_allreportinfo"));
            }
        }
        #endregion

        #region ForListView Paged Method
        IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacadeObjects.GAPgListView(rptm_allreportinfoEntity rptm_allreportinfo)
        {
            try
            {
                return DataAccessFactory.Createrptm_allreportinfoDataAccess().GAPgListView(rptm_allreportinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_allreportinfoEntity> Irptm_allreportinfoFacade.GAPgListViewrptm_allreportinfo"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #endregion
    }
}