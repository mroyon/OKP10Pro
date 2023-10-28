
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
    public sealed partial class gen_currencyexchagerateFacadeObjects : BaseFacade, Igen_currencyexchagerateFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_currencyexchagerateFacadeObjects";
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

        public gen_currencyexchagerateFacadeObjects()
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

        ~gen_currencyexchagerateFacadeObjects()
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
		
		long Igen_currencyexchagerateFacadeObjects.Delete(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
            {
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().Delete(gen_currencyexchagerate);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_currencyexchagerateFacade.Deletegen_currencyexchagerate"));
            }
        }
		
		long Igen_currencyexchagerateFacadeObjects.Update(gen_currencyexchagerateEntity gen_currencyexchagerate )
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().Update(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_currencyexchagerateFacade.Updategen_currencyexchagerate"));
            }
		}
		
		long Igen_currencyexchagerateFacadeObjects.Add(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().Add(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_currencyexchagerateFacade.Addgen_currencyexchagerate"));
            }
		}
		
        long Igen_currencyexchagerateFacadeObjects.SaveList(List<gen_currencyexchagerateEntity> list)
        {
            try
            {
                IList<gen_currencyexchagerateEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_currencyexchagerateEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_currencyexchagerateEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_currencyexchagerateDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_currencyexchagerate"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacadeObjects.GetAll(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().GetAll(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacade.GetAllgen_currencyexchagerate"));
            }
		}
		
		IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacadeObjects.GetAllByPages(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().GetAllByPages(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacade.GetAllByPagesgen_currencyexchagerate"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_currencyexchagerateEntity Igen_currencyexchagerateFacadeObjects.GetSingle(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().GetSingle(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_currencyexchagerateEntity Igen_currencyexchagerateFacade.GetSinglegen_currencyexchagerate"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacadeObjects.GAPgListView(gen_currencyexchagerateEntity gen_currencyexchagerate)
		{
			try
			{
				return DataAccessFactory.Creategen_currencyexchagerateDataAccess().GAPgListView(gen_currencyexchagerate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_currencyexchagerateEntity> Igen_currencyexchagerateFacade.GAPgListViewgen_currencyexchagerate"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}