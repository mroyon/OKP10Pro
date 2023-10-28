
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
    public sealed partial class hr_languageproficiencyFacadeObjects : BaseFacade, Ihr_languageproficiencyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_languageproficiencyFacadeObjects";
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

        public hr_languageproficiencyFacadeObjects()
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

        ~hr_languageproficiencyFacadeObjects()
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
		
		long Ihr_languageproficiencyFacadeObjects.Delete(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
            {
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().Delete(hr_languageproficiency);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_languageproficiencyFacade.Deletehr_languageproficiency"));
            }
        }
		
		long Ihr_languageproficiencyFacadeObjects.Update(hr_languageproficiencyEntity hr_languageproficiency )
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().Update(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_languageproficiencyFacade.Updatehr_languageproficiency"));
            }
		}
		
		long Ihr_languageproficiencyFacadeObjects.Add(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().Add(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_languageproficiencyFacade.Addhr_languageproficiency"));
            }
		}
		
        long Ihr_languageproficiencyFacadeObjects.SaveList(List<hr_languageproficiencyEntity> list)
        {
            try
            {
                IList<hr_languageproficiencyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_languageproficiencyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_languageproficiencyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_languageproficiencyDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_languageproficiency"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacadeObjects.GetAll(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().GetAll(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacade.GetAllhr_languageproficiency"));
            }
		}
		
		IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacadeObjects.GetAllByPages(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().GetAllByPages(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacade.GetAllByPageshr_languageproficiency"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_languageproficiencyEntity Ihr_languageproficiencyFacadeObjects.GetSingle(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().GetSingle(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_languageproficiencyEntity Ihr_languageproficiencyFacade.GetSinglehr_languageproficiency"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacadeObjects.GAPgListView(hr_languageproficiencyEntity hr_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Createhr_languageproficiencyDataAccess().GAPgListView(hr_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_languageproficiencyEntity> Ihr_languageproficiencyFacade.GAPgListViewhr_languageproficiency"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}