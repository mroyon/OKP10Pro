
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
    public sealed partial class owin_userroledetlentitymapFacadeObjects : BaseFacade, Iowin_userroledetlentitymapFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userroledetlentitymapFacadeObjects";
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

        public owin_userroledetlentitymapFacadeObjects()
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

        ~owin_userroledetlentitymapFacadeObjects()
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
		
		long Iowin_userroledetlentitymapFacadeObjects.Delete(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
            {
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().Delete(owin_userroledetlentitymap);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentitymapFacade.Deleteowin_userroledetlentitymap"));
            }
        }
		
		long Iowin_userroledetlentitymapFacadeObjects.Update(owin_userroledetlentitymapEntity owin_userroledetlentitymap )
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().Update(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentitymapFacade.Updateowin_userroledetlentitymap"));
            }
		}
		
		long Iowin_userroledetlentitymapFacadeObjects.Add(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().Add(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroledetlentitymapFacade.Addowin_userroledetlentitymap"));
            }
		}
		
        long Iowin_userroledetlentitymapFacadeObjects.SaveList(List<owin_userroledetlentitymapEntity> list)
        {
            try
            {
                IList<owin_userroledetlentitymapEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userroledetlentitymapEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userroledetlentitymapEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userroledetlentitymap"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacadeObjects.GetAll(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().GetAll(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacade.GetAllowin_userroledetlentitymap"));
            }
		}
		
		IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacadeObjects.GetAllByPages(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().GetAllByPages(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacade.GetAllByPagesowin_userroledetlentitymap"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_userroledetlentitymapFacadeObjects.SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlentitymapEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList)
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
                    return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().SaveMasterDetowin_userroledetlentityprofilemap(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userroledetlentityprofilemap"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userroledetlentitymapEntity Iowin_userroledetlentitymapFacadeObjects.GetSingle(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().GetSingle(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userroledetlentitymapEntity Iowin_userroledetlentitymapFacade.GetSingleowin_userroledetlentitymap"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacadeObjects.GAPgListView(owin_userroledetlentitymapEntity owin_userroledetlentitymap)
		{
			try
			{
				return DataAccessFactory.Createowin_userroledetlentitymapDataAccess().GAPgListView(owin_userroledetlentitymap);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroledetlentitymapEntity> Iowin_userroledetlentitymapFacade.GAPgListViewowin_userroledetlentitymap"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}