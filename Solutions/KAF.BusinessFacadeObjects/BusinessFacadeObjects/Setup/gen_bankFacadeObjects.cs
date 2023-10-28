
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
    public sealed partial class gen_bankFacadeObjects : BaseFacade, Igen_bankFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_bankFacadeObjects";
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

        public gen_bankFacadeObjects()
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

        ~gen_bankFacadeObjects()
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
		
		long Igen_bankFacadeObjects.Delete(gen_bankEntity gen_bank)
		{
			try
            {
				return DataAccessFactory.Creategen_bankDataAccess().Delete(gen_bank);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bankFacade.Deletegen_bank"));
            }
        }
		
		long Igen_bankFacadeObjects.Update(gen_bankEntity gen_bank )
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().Update(gen_bank);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_bankFacade.Updategen_bank"));
            }
		}
		
		long Igen_bankFacadeObjects.Add(gen_bankEntity gen_bank)
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().Add(gen_bank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bankFacade.Addgen_bank"));
            }
		}
		
        long Igen_bankFacadeObjects.SaveList(List<gen_bankEntity> list)
        {
            try
            {
                IList<gen_bankEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_bankEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_bankEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_bankDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_bank"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_bankEntity> Igen_bankFacadeObjects.GetAll(gen_bankEntity gen_bank)
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().GetAll(gen_bank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankEntity> Igen_bankFacade.GetAllgen_bank"));
            }
		}
		
		IList<gen_bankEntity> Igen_bankFacadeObjects.GetAllByPages(gen_bankEntity gen_bank)
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().GetAllByPages(gen_bank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankEntity> Igen_bankFacade.GetAllByPagesgen_bank"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_bankFacadeObjects.SaveMasterDetgen_bankbranch(gen_bankEntity Master, List<gen_bankbranchEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_bankbranchEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_bankbranchEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_bankbranchEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_bankDataAccess().SaveMasterDetgen_bankbranch(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_bankbranch"));
               }
        }
        
        
        long Igen_bankFacadeObjects.SaveMasterDethr_bankaccountinfo(gen_bankEntity Master, List<hr_bankaccountinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_bankaccountinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_bankaccountinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_bankaccountinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_bankDataAccess().SaveMasterDethr_bankaccountinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_bankaccountinfo"));
               }
        }
        
        
        long Igen_bankFacadeObjects.SaveMasterDethr_bankloaninfo(gen_bankEntity Master, List<hr_bankloaninfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_bankloaninfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_bankloaninfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_bankloaninfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_bankDataAccess().SaveMasterDethr_bankloaninfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_bankloaninfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_bankEntity Igen_bankFacadeObjects.GetSingle(gen_bankEntity gen_bank)
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().GetSingle(gen_bank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_bankEntity Igen_bankFacade.GetSinglegen_bank"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_bankEntity> Igen_bankFacadeObjects.GAPgListView(gen_bankEntity gen_bank)
		{
			try
			{
				return DataAccessFactory.Creategen_bankDataAccess().GAPgListView(gen_bank);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankEntity> Igen_bankFacade.GAPgListViewgen_bank"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}