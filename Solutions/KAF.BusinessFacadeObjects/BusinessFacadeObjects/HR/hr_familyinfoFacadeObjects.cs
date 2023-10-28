
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
    public sealed partial class hr_familyinfoFacadeObjects : BaseFacade, Ihr_familyinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_familyinfoFacadeObjects";
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

        public hr_familyinfoFacadeObjects()
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

        ~hr_familyinfoFacadeObjects()
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
		
		long Ihr_familyinfoFacadeObjects.Delete(hr_familyinfoEntity hr_familyinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_familyinfoDataAccess().Delete(hr_familyinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyinfoFacade.Deletehr_familyinfo"));
            }
        }
		
		long Ihr_familyinfoFacadeObjects.Update(hr_familyinfoEntity hr_familyinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().Update(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_familyinfoFacade.Updatehr_familyinfo"));
            }
		}
		
		long Ihr_familyinfoFacadeObjects.Add(hr_familyinfoEntity hr_familyinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().Add(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familyinfoFacade.Addhr_familyinfo"));
            }
		}
		
        long Ihr_familyinfoFacadeObjects.SaveList(List<hr_familyinfoEntity> list)
        {
            try
            {
                IList<hr_familyinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_familyinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_familyinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_familyinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_familyinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_familyinfoEntity> Ihr_familyinfoFacadeObjects.GetAll(hr_familyinfoEntity hr_familyinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().GetAll(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyinfoEntity> Ihr_familyinfoFacade.GetAllhr_familyinfo"));
            }
		}
		
		IList<hr_familyinfoEntity> Ihr_familyinfoFacadeObjects.GetAllByPages(hr_familyinfoEntity hr_familyinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().GetAllByPages(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyinfoEntity> Ihr_familyinfoFacade.GetAllByPageshr_familyinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_familyinfoFacadeObjects.SaveMasterDethr_familyinfo(hr_familyinfoEntity Master, List<hr_familyinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_familyinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_familyinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_familyinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_familyinfoDataAccess().SaveMasterDethr_familyinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyinfo"));
               }
        }
        
        
        long Ihr_familyinfoFacadeObjects.SaveMasterDethr_familyjobinfo(hr_familyinfoEntity Master, List<hr_familyjobinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_familyjobinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_familyjobinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_familyjobinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_familyinfoDataAccess().SaveMasterDethr_familyjobinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyjobinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_familyinfoEntity Ihr_familyinfoFacadeObjects.GetSingle(hr_familyinfoEntity hr_familyinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().GetSingle(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_familyinfoEntity Ihr_familyinfoFacade.GetSinglehr_familyinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_familyinfoEntity> Ihr_familyinfoFacadeObjects.GAPgListView(hr_familyinfoEntity hr_familyinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familyinfoDataAccess().GAPgListView(hr_familyinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familyinfoEntity> Ihr_familyinfoFacade.GAPgListViewhr_familyinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}