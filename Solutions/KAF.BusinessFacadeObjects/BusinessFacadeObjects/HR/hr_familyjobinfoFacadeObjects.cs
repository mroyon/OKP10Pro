
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
    public sealed partial class hr_familyjobinfoFacadeObjects : BaseFacade, Ihr_familyjobinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_familyjobinfoFacadeObjects";
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

        public hr_familyjobinfoFacadeObjects()
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

        ~hr_familyjobinfoFacadeObjects()
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
		
		long Ihr_familyjobinfoFacadeObjects.Delete(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().Delete(hr_familyjobinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyjobinfoFacade.Deletehr_familyjobinfo"));
            }
        }
		
		long Ihr_familyjobinfoFacadeObjects.Update(hr_familyjobinfoEntity hr_familyjobinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().Update(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_familyjobinfoFacade.Updatehr_familyjobinfo"));
            }
		}
		
		long Ihr_familyjobinfoFacadeObjects.Add(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().Add(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyjobinfoFacade.Addhr_familyjobinfo"));
            }
		}
		
        long Ihr_familyjobinfoFacadeObjects.SaveList(List<hr_familyjobinfoEntity> list)
        {
            try
            {
                IList<hr_familyjobinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_familyjobinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_familyjobinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_familyjobinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_familyjobinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacadeObjects.GetAll(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().GetAll(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacade.GetAllhr_familyjobinfo"));
            }
		}
		
		IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacadeObjects.GetAllByPages(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().GetAllByPages(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacade.GetAllByPageshr_familyjobinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_familyjobinfoEntity Ihr_familyjobinfoFacadeObjects.GetSingle(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().GetSingle(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_familyjobinfoEntity Ihr_familyjobinfoFacade.GetSinglehr_familyjobinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacadeObjects.GAPgListView(hr_familyjobinfoEntity hr_familyjobinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyjobinfoDataAccess().GAPgListView(hr_familyjobinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyjobinfoEntity> Ihr_familyjobinfoFacade.GAPgListViewhr_familyjobinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}