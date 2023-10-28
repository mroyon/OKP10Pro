
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
    public sealed partial class hr_visasentinfoFacadeObjects : BaseFacade, Ihr_visasentinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visasentinfoFacadeObjects";
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

        public hr_visasentinfoFacadeObjects()
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

        ~hr_visasentinfoFacadeObjects()
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
		
		long Ihr_visasentinfoFacadeObjects.Delete(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_visasentinfoDataAccess().Delete(hr_visasentinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfoFacade.Deletehr_visasentinfo"));
            }
        }
		
		long Ihr_visasentinfoFacadeObjects.Update(hr_visasentinfoEntity hr_visasentinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().Update(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfoFacade.Updatehr_visasentinfo"));
            }
		}
		
		long Ihr_visasentinfoFacadeObjects.Add(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().Add(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visasentinfoFacade.Addhr_visasentinfo"));
            }
		}
		
        long Ihr_visasentinfoFacadeObjects.SaveList(List<hr_visasentinfoEntity> list)
        {
            try
            {
                IList<hr_visasentinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visasentinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visasentinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visasentinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visasentinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visasentinfoEntity> Ihr_visasentinfoFacadeObjects.GetAll(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().GetAll(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfoEntity> Ihr_visasentinfoFacade.GetAllhr_visasentinfo"));
            }
		}
		
		IList<hr_visasentinfoEntity> Ihr_visasentinfoFacadeObjects.GetAllByPages(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().GetAllByPages(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfoEntity> Ihr_visasentinfoFacade.GetAllByPageshr_visasentinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visasentinfoFacadeObjects.SaveMasterDethr_ptademand(hr_visasentinfoEntity Master, List<hr_ptademandEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_ptademandEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_ptademandEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_ptademandEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visasentinfoDataAccess().SaveMasterDethr_ptademand(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_ptademand"));
               }
        }
        
        
        long Ihr_visasentinfoFacadeObjects.SaveMasterDethr_visasentinfodetl(hr_visasentinfoEntity Master, List<hr_visasentinfodetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_visasentinfoDataAccess().SaveMasterDethr_visasentinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visasentinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visasentinfoEntity Ihr_visasentinfoFacadeObjects.GetSingle(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().GetSingle(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visasentinfoEntity Ihr_visasentinfoFacade.GetSinglehr_visasentinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visasentinfoEntity> Ihr_visasentinfoFacadeObjects.GAPgListView(hr_visasentinfoEntity hr_visasentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visasentinfoDataAccess().GAPgListView(hr_visasentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visasentinfoEntity> Ihr_visasentinfoFacade.GAPgListViewhr_visasentinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}