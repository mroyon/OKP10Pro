
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
    public sealed partial class owin_userFacadeObjects : BaseFacade, Iowin_userFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userFacadeObjects";
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

        public owin_userFacadeObjects()
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

        ~owin_userFacadeObjects()
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
		
		long Iowin_userFacadeObjects.Delete(owin_userEntity owin_user)
		{
			try
            {
				return DataAccessFactory.Createowin_userDataAccess().Delete(owin_user);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Deleteowin_user"));
            }
        }
		
		long Iowin_userFacadeObjects.Update(owin_userEntity owin_user )
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().Update(owin_user);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Updateowin_user"));
            }
		}
		
		long Iowin_userFacadeObjects.Add(owin_userEntity owin_user)
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().Add(owin_user);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Addowin_user"));
            }
		}
		
        long Iowin_userFacadeObjects.SaveList(List<owin_userEntity> list)
        {
            try
            {
                IList<owin_userEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_user"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userEntity> Iowin_userFacadeObjects.GetAll(owin_userEntity owin_user)
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().GetAll(owin_user);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GetAllowin_user"));
            }
		}
		
		IList<owin_userEntity> Iowin_userFacadeObjects.GetAllByPages(owin_userEntity owin_user)
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().GetAllByPages(owin_user);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GetAllByPagesowin_user"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_lastworkingpage(owin_userEntity Master, List<owin_lastworkingpageEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_lastworkingpageEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_lastworkingpageEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_lastworkingpageEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_lastworkingpage(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_lastworkingpage"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_reportpermission(owin_userEntity Master, List<owin_reportpermissionEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_reportpermissionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_reportpermissionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_reportpermissionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_reportpermission(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_reportpermission"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userroledetl(owin_userEntity Master, List<owin_userroledetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userroledetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userroledetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userroledetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userroledetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetl"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_tsv(owin_userEntity Master, List<owin_tsvEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_tsvEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_tsvEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_tsvEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_tsv(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_tsv"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userlogintrail(owin_userEntity Master, List<owin_userlogintrailEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userlogintrailEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userlogintrailEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userlogintrailEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userlogintrail(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userlogintrail"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userpasswordresetinfo(owin_userEntity Master, List<owin_userpasswordresetinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userpasswordresetinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userpasswordresetinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userpasswordresetinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userpasswordresetinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userpasswordresetinfo"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userprefferencessettings(owin_userEntity Master, List<owin_userprefferencessettingsEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userprefferencessettingsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userprefferencessettingsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userprefferencessettingsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userprefferencessettings(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userprefferencessettings"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userrole(owin_userEntity Master, List<owin_userroleEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userroleEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userroleEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userroleEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userrole(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userrole"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userroledetlentitymap(owin_userEntity Master, List<owin_userroledetlentitymapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userroledetlentitymap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentitymap"));
               }
        }
        
        
        long Iowin_userFacadeObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userroledetlentityprofilemapEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userroledetlentityprofilemapEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userroledetlentityprofilemapEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userroledetlentityprofilemap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentityprofilemap"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userEntity Iowin_userFacadeObjects.GetSingle(owin_userEntity owin_user)
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().GetSingle(owin_user);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userEntity Iowin_userFacade.GetSingleowin_user"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userEntity> Iowin_userFacadeObjects.GAPgListView(owin_userEntity owin_user)
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().GAPgListView(owin_user);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GAPgListViewowin_user"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Iowin_userFacadeObjects.UpdateReviewed(owin_userEntity owin_user )
		{
			try
			{
				return DataAccessFactory.Createowin_userDataAccess().UpdateReviewed(owin_user);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.UpdateReviewedowin_user"));
            }
		}
        #endregion 
    
        #endregion
	}
}