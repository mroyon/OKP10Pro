
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
    public sealed partial class tran_manpowerstate_historyFacadeObjects : BaseFacade, Itran_manpowerstate_historyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_manpowerstate_historyFacadeObjects";
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

        public tran_manpowerstate_historyFacadeObjects()
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

        ~tran_manpowerstate_historyFacadeObjects()
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
		
		long Itran_manpowerstate_historyFacadeObjects.Delete(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
            {
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().Delete(tran_manpowerstate_history);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstate_historyFacade.Deletetran_manpowerstate_history"));
            }
        }
		
		long Itran_manpowerstate_historyFacadeObjects.Update(tran_manpowerstate_historyEntity tran_manpowerstate_history )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().Update(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstate_historyFacade.Updatetran_manpowerstate_history"));
            }
		}
		
		long Itran_manpowerstate_historyFacadeObjects.Add(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().Add(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstate_historyFacade.Addtran_manpowerstate_history"));
            }
		}
		
        long Itran_manpowerstate_historyFacadeObjects.SaveList(List<tran_manpowerstate_historyEntity> list)
        {
            try
            {
                IList<tran_manpowerstate_historyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_manpowerstate_historyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_manpowerstate_historyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_manpowerstate_history"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacadeObjects.GetAll(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().GetAll(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacade.GetAlltran_manpowerstate_history"));
            }
		}
		
		IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacadeObjects.GetAllByPages(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().GetAllByPages(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacade.GetAllByPagestran_manpowerstate_history"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_manpowerstate_historyEntity Itran_manpowerstate_historyFacadeObjects.GetSingle(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().GetSingle(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_manpowerstate_historyEntity Itran_manpowerstate_historyFacade.GetSingletran_manpowerstate_history"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacadeObjects.GAPgListView(tran_manpowerstate_historyEntity tran_manpowerstate_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().GAPgListView(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstate_historyEntity> Itran_manpowerstate_historyFacade.GAPgListViewtran_manpowerstate_history"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_manpowerstate_historyFacadeObjects.UpdateReviewed(tran_manpowerstate_historyEntity tran_manpowerstate_history )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstate_historyDataAccess().UpdateReviewed(tran_manpowerstate_history);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstate_historyFacade.UpdateReviewedtran_manpowerstate_history"));
            }
		}
        #endregion 
    
        #endregion
	}
}