
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
    public sealed partial class hr_attachmentinfoFacadeObjects : BaseFacade, Ihr_attachmentinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_attachmentinfoFacadeObjects";
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

        public hr_attachmentinfoFacadeObjects()
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

        ~hr_attachmentinfoFacadeObjects()
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
		
		long Ihr_attachmentinfoFacadeObjects.Delete(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().Delete(hr_attachmentinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_attachmentinfoFacade.Deletehr_attachmentinfo"));
            }
        }
		
		long Ihr_attachmentinfoFacadeObjects.Update(hr_attachmentinfoEntity hr_attachmentinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().Update(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_attachmentinfoFacade.Updatehr_attachmentinfo"));
            }
		}
		
		long Ihr_attachmentinfoFacadeObjects.Add(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().Add(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_attachmentinfoFacade.Addhr_attachmentinfo"));
            }
		}
		
        long Ihr_attachmentinfoFacadeObjects.SaveList(List<hr_attachmentinfoEntity> list)
        {
            try
            {
                IList<hr_attachmentinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_attachmentinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_attachmentinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_attachmentinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_attachmentinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacadeObjects.GetAll(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().GetAll(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacade.GetAllhr_attachmentinfo"));
            }
		}
		
		IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacadeObjects.GetAllByPages(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().GetAllByPages(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacade.GetAllByPageshr_attachmentinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_attachmentinfoEntity Ihr_attachmentinfoFacadeObjects.GetSingle(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().GetSingle(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_attachmentinfoEntity Ihr_attachmentinfoFacade.GetSinglehr_attachmentinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacadeObjects.GAPgListView(hr_attachmentinfoEntity hr_attachmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_attachmentinfoDataAccess().GAPgListView(hr_attachmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacade.GAPgListViewhr_attachmentinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}