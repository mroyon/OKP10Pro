
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
    public sealed partial class hr_visaissueinfodetlFacadeObjects : BaseFacade, Ihr_visaissueinfodetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visaissueinfodetlFacadeObjects";
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

        public hr_visaissueinfodetlFacadeObjects()
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

        ~hr_visaissueinfodetlFacadeObjects()
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
		
		long Ihr_visaissueinfodetlFacadeObjects.Delete(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
            {
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().Delete(hr_visaissueinfodetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfodetlFacade.Deletehr_visaissueinfodetl"));
            }
        }
		
		long Ihr_visaissueinfodetlFacadeObjects.Update(hr_visaissueinfodetlEntity hr_visaissueinfodetl )
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().Update(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfodetlFacade.Updatehr_visaissueinfodetl"));
            }
		}
		
		long Ihr_visaissueinfodetlFacadeObjects.Add(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().Add(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfodetlFacade.Addhr_visaissueinfodetl"));
            }
		}
		
        long Ihr_visaissueinfodetlFacadeObjects.SaveList(List<hr_visaissueinfodetlEntity> list)
        {
            try
            {
                IList<hr_visaissueinfodetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visaissueinfodetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visaissueinfodetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visaissueinfodetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacadeObjects.GetAll(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().GetAll(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacade.GetAllhr_visaissueinfodetl"));
            }
		}
		
		IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacadeObjects.GetAllByPages(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().GetAllByPages(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacade.GetAllByPageshr_visaissueinfodetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visaissueinfodetlFacadeObjects.SaveMasterDethr_visasentinfodetl(hr_visaissueinfodetlEntity Master, List<hr_visasentinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_visasentinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_visasentinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_visasentinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().SaveMasterDethr_visasentinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visasentinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visaissueinfodetlEntity Ihr_visaissueinfodetlFacadeObjects.GetSingle(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().GetSingle(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visaissueinfodetlEntity Ihr_visaissueinfodetlFacade.GetSinglehr_visaissueinfodetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacadeObjects.GAPgListView(hr_visaissueinfodetlEntity hr_visaissueinfodetl)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfodetlDataAccess().GAPgListView(hr_visaissueinfodetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfodetlEntity> Ihr_visaissueinfodetlFacade.GAPgListViewhr_visaissueinfodetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}