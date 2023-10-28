
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
    public sealed partial class hr_ptareceivedFacadeObjects : BaseFacade, Ihr_ptareceivedFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_ptareceivedFacadeObjects";
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

        public hr_ptareceivedFacadeObjects()
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

        ~hr_ptareceivedFacadeObjects()
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
		
		long Ihr_ptareceivedFacadeObjects.Delete(hr_ptareceivedEntity hr_ptareceived)
		{
			try
            {
				return DataAccessFactory.Createhr_ptareceivedDataAccess().Delete(hr_ptareceived);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptareceivedFacade.Deletehr_ptareceived"));
            }
        }
		
		long Ihr_ptareceivedFacadeObjects.Update(hr_ptareceivedEntity hr_ptareceived )
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().Update(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_ptareceivedFacade.Updatehr_ptareceived"));
            }
		}
		
		long Ihr_ptareceivedFacadeObjects.Add(hr_ptareceivedEntity hr_ptareceived)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().Add(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptareceivedFacade.Addhr_ptareceived"));
            }
		}
		
        long Ihr_ptareceivedFacadeObjects.SaveList(List<hr_ptareceivedEntity> list)
        {
            try
            {
                IList<hr_ptareceivedEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_ptareceivedEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_ptareceivedEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_ptareceivedDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_ptareceived"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_ptareceivedEntity> Ihr_ptareceivedFacadeObjects.GetAll(hr_ptareceivedEntity hr_ptareceived)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().GetAll(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceivedEntity> Ihr_ptareceivedFacade.GetAllhr_ptareceived"));
            }
		}
		
		IList<hr_ptareceivedEntity> Ihr_ptareceivedFacadeObjects.GetAllByPages(hr_ptareceivedEntity hr_ptareceived)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().GetAllByPages(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceivedEntity> Ihr_ptareceivedFacade.GetAllByPageshr_ptareceived"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_ptareceivedFacadeObjects.SaveMasterDethr_flightinfo(hr_ptareceivedEntity Master, List<hr_flightinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_flightinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_flightinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_flightinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_ptareceivedDataAccess().SaveMasterDethr_flightinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_flightinfo"));
               }
        }
        
        
        long Ihr_ptareceivedFacadeObjects.SaveMasterDethr_ptareceiveddetl(hr_ptareceivedEntity Master, List<hr_ptareceiveddetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_ptareceivedDataAccess().SaveMasterDethr_ptareceiveddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptareceiveddetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_ptareceivedEntity Ihr_ptareceivedFacadeObjects.GetSingle(hr_ptareceivedEntity hr_ptareceived)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().GetSingle(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_ptareceivedEntity Ihr_ptareceivedFacade.GetSinglehr_ptareceived"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_ptareceivedEntity> Ihr_ptareceivedFacadeObjects.GAPgListView(hr_ptareceivedEntity hr_ptareceived)
		{
			try
			{
				return DataAccessFactory.Createhr_ptareceivedDataAccess().GAPgListView(hr_ptareceived);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptareceivedEntity> Ihr_ptareceivedFacade.GAPgListViewhr_ptareceived"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}