
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
    public sealed partial class hr_replacementinfodetlFacadeObjects : BaseFacade, Ihr_replacementinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_replacementinfodetlFacadeObjects";
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

        public hr_replacementinfodetlFacadeObjects()
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

        ~hr_replacementinfodetlFacadeObjects()
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
		
		long Ihr_replacementinfodetlFacadeObjects.Delete(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().Delete(hr_replacementinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfodetlFacade.Deletehr_replacementinfodetl"));
            }
        }
		
		long Ihr_replacementinfodetlFacadeObjects.Update(hr_replacementinfodetlEntity hr_replacementinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().Update(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfodetlFacade.Updatehr_replacementinfodetl"));
            }
		}
		
		long Ihr_replacementinfodetlFacadeObjects.Add(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().Add(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfodetlFacade.Addhr_replacementinfodetl"));
            }
		}
		
        long Ihr_replacementinfodetlFacadeObjects.SaveList(List<hr_replacementinfodetlEntity> list)
        {
            try
            {
                IList<hr_replacementinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_replacementinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_replacementinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_replacementinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_replacementinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacadeObjects.GetAll(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().GetAll(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacade.GetAllhr_replacementinfodetl"));
            }
		}
		
		IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacadeObjects.GetAllByPages(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().GetAllByPages(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacade.GetAllByPageshr_replacementinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_replacementinfodetlFacadeObjects.SaveMasterDethr_reppassportinfodetl(hr_replacementinfodetlEntity Master, List<hr_reppassportinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_reppassportinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_reppassportinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_reppassportinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_replacementinfodetlDataAccess().SaveMasterDethr_reppassportinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_reppassportinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_replacementinfodetlEntity Ihr_replacementinfodetlFacadeObjects.GetSingle(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().GetSingle(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_replacementinfodetlEntity Ihr_replacementinfodetlFacade.GetSinglehr_replacementinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacadeObjects.GAPgListView(hr_replacementinfodetlEntity hr_replacementinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfodetlDataAccess().GAPgListView(hr_replacementinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfodetlEntity> Ihr_replacementinfodetlFacade.GAPgListViewhr_replacementinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}