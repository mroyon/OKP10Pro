
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
    public sealed partial class gen_bankbranchFacadeObjects : BaseFacade, Igen_bankbranchFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_bankbranchFacadeObjects";
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

        public gen_bankbranchFacadeObjects()
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

        ~gen_bankbranchFacadeObjects()
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
		
		long Igen_bankbranchFacadeObjects.Delete(gen_bankbranchEntity gen_bankbranch)
		{
			try
            {
				return DataAccessFactory.Creategen_bankbranchDataAccess().Delete(gen_bankbranch);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bankbranchFacade.Deletegen_bankbranch"));
            }
        }
		
		long Igen_bankbranchFacadeObjects.Update(gen_bankbranchEntity gen_bankbranch )
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().Update(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_bankbranchFacade.Updategen_bankbranch"));
            }
		}
		
		long Igen_bankbranchFacadeObjects.Add(gen_bankbranchEntity gen_bankbranch)
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().Add(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bankbranchFacade.Addgen_bankbranch"));
            }
		}
		
        long Igen_bankbranchFacadeObjects.SaveList(List<gen_bankbranchEntity> list)
        {
            try
            {
                IList<gen_bankbranchEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_bankbranchEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_bankbranchEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_bankbranchDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_bankbranch"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_bankbranchEntity> Igen_bankbranchFacadeObjects.GetAll(gen_bankbranchEntity gen_bankbranch)
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().GetAll(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankbranchEntity> Igen_bankbranchFacade.GetAllgen_bankbranch"));
            }
		}
		
		IList<gen_bankbranchEntity> Igen_bankbranchFacadeObjects.GetAllByPages(gen_bankbranchEntity gen_bankbranch)
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().GetAllByPages(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankbranchEntity> Igen_bankbranchFacade.GetAllByPagesgen_bankbranch"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_bankbranchFacadeObjects.SaveMasterDethr_bankaccountinfo(gen_bankbranchEntity Master, List<hr_bankaccountinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_bankbranchDataAccess().SaveMasterDethr_bankaccountinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_bankaccountinfo"));
               }
        }
        
        
        long Igen_bankbranchFacadeObjects.SaveMasterDethr_bankloaninfo(gen_bankbranchEntity Master, List<hr_bankloaninfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_bankbranchDataAccess().SaveMasterDethr_bankloaninfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_bankloaninfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_bankbranchEntity Igen_bankbranchFacadeObjects.GetSingle(gen_bankbranchEntity gen_bankbranch)
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().GetSingle(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_bankbranchEntity Igen_bankbranchFacade.GetSinglegen_bankbranch"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_bankbranchEntity> Igen_bankbranchFacadeObjects.GAPgListView(gen_bankbranchEntity gen_bankbranch)
		{
			try
			{
				return DataAccessFactory.Creategen_bankbranchDataAccess().GAPgListView(gen_bankbranch);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankbranchEntity> Igen_bankbranchFacade.GAPgListViewgen_bankbranch"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}