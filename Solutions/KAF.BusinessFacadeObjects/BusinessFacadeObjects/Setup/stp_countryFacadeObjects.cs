
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
    public sealed partial class stp_countryFacadeObjects : BaseFacade, Istp_countryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_countryFacadeObjects";
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

        public stp_countryFacadeObjects()
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

        ~stp_countryFacadeObjects()
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
		
		long Istp_countryFacadeObjects.Delete(stp_countryEntity stp_country)
		{
			try
            {
				return DataAccessFactory.Createstp_countryDataAccess().Delete(stp_country);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_countryFacade.Deletestp_country"));
            }
        }
		
		long Istp_countryFacadeObjects.Update(stp_countryEntity stp_country )
		{
			try
			{
				return DataAccessFactory.Createstp_countryDataAccess().Update(stp_country);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_countryFacade.Updatestp_country"));
            }
		}
		
		long Istp_countryFacadeObjects.Add(stp_countryEntity stp_country)
		{
			try
			{
				return DataAccessFactory.Createstp_countryDataAccess().Add(stp_country);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_countryFacade.Addstp_country"));
            }
		}
		
        long Istp_countryFacadeObjects.SaveList(List<stp_countryEntity> list)
        {
            try
            {
                IList<stp_countryEntity> listAdded = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Added);
                IList<stp_countryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Changed);
                IList<stp_countryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == KAF.BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createstp_countryDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_country"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<stp_countryEntity> Istp_countryFacadeObjects.GetAll(stp_countryEntity stp_country)
		{
			try
			{
				return DataAccessFactory.Createstp_countryDataAccess().GetAll(stp_country);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_countryEntity> Istp_countryFacade.GetAllstp_country"));
            }
		}
		
		IList<stp_countryEntity> Istp_countryFacadeObjects.GetAllByPages(stp_countryEntity stp_country)
		{
			try
			{
				return DataAccessFactory.Createstp_countryDataAccess().GetAllByPages(stp_country);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_countryEntity> Istp_countryFacade.GetAllByPagesstp_country"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Istp_countryFacadeObjects.SaveMasterDetstp_countrycity(stp_countryEntity Master, List<stp_countrycityEntity> DetailList)
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
                    return DataAccessFactory.Createstp_countryDataAccess().SaveMasterDetstp_countrycity(Master, listAdded, listUpdated, listDeleted);
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