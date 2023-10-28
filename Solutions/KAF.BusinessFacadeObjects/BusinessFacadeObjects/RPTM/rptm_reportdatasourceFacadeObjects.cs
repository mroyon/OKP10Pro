
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
    public sealed partial class rptm_reportdatasourceFacadeObjects : BaseFacade, Irptm_reportdatasourceFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "rptm_reportdatasourceFacadeObjects";
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

        public rptm_reportdatasourceFacadeObjects()
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

        ~rptm_reportdatasourceFacadeObjects()
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
		
		long Irptm_reportdatasourceFacadeObjects.Delete(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
            {
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().Delete(rptm_reportdatasource);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_reportdatasourceFacade.Deleterptm_reportdatasource"));
            }
        }
		
		long Irptm_reportdatasourceFacadeObjects.Update(rptm_reportdatasourceEntity rptm_reportdatasource )
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().Update(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Irptm_reportdatasourceFacade.Updaterptm_reportdatasource"));
            }
		}
		
		long Irptm_reportdatasourceFacadeObjects.Add(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().Add(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_reportdatasourceFacade.Addrptm_reportdatasource"));
            }
		}
		
        long Irptm_reportdatasourceFacadeObjects.SaveList(List<rptm_reportdatasourceEntity> list)
        {
            try
            {
                IList<rptm_reportdatasourceEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportdatasourceEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportdatasourceEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createrptm_reportdatasourceDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_rptm_reportdatasource"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacadeObjects.GetAll(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().GetAll(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacade.GetAllrptm_reportdatasource"));
            }
		}
		
		IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacadeObjects.GetAllByPages(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().GetAllByPages(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacade.GetAllByPagesrptm_reportdatasource"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        rptm_reportdatasourceEntity Irptm_reportdatasourceFacadeObjects.GetSingle(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().GetSingle(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("rptm_reportdatasourceEntity Irptm_reportdatasourceFacade.GetSinglerptm_reportdatasource"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacadeObjects.GAPgListView(rptm_reportdatasourceEntity rptm_reportdatasource)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportdatasourceDataAccess().GAPgListView(rptm_reportdatasource);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportdatasourceEntity> Irptm_reportdatasourceFacade.GAPgListViewrptm_reportdatasource"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}