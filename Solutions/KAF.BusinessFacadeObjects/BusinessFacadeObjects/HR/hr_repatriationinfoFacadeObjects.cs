
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
    public sealed partial class hr_repatriationinfoFacadeObjects : BaseFacade, Ihr_repatriationinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_repatriationinfoFacadeObjects";
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

        public hr_repatriationinfoFacadeObjects()
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

        ~hr_repatriationinfoFacadeObjects()
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
		
		long Ihr_repatriationinfoFacadeObjects.Delete(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().Delete(hr_repatriationinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_repatriationinfoFacade.Deletehr_repatriationinfo"));
            }
        }
		
		long Ihr_repatriationinfoFacadeObjects.Update(hr_repatriationinfoEntity hr_repatriationinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().Update(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_repatriationinfoFacade.Updatehr_repatriationinfo"));
            }
		}
		
		long Ihr_repatriationinfoFacadeObjects.Add(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().Add(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_repatriationinfoFacade.Addhr_repatriationinfo"));
            }
		}
		
        long Ihr_repatriationinfoFacadeObjects.SaveList(List<hr_repatriationinfoEntity> list)
        {
            try
            {
                IList<hr_repatriationinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_repatriationinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_repatriationinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_repatriationinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_repatriationinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacadeObjects.GetAll(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().GetAll(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacade.GetAllhr_repatriationinfo"));
            }
		}
		
		IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacadeObjects.GetAllByPages(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().GetAllByPages(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacade.GetAllByPageshr_repatriationinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_repatriationinfoEntity Ihr_repatriationinfoFacadeObjects.GetSingle(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().GetSingle(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_repatriationinfoEntity Ihr_repatriationinfoFacade.GetSinglehr_repatriationinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacadeObjects.GAPgListView(hr_repatriationinfoEntity hr_repatriationinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_repatriationinfoDataAccess().GAPgListView(hr_repatriationinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_repatriationinfoEntity> Ihr_repatriationinfoFacade.GAPgListViewhr_repatriationinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}