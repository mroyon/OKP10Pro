
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
    public sealed partial class gen_authorizestrengthFacadeObjects : BaseFacade, Igen_authorizestrengthFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_authorizestrengthFacadeObjects";
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

        public gen_authorizestrengthFacadeObjects()
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

        ~gen_authorizestrengthFacadeObjects()
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
		
		long Igen_authorizestrengthFacadeObjects.Delete(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
            {
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().Delete(gen_authorizestrength);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_authorizestrengthFacade.Deletegen_authorizestrength"));
            }
        }
		
		long Igen_authorizestrengthFacadeObjects.Update(gen_authorizestrengthEntity gen_authorizestrength )
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().Update(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_authorizestrengthFacade.Updategen_authorizestrength"));
            }
		}
		
		long Igen_authorizestrengthFacadeObjects.Add(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().Add(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_authorizestrengthFacade.Addgen_authorizestrength"));
            }
		}
		
        long Igen_authorizestrengthFacadeObjects.SaveList(List<gen_authorizestrengthEntity> list)
        {
            try
            {
                IList<gen_authorizestrengthEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_authorizestrengthEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_authorizestrengthEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_authorizestrengthDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_authorizestrength"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacadeObjects.GetAll(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().GetAll(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacade.GetAllgen_authorizestrength"));
            }
		}
		
		IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacadeObjects.GetAllByPages(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().GetAllByPages(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacade.GetAllByPagesgen_authorizestrength"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_authorizestrengthEntity Igen_authorizestrengthFacadeObjects.GetSingle(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().GetSingle(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_authorizestrengthEntity Igen_authorizestrengthFacade.GetSinglegen_authorizestrength"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacadeObjects.GAPgListView(gen_authorizestrengthEntity gen_authorizestrength)
		{
			try
			{
				return DataAccessFactory.Creategen_authorizestrengthDataAccess().GAPgListView(gen_authorizestrength);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_authorizestrengthEntity> Igen_authorizestrengthFacade.GAPgListViewgen_authorizestrength"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}