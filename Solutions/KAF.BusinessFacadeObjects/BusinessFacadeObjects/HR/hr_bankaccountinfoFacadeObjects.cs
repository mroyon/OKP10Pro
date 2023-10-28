
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
    public sealed partial class hr_bankaccountinfoFacadeObjects : BaseFacade, Ihr_bankaccountinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_bankaccountinfoFacadeObjects";
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

        public hr_bankaccountinfoFacadeObjects()
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

        ~hr_bankaccountinfoFacadeObjects()
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
		
		long Ihr_bankaccountinfoFacadeObjects.Delete(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().Delete(hr_bankaccountinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_bankaccountinfoFacade.Deletehr_bankaccountinfo"));
            }
        }
		
		long Ihr_bankaccountinfoFacadeObjects.Update(hr_bankaccountinfoEntity hr_bankaccountinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().Update(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_bankaccountinfoFacade.Updatehr_bankaccountinfo"));
            }
		}
		
		long Ihr_bankaccountinfoFacadeObjects.Add(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().Add(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_bankaccountinfoFacade.Addhr_bankaccountinfo"));
            }
		}
		
        long Ihr_bankaccountinfoFacadeObjects.SaveList(List<hr_bankaccountinfoEntity> list)
        {
            try
            {
                IList<hr_bankaccountinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_bankaccountinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_bankaccountinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_bankaccountinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_bankaccountinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacadeObjects.GetAll(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().GetAll(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacade.GetAllhr_bankaccountinfo"));
            }
		}
		
		IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacadeObjects.GetAllByPages(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().GetAllByPages(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacade.GetAllByPageshr_bankaccountinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_bankaccountinfoEntity Ihr_bankaccountinfoFacadeObjects.GetSingle(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().GetSingle(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_bankaccountinfoEntity Ihr_bankaccountinfoFacade.GetSinglehr_bankaccountinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacadeObjects.GAPgListView(hr_bankaccountinfoEntity hr_bankaccountinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_bankaccountinfoDataAccess().GAPgListView(hr_bankaccountinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_bankaccountinfoEntity> Ihr_bankaccountinfoFacade.GAPgListViewhr_bankaccountinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}