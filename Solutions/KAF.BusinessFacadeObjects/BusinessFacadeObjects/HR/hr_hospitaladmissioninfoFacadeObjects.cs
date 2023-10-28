
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
    public sealed partial class hr_hospitaladmissioninfoFacadeObjects : BaseFacade, Ihr_hospitaladmissioninfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_hospitaladmissioninfoFacadeObjects";
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

        public hr_hospitaladmissioninfoFacadeObjects()
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

        ~hr_hospitaladmissioninfoFacadeObjects()
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
		
		long Ihr_hospitaladmissioninfoFacadeObjects.Delete(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
            {
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().Delete(hr_hospitaladmissioninfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_hospitaladmissioninfoFacade.Deletehr_hospitaladmissioninfo"));
            }
        }
		
		long Ihr_hospitaladmissioninfoFacadeObjects.Update(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo )
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().Update(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_hospitaladmissioninfoFacade.Updatehr_hospitaladmissioninfo"));
            }
		}
		
		long Ihr_hospitaladmissioninfoFacadeObjects.Add(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().Add(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_hospitaladmissioninfoFacade.Addhr_hospitaladmissioninfo"));
            }
		}
		
        long Ihr_hospitaladmissioninfoFacadeObjects.SaveList(List<hr_hospitaladmissioninfoEntity> list)
        {
            try
            {
                IList<hr_hospitaladmissioninfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_hospitaladmissioninfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_hospitaladmissioninfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_hospitaladmissioninfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacadeObjects.GetAll(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().GetAll(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacade.GetAllhr_hospitaladmissioninfo"));
            }
		}
		
		IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacadeObjects.GetAllByPages(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().GetAllByPages(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacade.GetAllByPageshr_hospitaladmissioninfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_hospitaladmissioninfoEntity Ihr_hospitaladmissioninfoFacadeObjects.GetSingle(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().GetSingle(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_hospitaladmissioninfoEntity Ihr_hospitaladmissioninfoFacade.GetSinglehr_hospitaladmissioninfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacadeObjects.GAPgListView(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_hospitaladmissioninfoDataAccess().GAPgListView(hr_hospitaladmissioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_hospitaladmissioninfoEntity> Ihr_hospitaladmissioninfoFacade.GAPgListViewhr_hospitaladmissioninfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}