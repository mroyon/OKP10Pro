
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
    public sealed partial class tran_cuttinginfodetlFacadeObjects : BaseFacade, Itran_cuttinginfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_cuttinginfodetlFacadeObjects";
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

        public tran_cuttinginfodetlFacadeObjects()
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

        ~tran_cuttinginfodetlFacadeObjects()
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
		
		long Itran_cuttinginfodetlFacadeObjects.Delete(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
            {
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().Delete(tran_cuttinginfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfodetlFacade.Deletetran_cuttinginfodetl"));
            }
        }
		
		long Itran_cuttinginfodetlFacadeObjects.Update(tran_cuttinginfodetlEntity tran_cuttinginfodetl )
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().Update(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfodetlFacade.Updatetran_cuttinginfodetl"));
            }
		}
		
		long Itran_cuttinginfodetlFacadeObjects.Add(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().Add(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfodetlFacade.Addtran_cuttinginfodetl"));
            }
		}
		
        long Itran_cuttinginfodetlFacadeObjects.SaveList(List<tran_cuttinginfodetlEntity> list)
        {
            try
            {
                IList<tran_cuttinginfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_cuttinginfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_cuttinginfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_cuttinginfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacadeObjects.GetAll(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().GetAll(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacade.GetAlltran_cuttinginfodetl"));
            }
		}
		
		IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacadeObjects.GetAllByPages(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().GetAllByPages(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacade.GetAllByPagestran_cuttinginfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_cuttinginfodetlEntity Itran_cuttinginfodetlFacadeObjects.GetSingle(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().GetSingle(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_cuttinginfodetlEntity Itran_cuttinginfodetlFacade.GetSingletran_cuttinginfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacadeObjects.GAPgListView(tran_cuttinginfodetlEntity tran_cuttinginfodetl)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().GAPgListView(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfodetlEntity> Itran_cuttinginfodetlFacade.GAPgListViewtran_cuttinginfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_cuttinginfodetlFacadeObjects.UpdateReviewed(tran_cuttinginfodetlEntity tran_cuttinginfodetl )
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfodetlDataAccess().UpdateReviewed(tran_cuttinginfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfodetlFacade.UpdateReviewedtran_cuttinginfodetl"));
            }
		}
        #endregion 
    
        #endregion
	}
}