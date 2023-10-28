
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
    public sealed partial class hr_medicalinfoFacadeObjects : BaseFacade, Ihr_medicalinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_medicalinfoFacadeObjects";
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

        public hr_medicalinfoFacadeObjects()
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

        ~hr_medicalinfoFacadeObjects()
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
		
		long Ihr_medicalinfoFacadeObjects.Delete(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_medicalinfoDataAccess().Delete(hr_medicalinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_medicalinfoFacade.Deletehr_medicalinfo"));
            }
        }
		
		long Ihr_medicalinfoFacadeObjects.Update(hr_medicalinfoEntity hr_medicalinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().Update(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_medicalinfoFacade.Updatehr_medicalinfo"));
            }
		}
		
		long Ihr_medicalinfoFacadeObjects.Add(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().Add(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_medicalinfoFacade.Addhr_medicalinfo"));
            }
		}
		
        long Ihr_medicalinfoFacadeObjects.SaveList(List<hr_medicalinfoEntity> list)
        {
            try
            {
                IList<hr_medicalinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_medicalinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_medicalinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_medicalinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_medicalinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_medicalinfoEntity> Ihr_medicalinfoFacadeObjects.GetAll(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().GetAll(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_medicalinfoEntity> Ihr_medicalinfoFacade.GetAllhr_medicalinfo"));
            }
		}
		
		IList<hr_medicalinfoEntity> Ihr_medicalinfoFacadeObjects.GetAllByPages(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().GetAllByPages(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_medicalinfoEntity> Ihr_medicalinfoFacade.GetAllByPageshr_medicalinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_medicalinfoEntity Ihr_medicalinfoFacadeObjects.GetSingle(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().GetSingle(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_medicalinfoEntity Ihr_medicalinfoFacade.GetSinglehr_medicalinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_medicalinfoEntity> Ihr_medicalinfoFacadeObjects.GAPgListView(hr_medicalinfoEntity hr_medicalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_medicalinfoDataAccess().GAPgListView(hr_medicalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_medicalinfoEntity> Ihr_medicalinfoFacade.GAPgListViewhr_medicalinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}