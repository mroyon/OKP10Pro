
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
    public sealed partial class gen_rankFacadeObjects : BaseFacade, Igen_rankFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_rankFacadeObjects";
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

        public gen_rankFacadeObjects()
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

        ~gen_rankFacadeObjects()
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
		
		long Igen_rankFacadeObjects.Delete(gen_rankEntity gen_rank)
		{
			try
            {
				return DataAccessFactory.Creategen_rankDataAccess().Delete(gen_rank);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Deletegen_rank"));
            }
        }
		
		long Igen_rankFacadeObjects.Update(gen_rankEntity gen_rank )
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().Update(gen_rank);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Updategen_rank"));
            }
		}
		
		long Igen_rankFacadeObjects.Add(gen_rankEntity gen_rank)
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().Add(gen_rank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Addgen_rank"));
            }
		}
		
        long Igen_rankFacadeObjects.SaveList(List<gen_rankEntity> list)
        {
            try
            {
                IList<gen_rankEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_rankEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_rankEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_rankDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_rank"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_rankEntity> Igen_rankFacadeObjects.GetAll(gen_rankEntity gen_rank)
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().GetAll(gen_rank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GetAllgen_rank"));
            }
		}
		
		IList<gen_rankEntity> Igen_rankFacadeObjects.GetAllByPages(gen_rankEntity gen_rank)
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().GetAllByPages(gen_rank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GetAllByPagesgen_rank"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_rankFacadeObjects.SaveMasterDethr_promotioninfo(gen_rankEntity Master, List<hr_promotioninfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_promotioninfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_promotioninfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_promotioninfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_rankDataAccess().SaveMasterDethr_promotioninfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_promotioninfo"));
               }
        }
        
        
        long Igen_rankFacadeObjects.SaveMasterDethr_newdemanddetl(gen_rankEntity Master, List<hr_newdemanddetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_newdemanddetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_newdemanddetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_newdemanddetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_rankDataAccess().SaveMasterDethr_newdemanddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_newdemanddetl"));
               }
        }
        
        
        long Igen_rankFacadeObjects.SaveMasterDethr_svcinfo(gen_rankEntity Master, List<hr_svcinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_svcinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_svcinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_svcinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_rankDataAccess().SaveMasterDethr_svcinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_svcinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_rankEntity Igen_rankFacadeObjects.GetSingle(gen_rankEntity gen_rank)
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().GetSingle(gen_rank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_rankEntity Igen_rankFacade.GetSinglegen_rank"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_rankEntity> Igen_rankFacadeObjects.GAPgListView(gen_rankEntity gen_rank)
		{
			try
			{
				return DataAccessFactory.Creategen_rankDataAccess().GAPgListView(gen_rank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GAPgListViewgen_rank"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}