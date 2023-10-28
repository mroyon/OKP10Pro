
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
    public sealed partial class stp_countrycityFacadeObjects : BaseFacade, Istp_countrycityFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_countrycityFacadeObjects";
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

        public stp_countrycityFacadeObjects()
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

        ~stp_countrycityFacadeObjects()
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
		
		long Istp_countrycityFacadeObjects.Delete(stp_countrycityEntity stp_countrycity)
		{
			try
            {
				return DataAccessFactory.Createstp_countrycityDataAccess().Delete(stp_countrycity);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_countrycityFacade.Deletestp_countrycity"));
            }
        }
		
		long Istp_countrycityFacadeObjects.Update(stp_countrycityEntity stp_countrycity )
		{
			try
			{
				return DataAccessFactory.Createstp_countrycityDataAccess().Update(stp_countrycity);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_countrycityFacade.Updatestp_countrycity"));
            }
		}
		
		long Istp_countrycityFacadeObjects.Add(stp_countrycityEntity stp_countrycity)
		{
			try
			{
				return DataAccessFactory.Createstp_countrycityDataAccess().Add(stp_countrycity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_countrycityFacade.Addstp_countrycity"));
            }
		}
		
        long Istp_countrycityFacadeObjects.SaveList(List<stp_countrycityEntity> list)
        {
            try
            {
                IList<stp_countrycityEntity> listAdded = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Added);
                IList<stp_countrycityEntity> listUpdated = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Changed);
                IList<stp_countrycityEntity> listDeleted = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createstp_countrycityDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_countrycity"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<stp_countrycityEntity> Istp_countrycityFacadeObjects.GetAll(stp_countrycityEntity stp_countrycity)
		{
			try
			{
				return DataAccessFactory.Createstp_countrycityDataAccess().GetAll(stp_countrycity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_countrycityEntity> Istp_countrycityFacade.GetAllstp_countrycity"));
            }
		}
		
		IList<stp_countrycityEntity> Istp_countrycityFacadeObjects.GetAllByPages(stp_countrycityEntity stp_countrycity)
		{
			try
			{
				return DataAccessFactory.Createstp_countrycityDataAccess().GetAllByPages(stp_countrycity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_countrycityEntity> Istp_countrycityFacade.GetAllByPagesstp_countrycity"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Istp_countrycityFacadeObjects.SaveMasterDetstp_countrycity(stp_countrycityEntity Master, List<stp_countrycityEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<stp_countrycityEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Added);
                    IList<stp_countrycityEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Changed);
                    IList<stp_countrycityEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createstp_countrycityDataAccess().SaveMasterDetstp_countrycity(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_countrycity"));
               }
        }
        
        
        #endregion	
	
        #endregion
	}
}