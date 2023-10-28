﻿
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
    public sealed partial class owin_rolepermissionFacadeObjects : BaseFacade, Iowin_rolepermissionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_rolepermissionFacadeObjects";
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

        public owin_rolepermissionFacadeObjects()
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

        ~owin_rolepermissionFacadeObjects()
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
		
		long Iowin_rolepermissionFacadeObjects.Delete(owin_rolepermissionEntity owin_rolepermission)
		{
			try
            {
				return DataAccessFactory.Createowin_rolepermissionDataAccess().Delete(owin_rolepermission);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Deleteowin_rolepermission"));
            }
        }
		
		long Iowin_rolepermissionFacadeObjects.Update(owin_rolepermissionEntity owin_rolepermission )
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().Update(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Updateowin_rolepermission"));
            }
		}
		
		long Iowin_rolepermissionFacadeObjects.Add(owin_rolepermissionEntity owin_rolepermission)
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().Add(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Addowin_rolepermission"));
            }
		}
		
        long Iowin_rolepermissionFacadeObjects.SaveList(List<owin_rolepermissionEntity> list)
        {
            try
            {
                IList<owin_rolepermissionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_rolepermissionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_rolepermissionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_rolepermissionDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_rolepermission"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_rolepermissionEntity> Iowin_rolepermissionFacadeObjects.GetAll(owin_rolepermissionEntity owin_rolepermission)
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().GetAll(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GetAllowin_rolepermission"));
            }
		}
		
		IList<owin_rolepermissionEntity> Iowin_rolepermissionFacadeObjects.GetAllByPages(owin_rolepermissionEntity owin_rolepermission)
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().GetAllByPages(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GetAllByPagesowin_rolepermission"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_rolepermissionEntity Iowin_rolepermissionFacadeObjects.GetSingle(owin_rolepermissionEntity owin_rolepermission)
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().GetSingle(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_rolepermissionEntity Iowin_rolepermissionFacade.GetSingleowin_rolepermission"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_rolepermissionEntity> Iowin_rolepermissionFacadeObjects.GAPgListView(owin_rolepermissionEntity owin_rolepermission)
		{
			try
			{
				return DataAccessFactory.Createowin_rolepermissionDataAccess().GAPgListView(owin_rolepermission);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GAPgListViewowin_rolepermission"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}