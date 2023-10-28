
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
    public sealed partial class hr_flightinfodetlFacadeObjects : BaseFacade, Ihr_flightinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_flightinfodetlFacadeObjects";
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

        public hr_flightinfodetlFacadeObjects()
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

        ~hr_flightinfodetlFacadeObjects()
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
		
		long Ihr_flightinfodetlFacadeObjects.Delete(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().Delete(hr_flightinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_flightinfodetlFacade.Deletehr_flightinfodetl"));
            }
        }

        long Ihr_flightinfodetlFacadeObjects.Delete_ReIssue(hr_flightinfodetlEntity hr_flightinfodetl)
        {
            try
            {
                return DataAccessFactory.Createhr_flightinfodetlDataAccess().Delete_ReIssue(hr_flightinfodetl);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_flightinfodetlFacade.Deletehr_flightinfodetl"));
            }
        }

        long Ihr_flightinfodetlFacadeObjects.Update(hr_flightinfodetlEntity hr_flightinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().Update(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_flightinfodetlFacade.Updatehr_flightinfodetl"));
            }
		}
		
		long Ihr_flightinfodetlFacadeObjects.Add(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().Add(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_flightinfodetlFacade.Addhr_flightinfodetl"));
            }
		}
		
        long Ihr_flightinfodetlFacadeObjects.SaveList(List<hr_flightinfodetlEntity> list)
        {
            try
            {
                IList<hr_flightinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_flightinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_flightinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_flightinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_flightinfodetl"));
            }
        }

        long Ihr_flightinfodetlFacadeObjects.SaveCancelReIssueList(List<hr_flightinfodetlEntity> list)
        {
            try
            {
                IList<hr_flightinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_flightinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_flightinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                return DataAccessFactory.Createhr_flightinfodetlDataAccess().SaveCancelReIssueList(listAdded, listUpdated, listDeleted);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_flightinfodetl"));
            }
        }

        #endregion Save Update Delete List	

        #region GetAll

        IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacadeObjects.GetAll(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().GetAll(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacade.GetAllhr_flightinfodetl"));
            }
		}
		
		IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacadeObjects.GetAllByPages(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().GetAllByPages(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacade.GetAllByPageshr_flightinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_flightinfodetlFacadeObjects.SaveMasterDethr_arrivalinfodetl(hr_flightinfodetlEntity Master, List<hr_arrivalinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_arrivalinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_arrivalinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_arrivalinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_flightinfodetlDataAccess().SaveMasterDethr_arrivalinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_arrivalinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_flightinfodetlEntity Ihr_flightinfodetlFacadeObjects.GetSingle(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().GetSingle(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_flightinfodetlEntity Ihr_flightinfodetlFacade.GetSinglehr_flightinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacadeObjects.GAPgListView(hr_flightinfodetlEntity hr_flightinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfodetlDataAccess().GAPgListView(hr_flightinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfodetlEntity> Ihr_flightinfodetlFacade.GAPgListViewhr_flightinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}