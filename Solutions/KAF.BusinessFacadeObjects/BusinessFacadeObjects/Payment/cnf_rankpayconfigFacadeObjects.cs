
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
    public sealed partial class cnf_rankpayconfigFacadeObjects : BaseFacade, Icnf_rankpayconfigFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_rankpayconfigFacadeObjects";
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

        public cnf_rankpayconfigFacadeObjects()
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

        ~cnf_rankpayconfigFacadeObjects()
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
		
		long Icnf_rankpayconfigFacadeObjects.Delete(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
            {
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().Delete(cnf_rankpayconfig);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_rankpayconfigFacade.Deletecnf_rankpayconfig"));
            }
        }
		
		long Icnf_rankpayconfigFacadeObjects.Update(cnf_rankpayconfigEntity cnf_rankpayconfig )
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().Update(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_rankpayconfigFacade.Updatecnf_rankpayconfig"));
            }
		}
		
		long Icnf_rankpayconfigFacadeObjects.Add(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().Add(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_rankpayconfigFacade.Addcnf_rankpayconfig"));
            }
		}
		
        long Icnf_rankpayconfigFacadeObjects.SaveList(List<cnf_rankpayconfigEntity> list)
        {
            try
            {
                IList<cnf_rankpayconfigEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_rankpayconfigEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_rankpayconfigEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createcnf_rankpayconfigDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_rankpayconfig"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacadeObjects.GetAll(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().GetAll(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacade.GetAllcnf_rankpayconfig"));
            }
		}
		
		IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacadeObjects.GetAllByPages(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().GetAllByPages(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacade.GetAllByPagescnf_rankpayconfig"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        cnf_rankpayconfigEntity Icnf_rankpayconfigFacadeObjects.GetSingle(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().GetSingle(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_rankpayconfigEntity Icnf_rankpayconfigFacade.GetSinglecnf_rankpayconfig"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacadeObjects.GAPgListView(cnf_rankpayconfigEntity cnf_rankpayconfig)
		{
			try
			{
				return DataAccessFactory.Createcnf_rankpayconfigDataAccess().GAPgListView(cnf_rankpayconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_rankpayconfigEntity> Icnf_rankpayconfigFacade.GAPgListViewcnf_rankpayconfig"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}