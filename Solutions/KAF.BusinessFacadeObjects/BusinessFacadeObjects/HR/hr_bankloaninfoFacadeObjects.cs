
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
    public sealed partial class hr_bankloaninfoFacadeObjects : BaseFacade, Ihr_bankloaninfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_bankloaninfoFacadeObjects";
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

        public hr_bankloaninfoFacadeObjects()
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

        ~hr_bankloaninfoFacadeObjects()
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
		
		long Ihr_bankloaninfoFacadeObjects.Delete(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
            {
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().Delete(hr_bankloaninfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_bankloaninfoFacade.Deletehr_bankloaninfo"));
            }
        }
		
		long Ihr_bankloaninfoFacadeObjects.Update(hr_bankloaninfoEntity hr_bankloaninfo )
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().Update(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_bankloaninfoFacade.Updatehr_bankloaninfo"));
            }
		}
		
		long Ihr_bankloaninfoFacadeObjects.Add(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().Add(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_bankloaninfoFacade.Addhr_bankloaninfo"));
            }
		}
		
        long Ihr_bankloaninfoFacadeObjects.SaveList(List<hr_bankloaninfoEntity> list)
        {
            try
            {
                IList<hr_bankloaninfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_bankloaninfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_bankloaninfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_bankloaninfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_bankloaninfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacadeObjects.GetAll(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().GetAll(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacade.GetAllhr_bankloaninfo"));
            }
		}
		
		IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacadeObjects.GetAllByPages(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().GetAllByPages(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacade.GetAllByPageshr_bankloaninfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_bankloaninfoEntity Ihr_bankloaninfoFacadeObjects.GetSingle(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().GetSingle(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_bankloaninfoEntity Ihr_bankloaninfoFacade.GetSinglehr_bankloaninfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacadeObjects.GAPgListView(hr_bankloaninfoEntity hr_bankloaninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankloaninfoDataAccess().GAPgListView(hr_bankloaninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankloaninfoEntity> Ihr_bankloaninfoFacade.GAPgListViewhr_bankloaninfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}