
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
    public sealed partial class hr_reppassportinfoFacadeObjects : BaseFacade, Ihr_reppassportinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_reppassportinfoFacadeObjects";
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

        public hr_reppassportinfoFacadeObjects()
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

        ~hr_reppassportinfoFacadeObjects()
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
		
		long Ihr_reppassportinfoFacadeObjects.Delete(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().Delete(hr_reppassportinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfoFacade.Deletehr_reppassportinfo"));
            }
        }
		
		long Ihr_reppassportinfoFacadeObjects.Update(hr_reppassportinfoEntity hr_reppassportinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().Update(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfoFacade.Updatehr_reppassportinfo"));
            }
		}
		
		long Ihr_reppassportinfoFacadeObjects.Add(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().Add(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_reppassportinfoFacade.Addhr_reppassportinfo"));
            }
		}
		
        long Ihr_reppassportinfoFacadeObjects.SaveList(List<hr_reppassportinfoEntity> list)
        {
            try
            {
                IList<hr_reppassportinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_reppassportinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_reppassportinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_reppassportinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_reppassportinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacadeObjects.GetAll(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().GetAll(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacade.GetAllhr_reppassportinfo"));
            }
		}
		
		IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacadeObjects.GetAllByPages(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().GetAllByPages(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacade.GetAllByPageshr_reppassportinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_reppassportinfoFacadeObjects.SaveMasterDethr_reppassportinfodetl(hr_reppassportinfoEntity Master, List<hr_reppassportinfodetlEntity> DetailList)
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
                    return DataAccessFactory.Createhr_reppassportinfoDataAccess().SaveMasterDethr_reppassportinfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_reppassportinfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_reppassportinfoEntity Ihr_reppassportinfoFacadeObjects.GetSingle(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().GetSingle(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_reppassportinfoEntity Ihr_reppassportinfoFacade.GetSinglehr_reppassportinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacadeObjects.GAPgListView(hr_reppassportinfoEntity hr_reppassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_reppassportinfoDataAccess().GAPgListView(hr_reppassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_reppassportinfoEntity> Ihr_reppassportinfoFacade.GAPgListViewhr_reppassportinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}