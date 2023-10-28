
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
    public sealed partial class hr_ptademanddetlFacadeObjects : BaseFacade, Ihr_ptademanddetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_ptademanddetlFacadeObjects";
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

        public hr_ptademanddetlFacadeObjects()
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

        ~hr_ptademanddetlFacadeObjects()
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
		
		long Ihr_ptademanddetlFacadeObjects.Delete(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
            {
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().Delete(hr_ptademanddetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptademanddetlFacade.Deletehr_ptademanddetl"));
            }
        }
		
		long Ihr_ptademanddetlFacadeObjects.Update(hr_ptademanddetlEntity hr_ptademanddetl )
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().Update(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_ptademanddetlFacade.Updatehr_ptademanddetl"));
            }
		}
		
		long Ihr_ptademanddetlFacadeObjects.Add(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().Add(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptademanddetlFacade.Addhr_ptademanddetl"));
            }
		}
		
        long Ihr_ptademanddetlFacadeObjects.SaveList(List<hr_ptademanddetlEntity> list)
        {
            try
            {
                IList<hr_ptademanddetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_ptademanddetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_ptademanddetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_ptademanddetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_ptademanddetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacadeObjects.GetAll(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().GetAll(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacade.GetAllhr_ptademanddetl"));
            }
		}
		
		IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacadeObjects.GetAllByPages(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().GetAllByPages(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacade.GetAllByPageshr_ptademanddetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_ptademanddetlFacadeObjects.SaveMasterDethr_ptareceiveddetl(hr_ptademanddetlEntity Master, List<hr_ptareceiveddetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_ptareceiveddetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_ptareceiveddetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_ptareceiveddetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_ptademanddetlDataAccess().SaveMasterDethr_ptareceiveddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptareceiveddetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_ptademanddetlEntity Ihr_ptademanddetlFacadeObjects.GetSingle(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().GetSingle(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_ptademanddetlEntity Ihr_ptademanddetlFacade.GetSinglehr_ptademanddetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacadeObjects.GAPgListView(hr_ptademanddetlEntity hr_ptademanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademanddetlDataAccess().GAPgListView(hr_ptademanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademanddetlEntity> Ihr_ptademanddetlFacade.GAPgListViewhr_ptademanddetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}