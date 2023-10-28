
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
    public sealed partial class stp_passpolicyFacadeObjects : BaseFacade, Istp_passpolicyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_passpolicyFacadeObjects";
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

        public stp_passpolicyFacadeObjects()
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

        ~stp_passpolicyFacadeObjects()
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
		
		long Istp_passpolicyFacadeObjects.Delete(stp_passpolicyEntity stp_passpolicy)
		{
			try
            {
				return DataAccessFactory.Createstp_passpolicyDataAccess().Delete(stp_passpolicy);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_passpolicyFacade.Deletestp_passpolicy"));
            }
        }
		
		long Istp_passpolicyFacadeObjects.Update(stp_passpolicyEntity stp_passpolicy )
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().Update(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_passpolicyFacade.Updatestp_passpolicy"));
            }
		}
		
		long Istp_passpolicyFacadeObjects.Add(stp_passpolicyEntity stp_passpolicy)
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().Add(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_passpolicyFacade.Addstp_passpolicy"));
            }
		}
		
        long Istp_passpolicyFacadeObjects.SaveList(List<stp_passpolicyEntity> list)
        {
            try
            {
                IList<stp_passpolicyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<stp_passpolicyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<stp_passpolicyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createstp_passpolicyDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_passpolicy"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<stp_passpolicyEntity> Istp_passpolicyFacadeObjects.GetAll(stp_passpolicyEntity stp_passpolicy)
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().GetAll(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_passpolicyEntity> Istp_passpolicyFacade.GetAllstp_passpolicy"));
            }
		}
		
		IList<stp_passpolicyEntity> Istp_passpolicyFacadeObjects.GetAllByPages(stp_passpolicyEntity stp_passpolicy)
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().GetAllByPages(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_passpolicyEntity> Istp_passpolicyFacade.GetAllByPagesstp_passpolicy"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        stp_passpolicyEntity Istp_passpolicyFacadeObjects.GetSingle(stp_passpolicyEntity stp_passpolicy)
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().GetSingle(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("stp_passpolicyEntity Istp_passpolicyFacade.GetSinglestp_passpolicy"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<stp_passpolicyEntity> Istp_passpolicyFacadeObjects.GAPgListView(stp_passpolicyEntity stp_passpolicy)
		{
			try
			{
				return DataAccessFactory.Createstp_passpolicyDataAccess().GAPgListView(stp_passpolicy);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_passpolicyEntity> Istp_passpolicyFacade.GAPgListViewstp_passpolicy"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}