
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
    public sealed partial class hr_deathinfoFacadeObjects : BaseFacade, Ihr_deathinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_deathinfoFacadeObjects";
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

        public hr_deathinfoFacadeObjects()
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

        ~hr_deathinfoFacadeObjects()
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
		
		long Ihr_deathinfoFacadeObjects.Delete(hr_deathinfoEntity hr_deathinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_deathinfoDataAccess().Delete(hr_deathinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_deathinfoFacade.Deletehr_deathinfo"));
            }
        }
		
		long Ihr_deathinfoFacadeObjects.Update(hr_deathinfoEntity hr_deathinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().Update(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_deathinfoFacade.Updatehr_deathinfo"));
            }
		}
		
		long Ihr_deathinfoFacadeObjects.Add(hr_deathinfoEntity hr_deathinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().Add(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_deathinfoFacade.Addhr_deathinfo"));
            }
		}
		
        long Ihr_deathinfoFacadeObjects.SaveList(List<hr_deathinfoEntity> list)
        {
            try
            {
                IList<hr_deathinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_deathinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_deathinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_deathinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_deathinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_deathinfoEntity> Ihr_deathinfoFacadeObjects.GetAll(hr_deathinfoEntity hr_deathinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().GetAll(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_deathinfoEntity> Ihr_deathinfoFacade.GetAllhr_deathinfo"));
            }
		}
		
		IList<hr_deathinfoEntity> Ihr_deathinfoFacadeObjects.GetAllByPages(hr_deathinfoEntity hr_deathinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().GetAllByPages(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_deathinfoEntity> Ihr_deathinfoFacade.GetAllByPageshr_deathinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_deathinfoEntity Ihr_deathinfoFacadeObjects.GetSingle(hr_deathinfoEntity hr_deathinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().GetSingle(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_deathinfoEntity Ihr_deathinfoFacade.GetSinglehr_deathinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_deathinfoEntity> Ihr_deathinfoFacadeObjects.GAPgListView(hr_deathinfoEntity hr_deathinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_deathinfoDataAccess().GAPgListView(hr_deathinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_deathinfoEntity> Ihr_deathinfoFacade.GAPgListViewhr_deathinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}