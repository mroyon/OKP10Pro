
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
    public sealed partial class hr_newdemandFacadeObjects : BaseFacade, Ihr_newdemandFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_newdemandFacadeObjects";
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

        public hr_newdemandFacadeObjects()
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

        ~hr_newdemandFacadeObjects()
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
		
		long Ihr_newdemandFacadeObjects.Delete(hr_newdemandEntity hr_newdemand)
		{
			try
            {
				return DataAccessFactory.Createhr_newdemandDataAccess().Delete(hr_newdemand);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Deletehr_newdemand"));
            }
        }
		
		long Ihr_newdemandFacadeObjects.Update(hr_newdemandEntity hr_newdemand )
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().Update(hr_newdemand);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Updatehr_newdemand"));
            }
		}
		
		long Ihr_newdemandFacadeObjects.Add(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().Add(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Addhr_newdemand"));
            }
		}
		
        long Ihr_newdemandFacadeObjects.SaveList(List<hr_newdemandEntity> list)
        {
            try
            {
                IList<hr_newdemandEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_newdemandEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_newdemandEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_newdemandDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_newdemand"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GetAll(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GetAll(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GetAllhr_newdemand"));
            }
		}
		
		IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GetAllByPages(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GetAllByPages(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GetAllByPageshr_newdemand"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_newdemandFacadeObjects.SaveMasterDethr_newdemanddetl(hr_newdemandEntity Master, List<hr_newdemanddetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_newdemanddetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_newdemanddetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_newdemanddetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_newdemandDataAccess().SaveMasterDethr_newdemanddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_newdemanddetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_newdemandEntity Ihr_newdemandFacadeObjects.GetSingle(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GetSingle(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_newdemandEntity Ihr_newdemandFacade.GetSinglehr_newdemand"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GAPgListView(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GAPgListView(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GAPgListViewhr_newdemand"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}