
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
    public sealed partial class gen_okpcoFacadeObjects : BaseFacade, Igen_okpcoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_okpcoFacadeObjects";
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

        public gen_okpcoFacadeObjects()
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

        ~gen_okpcoFacadeObjects()
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
		
		long Igen_okpcoFacadeObjects.Delete(gen_okpcoEntity gen_okpco)
		{
			try
            {
				return DataAccessFactory.Creategen_okpcoDataAccess().Delete(gen_okpco);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_okpcoFacade.Deletegen_okpco"));
            }
        }
		
		long Igen_okpcoFacadeObjects.Update(gen_okpcoEntity gen_okpco )
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().Update(gen_okpco);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_okpcoFacade.Updategen_okpco"));
            }
		}
		
		long Igen_okpcoFacadeObjects.Add(gen_okpcoEntity gen_okpco)
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().Add(gen_okpco);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_okpcoFacade.Addgen_okpco"));
            }
		}
		
        long Igen_okpcoFacadeObjects.SaveList(List<gen_okpcoEntity> list)
        {
            try
            {
                IList<gen_okpcoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_okpcoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_okpcoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_okpcoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_okpco"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_okpcoEntity> Igen_okpcoFacadeObjects.GetAll(gen_okpcoEntity gen_okpco)
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().GetAll(gen_okpco);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_okpcoEntity> Igen_okpcoFacade.GetAllgen_okpco"));
            }
		}
		
		IList<gen_okpcoEntity> Igen_okpcoFacadeObjects.GetAllByPages(gen_okpcoEntity gen_okpco)
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().GetAllByPages(gen_okpco);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_okpcoEntity> Igen_okpcoFacade.GetAllByPagesgen_okpco"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_okpcoEntity Igen_okpcoFacadeObjects.GetSingle(gen_okpcoEntity gen_okpco)
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().GetSingle(gen_okpco);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_okpcoEntity Igen_okpcoFacade.GetSinglegen_okpco"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_okpcoEntity> Igen_okpcoFacadeObjects.GAPgListView(gen_okpcoEntity gen_okpco)
		{
			try
			{
				return DataAccessFactory.Creategen_okpcoDataAccess().GAPgListView(gen_okpco);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_okpcoEntity> Igen_okpcoFacade.GAPgListViewgen_okpco"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}