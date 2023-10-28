
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
    public sealed partial class gen_penaltytypeFacadeObjects : BaseFacade, Igen_penaltytypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_penaltytypeFacadeObjects";
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

        public gen_penaltytypeFacadeObjects()
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

        ~gen_penaltytypeFacadeObjects()
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
		
		long Igen_penaltytypeFacadeObjects.Delete(gen_penaltytypeEntity gen_penaltytype)
		{
			try
            {
				return DataAccessFactory.Creategen_penaltytypeDataAccess().Delete(gen_penaltytype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_penaltytypeFacade.Deletegen_penaltytype"));
            }
        }
		
		long Igen_penaltytypeFacadeObjects.Update(gen_penaltytypeEntity gen_penaltytype )
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().Update(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_penaltytypeFacade.Updategen_penaltytype"));
            }
		}
		
		long Igen_penaltytypeFacadeObjects.Add(gen_penaltytypeEntity gen_penaltytype)
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().Add(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_penaltytypeFacade.Addgen_penaltytype"));
            }
		}
		
        long Igen_penaltytypeFacadeObjects.SaveList(List<gen_penaltytypeEntity> list)
        {
            try
            {
                IList<gen_penaltytypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_penaltytypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_penaltytypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_penaltytypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_penaltytype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_penaltytypeEntity> Igen_penaltytypeFacadeObjects.GetAll(gen_penaltytypeEntity gen_penaltytype)
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().GetAll(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_penaltytypeEntity> Igen_penaltytypeFacade.GetAllgen_penaltytype"));
            }
		}
		
		IList<gen_penaltytypeEntity> Igen_penaltytypeFacadeObjects.GetAllByPages(gen_penaltytypeEntity gen_penaltytype)
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().GetAllByPages(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_penaltytypeEntity> Igen_penaltytypeFacade.GetAllByPagesgen_penaltytype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_penaltytypeEntity Igen_penaltytypeFacadeObjects.GetSingle(gen_penaltytypeEntity gen_penaltytype)
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().GetSingle(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_penaltytypeEntity Igen_penaltytypeFacade.GetSinglegen_penaltytype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_penaltytypeEntity> Igen_penaltytypeFacadeObjects.GAPgListView(gen_penaltytypeEntity gen_penaltytype)
		{
			try
			{
				return DataAccessFactory.Creategen_penaltytypeDataAccess().GAPgListView(gen_penaltytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_penaltytypeEntity> Igen_penaltytypeFacade.GAPgListViewgen_penaltytype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}