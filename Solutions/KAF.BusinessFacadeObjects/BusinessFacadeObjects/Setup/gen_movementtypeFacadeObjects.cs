
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
    public sealed partial class gen_movementtypeFacadeObjects : BaseFacade, Igen_movementtypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_movementtypeFacadeObjects";
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

        public gen_movementtypeFacadeObjects()
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

        ~gen_movementtypeFacadeObjects()
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
		
		long Igen_movementtypeFacadeObjects.Delete(gen_movementtypeEntity gen_movementtype)
		{
			try
            {
				return DataAccessFactory.Creategen_movementtypeDataAccess().Delete(gen_movementtype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_movementtypeFacade.Deletegen_movementtype"));
            }
        }
		
		long Igen_movementtypeFacadeObjects.Update(gen_movementtypeEntity gen_movementtype )
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().Update(gen_movementtype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_movementtypeFacade.Updategen_movementtype"));
            }
		}
		
		long Igen_movementtypeFacadeObjects.Add(gen_movementtypeEntity gen_movementtype)
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().Add(gen_movementtype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_movementtypeFacade.Addgen_movementtype"));
            }
		}
		
        long Igen_movementtypeFacadeObjects.SaveList(List<gen_movementtypeEntity> list)
        {
            try
            {
                IList<gen_movementtypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_movementtypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_movementtypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_movementtypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_movementtype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_movementtypeEntity> Igen_movementtypeFacadeObjects.GetAll(gen_movementtypeEntity gen_movementtype)
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().GetAll(gen_movementtype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_movementtypeEntity> Igen_movementtypeFacade.GetAllgen_movementtype"));
            }
		}
		
		IList<gen_movementtypeEntity> Igen_movementtypeFacadeObjects.GetAllByPages(gen_movementtypeEntity gen_movementtype)
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().GetAllByPages(gen_movementtype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_movementtypeEntity> Igen_movementtypeFacade.GetAllByPagesgen_movementtype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_movementtypeEntity Igen_movementtypeFacadeObjects.GetSingle(gen_movementtypeEntity gen_movementtype)
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().GetSingle(gen_movementtype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_movementtypeEntity Igen_movementtypeFacade.GetSinglegen_movementtype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_movementtypeEntity> Igen_movementtypeFacadeObjects.GAPgListView(gen_movementtypeEntity gen_movementtype)
		{
			try
			{
				return DataAccessFactory.Creategen_movementtypeDataAccess().GAPgListView(gen_movementtype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_movementtypeEntity> Igen_movementtypeFacade.GAPgListViewgen_movementtype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}