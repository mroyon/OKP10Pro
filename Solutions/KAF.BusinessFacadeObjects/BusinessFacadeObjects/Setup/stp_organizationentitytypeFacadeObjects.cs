
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
    public sealed partial class stp_organizationentitytypeFacadeObjects : BaseFacade, Istp_organizationentitytypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_organizationentitytypeFacadeObjects";
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

        public stp_organizationentitytypeFacadeObjects()
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

        ~stp_organizationentitytypeFacadeObjects()
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
		
		long Istp_organizationentitytypeFacadeObjects.Delete(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
            {
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().Delete(stp_organizationentitytype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentitytypeFacade.Deletestp_organizationentitytype"));
            }
        }
		
		long Istp_organizationentitytypeFacadeObjects.Update(stp_organizationentitytypeEntity stp_organizationentitytype )
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().Update(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_organizationentitytypeFacade.Updatestp_organizationentitytype"));
            }
		}
		
		long Istp_organizationentitytypeFacadeObjects.Add(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().Add(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentitytypeFacade.Addstp_organizationentitytype"));
            }
		}
		
        long Istp_organizationentitytypeFacadeObjects.SaveList(List<stp_organizationentitytypeEntity> list)
        {
            try
            {
                IList<stp_organizationentitytypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<stp_organizationentitytypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<stp_organizationentitytypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createstp_organizationentitytypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_organizationentitytype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacadeObjects.GetAll(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().GetAll(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacade.GetAllstp_organizationentitytype"));
            }
		}
		
		IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacadeObjects.GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().GetAllByPages(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacade.GetAllByPagesstp_organizationentitytype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Istp_organizationentitytypeFacadeObjects.SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity Master, List<stp_organizationentityEntity> DetailList)
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
                    return DataAccessFactory.Createstp_organizationentitytypeDataAccess().SaveMasterDetstp_organizationentity(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_organizationentity"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        stp_organizationentitytypeEntity Istp_organizationentitytypeFacadeObjects.GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().GetSingle(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("stp_organizationentitytypeEntity Istp_organizationentitytypeFacade.GetSinglestp_organizationentitytype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacadeObjects.GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentitytypeDataAccess().GAPgListView(stp_organizationentitytype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacade.GAPgListViewstp_organizationentitytype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}