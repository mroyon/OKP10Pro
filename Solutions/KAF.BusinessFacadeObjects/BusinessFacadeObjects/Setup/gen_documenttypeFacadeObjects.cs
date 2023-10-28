
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
    public sealed partial class gen_documenttypeFacadeObjects : BaseFacade, Igen_documenttypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_documenttypeFacadeObjects";
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

        public gen_documenttypeFacadeObjects()
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

        ~gen_documenttypeFacadeObjects()
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
		
		long Igen_documenttypeFacadeObjects.Delete(gen_documenttypeEntity gen_documenttype)
		{
			try
            {
				return DataAccessFactory.Creategen_documenttypeDataAccess().Delete(gen_documenttype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_documenttypeFacade.Deletegen_documenttype"));
            }
        }
		
		long Igen_documenttypeFacadeObjects.Update(gen_documenttypeEntity gen_documenttype )
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().Update(gen_documenttype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_documenttypeFacade.Updategen_documenttype"));
            }
		}
		
		long Igen_documenttypeFacadeObjects.Add(gen_documenttypeEntity gen_documenttype)
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().Add(gen_documenttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_documenttypeFacade.Addgen_documenttype"));
            }
		}
		
        long Igen_documenttypeFacadeObjects.SaveList(List<gen_documenttypeEntity> list)
        {
            try
            {
                IList<gen_documenttypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_documenttypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_documenttypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_documenttypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_documenttype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_documenttypeEntity> Igen_documenttypeFacadeObjects.GetAll(gen_documenttypeEntity gen_documenttype)
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().GetAll(gen_documenttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_documenttypeEntity> Igen_documenttypeFacade.GetAllgen_documenttype"));
            }
		}
		
		IList<gen_documenttypeEntity> Igen_documenttypeFacadeObjects.GetAllByPages(gen_documenttypeEntity gen_documenttype)
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().GetAllByPages(gen_documenttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_documenttypeEntity> Igen_documenttypeFacade.GetAllByPagesgen_documenttype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_documenttypeEntity Igen_documenttypeFacadeObjects.GetSingle(gen_documenttypeEntity gen_documenttype)
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().GetSingle(gen_documenttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_documenttypeEntity Igen_documenttypeFacade.GetSinglegen_documenttype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_documenttypeEntity> Igen_documenttypeFacadeObjects.GAPgListView(gen_documenttypeEntity gen_documenttype)
		{
			try
			{
				return DataAccessFactory.Creategen_documenttypeDataAccess().GAPgListView(gen_documenttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_documenttypeEntity> Igen_documenttypeFacade.GAPgListViewgen_documenttype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}