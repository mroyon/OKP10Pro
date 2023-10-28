
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
    public sealed partial class gen_freedomfighttypeFacadeObjects : BaseFacade, Igen_freedomfighttypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_freedomfighttypeFacadeObjects";
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

        public gen_freedomfighttypeFacadeObjects()
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

        ~gen_freedomfighttypeFacadeObjects()
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
		
		long Igen_freedomfighttypeFacadeObjects.Delete(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
            {
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().Delete(gen_freedomfighttype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_freedomfighttypeFacade.Deletegen_freedomfighttype"));
            }
        }
		
		long Igen_freedomfighttypeFacadeObjects.Update(gen_freedomfighttypeEntity gen_freedomfighttype )
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().Update(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_freedomfighttypeFacade.Updategen_freedomfighttype"));
            }
		}
		
		long Igen_freedomfighttypeFacadeObjects.Add(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().Add(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_freedomfighttypeFacade.Addgen_freedomfighttype"));
            }
		}
		
        long Igen_freedomfighttypeFacadeObjects.SaveList(List<gen_freedomfighttypeEntity> list)
        {
            try
            {
                IList<gen_freedomfighttypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_freedomfighttypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_freedomfighttypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_freedomfighttypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_freedomfighttype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacadeObjects.GetAll(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().GetAll(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacade.GetAllgen_freedomfighttype"));
            }
		}
		
		IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacadeObjects.GetAllByPages(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().GetAllByPages(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacade.GetAllByPagesgen_freedomfighttype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_freedomfighttypeEntity Igen_freedomfighttypeFacadeObjects.GetSingle(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().GetSingle(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_freedomfighttypeEntity Igen_freedomfighttypeFacade.GetSinglegen_freedomfighttype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacadeObjects.GAPgListView(gen_freedomfighttypeEntity gen_freedomfighttype)
		{
			try
			{
				return DataAccessFactory.Creategen_freedomfighttypeDataAccess().GAPgListView(gen_freedomfighttype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_freedomfighttypeEntity> Igen_freedomfighttypeFacade.GAPgListViewgen_freedomfighttype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}