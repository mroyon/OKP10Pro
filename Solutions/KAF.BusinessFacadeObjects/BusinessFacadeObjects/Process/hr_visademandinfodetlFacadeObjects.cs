
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
    public sealed partial class hr_visademandinfodetlFacadeObjects : BaseFacade, Ihr_visademandinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visademandinfodetlFacadeObjects";
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

        public hr_visademandinfodetlFacadeObjects()
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

        ~hr_visademandinfodetlFacadeObjects()
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
		
		long Ihr_visademandinfodetlFacadeObjects.Delete(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().Delete(hr_visademandinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfodetlFacade.Deletehr_visademandinfodetl"));
            }
        }
		
		long Ihr_visademandinfodetlFacadeObjects.Update(hr_visademandinfodetlEntity hr_visademandinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().Update(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfodetlFacade.Updatehr_visademandinfodetl"));
            }
		}
		
		long Ihr_visademandinfodetlFacadeObjects.Add(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().Add(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfodetlFacade.Addhr_visademandinfodetl"));
            }
		}
		
        long Ihr_visademandinfodetlFacadeObjects.SaveList(List<hr_visademandinfodetlEntity> list)
        {
            try
            {
                IList<hr_visademandinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visademandinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visademandinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visademandinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visademandinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacadeObjects.GetAll(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().GetAll(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacade.GetAllhr_visademandinfodetl"));
            }
		}
		
		IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacadeObjects.GetAllByPages(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().GetAllByPages(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacade.GetAllByPageshr_visademandinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visademandinfodetlFacadeObjects.SaveMasterDethr_visaissueinfodetl(hr_visademandinfodetlEntity Master, List<hr_visaissueinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_visaissueinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_visaissueinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_visaissueinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visademandinfodetlDataAccess().SaveMasterDethr_visaissueinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visaissueinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visademandinfodetlEntity Ihr_visademandinfodetlFacadeObjects.GetSingle(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().GetSingle(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visademandinfodetlEntity Ihr_visademandinfodetlFacade.GetSinglehr_visademandinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacadeObjects.GAPgListView(hr_visademandinfodetlEntity hr_visademandinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfodetlDataAccess().GAPgListView(hr_visademandinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfodetlEntity> Ihr_visademandinfodetlFacade.GAPgListViewhr_visademandinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}