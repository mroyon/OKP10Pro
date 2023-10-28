
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
    public sealed partial class hr_okptransferinfoFacadeObjects : BaseFacade, Ihr_okptransferinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_okptransferinfoFacadeObjects";
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

        public hr_okptransferinfoFacadeObjects()
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

        ~hr_okptransferinfoFacadeObjects()
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
		
		long Ihr_okptransferinfoFacadeObjects.Delete(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().Delete(hr_okptransferinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_okptransferinfoFacade.Deletehr_okptransferinfo"));
            }
        }
		
		long Ihr_okptransferinfoFacadeObjects.Update(hr_okptransferinfoEntity hr_okptransferinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().Update(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_okptransferinfoFacade.Updatehr_okptransferinfo"));
            }
		}
		
		long Ihr_okptransferinfoFacadeObjects.Add(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().Add(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_okptransferinfoFacade.Addhr_okptransferinfo"));
            }
		}
		
        long Ihr_okptransferinfoFacadeObjects.SaveList(List<hr_okptransferinfoEntity> list)
        {
            try
            {
                IList<hr_okptransferinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_okptransferinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_okptransferinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_okptransferinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_okptransferinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacadeObjects.GetAll(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().GetAll(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacade.GetAllhr_okptransferinfo"));
            }
		}
		
		IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacadeObjects.GetAllByPages(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().GetAllByPages(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacade.GetAllByPageshr_okptransferinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_okptransferinfoEntity Ihr_okptransferinfoFacadeObjects.GetSingle(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().GetSingle(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_okptransferinfoEntity Ihr_okptransferinfoFacade.GetSinglehr_okptransferinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacadeObjects.GAPgListView(hr_okptransferinfoEntity hr_okptransferinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_okptransferinfoDataAccess().GAPgListView(hr_okptransferinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacade.GAPgListViewhr_okptransferinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}