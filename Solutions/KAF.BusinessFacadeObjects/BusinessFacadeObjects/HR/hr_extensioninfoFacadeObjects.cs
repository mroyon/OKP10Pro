
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
    public sealed partial class hr_extensioninfoFacadeObjects : BaseFacade, Ihr_extensioninfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_extensioninfoFacadeObjects";
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

        public hr_extensioninfoFacadeObjects()
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

        ~hr_extensioninfoFacadeObjects()
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
		
		long Ihr_extensioninfoFacadeObjects.Delete(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
            {
				return DataAccessFactory.Createhr_extensioninfoDataAccess().Delete(hr_extensioninfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_extensioninfoFacade.Deletehr_extensioninfo"));
            }
        }
		
		long Ihr_extensioninfoFacadeObjects.Update(hr_extensioninfoEntity hr_extensioninfo )
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().Update(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_extensioninfoFacade.Updatehr_extensioninfo"));
            }
		}
		
		long Ihr_extensioninfoFacadeObjects.Add(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().Add(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_extensioninfoFacade.Addhr_extensioninfo"));
            }
		}
		
        long Ihr_extensioninfoFacadeObjects.SaveList(List<hr_extensioninfoEntity> list)
        {
            try
            {
                IList<hr_extensioninfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_extensioninfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_extensioninfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_extensioninfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_extensioninfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_extensioninfoEntity> Ihr_extensioninfoFacadeObjects.GetAll(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().GetAll(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_extensioninfoEntity> Ihr_extensioninfoFacade.GetAllhr_extensioninfo"));
            }
		}
		
		IList<hr_extensioninfoEntity> Ihr_extensioninfoFacadeObjects.GetAllByPages(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().GetAllByPages(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_extensioninfoEntity> Ihr_extensioninfoFacade.GetAllByPageshr_extensioninfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_extensioninfoEntity Ihr_extensioninfoFacadeObjects.GetSingle(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().GetSingle(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_extensioninfoEntity Ihr_extensioninfoFacade.GetSinglehr_extensioninfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_extensioninfoEntity> Ihr_extensioninfoFacadeObjects.GAPgListView(hr_extensioninfoEntity hr_extensioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_extensioninfoDataAccess().GAPgListView(hr_extensioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_extensioninfoEntity> Ihr_extensioninfoFacade.GAPgListViewhr_extensioninfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}