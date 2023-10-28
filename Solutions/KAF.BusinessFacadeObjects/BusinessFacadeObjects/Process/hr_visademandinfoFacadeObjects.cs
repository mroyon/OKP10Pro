
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
    public sealed partial class hr_visademandinfoFacadeObjects : BaseFacade, Ihr_visademandinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visademandinfoFacadeObjects";
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

        public hr_visademandinfoFacadeObjects()
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

        ~hr_visademandinfoFacadeObjects()
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
		
		long Ihr_visademandinfoFacadeObjects.Delete(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_visademandinfoDataAccess().Delete(hr_visademandinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfoFacade.Deletehr_visademandinfo"));
            }
        }
		
		long Ihr_visademandinfoFacadeObjects.Update(hr_visademandinfoEntity hr_visademandinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().Update(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfoFacade.Updatehr_visademandinfo"));
            }
		}
		
		long Ihr_visademandinfoFacadeObjects.Add(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().Add(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visademandinfoFacade.Addhr_visademandinfo"));
            }
		}
		
        long Ihr_visademandinfoFacadeObjects.SaveList(List<hr_visademandinfoEntity> list)
        {
            try
            {
                IList<hr_visademandinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visademandinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visademandinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visademandinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visademandinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visademandinfoEntity> Ihr_visademandinfoFacadeObjects.GetAll(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().GetAll(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfoEntity> Ihr_visademandinfoFacade.GetAllhr_visademandinfo"));
            }
		}
		
		IList<hr_visademandinfoEntity> Ihr_visademandinfoFacadeObjects.GetAllByPages(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().GetAllByPages(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfoEntity> Ihr_visademandinfoFacade.GetAllByPageshr_visademandinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visademandinfoFacadeObjects.SaveMasterDethr_visademandinfodetl(hr_visademandinfoEntity Master, List<hr_visademandinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_visademandinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_visademandinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_visademandinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visademandinfoDataAccess().SaveMasterDethr_visademandinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visademandinfodetl"));
               }
        }
        
        
        long Ihr_visademandinfoFacadeObjects.SaveMasterDethr_visaissueinfo(hr_visademandinfoEntity Master, List<hr_visaissueinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_visaissueinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_visaissueinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_visaissueinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visademandinfoDataAccess().SaveMasterDethr_visaissueinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visaissueinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visademandinfoEntity Ihr_visademandinfoFacadeObjects.GetSingle(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().GetSingle(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visademandinfoEntity Ihr_visademandinfoFacade.GetSinglehr_visademandinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visademandinfoEntity> Ihr_visademandinfoFacadeObjects.GAPgListView(hr_visademandinfoEntity hr_visademandinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visademandinfoDataAccess().GAPgListView(hr_visademandinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visademandinfoEntity> Ihr_visademandinfoFacade.GAPgListViewhr_visademandinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}