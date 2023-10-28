
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
    public sealed partial class hr_residentvisaFacadeObjects : BaseFacade, Ihr_residentvisaFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_residentvisaFacadeObjects";
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

        public hr_residentvisaFacadeObjects()
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

        ~hr_residentvisaFacadeObjects()
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
		
		long Ihr_residentvisaFacadeObjects.Delete(hr_residentvisaEntity hr_residentvisa)
		{
			try
            {
				return DataAccessFactory.Createhr_residentvisaDataAccess().Delete(hr_residentvisa);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_residentvisaFacade.Deletehr_residentvisa"));
            }
        }
		
		long Ihr_residentvisaFacadeObjects.Update(hr_residentvisaEntity hr_residentvisa )
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().Update(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_residentvisaFacade.Updatehr_residentvisa"));
            }
		}
		
		long Ihr_residentvisaFacadeObjects.Add(hr_residentvisaEntity hr_residentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().Add(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_residentvisaFacade.Addhr_residentvisa"));
            }
		}
		
        long Ihr_residentvisaFacadeObjects.SaveList(List<hr_residentvisaEntity> list)
        {
            try
            {
                IList<hr_residentvisaEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_residentvisaEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_residentvisaEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_residentvisaDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_residentvisa"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_residentvisaEntity> Ihr_residentvisaFacadeObjects.GetAll(hr_residentvisaEntity hr_residentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().GetAll(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_residentvisaEntity> Ihr_residentvisaFacade.GetAllhr_residentvisa"));
            }
		}
		
		IList<hr_residentvisaEntity> Ihr_residentvisaFacadeObjects.GetAllByPages(hr_residentvisaEntity hr_residentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().GetAllByPages(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_residentvisaEntity> Ihr_residentvisaFacade.GetAllByPageshr_residentvisa"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_residentvisaEntity Ihr_residentvisaFacadeObjects.GetSingle(hr_residentvisaEntity hr_residentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().GetSingle(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_residentvisaEntity Ihr_residentvisaFacade.GetSinglehr_residentvisa"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_residentvisaEntity> Ihr_residentvisaFacadeObjects.GAPgListView(hr_residentvisaEntity hr_residentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_residentvisaDataAccess().GAPgListView(hr_residentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_residentvisaEntity> Ihr_residentvisaFacade.GAPgListViewhr_residentvisa"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}