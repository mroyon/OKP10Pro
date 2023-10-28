
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
    public sealed partial class hr_documentuploadFacadeObjects : BaseFacade, Ihr_documentuploadFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_documentuploadFacadeObjects";
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

        public hr_documentuploadFacadeObjects()
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

        ~hr_documentuploadFacadeObjects()
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
		
		long Ihr_documentuploadFacadeObjects.Delete(hr_documentuploadEntity hr_documentupload)
		{
			try
            {
				return DataAccessFactory.Createhr_documentuploadDataAccess().Delete(hr_documentupload);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_documentuploadFacade.Deletehr_documentupload"));
            }
        }
		
		long Ihr_documentuploadFacadeObjects.Update(hr_documentuploadEntity hr_documentupload )
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().Update(hr_documentupload);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_documentuploadFacade.Updatehr_documentupload"));
            }
		}
		
		long Ihr_documentuploadFacadeObjects.Add(hr_documentuploadEntity hr_documentupload)
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().Add(hr_documentupload);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_documentuploadFacade.Addhr_documentupload"));
            }
		}
		
        long Ihr_documentuploadFacadeObjects.SaveList(List<hr_documentuploadEntity> list)
        {
            try
            {
                IList<hr_documentuploadEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_documentuploadEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_documentuploadEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_documentuploadDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_documentupload"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_documentuploadEntity> Ihr_documentuploadFacadeObjects.GetAll(hr_documentuploadEntity hr_documentupload)
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().GetAll(hr_documentupload);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_documentuploadEntity> Ihr_documentuploadFacade.GetAllhr_documentupload"));
            }
		}
		
		IList<hr_documentuploadEntity> Ihr_documentuploadFacadeObjects.GetAllByPages(hr_documentuploadEntity hr_documentupload)
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().GetAllByPages(hr_documentupload);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_documentuploadEntity> Ihr_documentuploadFacade.GetAllByPageshr_documentupload"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_documentuploadEntity Ihr_documentuploadFacadeObjects.GetSingle(hr_documentuploadEntity hr_documentupload)
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().GetSingle(hr_documentupload);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_documentuploadEntity Ihr_documentuploadFacade.GetSinglehr_documentupload"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_documentuploadEntity> Ihr_documentuploadFacadeObjects.GAPgListView(hr_documentuploadEntity hr_documentupload)
		{
			try
			{
				return DataAccessFactory.Createhr_documentuploadDataAccess().GAPgListView(hr_documentupload);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_documentuploadEntity> Ihr_documentuploadFacade.GAPgListViewhr_documentupload"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}