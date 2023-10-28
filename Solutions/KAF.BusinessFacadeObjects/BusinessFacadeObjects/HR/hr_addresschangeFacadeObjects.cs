
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
    public sealed partial class hr_addresschangeFacadeObjects : BaseFacade, Ihr_addresschangeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_addresschangeFacadeObjects";
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

        public hr_addresschangeFacadeObjects()
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

        ~hr_addresschangeFacadeObjects()
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
		
		long Ihr_addresschangeFacadeObjects.Delete(hr_addresschangeEntity hr_addresschange)
		{
			try
            {
				return DataAccessFactory.Createhr_addresschangeDataAccess().Delete(hr_addresschange);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_addresschangeFacade.Deletehr_addresschange"));
            }
        }
		
		long Ihr_addresschangeFacadeObjects.Update(hr_addresschangeEntity hr_addresschange )
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().Update(hr_addresschange);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_addresschangeFacade.Updatehr_addresschange"));
            }
		}
		
		long Ihr_addresschangeFacadeObjects.Add(hr_addresschangeEntity hr_addresschange)
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().Add(hr_addresschange);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_addresschangeFacade.Addhr_addresschange"));
            }
		}
		
        long Ihr_addresschangeFacadeObjects.SaveList(List<hr_addresschangeEntity> list)
        {
            try
            {
                IList<hr_addresschangeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_addresschangeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_addresschangeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_addresschangeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_addresschange"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_addresschangeEntity> Ihr_addresschangeFacadeObjects.GetAll(hr_addresschangeEntity hr_addresschange)
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().GetAll(hr_addresschange);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_addresschangeEntity> Ihr_addresschangeFacade.GetAllhr_addresschange"));
            }
		}
		
		IList<hr_addresschangeEntity> Ihr_addresschangeFacadeObjects.GetAllByPages(hr_addresschangeEntity hr_addresschange)
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().GetAllByPages(hr_addresschange);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_addresschangeEntity> Ihr_addresschangeFacade.GetAllByPageshr_addresschange"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_addresschangeEntity Ihr_addresschangeFacadeObjects.GetSingle(hr_addresschangeEntity hr_addresschange)
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().GetSingle(hr_addresschange);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_addresschangeEntity Ihr_addresschangeFacade.GetSinglehr_addresschange"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_addresschangeEntity> Ihr_addresschangeFacadeObjects.GAPgListView(hr_addresschangeEntity hr_addresschange)
		{
			try
			{
				return DataAccessFactory.Createhr_addresschangeDataAccess().GAPgListView(hr_addresschange);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_addresschangeEntity> Ihr_addresschangeFacade.GAPgListViewhr_addresschange"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}