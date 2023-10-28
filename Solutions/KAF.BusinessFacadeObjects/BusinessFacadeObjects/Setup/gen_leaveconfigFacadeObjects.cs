
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
    public sealed partial class gen_leaveconfigFacadeObjects : BaseFacade, Igen_leaveconfigFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_leaveconfigFacadeObjects";
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

        public gen_leaveconfigFacadeObjects()
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

        ~gen_leaveconfigFacadeObjects()
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
		
		long Igen_leaveconfigFacadeObjects.Delete(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
            {
				return DataAccessFactory.Creategen_leaveconfigDataAccess().Delete(gen_leaveconfig);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_leaveconfigFacade.Deletegen_leaveconfig"));
            }
        }
		
		long Igen_leaveconfigFacadeObjects.Update(gen_leaveconfigEntity gen_leaveconfig )
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().Update(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_leaveconfigFacade.Updategen_leaveconfig"));
            }
		}
		
		long Igen_leaveconfigFacadeObjects.Add(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().Add(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_leaveconfigFacade.Addgen_leaveconfig"));
            }
		}
		
        long Igen_leaveconfigFacadeObjects.SaveList(List<gen_leaveconfigEntity> list)
        {
            try
            {
                IList<gen_leaveconfigEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_leaveconfigEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_leaveconfigEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_leaveconfigDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_leaveconfig"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_leaveconfigEntity> Igen_leaveconfigFacadeObjects.GetAll(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().GetAll(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leaveconfigEntity> Igen_leaveconfigFacade.GetAllgen_leaveconfig"));
            }
		}
		
		IList<gen_leaveconfigEntity> Igen_leaveconfigFacadeObjects.GetAllByPages(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().GetAllByPages(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leaveconfigEntity> Igen_leaveconfigFacade.GetAllByPagesgen_leaveconfig"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_leaveconfigEntity Igen_leaveconfigFacadeObjects.GetSingle(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().GetSingle(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_leaveconfigEntity Igen_leaveconfigFacade.GetSinglegen_leaveconfig"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_leaveconfigEntity> Igen_leaveconfigFacadeObjects.GAPgListView(gen_leaveconfigEntity gen_leaveconfig)
		{
			try
			{
				return DataAccessFactory.Creategen_leaveconfigDataAccess().GAPgListView(gen_leaveconfig);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leaveconfigEntity> Igen_leaveconfigFacade.GAPgListViewgen_leaveconfig"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}