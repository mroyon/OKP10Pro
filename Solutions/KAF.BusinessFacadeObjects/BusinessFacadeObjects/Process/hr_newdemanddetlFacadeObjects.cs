
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
    public sealed partial class hr_newdemanddetlFacadeObjects : BaseFacade, Ihr_newdemanddetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_newdemanddetlFacadeObjects";
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

        public hr_newdemanddetlFacadeObjects()
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

        ~hr_newdemanddetlFacadeObjects()
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
		
		long Ihr_newdemanddetlFacadeObjects.Delete(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
            {
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Delete(hr_newdemanddetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Deletehr_newdemanddetl"));
            }
        }
		
		long Ihr_newdemanddetlFacadeObjects.Update(hr_newdemanddetlEntity hr_newdemanddetl )
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Update(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Updatehr_newdemanddetl"));
            }
		}
		
		long Ihr_newdemanddetlFacadeObjects.Add(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Add(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Addhr_newdemanddetl"));
            }
		}
		
        long Ihr_newdemanddetlFacadeObjects.SaveList(List<hr_newdemanddetlEntity> list)
        {
            try
            {
                IList<hr_newdemanddetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_newdemanddetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_newdemanddetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_newdemanddetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_newdemanddetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GetAll(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetAll(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GetAllhr_newdemanddetl"));
            }
		}
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GetAllByPages(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetAllByPages(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GetAllByPageshr_newdemanddetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_newdemanddetlFacadeObjects.SaveMasterDethr_demanddetlpassport(hr_newdemanddetlEntity Master, List<hr_demanddetlpassportEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_demanddetlpassportEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_demanddetlpassportEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_demanddetlpassportEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_newdemanddetlDataAccess().SaveMasterDethr_demanddetlpassport(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_demanddetlpassport"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_newdemanddetlEntity Ihr_newdemanddetlFacadeObjects.GetSingle(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetSingle(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_newdemanddetlEntity Ihr_newdemanddetlFacade.GetSinglehr_newdemanddetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GAPgListView(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GAPgListView(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GAPgListViewhr_newdemanddetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}