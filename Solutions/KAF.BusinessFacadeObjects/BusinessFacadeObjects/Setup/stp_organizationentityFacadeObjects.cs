
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
    public sealed partial class stp_organizationentityFacadeObjects : BaseFacade, Istp_organizationentityFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_organizationentityFacadeObjects";
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

        public stp_organizationentityFacadeObjects()
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

        ~stp_organizationentityFacadeObjects()
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
		
		long Istp_organizationentityFacadeObjects.Delete(stp_organizationentityEntity stp_organizationentity)
		{
			try
            {
				return DataAccessFactory.Createstp_organizationentityDataAccess().Delete(stp_organizationentity);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Deletestp_organizationentity"));
            }
        }
		
		long Istp_organizationentityFacadeObjects.Update(stp_organizationentityEntity stp_organizationentity )
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().Update(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Updatestp_organizationentity"));
            }
		}
		
		long Istp_organizationentityFacadeObjects.Add(stp_organizationentityEntity stp_organizationentity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().Add(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Addstp_organizationentity"));
            }
		}
		
        long Istp_organizationentityFacadeObjects.SaveList(List<stp_organizationentityEntity> list)
        {
            try
            {
                IList<stp_organizationentityEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<stp_organizationentityEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<stp_organizationentityEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createstp_organizationentityDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_organizationentity"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<stp_organizationentityEntity> Istp_organizationentityFacadeObjects.GetAll(stp_organizationentityEntity stp_organizationentity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().GetAll(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetAllstp_organizationentity"));
            }
		}
		
		IList<stp_organizationentityEntity> Istp_organizationentityFacadeObjects.GetAllByPages(stp_organizationentityEntity stp_organizationentity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().GetAllByPages(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetAllByPagesstp_organizationentity"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Istp_organizationentityFacadeObjects.SaveMasterDetgen_arms(stp_organizationentityEntity Master, List<gen_armsEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_armsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_armsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_armsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetgen_arms(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_arms"));
               }
        }
        
        
        long Istp_organizationentityFacadeObjects.SaveMasterDethr_svcinfo(stp_organizationentityEntity Master, List<hr_svcinfoEntity> DetailList)
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
                    return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDethr_svcinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_servicerelatedinfo"));
               }
        }
        
        
      //  long Istp_organizationentityFacadeObjects.SaveMasterDethr_relativesworkinginmod(stp_organizationentityEntity Master, List<hr_relativesworkinginmodEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<hr_relativesworkinginmodEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<hr_relativesworkinginmodEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<hr_relativesworkinginmodEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDethr_relativesworkinginmod(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_relativesworkinginmod"));
      //         }
      //  }
        
        
        long Istp_organizationentityFacadeObjects.SaveMasterDetowin_userroledetlentitymap(stp_organizationentityEntity Master, List<owin_userroledetlentitymapEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userroledetlentitymapEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userroledetlentitymapEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userroledetlentitymapEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetowin_userroledetlentitymap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentitymap"));
               }
        }
        
        
        long Istp_organizationentityFacadeObjects.SaveMasterDetstp_organizationentity(stp_organizationentityEntity Master, List<stp_organizationentityEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<stp_organizationentityEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<stp_organizationentityEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<stp_organizationentityEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetstp_organizationentity(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_organizationentity"));
               }
        }
        
        
        long Istp_organizationentityFacadeObjects.SaveMasterDetuseraccountsprof(stp_organizationentityEntity Master, List<useraccountsprofEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<useraccountsprofEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<useraccountsprofEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<useraccountsprofEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetuseraccountsprof(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetuseraccountsprof"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        stp_organizationentityEntity Istp_organizationentityFacadeObjects.GetSingle(stp_organizationentityEntity stp_organizationentity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().GetSingle(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("stp_organizationentityEntity Istp_organizationentityFacade.GetSinglestp_organizationentity"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<stp_organizationentityEntity> Istp_organizationentityFacadeObjects.GAPgListView(stp_organizationentityEntity stp_organizationentity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().GAPgListView(stp_organizationentity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GAPgListViewstp_organizationentity"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}