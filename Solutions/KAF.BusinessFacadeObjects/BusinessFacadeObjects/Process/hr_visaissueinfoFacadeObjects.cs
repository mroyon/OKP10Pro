
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
    public sealed partial class hr_visaissueinfoFacadeObjects : BaseFacade, Ihr_visaissueinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_visaissueinfoFacadeObjects";
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

        public hr_visaissueinfoFacadeObjects()
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

        ~hr_visaissueinfoFacadeObjects()
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
		
		long Ihr_visaissueinfoFacadeObjects.Delete(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().Delete(hr_visaissueinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfoFacade.Deletehr_visaissueinfo"));
            }
        }
		
		long Ihr_visaissueinfoFacadeObjects.Update(hr_visaissueinfoEntity hr_visaissueinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().Update(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfoFacade.Updatehr_visaissueinfo"));
            }
		}
		
		long Ihr_visaissueinfoFacadeObjects.Add(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().Add(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_visaissueinfoFacade.Addhr_visaissueinfo"));
            }
		}
		
        long Ihr_visaissueinfoFacadeObjects.SaveList(List<hr_visaissueinfoEntity> list)
        {
            try
            {
                IList<hr_visaissueinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_visaissueinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_visaissueinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_visaissueinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_visaissueinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacadeObjects.GetAll(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().GetAll(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacade.GetAllhr_visaissueinfo"));
            }
		}
		
		IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacadeObjects.GetAllByPages(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().GetAllByPages(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacade.GetAllByPageshr_visaissueinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_visaissueinfoFacadeObjects.SaveMasterDethr_visaissueinfodetl(hr_visaissueinfoEntity Master, List<hr_visaissueinfodetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_visaissueinfoDataAccess().SaveMasterDethr_visaissueinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visaissueinfodetl"));
               }
        }
        
        
        long Ihr_visaissueinfoFacadeObjects.SaveMasterDethr_visasentinfo(hr_visaissueinfoEntity Master, List<hr_visasentinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_visasentinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_visasentinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_visasentinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_visaissueinfoDataAccess().SaveMasterDethr_visasentinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_visasentinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_visaissueinfoEntity Ihr_visaissueinfoFacadeObjects.GetSingle(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().GetSingle(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_visaissueinfoEntity Ihr_visaissueinfoFacade.GetSinglehr_visaissueinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacadeObjects.GAPgListView(hr_visaissueinfoEntity hr_visaissueinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_visaissueinfoDataAccess().GAPgListView(hr_visaissueinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_visaissueinfoEntity> Ihr_visaissueinfoFacade.GAPgListViewhr_visaissueinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}