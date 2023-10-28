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
    public sealed partial class useraccountsprofFacadeObjects : BaseFacade, IuseraccountsprofFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "useraccountsprofFacadeObjects";
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

        public useraccountsprofFacadeObjects()
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

        ~useraccountsprofFacadeObjects()
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
		
		long IuseraccountsprofFacadeObjects.Delete(useraccountsprofEntity useraccountsprof)
		{
			try
            {
				return DataAccessFactory.CreateuseraccountsprofDataAccess().Delete(useraccountsprof);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IuseraccountsprofFacade.Deleteuseraccountsprof"));
            }
        }
		
		long IuseraccountsprofFacadeObjects.Update(useraccountsprofEntity useraccountsprof )
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().Update(useraccountsprof);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("IuseraccountsprofFacade.Updateuseraccountsprof"));
            }
		}
		
		long IuseraccountsprofFacadeObjects.Add(useraccountsprofEntity useraccountsprof)
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().Add(useraccountsprof);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IuseraccountsprofFacade.Adduseraccountsprof"));
            }
		}
		
        long IuseraccountsprofFacadeObjects.SaveList(List<useraccountsprofEntity> list)
        {
            try
            {
                IList<useraccountsprofEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<useraccountsprofEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<useraccountsprofEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.CreateuseraccountsprofDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_useraccountsprof"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<useraccountsprofEntity> IuseraccountsprofFacadeObjects.GetAll(useraccountsprofEntity useraccountsprof)
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().GetAll(useraccountsprof);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<useraccountsprofEntity> IuseraccountsprofFacade.GetAlluseraccountsprof"));
            }
		}
		
		IList<useraccountsprofEntity> IuseraccountsprofFacadeObjects.GetAllByPages(useraccountsprofEntity useraccountsprof)
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().GetAllByPages(useraccountsprof);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<useraccountsprofEntity> IuseraccountsprofFacade.GetAllByPagesuseraccountsprof"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        useraccountsprofEntity IuseraccountsprofFacadeObjects.GetSingle(useraccountsprofEntity useraccountsprof)
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().GetSingle(useraccountsprof);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("useraccountsprofEntity IuseraccountsprofFacade.GetSingleuseraccountsprof"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<useraccountsprofEntity> IuseraccountsprofFacadeObjects.GAPgListView(useraccountsprofEntity useraccountsprof)
		{
			try
			{
				return DataAccessFactory.CreateuseraccountsprofDataAccess().GAPgListView(useraccountsprof);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<useraccountsprofEntity> IuseraccountsprofFacade.GAPgListViewuseraccountsprof"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}