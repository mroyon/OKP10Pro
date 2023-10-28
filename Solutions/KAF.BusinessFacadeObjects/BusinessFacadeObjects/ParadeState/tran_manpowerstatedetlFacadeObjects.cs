
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
    public sealed partial class tran_manpowerstatedetlFacadeObjects : BaseFacade, Itran_manpowerstatedetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_manpowerstatedetlFacadeObjects";
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

        public tran_manpowerstatedetlFacadeObjects()
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

        ~tran_manpowerstatedetlFacadeObjects()
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
		
		long Itran_manpowerstatedetlFacadeObjects.Delete(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
            {
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().Delete(tran_manpowerstatedetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetlFacade.Deletetran_manpowerstatedetl"));
            }
        }
		
		long Itran_manpowerstatedetlFacadeObjects.Update(tran_manpowerstatedetlEntity tran_manpowerstatedetl )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().Update(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetlFacade.Updatetran_manpowerstatedetl"));
            }
		}
		
		long Itran_manpowerstatedetlFacadeObjects.Add(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().Add(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstatedetlFacade.Addtran_manpowerstatedetl"));
            }
		}
		
        long Itran_manpowerstatedetlFacadeObjects.SaveList(List<tran_manpowerstatedetlEntity> list)
        {
            try
            {
                IList<tran_manpowerstatedetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_manpowerstatedetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_manpowerstatedetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_manpowerstatedetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacadeObjects.GetAll(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().GetAll(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacade.GetAlltran_manpowerstatedetl"));
            }
		}
		
		IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacadeObjects.GetAllByPages(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().GetAllByPages(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacade.GetAllByPagestran_manpowerstatedetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_manpowerstatedetlEntity Itran_manpowerstatedetlFacadeObjects.GetSingle(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().GetSingle(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_manpowerstatedetlEntity Itran_manpowerstatedetlFacade.GetSingletran_manpowerstatedetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacadeObjects.GAPgListView(tran_manpowerstatedetlEntity tran_manpowerstatedetl)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstatedetlDataAccess().GAPgListView(tran_manpowerstatedetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstatedetlEntity> Itran_manpowerstatedetlFacade.GAPgListViewtran_manpowerstatedetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}