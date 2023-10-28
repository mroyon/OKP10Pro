
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
    public sealed partial class gen_monthFacadeObjects : BaseFacade, Igen_monthFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_monthFacadeObjects";
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

        public gen_monthFacadeObjects()
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

        ~gen_monthFacadeObjects()
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
		
		long Igen_monthFacadeObjects.Delete(gen_monthEntity gen_month)
		{
			try
            {
				return DataAccessFactory.Creategen_monthDataAccess().Delete(gen_month);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_monthFacade.Deletegen_month"));
            }
        }
		
		long Igen_monthFacadeObjects.Update(gen_monthEntity gen_month )
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().Update(gen_month);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_monthFacade.Updategen_month"));
            }
		}
		
		long Igen_monthFacadeObjects.Add(gen_monthEntity gen_month)
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().Add(gen_month);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_monthFacade.Addgen_month"));
            }
		}
		
        long Igen_monthFacadeObjects.SaveList(List<gen_monthEntity> list)
        {
            try
            {
                IList<gen_monthEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_monthEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_monthEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_monthDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_month"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_monthEntity> Igen_monthFacadeObjects.GetAll(gen_monthEntity gen_month)
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().GetAll(gen_month);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_monthEntity> Igen_monthFacade.GetAllgen_month"));
            }
		}
		
		IList<gen_monthEntity> Igen_monthFacadeObjects.GetAllByPages(gen_monthEntity gen_month)
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().GetAllByPages(gen_month);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_monthEntity> Igen_monthFacade.GetAllByPagesgen_month"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_monthEntity Igen_monthFacadeObjects.GetSingle(gen_monthEntity gen_month)
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().GetSingle(gen_month);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_monthEntity Igen_monthFacade.GetSinglegen_month"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_monthEntity> Igen_monthFacadeObjects.GAPgListView(gen_monthEntity gen_month)
		{
			try
			{
				return DataAccessFactory.Creategen_monthDataAccess().GAPgListView(gen_month);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_monthEntity> Igen_monthFacade.GAPgListViewgen_month"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}