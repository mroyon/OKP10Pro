
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
    public sealed partial class hr_rewardinfoFacadeObjects : BaseFacade, Ihr_rewardinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_rewardinfoFacadeObjects";
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

        public hr_rewardinfoFacadeObjects()
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

        ~hr_rewardinfoFacadeObjects()
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
		
		long Ihr_rewardinfoFacadeObjects.Delete(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_rewardinfoDataAccess().Delete(hr_rewardinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_rewardinfoFacade.Deletehr_rewardinfo"));
            }
        }
		
		long Ihr_rewardinfoFacadeObjects.Update(hr_rewardinfoEntity hr_rewardinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().Update(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_rewardinfoFacade.Updatehr_rewardinfo"));
            }
		}
		
		long Ihr_rewardinfoFacadeObjects.Add(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().Add(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_rewardinfoFacade.Addhr_rewardinfo"));
            }
		}
		
        long Ihr_rewardinfoFacadeObjects.SaveList(List<hr_rewardinfoEntity> list)
        {
            try
            {
                IList<hr_rewardinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_rewardinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_rewardinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_rewardinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_rewardinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_rewardinfoEntity> Ihr_rewardinfoFacadeObjects.GetAll(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().GetAll(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_rewardinfoEntity> Ihr_rewardinfoFacade.GetAllhr_rewardinfo"));
            }
		}
		
		IList<hr_rewardinfoEntity> Ihr_rewardinfoFacadeObjects.GetAllByPages(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().GetAllByPages(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_rewardinfoEntity> Ihr_rewardinfoFacade.GetAllByPageshr_rewardinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_rewardinfoEntity Ihr_rewardinfoFacadeObjects.GetSingle(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().GetSingle(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_rewardinfoEntity Ihr_rewardinfoFacade.GetSinglehr_rewardinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_rewardinfoEntity> Ihr_rewardinfoFacadeObjects.GAPgListView(hr_rewardinfoEntity hr_rewardinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_rewardinfoDataAccess().GAPgListView(hr_rewardinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_rewardinfoEntity> Ihr_rewardinfoFacade.GAPgListViewhr_rewardinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}