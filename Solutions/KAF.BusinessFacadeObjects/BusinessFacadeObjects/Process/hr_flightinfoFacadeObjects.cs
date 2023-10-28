
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
    public sealed partial class hr_flightinfoFacadeObjects : BaseFacade, Ihr_flightinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_flightinfoFacadeObjects";
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

        public hr_flightinfoFacadeObjects()
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

        ~hr_flightinfoFacadeObjects()
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
		
		long Ihr_flightinfoFacadeObjects.Delete(hr_flightinfoEntity hr_flightinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_flightinfoDataAccess().Delete(hr_flightinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_flightinfoFacade.Deletehr_flightinfo"));
            }
        }
		
		long Ihr_flightinfoFacadeObjects.Update(hr_flightinfoEntity hr_flightinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().Update(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_flightinfoFacade.Updatehr_flightinfo"));
            }
		}
		
		long Ihr_flightinfoFacadeObjects.Add(hr_flightinfoEntity hr_flightinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().Add(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_flightinfoFacade.Addhr_flightinfo"));
            }
		}
		
        long Ihr_flightinfoFacadeObjects.SaveList(List<hr_flightinfoEntity> list)
        {
            try
            {
                IList<hr_flightinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_flightinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_flightinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_flightinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_flightinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_flightinfoEntity> Ihr_flightinfoFacadeObjects.GetAll(hr_flightinfoEntity hr_flightinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().GetAll(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfoEntity> Ihr_flightinfoFacade.GetAllhr_flightinfo"));
            }
		}
		
		IList<hr_flightinfoEntity> Ihr_flightinfoFacadeObjects.GetAllByPages(hr_flightinfoEntity hr_flightinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().GetAllByPages(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfoEntity> Ihr_flightinfoFacade.GetAllByPageshr_flightinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_flightinfoFacadeObjects.SaveMasterDethr_arrivalinfo(hr_flightinfoEntity Master, List<hr_arrivalinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_arrivalinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_arrivalinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_arrivalinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_flightinfoDataAccess().SaveMasterDethr_arrivalinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_arrivalinfo"));
               }
        }
        
        
        long Ihr_flightinfoFacadeObjects.SaveMasterDethr_flightinfodetl(hr_flightinfoEntity Master, List<hr_flightinfodetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_flightinfoDataAccess().SaveMasterDethr_flightinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_flightinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_flightinfoEntity Ihr_flightinfoFacadeObjects.GetSingle(hr_flightinfoEntity hr_flightinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().GetSingle(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_flightinfoEntity Ihr_flightinfoFacade.GetSinglehr_flightinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_flightinfoEntity> Ihr_flightinfoFacadeObjects.GAPgListView(hr_flightinfoEntity hr_flightinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_flightinfoDataAccess().GAPgListView(hr_flightinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfoEntity> Ihr_flightinfoFacade.GAPgListViewhr_flightinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}