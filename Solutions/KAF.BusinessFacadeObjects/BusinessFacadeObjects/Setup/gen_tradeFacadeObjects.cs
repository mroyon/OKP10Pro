
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
    public sealed partial class gen_tradeFacadeObjects : BaseFacade, Igen_tradeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_tradeFacadeObjects";
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

        public gen_tradeFacadeObjects()
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

        ~gen_tradeFacadeObjects()
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
		
		long Igen_tradeFacadeObjects.Delete(gen_tradeEntity gen_trade)
		{
			try
            {
				return DataAccessFactory.Creategen_tradeDataAccess().Delete(gen_trade);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_tradeFacade.Deletegen_trade"));
            }
        }
		
		long Igen_tradeFacadeObjects.Update(gen_tradeEntity gen_trade )
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().Update(gen_trade);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_tradeFacade.Updategen_trade"));
            }
		}
		
		long Igen_tradeFacadeObjects.Add(gen_tradeEntity gen_trade)
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().Add(gen_trade);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_tradeFacade.Addgen_trade"));
            }
		}
		
        long Igen_tradeFacadeObjects.SaveList(List<gen_tradeEntity> list)
        {
            try
            {
                IList<gen_tradeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_tradeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_tradeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_tradeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_trade"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_tradeEntity> Igen_tradeFacadeObjects.GetAll(gen_tradeEntity gen_trade)
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().GetAll(gen_trade);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_tradeEntity> Igen_tradeFacade.GetAllgen_trade"));
            }
		}
		
		IList<gen_tradeEntity> Igen_tradeFacadeObjects.GetAllByPages(gen_tradeEntity gen_trade)
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().GetAllByPages(gen_trade);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_tradeEntity> Igen_tradeFacade.GetAllByPagesgen_trade"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_tradeFacadeObjects.SaveMasterDethr_newdemanddetl(gen_tradeEntity Master, List<hr_newdemanddetlEntity> DetailList)
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
                    return DataAccessFactory.Creategen_tradeDataAccess().SaveMasterDethr_newdemanddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_newdemanddetl"));
               }
        }
        
        
        long Igen_tradeFacadeObjects.SaveMasterDethr_svcinfo(gen_tradeEntity Master, List<hr_svcinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_tradeDataAccess().SaveMasterDethr_svcinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_svcinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_tradeEntity Igen_tradeFacadeObjects.GetSingle(gen_tradeEntity gen_trade)
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().GetSingle(gen_trade);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_tradeEntity Igen_tradeFacade.GetSinglegen_trade"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_tradeEntity> Igen_tradeFacadeObjects.GAPgListView(gen_tradeEntity gen_trade)
		{
			try
			{
				return DataAccessFactory.Creategen_tradeDataAccess().GAPgListView(gen_trade);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_tradeEntity> Igen_tradeFacade.GAPgListViewgen_trade"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}