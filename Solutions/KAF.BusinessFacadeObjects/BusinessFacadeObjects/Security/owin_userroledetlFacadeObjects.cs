
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
    public sealed partial class owin_userroledetlFacadeObjects : BaseFacade, Iowin_userroledetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userroledetlFacadeObjects";
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

        public owin_userroledetlFacadeObjects()
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

        ~owin_userroledetlFacadeObjects()
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
		
		long Iowin_userroledetlFacadeObjects.Delete(owin_userroledetlEntity owin_userroledetl)
		{
			try
            {
				return DataAccessFactory.Createowin_userroledetlDataAccess().Delete(owin_userroledetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlFacade.Deleteowin_userroledetl"));
            }
        }
		
		long Iowin_userroledetlFacadeObjects.Update(owin_userroledetlEntity owin_userroledetl )
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().Update(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlFacade.Updateowin_userroledetl"));
            }
		}
		
		long Iowin_userroledetlFacadeObjects.Add(owin_userroledetlEntity owin_userroledetl)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().Add(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlFacade.Addowin_userroledetl"));
            }
		}
		
        long Iowin_userroledetlFacadeObjects.SaveList(List<owin_userroledetlEntity> list)
        {
            try
            {
                IList<owin_userroledetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userroledetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userroledetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userroledetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userroledetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userroledetlEntity> Iowin_userroledetlFacadeObjects.GetAll(owin_userroledetlEntity owin_userroledetl)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().GetAll(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlEntity> Iowin_userroledetlFacade.GetAllowin_userroledetl"));
            }
		}
		
		IList<owin_userroledetlEntity> Iowin_userroledetlFacadeObjects.GetAllByPages(owin_userroledetlEntity owin_userroledetl)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().GetAllByPages(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlEntity> Iowin_userroledetlFacade.GetAllByPagesowin_userroledetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_userroledetlFacadeObjects.SaveMasterDetowin_userroledetlentitymap(owin_userroledetlEntity Master, List<owin_userroledetlentitymapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroledetlDataAccess().SaveMasterDetowin_userroledetlentitymap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentitymap"));
               }
        }
        
        
        long Iowin_userroledetlFacadeObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroledetlDataAccess().SaveMasterDetowin_userroledetlentityprofilemap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentityprofilemap"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userroledetlEntity Iowin_userroledetlFacadeObjects.GetSingle(owin_userroledetlEntity owin_userroledetl)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().GetSingle(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userroledetlEntity Iowin_userroledetlFacade.GetSingleowin_userroledetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userroledetlEntity> Iowin_userroledetlFacadeObjects.GAPgListView(owin_userroledetlEntity owin_userroledetl)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlDataAccess().GAPgListView(owin_userroledetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlEntity> Iowin_userroledetlFacade.GAPgListViewowin_userroledetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}