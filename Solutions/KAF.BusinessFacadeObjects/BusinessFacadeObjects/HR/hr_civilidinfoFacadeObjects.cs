
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
    public sealed partial class hr_civilidinfoFacadeObjects : BaseFacade, Ihr_civilidinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_civilidinfoFacadeObjects";
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

        public hr_civilidinfoFacadeObjects()
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

        ~hr_civilidinfoFacadeObjects()
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
		
		long Ihr_civilidinfoFacadeObjects.Delete(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Delete(hr_civilidinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_civilidinfoFacade.Deletehr_civilidinfo"));
            }
        }
		
		long Ihr_civilidinfoFacadeObjects.Update(hr_civilidinfoEntity hr_civilidinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Update(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_civilidinfoFacade.Updatehr_civilidinfo"));
            }
		}
		
		long Ihr_civilidinfoFacadeObjects.Add(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Add(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_civilidinfoFacade.Addhr_civilidinfo"));
            }
		}
		
        long Ihr_civilidinfoFacadeObjects.SaveList(List<hr_civilidinfoEntity> list)
        {
            try
            {
                IList<hr_civilidinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_civilidinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_civilidinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_civilidinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_civilidinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_civilidinfoEntity> Ihr_civilidinfoFacadeObjects.GetAll(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().GetAll(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_civilidinfoEntity> Ihr_civilidinfoFacade.GetAllhr_civilidinfo"));
            }
		}
		
		IList<hr_civilidinfoEntity> Ihr_civilidinfoFacadeObjects.GetAllByPages(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().GetAllByPages(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_civilidinfoEntity> Ihr_civilidinfoFacade.GetAllByPageshr_civilidinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_civilidinfoEntity Ihr_civilidinfoFacadeObjects.GetSingle(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().GetSingle(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_civilidinfoEntity Ihr_civilidinfoFacade.GetSinglehr_civilidinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_civilidinfoEntity> Ihr_civilidinfoFacadeObjects.GAPgListView(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().GAPgListView(hr_civilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_civilidinfoEntity> Ihr_civilidinfoFacade.GAPgListViewhr_civilidinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}