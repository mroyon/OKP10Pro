
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
    public sealed partial class hr_basicfileFacadeObjects : BaseFacade, Ihr_basicfileFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_basicfileFacadeObjects";
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

        public hr_basicfileFacadeObjects()
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

        ~hr_basicfileFacadeObjects()
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
		
		long Ihr_basicfileFacadeObjects.Delete(hr_basicfileEntity hr_basicfile)
		{
			try
            {
				return DataAccessFactory.Createhr_basicfileDataAccess().Delete(hr_basicfile);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_basicfileFacade.Deletehr_basicfile"));
            }
        }
		
		long Ihr_basicfileFacadeObjects.Update(hr_basicfileEntity hr_basicfile )
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().Update(hr_basicfile);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_basicfileFacade.Updatehr_basicfile"));
            }
		}
		
		long Ihr_basicfileFacadeObjects.Add(hr_basicfileEntity hr_basicfile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().Add(hr_basicfile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_basicfileFacade.Addhr_basicfile"));
            }
		}
		
        long Ihr_basicfileFacadeObjects.SaveList(List<hr_basicfileEntity> list)
        {
            try
            {
                IList<hr_basicfileEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_basicfileEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_basicfileEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_basicfileDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_basicfile"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_basicfileEntity> Ihr_basicfileFacadeObjects.GetAll(hr_basicfileEntity hr_basicfile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().GetAll(hr_basicfile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicfileEntity> Ihr_basicfileFacade.GetAllhr_basicfile"));
            }
		}
		
		IList<hr_basicfileEntity> Ihr_basicfileFacadeObjects.GetAllByPages(hr_basicfileEntity hr_basicfile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().GetAllByPages(hr_basicfile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicfileEntity> Ihr_basicfileFacade.GetAllByPageshr_basicfile"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_basicfileEntity Ihr_basicfileFacadeObjects.GetSingle(hr_basicfileEntity hr_basicfile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().GetSingle(hr_basicfile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_basicfileEntity Ihr_basicfileFacade.GetSinglehr_basicfile"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_basicfileEntity> Ihr_basicfileFacadeObjects.GAPgListView(hr_basicfileEntity hr_basicfile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicfileDataAccess().GAPgListView(hr_basicfile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicfileEntity> Ihr_basicfileFacade.GAPgListViewhr_basicfile"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}