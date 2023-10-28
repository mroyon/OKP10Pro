
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
    public sealed partial class owin_reportpermissionFacadeObjects : BaseFacade, Iowin_reportpermissionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_reportpermissionFacadeObjects";
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

        public owin_reportpermissionFacadeObjects()
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

        ~owin_reportpermissionFacadeObjects()
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
		
		long Iowin_reportpermissionFacadeObjects.Delete(owin_reportpermissionEntity owin_reportpermission)
		{
			try
            {
				return DataAccessFactory.Createowin_reportpermissionDataAccess().Delete(owin_reportpermission);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportpermissionFacade.Deleteowin_reportpermission"));
            }
        }
		
		long Iowin_reportpermissionFacadeObjects.Update(owin_reportpermissionEntity owin_reportpermission )
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().Update(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_reportpermissionFacade.Updateowin_reportpermission"));
            }
		}
		
		long Iowin_reportpermissionFacadeObjects.Add(owin_reportpermissionEntity owin_reportpermission)
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().Add(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportpermissionFacade.Addowin_reportpermission"));
            }
		}
		
        long Iowin_reportpermissionFacadeObjects.SaveList(List<owin_reportpermissionEntity> list)
        {
            try
            {
                IList<owin_reportpermissionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_reportpermissionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_reportpermissionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_reportpermissionDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_reportpermission"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_reportpermissionEntity> Iowin_reportpermissionFacadeObjects.GetAll(owin_reportpermissionEntity owin_reportpermission)
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().GetAll(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportpermissionEntity> Iowin_reportpermissionFacade.GetAllowin_reportpermission"));
            }
		}
		
		IList<owin_reportpermissionEntity> Iowin_reportpermissionFacadeObjects.GetAllByPages(owin_reportpermissionEntity owin_reportpermission)
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().GetAllByPages(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportpermissionEntity> Iowin_reportpermissionFacade.GetAllByPagesowin_reportpermission"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_reportpermissionEntity Iowin_reportpermissionFacadeObjects.GetSingle(owin_reportpermissionEntity owin_reportpermission)
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().GetSingle(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_reportpermissionEntity Iowin_reportpermissionFacade.GetSingleowin_reportpermission"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_reportpermissionEntity> Iowin_reportpermissionFacadeObjects.GAPgListView(owin_reportpermissionEntity owin_reportpermission)
		{
			try
			{
				return DataAccessFactory.Createowin_reportpermissionDataAccess().GAPgListView(owin_reportpermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportpermissionEntity> Iowin_reportpermissionFacade.GAPgListViewowin_reportpermission"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}