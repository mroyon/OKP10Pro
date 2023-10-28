
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
    public sealed partial class hr_emergencycontactFacadeObjects : BaseFacade, Ihr_emergencycontactFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_emergencycontactFacadeObjects";
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

        public hr_emergencycontactFacadeObjects()
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

        ~hr_emergencycontactFacadeObjects()
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
		
		long Ihr_emergencycontactFacadeObjects.Delete(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
            {
				return DataAccessFactory.Createhr_emergencycontactDataAccess().Delete(hr_emergencycontact);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_emergencycontactFacade.Deletehr_emergencycontact"));
            }
        }
		
		long Ihr_emergencycontactFacadeObjects.Update(hr_emergencycontactEntity hr_emergencycontact )
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().Update(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_emergencycontactFacade.Updatehr_emergencycontact"));
            }
		}
		
		long Ihr_emergencycontactFacadeObjects.Add(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().Add(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_emergencycontactFacade.Addhr_emergencycontact"));
            }
		}
		
        long Ihr_emergencycontactFacadeObjects.SaveList(List<hr_emergencycontactEntity> list)
        {
            try
            {
                IList<hr_emergencycontactEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_emergencycontactEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_emergencycontactEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_emergencycontactDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_emergencycontact"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_emergencycontactEntity> Ihr_emergencycontactFacadeObjects.GetAll(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().GetAll(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_emergencycontactEntity> Ihr_emergencycontactFacade.GetAllhr_emergencycontact"));
            }
		}
		
		IList<hr_emergencycontactEntity> Ihr_emergencycontactFacadeObjects.GetAllByPages(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().GetAllByPages(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_emergencycontactEntity> Ihr_emergencycontactFacade.GetAllByPageshr_emergencycontact"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_emergencycontactEntity Ihr_emergencycontactFacadeObjects.GetSingle(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().GetSingle(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_emergencycontactEntity Ihr_emergencycontactFacade.GetSinglehr_emergencycontact"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_emergencycontactEntity> Ihr_emergencycontactFacadeObjects.GAPgListView(hr_emergencycontactEntity hr_emergencycontact)
		{
			try
			{
				return DataAccessFactory.Createhr_emergencycontactDataAccess().GAPgListView(hr_emergencycontact);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_emergencycontactEntity> Ihr_emergencycontactFacade.GAPgListViewhr_emergencycontact"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}