
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
    public sealed partial class hr_replacementinfoFacadeObjects : BaseFacade, Ihr_replacementinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_replacementinfoFacadeObjects";
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

        public hr_replacementinfoFacadeObjects()
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

        ~hr_replacementinfoFacadeObjects()
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
		
		long Ihr_replacementinfoFacadeObjects.Delete(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_replacementinfoDataAccess().Delete(hr_replacementinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfoFacade.Deletehr_replacementinfo"));
            }
        }
		
		long Ihr_replacementinfoFacadeObjects.Update(hr_replacementinfoEntity hr_replacementinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().Update(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfoFacade.Updatehr_replacementinfo"));
            }
		}
		
		long Ihr_replacementinfoFacadeObjects.Add(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().Add(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_replacementinfoFacade.Addhr_replacementinfo"));
            }
		}
		
        long Ihr_replacementinfoFacadeObjects.SaveList(List<hr_replacementinfoEntity> list)
        {
            try
            {
                IList<hr_replacementinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_replacementinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_replacementinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_replacementinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_replacementinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_replacementinfoEntity> Ihr_replacementinfoFacadeObjects.GetAll(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().GetAll(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfoEntity> Ihr_replacementinfoFacade.GetAllhr_replacementinfo"));
            }
		}
		
		IList<hr_replacementinfoEntity> Ihr_replacementinfoFacadeObjects.GetAllByPages(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().GetAllByPages(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfoEntity> Ihr_replacementinfoFacade.GetAllByPageshr_replacementinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_replacementinfoFacadeObjects.SaveMasterDethr_replacementinfodetl(hr_replacementinfoEntity Master, List<hr_replacementinfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_replacementinfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_replacementinfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_replacementinfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_replacementinfoDataAccess().SaveMasterDethr_replacementinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_replacementinfodetl"));
               }
        }
        
        
        long Ihr_replacementinfoFacadeObjects.SaveMasterDethr_reppassportinfo(hr_replacementinfoEntity Master, List<hr_reppassportinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_reppassportinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_reppassportinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_reppassportinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_replacementinfoDataAccess().SaveMasterDethr_reppassportinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_reppassportinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_replacementinfoEntity Ihr_replacementinfoFacadeObjects.GetSingle(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().GetSingle(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_replacementinfoEntity Ihr_replacementinfoFacade.GetSinglehr_replacementinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_replacementinfoEntity> Ihr_replacementinfoFacadeObjects.GAPgListView(hr_replacementinfoEntity hr_replacementinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_replacementinfoDataAccess().GAPgListView(hr_replacementinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_replacementinfoEntity> Ihr_replacementinfoFacade.GAPgListViewhr_replacementinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}