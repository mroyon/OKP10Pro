
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
    public sealed partial class hr_familyresidentvisaFacadeObjects : BaseFacade, Ihr_familyresidentvisaFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_familyresidentvisaFacadeObjects";
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

        public hr_familyresidentvisaFacadeObjects()
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

        ~hr_familyresidentvisaFacadeObjects()
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
		
		long Ihr_familyresidentvisaFacadeObjects.Delete(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
            {
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().Delete(hr_familyresidentvisa);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyresidentvisaFacade.Deletehr_familyresidentvisa"));
            }
        }
		
		long Ihr_familyresidentvisaFacadeObjects.Update(hr_familyresidentvisaEntity hr_familyresidentvisa )
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().Update(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_familyresidentvisaFacade.Updatehr_familyresidentvisa"));
            }
		}
		
		long Ihr_familyresidentvisaFacadeObjects.Add(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().Add(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyresidentvisaFacade.Addhr_familyresidentvisa"));
            }
		}
		
        long Ihr_familyresidentvisaFacadeObjects.SaveList(List<hr_familyresidentvisaEntity> list)
        {
            try
            {
                IList<hr_familyresidentvisaEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_familyresidentvisaEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_familyresidentvisaEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_familyresidentvisaDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_familyresidentvisa"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacadeObjects.GetAll(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().GetAll(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacade.GetAllhr_familyresidentvisa"));
            }
		}
		
		IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacadeObjects.GetAllByPages(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().GetAllByPages(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacade.GetAllByPageshr_familyresidentvisa"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_familyresidentvisaEntity Ihr_familyresidentvisaFacadeObjects.GetSingle(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().GetSingle(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_familyresidentvisaEntity Ihr_familyresidentvisaFacade.GetSinglehr_familyresidentvisa"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacadeObjects.GAPgListView(hr_familyresidentvisaEntity hr_familyresidentvisa)
		{
			try
			{
				return DataAccessFactory.Createhr_familyresidentvisaDataAccess().GAPgListView(hr_familyresidentvisa);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyresidentvisaEntity> Ihr_familyresidentvisaFacade.GAPgListViewhr_familyresidentvisa"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}