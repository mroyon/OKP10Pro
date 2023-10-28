
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
    public sealed partial class hr_leavemodificationFacadeObjects : BaseFacade, Ihr_leavemodificationFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_leavemodificationFacadeObjects";
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

        public hr_leavemodificationFacadeObjects()
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

        ~hr_leavemodificationFacadeObjects()
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
		
		long Ihr_leavemodificationFacadeObjects.Delete(hr_leavemodificationEntity hr_leavemodification)
		{
			try
            {
				return DataAccessFactory.Createhr_leavemodificationDataAccess().Delete(hr_leavemodification);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_leavemodificationFacade.Deletehr_leavemodification"));
            }
        }
		
		long Ihr_leavemodificationFacadeObjects.Update(hr_leavemodificationEntity hr_leavemodification )
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().Update(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_leavemodificationFacade.Updatehr_leavemodification"));
            }
		}
		
		long Ihr_leavemodificationFacadeObjects.Add(hr_leavemodificationEntity hr_leavemodification)
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().Add(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_leavemodificationFacade.Addhr_leavemodification"));
            }
		}
		
        long Ihr_leavemodificationFacadeObjects.SaveList(List<hr_leavemodificationEntity> list)
        {
            try
            {
                IList<hr_leavemodificationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_leavemodificationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_leavemodificationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_leavemodificationDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_leavemodification"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_leavemodificationEntity> Ihr_leavemodificationFacadeObjects.GetAll(hr_leavemodificationEntity hr_leavemodification)
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().GetAll(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leavemodificationEntity> Ihr_leavemodificationFacade.GetAllhr_leavemodification"));
            }
		}
		
		IList<hr_leavemodificationEntity> Ihr_leavemodificationFacadeObjects.GetAllByPages(hr_leavemodificationEntity hr_leavemodification)
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().GetAllByPages(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leavemodificationEntity> Ihr_leavemodificationFacade.GetAllByPageshr_leavemodification"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_leavemodificationEntity Ihr_leavemodificationFacadeObjects.GetSingle(hr_leavemodificationEntity hr_leavemodification)
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().GetSingle(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_leavemodificationEntity Ihr_leavemodificationFacade.GetSinglehr_leavemodification"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_leavemodificationEntity> Ihr_leavemodificationFacadeObjects.GAPgListView(hr_leavemodificationEntity hr_leavemodification)
		{
			try
			{
				return DataAccessFactory.Createhr_leavemodificationDataAccess().GAPgListView(hr_leavemodification);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leavemodificationEntity> Ihr_leavemodificationFacade.GAPgListViewhr_leavemodification"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}