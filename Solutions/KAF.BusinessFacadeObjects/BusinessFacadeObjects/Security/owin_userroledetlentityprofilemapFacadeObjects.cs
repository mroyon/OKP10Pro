
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
    public sealed partial class owin_userroledetlentityprofilemapFacadeObjects : BaseFacade, Iowin_userroledetlentityprofilemapFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userroledetlentityprofilemapFacadeObjects";
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

        public owin_userroledetlentityprofilemapFacadeObjects()
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

        ~owin_userroledetlentityprofilemapFacadeObjects()
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
		
		long Iowin_userroledetlentityprofilemapFacadeObjects.Delete(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
            {
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().Delete(owin_userroledetlentityprofilemap);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentityprofilemapFacade.Deleteowin_userroledetlentityprofilemap"));
            }
        }
		
		long Iowin_userroledetlentityprofilemapFacadeObjects.Update(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap )
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().Update(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentityprofilemapFacade.Updateowin_userroledetlentityprofilemap"));
            }
		}
		
		long Iowin_userroledetlentityprofilemapFacadeObjects.Add(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().Add(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentityprofilemapFacade.Addowin_userroledetlentityprofilemap"));
            }
		}
		
        long Iowin_userroledetlentityprofilemapFacadeObjects.SaveList(List<owin_userroledetlentityprofilemapEntity> list)
        {
            try
            {
                IList<owin_userroledetlentityprofilemapEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userroledetlentityprofilemapEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userroledetlentityprofilemapEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userroledetlentityprofilemap"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacadeObjects.GetAll(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().GetAll(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacade.GetAllowin_userroledetlentityprofilemap"));
            }
		}
		
		IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacadeObjects.GetAllByPages(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().GetAllByPages(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacade.GetAllByPagesowin_userroledetlentityprofilemap"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userroledetlentityprofilemapEntity Iowin_userroledetlentityprofilemapFacadeObjects.GetSingle(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().GetSingle(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userroledetlentityprofilemapEntity Iowin_userroledetlentityprofilemapFacade.GetSingleowin_userroledetlentityprofilemap"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacadeObjects.GAPgListView(owin_userroledetlentityprofilemapEntity owin_userroledetlentityprofilemap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentityprofilemapDataAccess().GAPgListView(owin_userroledetlentityprofilemap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentityprofilemapEntity> Iowin_userroledetlentityprofilemapFacade.GAPgListViewowin_userroledetlentityprofilemap"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}