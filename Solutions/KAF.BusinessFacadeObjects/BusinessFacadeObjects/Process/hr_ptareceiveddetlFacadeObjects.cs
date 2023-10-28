
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
    public sealed partial class hr_ptareceiveddetlFacadeObjects : BaseFacade, Ihr_ptareceiveddetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_ptareceiveddetlFacadeObjects";
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

        public hr_ptareceiveddetlFacadeObjects()
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

        ~hr_ptareceiveddetlFacadeObjects()
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
		
		long Ihr_ptareceiveddetlFacadeObjects.Delete(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
            {
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().Delete(hr_ptareceiveddetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptareceiveddetlFacade.Deletehr_ptareceiveddetl"));
            }
        }
		
		long Ihr_ptareceiveddetlFacadeObjects.Update(hr_ptareceiveddetlEntity hr_ptareceiveddetl )
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().Update(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_ptareceiveddetlFacade.Updatehr_ptareceiveddetl"));
            }
		}
		
		long Ihr_ptareceiveddetlFacadeObjects.Add(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().Add(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptareceiveddetlFacade.Addhr_ptareceiveddetl"));
            }
		}
		
        long Ihr_ptareceiveddetlFacadeObjects.SaveList(List<hr_ptareceiveddetlEntity> list)
        {
            try
            {
                IList<hr_ptareceiveddetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_ptareceiveddetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_ptareceiveddetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_ptareceiveddetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacadeObjects.GetAll(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().GetAll(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacade.GetAllhr_ptareceiveddetl"));
            }
		}
		
		IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacadeObjects.GetAllByPages(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().GetAllByPages(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacade.GetAllByPageshr_ptareceiveddetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_ptareceiveddetlFacadeObjects.SaveMasterDethr_flightinfodetl(hr_ptareceiveddetlEntity Master, List<hr_flightinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_flightinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_flightinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_flightinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().SaveMasterDethr_flightinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_flightinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_ptareceiveddetlEntity Ihr_ptareceiveddetlFacadeObjects.GetSingle(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().GetSingle(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_ptareceiveddetlEntity Ihr_ptareceiveddetlFacade.GetSinglehr_ptareceiveddetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacadeObjects.GAPgListView(hr_ptareceiveddetlEntity hr_ptareceiveddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceiveddetlDataAccess().GAPgListView(hr_ptareceiveddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceiveddetlEntity> Ihr_ptareceiveddetlFacade.GAPgListViewhr_ptareceiveddetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}