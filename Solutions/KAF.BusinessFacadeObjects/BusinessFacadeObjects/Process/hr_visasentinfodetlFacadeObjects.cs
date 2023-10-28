
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
    public sealed partial class hr_visasentinfodetlFacadeObjects : BaseFacade, Ihr_visasentinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visasentinfodetlFacadeObjects";
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

        public hr_visasentinfodetlFacadeObjects()
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

        ~hr_visasentinfodetlFacadeObjects()
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
		
		long Ihr_visasentinfodetlFacadeObjects.Delete(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().Delete(hr_visasentinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfodetlFacade.Deletehr_visasentinfodetl"));
            }
        }
		
		long Ihr_visasentinfodetlFacadeObjects.Update(hr_visasentinfodetlEntity hr_visasentinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().Update(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfodetlFacade.Updatehr_visasentinfodetl"));
            }
		}
		
		long Ihr_visasentinfodetlFacadeObjects.Add(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().Add(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfodetlFacade.Addhr_visasentinfodetl"));
            }
		}
		
        long Ihr_visasentinfodetlFacadeObjects.SaveList(List<hr_visasentinfodetlEntity> list)
        {
            try
            {
                IList<hr_visasentinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visasentinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visasentinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visasentinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visasentinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacadeObjects.GetAll(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().GetAll(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacade.GetAllhr_visasentinfodetl"));
            }
		}
		
		IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacadeObjects.GetAllByPages(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().GetAllByPages(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacade.GetAllByPageshr_visasentinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visasentinfodetlFacadeObjects.SaveMasterDethr_ptademanddetl(hr_visasentinfodetlEntity Master, List<hr_ptademanddetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_visasentinfodetlDataAccess().SaveMasterDethr_ptademanddetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptademanddetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visasentinfodetlEntity Ihr_visasentinfodetlFacadeObjects.GetSingle(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().GetSingle(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visasentinfodetlEntity Ihr_visasentinfodetlFacade.GetSinglehr_visasentinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacadeObjects.GAPgListView(hr_visasentinfodetlEntity hr_visasentinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfodetlDataAccess().GAPgListView(hr_visasentinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfodetlEntity> Ihr_visasentinfodetlFacade.GAPgListViewhr_visasentinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}