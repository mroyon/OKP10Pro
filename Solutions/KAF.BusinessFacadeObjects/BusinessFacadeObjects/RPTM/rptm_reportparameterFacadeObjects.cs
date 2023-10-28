
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
    public sealed partial class rptm_reportparameterFacadeObjects : BaseFacade, Irptm_reportparameterFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "rptm_reportparameterFacadeObjects";
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

        public rptm_reportparameterFacadeObjects()
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

        ~rptm_reportparameterFacadeObjects()
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
		
		long Irptm_reportparameterFacadeObjects.Delete(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
            {
				return DataAccessFactory.Createrptm_reportparameterDataAccess().Delete(rptm_reportparameter);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_reportparameterFacade.Deleterptm_reportparameter"));
            }
        }
		
		long Irptm_reportparameterFacadeObjects.Update(rptm_reportparameterEntity rptm_reportparameter )
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().Update(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Irptm_reportparameterFacade.Updaterptm_reportparameter"));
            }
		}
		
		long Irptm_reportparameterFacadeObjects.Add(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().Add(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Irptm_reportparameterFacade.Addrptm_reportparameter"));
            }
		}
		
        long Irptm_reportparameterFacadeObjects.SaveList(List<rptm_reportparameterEntity> list)
        {
            try
            {
                IList<rptm_reportparameterEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<rptm_reportparameterEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<rptm_reportparameterEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createrptm_reportparameterDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_rptm_reportparameter"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<rptm_reportparameterEntity> Irptm_reportparameterFacadeObjects.GetAll(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().GetAll(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportparameterEntity> Irptm_reportparameterFacade.GetAllrptm_reportparameter"));
            }
		}
		
		IList<rptm_reportparameterEntity> Irptm_reportparameterFacadeObjects.GetAllByPages(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().GetAllByPages(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportparameterEntity> Irptm_reportparameterFacade.GetAllByPagesrptm_reportparameter"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        rptm_reportparameterEntity Irptm_reportparameterFacadeObjects.GetSingle(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().GetSingle(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("rptm_reportparameterEntity Irptm_reportparameterFacade.GetSinglerptm_reportparameter"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<rptm_reportparameterEntity> Irptm_reportparameterFacadeObjects.GAPgListView(rptm_reportparameterEntity rptm_reportparameter)
		{
			try
			{
				return DataAccessFactory.Createrptm_reportparameterDataAccess().GAPgListView(rptm_reportparameter);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<rptm_reportparameterEntity> Irptm_reportparameterFacade.GAPgListViewrptm_reportparameter"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}