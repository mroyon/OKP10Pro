
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
    public sealed partial class owin_reportroleFacadeObjects : BaseFacade, Iowin_reportroleFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_reportroleFacadeObjects";
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

        public owin_reportroleFacadeObjects()
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

        ~owin_reportroleFacadeObjects()
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
		
		long Iowin_reportroleFacadeObjects.Delete(owin_reportroleEntity owin_reportrole)
		{
			try
            {
				return DataAccessFactory.Createowin_reportroleDataAccess().Delete(owin_reportrole);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportroleFacade.Deleteowin_reportrole"));
            }
        }
		
		long Iowin_reportroleFacadeObjects.Update(owin_reportroleEntity owin_reportrole )
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().Update(owin_reportrole);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_reportroleFacade.Updateowin_reportrole"));
            }
		}
		
		long Iowin_reportroleFacadeObjects.Add(owin_reportroleEntity owin_reportrole)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().Add(owin_reportrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportroleFacade.Addowin_reportrole"));
            }
		}
		
        long Iowin_reportroleFacadeObjects.SaveList(List<owin_reportroleEntity> list)
        {
            try
            {
                IList<owin_reportroleEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_reportroleEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_reportroleEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_reportroleDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_reportrole"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_reportroleEntity> Iowin_reportroleFacadeObjects.GetAll(owin_reportroleEntity owin_reportrole)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().GetAll(owin_reportrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroleEntity> Iowin_reportroleFacade.GetAllowin_reportrole"));
            }
		}
		
		IList<owin_reportroleEntity> Iowin_reportroleFacadeObjects.GetAllByPages(owin_reportroleEntity owin_reportrole)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().GetAllByPages(owin_reportrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroleEntity> Iowin_reportroleFacade.GetAllByPagesowin_reportrole"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_reportroleFacadeObjects.SaveMasterDetowin_reportpermission(owin_reportroleEntity Master, List<owin_reportpermissionEntity> DetailList)
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
                    return DataAccessFactory.Createowin_reportroleDataAccess().SaveMasterDetowin_reportpermission(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_reportpermission"));
               }
        }
        
        
        long Iowin_reportroleFacadeObjects.SaveMasterDetowin_reportroletemplate(owin_reportroleEntity Master, List<owin_reportroletemplateEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_reportroletemplateEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_reportroletemplateEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_reportroletemplateEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_reportroleDataAccess().SaveMasterDetowin_reportroletemplate(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_reportroletemplate"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_reportroleEntity Iowin_reportroleFacadeObjects.GetSingle(owin_reportroleEntity owin_reportrole)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().GetSingle(owin_reportrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_reportroleEntity Iowin_reportroleFacade.GetSingleowin_reportrole"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_reportroleEntity> Iowin_reportroleFacadeObjects.GAPgListView(owin_reportroleEntity owin_reportrole)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroleDataAccess().GAPgListView(owin_reportrole);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroleEntity> Iowin_reportroleFacade.GAPgListViewowin_reportrole"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}