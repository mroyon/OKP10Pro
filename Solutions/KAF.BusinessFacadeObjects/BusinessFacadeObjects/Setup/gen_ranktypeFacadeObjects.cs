
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
    public sealed partial class gen_ranktypeFacadeObjects : BaseFacade, Igen_ranktypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_ranktypeFacadeObjects";
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

        public gen_ranktypeFacadeObjects()
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

        ~gen_ranktypeFacadeObjects()
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
		
		long Igen_ranktypeFacadeObjects.Delete(gen_ranktypeEntity gen_ranktype)
		{
			try
            {
				return DataAccessFactory.Creategen_ranktypeDataAccess().Delete(gen_ranktype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_ranktypeFacade.Deletegen_ranktype"));
            }
        }
		
		long Igen_ranktypeFacadeObjects.Update(gen_ranktypeEntity gen_ranktype )
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().Update(gen_ranktype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_ranktypeFacade.Updategen_ranktype"));
            }
		}
		
		long Igen_ranktypeFacadeObjects.Add(gen_ranktypeEntity gen_ranktype)
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().Add(gen_ranktype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_ranktypeFacade.Addgen_ranktype"));
            }
		}
		
        long Igen_ranktypeFacadeObjects.SaveList(List<gen_ranktypeEntity> list)
        {
            try
            {
                IList<gen_ranktypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_ranktypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_ranktypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_ranktypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_ranktype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_ranktypeEntity> Igen_ranktypeFacadeObjects.GetAll(gen_ranktypeEntity gen_ranktype)
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().GetAll(gen_ranktype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_ranktypeEntity> Igen_ranktypeFacade.GetAllgen_ranktype"));
            }
		}
		
		IList<gen_ranktypeEntity> Igen_ranktypeFacadeObjects.GetAllByPages(gen_ranktypeEntity gen_ranktype)
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().GetAllByPages(gen_ranktype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_ranktypeEntity> Igen_ranktypeFacade.GetAllByPagesgen_ranktype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_ranktypeFacadeObjects.SaveMasterDetgen_rank(gen_ranktypeEntity Master, List<gen_rankEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_rankEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_rankEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_rankEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_ranktypeDataAccess().SaveMasterDetgen_rank(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_rank"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_ranktypeEntity Igen_ranktypeFacadeObjects.GetSingle(gen_ranktypeEntity gen_ranktype)
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().GetSingle(gen_ranktype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_ranktypeEntity Igen_ranktypeFacade.GetSinglegen_ranktype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_ranktypeEntity> Igen_ranktypeFacadeObjects.GAPgListView(gen_ranktypeEntity gen_ranktype)
		{
			try
			{
				return DataAccessFactory.Creategen_ranktypeDataAccess().GAPgListView(gen_ranktype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_ranktypeEntity> Igen_ranktypeFacade.GAPgListViewgen_ranktype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}