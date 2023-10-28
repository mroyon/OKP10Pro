
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
    public sealed partial class hr_personalinfoFacadeObjects : BaseFacade, Ihr_personalinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_personalinfoFacadeObjects";
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

        public hr_personalinfoFacadeObjects()
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

        ~hr_personalinfoFacadeObjects()
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
		
		long Ihr_personalinfoFacadeObjects.Delete(hr_personalinfoEntity hr_personalinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_personalinfoDataAccess().Delete(hr_personalinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Deletehr_personalinfo"));
            }
        }
		
		long Ihr_personalinfoFacadeObjects.Update(hr_personalinfoEntity hr_personalinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().Update(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Updatehr_personalinfo"));
            }
		}
		
		long Ihr_personalinfoFacadeObjects.Add(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().Add(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Addhr_personalinfo"));
            }
		}
		
        long Ihr_personalinfoFacadeObjects.SaveList(List<hr_personalinfoEntity> list)
        {
            try
            {
                IList<hr_personalinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_personalinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_personalinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_personalinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_personalinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GetAll(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetAll(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GetAllhr_personalinfo"));
            }
		}
		
		IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GetAllByPages(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetAllByPages(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GetAllByPageshr_personalinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_personalinfoEntity Ihr_personalinfoFacadeObjects.GetSingle(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetSingle(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_personalinfoEntity Ihr_personalinfoFacade.GetSinglehr_personalinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GAPgListView(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GAPgListView(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GAPgListViewhr_personalinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}