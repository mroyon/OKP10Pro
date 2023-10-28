
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
    public sealed partial class hr_passportinfoFacadeObjects : BaseFacade, Ihr_passportinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_passportinfoFacadeObjects";
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

        public hr_passportinfoFacadeObjects()
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

        ~hr_passportinfoFacadeObjects()
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
		
		long Ihr_passportinfoFacadeObjects.Delete(hr_passportinfoEntity hr_passportinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_passportinfoDataAccess().Delete(hr_passportinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Deletehr_passportinfo"));
            }
        }
		
		long Ihr_passportinfoFacadeObjects.Update(hr_passportinfoEntity hr_passportinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().Update(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Updatehr_passportinfo"));
            }
		}
		
		long Ihr_passportinfoFacadeObjects.Add(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().Add(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Addhr_passportinfo"));
            }
		}
		
        long Ihr_passportinfoFacadeObjects.SaveList(List<hr_passportinfoEntity> list)
        {
            try
            {
                IList<hr_passportinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_passportinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_passportinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_passportinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_passportinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GetAll(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetAll(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GetAllhr_passportinfo"));
            }
		}
		
		IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GetAllByPages(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetAllByPages(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GetAllByPageshr_passportinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_passportinfoFacadeObjects.SaveMasterDethr_residentvisa(hr_passportinfoEntity Master, List<hr_residentvisaEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_residentvisaEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_residentvisaEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_residentvisaEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_passportinfoDataAccess().SaveMasterDethr_residentvisa(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_residentvisa"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_passportinfoEntity Ihr_passportinfoFacadeObjects.GetSingle(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetSingle(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_passportinfoEntity Ihr_passportinfoFacade.GetSinglehr_passportinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GAPgListView(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GAPgListView(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GAPgListViewhr_passportinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}