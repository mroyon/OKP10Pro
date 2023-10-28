
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
    public sealed partial class gen_grouprankFacadeObjects : BaseFacade, Igen_grouprankFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_grouprankFacadeObjects";
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

        public gen_grouprankFacadeObjects()
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

        ~gen_grouprankFacadeObjects()
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
		
		long Igen_grouprankFacadeObjects.Delete(gen_grouprankEntity gen_grouprank)
		{
			try
            {
				return DataAccessFactory.Creategen_grouprankDataAccess().Delete(gen_grouprank);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_grouprankFacade.Deletegen_grouprank"));
            }
        }
		
		long Igen_grouprankFacadeObjects.Update(gen_grouprankEntity gen_grouprank )
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().Update(gen_grouprank);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_grouprankFacade.Updategen_grouprank"));
            }
		}
		
		long Igen_grouprankFacadeObjects.Add(gen_grouprankEntity gen_grouprank)
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().Add(gen_grouprank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_grouprankFacade.Addgen_grouprank"));
            }
		}
		
        long Igen_grouprankFacadeObjects.SaveList(List<gen_grouprankEntity> list)
        {
            try
            {
                IList<gen_grouprankEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_grouprankEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_grouprankEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_grouprankDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_grouprank"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_grouprankEntity> Igen_grouprankFacadeObjects.GetAll(gen_grouprankEntity gen_grouprank)
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().GetAll(gen_grouprank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_grouprankEntity> Igen_grouprankFacade.GetAllgen_grouprank"));
            }
		}
		
		IList<gen_grouprankEntity> Igen_grouprankFacadeObjects.GetAllByPages(gen_grouprankEntity gen_grouprank)
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().GetAllByPages(gen_grouprank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_grouprankEntity> Igen_grouprankFacade.GetAllByPagesgen_grouprank"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_grouprankEntity Igen_grouprankFacadeObjects.GetSingle(gen_grouprankEntity gen_grouprank)
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().GetSingle(gen_grouprank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_grouprankEntity Igen_grouprankFacade.GetSinglegen_grouprank"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_grouprankEntity> Igen_grouprankFacadeObjects.GAPgListView(gen_grouprankEntity gen_grouprank)
		{
			try
			{
				return DataAccessFactory.Creategen_grouprankDataAccess().GAPgListView(gen_grouprank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_grouprankEntity> Igen_grouprankFacade.GAPgListViewgen_grouprank"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}