
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
    public sealed partial class gen_servicestatusFacadeObjects : BaseFacade, Igen_servicestatusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_servicestatusFacadeObjects";
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

        public gen_servicestatusFacadeObjects()
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

        ~gen_servicestatusFacadeObjects()
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
		
		long Igen_servicestatusFacadeObjects.Delete(gen_servicestatusEntity gen_servicestatus)
		{
			try
            {
				return DataAccessFactory.Creategen_servicestatusDataAccess().Delete(gen_servicestatus);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestatusFacade.Deletegen_servicestatus"));
            }
        }
		
		long Igen_servicestatusFacadeObjects.Update(gen_servicestatusEntity gen_servicestatus )
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().Update(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_servicestatusFacade.Updategen_servicestatus"));
            }
		}
		
		long Igen_servicestatusFacadeObjects.Add(gen_servicestatusEntity gen_servicestatus)
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().Add(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestatusFacade.Addgen_servicestatus"));
            }
		}
		
        long Igen_servicestatusFacadeObjects.SaveList(List<gen_servicestatusEntity> list)
        {
            try
            {
                IList<gen_servicestatusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_servicestatusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_servicestatusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_servicestatusDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_servicestatus"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_servicestatusEntity> Igen_servicestatusFacadeObjects.GetAll(gen_servicestatusEntity gen_servicestatus)
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().GetAll(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestatusEntity> Igen_servicestatusFacade.GetAllgen_servicestatus"));
            }
		}
		
		IList<gen_servicestatusEntity> Igen_servicestatusFacadeObjects.GetAllByPages(gen_servicestatusEntity gen_servicestatus)
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().GetAllByPages(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestatusEntity> Igen_servicestatusFacade.GetAllByPagesgen_servicestatus"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_servicestatusEntity Igen_servicestatusFacadeObjects.GetSingle(gen_servicestatusEntity gen_servicestatus)
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().GetSingle(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_servicestatusEntity Igen_servicestatusFacade.GetSinglegen_servicestatus"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_servicestatusEntity> Igen_servicestatusFacadeObjects.GAPgListView(gen_servicestatusEntity gen_servicestatus)
		{
			try
			{
				return DataAccessFactory.Creategen_servicestatusDataAccess().GAPgListView(gen_servicestatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestatusEntity> Igen_servicestatusFacade.GAPgListViewgen_servicestatus"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}