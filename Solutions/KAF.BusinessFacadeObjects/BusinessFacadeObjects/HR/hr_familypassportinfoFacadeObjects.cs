
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
    public sealed partial class hr_familypassportinfoFacadeObjects : BaseFacade, Ihr_familypassportinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_familypassportinfoFacadeObjects";
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

        public hr_familypassportinfoFacadeObjects()
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

        ~hr_familypassportinfoFacadeObjects()
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
		
		long Ihr_familypassportinfoFacadeObjects.Delete(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().Delete(hr_familypassportinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familypassportinfoFacade.Deletehr_familypassportinfo"));
            }
        }
		
		long Ihr_familypassportinfoFacadeObjects.Update(hr_familypassportinfoEntity hr_familypassportinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().Update(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_familypassportinfoFacade.Updatehr_familypassportinfo"));
            }
		}
		
		long Ihr_familypassportinfoFacadeObjects.Add(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().Add(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familypassportinfoFacade.Addhr_familypassportinfo"));
            }
		}
		
        long Ihr_familypassportinfoFacadeObjects.SaveList(List<hr_familypassportinfoEntity> list)
        {
            try
            {
                IList<hr_familypassportinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_familypassportinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_familypassportinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_familypassportinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_familypassportinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacadeObjects.GetAll(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().GetAll(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacade.GetAllhr_familypassportinfo"));
            }
		}
		
		IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacadeObjects.GetAllByPages(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().GetAllByPages(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacade.GetAllByPageshr_familypassportinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Ihr_familypassportinfoFacadeObjects.SaveMasterDethr_familyresidentvisa(hr_familypassportinfoEntity Master, List<hr_familyresidentvisaEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_familyresidentvisaEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_familyresidentvisaEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_familyresidentvisaEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createhr_familypassportinfoDataAccess().SaveMasterDethr_familyresidentvisa(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyresidentvisa"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_familypassportinfoEntity Ihr_familypassportinfoFacadeObjects.GetSingle(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().GetSingle(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_familypassportinfoEntity Ihr_familypassportinfoFacade.GetSinglehr_familypassportinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacadeObjects.GAPgListView(hr_familypassportinfoEntity hr_familypassportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familypassportinfoDataAccess().GAPgListView(hr_familypassportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familypassportinfoEntity> Ihr_familypassportinfoFacade.GAPgListViewhr_familypassportinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}