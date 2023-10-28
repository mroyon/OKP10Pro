
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
    public sealed partial class hr_arrivalinfoFacadeObjects : BaseFacade, Ihr_arrivalinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_arrivalinfoFacadeObjects";
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

        public hr_arrivalinfoFacadeObjects()
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

        ~hr_arrivalinfoFacadeObjects()
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
		
		long Ihr_arrivalinfoFacadeObjects.Delete(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().Delete(hr_arrivalinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfoFacade.Deletehr_arrivalinfo"));
            }
        }
		
		long Ihr_arrivalinfoFacadeObjects.Update(hr_arrivalinfoEntity hr_arrivalinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().Update(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfoFacade.Updatehr_arrivalinfo"));
            }
		}
		
		long Ihr_arrivalinfoFacadeObjects.Add(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().Add(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_arrivalinfoFacade.Addhr_arrivalinfo"));
            }
		}
		
        long Ihr_arrivalinfoFacadeObjects.SaveList(List<hr_arrivalinfoEntity> list)
        {
            try
            {
                IList<hr_arrivalinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_arrivalinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_arrivalinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_arrivalinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_arrivalinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacadeObjects.GetAll(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().GetAll(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacade.GetAllhr_arrivalinfo"));
            }
		}
		
		IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacadeObjects.GetAllByPages(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().GetAllByPages(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacade.GetAllByPageshr_arrivalinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_arrivalinfoFacadeObjects.SaveMasterDethr_arrivalinfodetl(hr_arrivalinfoEntity Master, List<hr_arrivalinfodetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_arrivalinfoDataAccess().SaveMasterDethr_arrivalinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_arrivalinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_arrivalinfoEntity Ihr_arrivalinfoFacadeObjects.GetSingle(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().GetSingle(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_arrivalinfoEntity Ihr_arrivalinfoFacade.GetSinglehr_arrivalinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacadeObjects.GAPgListView(hr_arrivalinfoEntity hr_arrivalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_arrivalinfoDataAccess().GAPgListView(hr_arrivalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_arrivalinfoEntity> Ihr_arrivalinfoFacade.GAPgListViewhr_arrivalinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}