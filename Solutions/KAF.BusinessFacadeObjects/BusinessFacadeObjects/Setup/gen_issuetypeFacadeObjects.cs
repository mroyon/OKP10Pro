
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
    public sealed partial class gen_issuetypeFacadeObjects : BaseFacade, Igen_issuetypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_issuetypeFacadeObjects";
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

        public gen_issuetypeFacadeObjects()
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

        ~gen_issuetypeFacadeObjects()
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
		
		long Igen_issuetypeFacadeObjects.Delete(gen_issuetypeEntity gen_issuetype)
		{
			try
            {
				return DataAccessFactory.Creategen_issuetypeDataAccess().Delete(gen_issuetype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_issuetypeFacade.Deletegen_issuetype"));
            }
        }
		
		long Igen_issuetypeFacadeObjects.Update(gen_issuetypeEntity gen_issuetype )
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().Update(gen_issuetype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_issuetypeFacade.Updategen_issuetype"));
            }
		}
		
		long Igen_issuetypeFacadeObjects.Add(gen_issuetypeEntity gen_issuetype)
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().Add(gen_issuetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_issuetypeFacade.Addgen_issuetype"));
            }
		}
		
        long Igen_issuetypeFacadeObjects.SaveList(List<gen_issuetypeEntity> list)
        {
            try
            {
                IList<gen_issuetypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_issuetypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_issuetypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_issuetypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_issuetype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_issuetypeEntity> Igen_issuetypeFacadeObjects.GetAll(gen_issuetypeEntity gen_issuetype)
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().GetAll(gen_issuetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_issuetypeEntity> Igen_issuetypeFacade.GetAllgen_issuetype"));
            }
		}
		
		IList<gen_issuetypeEntity> Igen_issuetypeFacadeObjects.GetAllByPages(gen_issuetypeEntity gen_issuetype)
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().GetAllByPages(gen_issuetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_issuetypeEntity> Igen_issuetypeFacade.GetAllByPagesgen_issuetype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_issuetypeEntity Igen_issuetypeFacadeObjects.GetSingle(gen_issuetypeEntity gen_issuetype)
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().GetSingle(gen_issuetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_issuetypeEntity Igen_issuetypeFacade.GetSinglegen_issuetype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_issuetypeEntity> Igen_issuetypeFacadeObjects.GAPgListView(gen_issuetypeEntity gen_issuetype)
		{
			try
			{
				return DataAccessFactory.Creategen_issuetypeDataAccess().GAPgListView(gen_issuetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_issuetypeEntity> Igen_issuetypeFacade.GAPgListViewgen_issuetype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}