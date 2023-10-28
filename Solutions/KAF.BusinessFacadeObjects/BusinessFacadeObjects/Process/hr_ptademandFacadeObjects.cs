
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
    public sealed partial class hr_ptademandFacadeObjects : BaseFacade, Ihr_ptademandFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_ptademandFacadeObjects";
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

        public hr_ptademandFacadeObjects()
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

        ~hr_ptademandFacadeObjects()
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
		
		long Ihr_ptademandFacadeObjects.Delete(hr_ptademandEntity hr_ptademand)
		{
			try
            {
				return DataAccessFactory.Createhr_ptademandDataAccess().Delete(hr_ptademand);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptademandFacade.Deletehr_ptademand"));
            }
        }
		
		long Ihr_ptademandFacadeObjects.Update(hr_ptademandEntity hr_ptademand )
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().Update(hr_ptademand);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_ptademandFacade.Updatehr_ptademand"));
            }
		}
		
		long Ihr_ptademandFacadeObjects.Add(hr_ptademandEntity hr_ptademand)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().Add(hr_ptademand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_ptademandFacade.Addhr_ptademand"));
            }
		}
		
        long Ihr_ptademandFacadeObjects.SaveList(List<hr_ptademandEntity> list)
        {
            try
            {
                IList<hr_ptademandEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_ptademandEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_ptademandEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_ptademandDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_ptademand"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_ptademandEntity> Ihr_ptademandFacadeObjects.GetAll(hr_ptademandEntity hr_ptademand)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().GetAll(hr_ptademand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademandEntity> Ihr_ptademandFacade.GetAllhr_ptademand"));
            }
		}
		
		IList<hr_ptademandEntity> Ihr_ptademandFacadeObjects.GetAllByPages(hr_ptademandEntity hr_ptademand)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().GetAllByPages(hr_ptademand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademandEntity> Ihr_ptademandFacade.GetAllByPageshr_ptademand"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_ptademandFacadeObjects.SaveMasterDethr_ptademanddetl(hr_ptademandEntity Master, List<hr_ptademanddetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_ptademanddetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_ptademanddetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_ptademanddetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_ptademandDataAccess().SaveMasterDethr_ptademanddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptademanddetl"));
               }
        }
        
        
        long Ihr_ptademandFacadeObjects.SaveMasterDethr_ptareceived(hr_ptademandEntity Master, List<hr_ptareceivedEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_ptareceivedEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_ptareceivedEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_ptareceivedEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_ptademandDataAccess().SaveMasterDethr_ptareceived(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptareceived"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_ptademandEntity Ihr_ptademandFacadeObjects.GetSingle(hr_ptademandEntity hr_ptademand)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().GetSingle(hr_ptademand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_ptademandEntity Ihr_ptademandFacade.GetSinglehr_ptademand"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_ptademandEntity> Ihr_ptademandFacadeObjects.GAPgListView(hr_ptademandEntity hr_ptademand)
		{
			try
			{
				return DataAccessFactory.Createhr_ptademandDataAccess().GAPgListView(hr_ptademand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_ptademandEntity> Ihr_ptademandFacade.GAPgListViewhr_ptademand"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}