
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
    public sealed partial class hr_arrivalinfodetlFacadeObjects : BaseFacade, Ihr_arrivalinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_arrivalinfodetlFacadeObjects";
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

        public hr_arrivalinfodetlFacadeObjects()
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

        ~hr_arrivalinfodetlFacadeObjects()
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
		
		long Ihr_arrivalinfodetlFacadeObjects.Delete(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().Delete(hr_arrivalinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfodetlFacade.Deletehr_arrivalinfodetl"));
            }
        }
		
		long Ihr_arrivalinfodetlFacadeObjects.Update(hr_arrivalinfodetlEntity hr_arrivalinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().Update(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfodetlFacade.Updatehr_arrivalinfodetl"));
            }
		}
		
		long Ihr_arrivalinfodetlFacadeObjects.Add(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().Add(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfodetlFacade.Addhr_arrivalinfodetl"));
            }
		}
		
        long Ihr_arrivalinfodetlFacadeObjects.SaveList(List<hr_arrivalinfodetlEntity> list)
        {
            try
            {
                IList<hr_arrivalinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_arrivalinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_arrivalinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_arrivalinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacadeObjects.GetAll(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().GetAll(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacade.GetAllhr_arrivalinfodetl"));
            }
		}
		
		IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacadeObjects.GetAllByPages(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().GetAllByPages(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacade.GetAllByPageshr_arrivalinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_arrivalinfodetlEntity Ihr_arrivalinfodetlFacadeObjects.GetSingle(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().GetSingle(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_arrivalinfodetlEntity Ihr_arrivalinfodetlFacade.GetSinglehr_arrivalinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacadeObjects.GAPgListView(hr_arrivalinfodetlEntity hr_arrivalinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfodetlDataAccess().GAPgListView(hr_arrivalinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfodetlEntity> Ihr_arrivalinfodetlFacade.GAPgListViewhr_arrivalinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}