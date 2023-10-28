
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
    public sealed partial class hr_reppassportinfodetlFacadeObjects : BaseFacade, Ihr_reppassportinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_reppassportinfodetlFacadeObjects";
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

        public hr_reppassportinfodetlFacadeObjects()
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

        ~hr_reppassportinfodetlFacadeObjects()
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
		
		long Ihr_reppassportinfodetlFacadeObjects.Delete(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().Delete(hr_reppassportinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfodetlFacade.Deletehr_reppassportinfodetl"));
            }
        }
		
		long Ihr_reppassportinfodetlFacadeObjects.Update(hr_reppassportinfodetlEntity hr_reppassportinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().Update(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfodetlFacade.Updatehr_reppassportinfodetl"));
            }
		}
		
		long Ihr_reppassportinfodetlFacadeObjects.Add(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().Add(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfodetlFacade.Addhr_reppassportinfodetl"));
            }
		}
		
        long Ihr_reppassportinfodetlFacadeObjects.SaveList(List<hr_reppassportinfodetlEntity> list)
        {
            try
            {
                IList<hr_reppassportinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_reppassportinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_reppassportinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_reppassportinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacadeObjects.GetAll(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().GetAll(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacade.GetAllhr_reppassportinfodetl"));
            }
		}
		
		IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacadeObjects.GetAllByPages(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().GetAllByPages(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacade.GetAllByPageshr_reppassportinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_reppassportinfodetlEntity Ihr_reppassportinfodetlFacadeObjects.GetSingle(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().GetSingle(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_reppassportinfodetlEntity Ihr_reppassportinfodetlFacade.GetSinglehr_reppassportinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacadeObjects.GAPgListView(hr_reppassportinfodetlEntity hr_reppassportinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfodetlDataAccess().GAPgListView(hr_reppassportinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfodetlEntity> Ihr_reppassportinfodetlFacade.GAPgListViewhr_reppassportinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}