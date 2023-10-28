
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
    public sealed partial class hr_leaveinfoFacadeObjects : BaseFacade, Ihr_leaveinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_leaveinfoFacadeObjects";
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

        public hr_leaveinfoFacadeObjects()
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

        ~hr_leaveinfoFacadeObjects()
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
		
		long Ihr_leaveinfoFacadeObjects.Delete(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_leaveinfoDataAccess().Delete(hr_leaveinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_leaveinfoFacade.Deletehr_leaveinfo"));
            }
        }
		
		long Ihr_leaveinfoFacadeObjects.Update(hr_leaveinfoEntity hr_leaveinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().Update(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_leaveinfoFacade.Updatehr_leaveinfo"));
            }
		}
		
		long Ihr_leaveinfoFacadeObjects.Add(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().Add(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_leaveinfoFacade.Addhr_leaveinfo"));
            }
		}
		
        long Ihr_leaveinfoFacadeObjects.SaveList(List<hr_leaveinfoEntity> list)
        {
            try
            {
                IList<hr_leaveinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_leaveinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_leaveinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_leaveinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_leaveinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_leaveinfoEntity> Ihr_leaveinfoFacadeObjects.GetAll(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().GetAll(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leaveinfoEntity> Ihr_leaveinfoFacade.GetAllhr_leaveinfo"));
            }
		}
		
		IList<hr_leaveinfoEntity> Ihr_leaveinfoFacadeObjects.GetAllByPages(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().GetAllByPages(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leaveinfoEntity> Ihr_leaveinfoFacade.GetAllByPageshr_leaveinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_leaveinfoFacadeObjects.SaveMasterDethr_leavemodification(hr_leaveinfoEntity Master, List<hr_leavemodificationEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_leavemodificationEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_leavemodificationEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_leavemodificationEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_leaveinfoDataAccess().SaveMasterDethr_leavemodification(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_leavemodification"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_leaveinfoEntity Ihr_leaveinfoFacadeObjects.GetSingle(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().GetSingle(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_leaveinfoEntity Ihr_leaveinfoFacade.GetSinglehr_leaveinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_leaveinfoEntity> Ihr_leaveinfoFacadeObjects.GAPgListView(hr_leaveinfoEntity hr_leaveinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_leaveinfoDataAccess().GAPgListView(hr_leaveinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_leaveinfoEntity> Ihr_leaveinfoFacade.GAPgListViewhr_leaveinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}