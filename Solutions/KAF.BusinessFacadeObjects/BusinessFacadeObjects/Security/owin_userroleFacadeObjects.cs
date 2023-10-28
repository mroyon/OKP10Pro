
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
    public sealed partial class owin_userroleFacadeObjects : BaseFacade, Iowin_userroleFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userroleFacadeObjects";
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

        public owin_userroleFacadeObjects()
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

        ~owin_userroleFacadeObjects()
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
		
		long Iowin_userroleFacadeObjects.Delete(owin_userroleEntity owin_userrole)
		{
			try
            {
				return DataAccessFactory.Createowin_userroleDataAccess().Delete(owin_userrole);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Deleteowin_userrole"));
            }
        }
		
		long Iowin_userroleFacadeObjects.Update(owin_userroleEntity owin_userrole )
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().Update(owin_userrole);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Updateowin_userrole"));
            }
		}
		
		long Iowin_userroleFacadeObjects.Add(owin_userroleEntity owin_userrole)
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().Add(owin_userrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Addowin_userrole"));
            }
		}
		
        long Iowin_userroleFacadeObjects.SaveList(List<owin_userroleEntity> list)
        {
            try
            {
                IList<owin_userroleEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userroleEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userroleEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userroleDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userrole"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userroleEntity> Iowin_userroleFacadeObjects.GetAll(owin_userroleEntity owin_userrole)
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().GetAll(owin_userrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GetAllowin_userrole"));
            }
		}
		
		IList<owin_userroleEntity> Iowin_userroleFacadeObjects.GetAllByPages(owin_userroleEntity owin_userrole)
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().GetAllByPages(owin_userrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GetAllByPagesowin_userrole"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_userroleFacadeObjects.SaveMasterDetowin_userroledetl(owin_userroleEntity Master, List<owin_userroledetlEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroleDataAccess().SaveMasterDetowin_userroledetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetl"));
               }
        }
        
        
        long Iowin_userroleFacadeObjects.SaveMasterDetowin_userroledetlentitymap(owin_userroleEntity Master, List<owin_userroledetlentitymapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroleDataAccess().SaveMasterDetowin_userroledetlentitymap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentitymap"));
               }
        }
        
        
        long Iowin_userroleFacadeObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userroleEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroleDataAccess().SaveMasterDetowin_userroledetlentityprofilemap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentityprofilemap"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userroleEntity Iowin_userroleFacadeObjects.GetSingle(owin_userroleEntity owin_userrole)
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().GetSingle(owin_userrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userroleEntity Iowin_userroleFacade.GetSingleowin_userrole"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userroleEntity> Iowin_userroleFacadeObjects.GAPgListView(owin_userroleEntity owin_userrole)
		{
			try
			{
				return DataAccessFactory.Createowin_userroleDataAccess().GAPgListView(owin_userrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GAPgListViewowin_userrole"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}