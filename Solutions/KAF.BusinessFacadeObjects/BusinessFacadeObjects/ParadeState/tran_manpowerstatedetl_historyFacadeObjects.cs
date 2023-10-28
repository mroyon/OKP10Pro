
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
    public sealed partial class tran_manpowerstatedetl_historyFacadeObjects : BaseFacade, Itran_manpowerstatedetl_historyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_manpowerstatedetl_historyFacadeObjects";
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

        public tran_manpowerstatedetl_historyFacadeObjects()
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

        ~tran_manpowerstatedetl_historyFacadeObjects()
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
		
		long Itran_manpowerstatedetl_historyFacadeObjects.Delete(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
            {
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().Delete(tran_manpowerstatedetl_history);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetl_historyFacade.Deletetran_manpowerstatedetl_history"));
            }
        }
		
		long Itran_manpowerstatedetl_historyFacadeObjects.Update(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().Update(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetl_historyFacade.Updatetran_manpowerstatedetl_history"));
            }
		}
		
		long Itran_manpowerstatedetl_historyFacadeObjects.Add(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().Add(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetl_historyFacade.Addtran_manpowerstatedetl_history"));
            }
		}
		
        long Itran_manpowerstatedetl_historyFacadeObjects.SaveList(List<tran_manpowerstatedetl_historyEntity> list)
        {
            try
            {
                IList<tran_manpowerstatedetl_historyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_manpowerstatedetl_historyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_manpowerstatedetl_historyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_manpowerstatedetl_history"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacadeObjects.GetAll(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().GetAll(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacade.GetAlltran_manpowerstatedetl_history"));
            }
		}
		
		IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacadeObjects.GetAllByPages(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().GetAllByPages(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacade.GetAllByPagestran_manpowerstatedetl_history"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_manpowerstatedetl_historyEntity Itran_manpowerstatedetl_historyFacadeObjects.GetSingle(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().GetSingle(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_manpowerstatedetl_historyEntity Itran_manpowerstatedetl_historyFacade.GetSingletran_manpowerstatedetl_history"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacadeObjects.GAPgListView(tran_manpowerstatedetl_historyEntity tran_manpowerstatedetl_history)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetl_historyDataAccess().GAPgListView(tran_manpowerstatedetl_history);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetl_historyEntity> Itran_manpowerstatedetl_historyFacade.GAPgListViewtran_manpowerstatedetl_history"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}