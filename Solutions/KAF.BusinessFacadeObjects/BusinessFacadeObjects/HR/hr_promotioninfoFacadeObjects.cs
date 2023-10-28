
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
    public sealed partial class hr_promotioninfoFacadeObjects : BaseFacade, Ihr_promotioninfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_promotioninfoFacadeObjects";
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

        public hr_promotioninfoFacadeObjects()
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

        ~hr_promotioninfoFacadeObjects()
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
		
		long Ihr_promotioninfoFacadeObjects.Delete(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
            {
				return DataAccessFactory.Createhr_promotioninfoDataAccess().Delete(hr_promotioninfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_promotioninfoFacade.Deletehr_promotioninfo"));
            }
        }
		
		long Ihr_promotioninfoFacadeObjects.Update(hr_promotioninfoEntity hr_promotioninfo )
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().Update(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_promotioninfoFacade.Updatehr_promotioninfo"));
            }
		}
		
		long Ihr_promotioninfoFacadeObjects.Add(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().Add(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_promotioninfoFacade.Addhr_promotioninfo"));
            }
		}
		
        long Ihr_promotioninfoFacadeObjects.SaveList(List<hr_promotioninfoEntity> list)
        {
            try
            {
                IList<hr_promotioninfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_promotioninfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_promotioninfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_promotioninfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_promotioninfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_promotioninfoEntity> Ihr_promotioninfoFacadeObjects.GetAll(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().GetAll(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_promotioninfoEntity> Ihr_promotioninfoFacade.GetAllhr_promotioninfo"));
            }
		}
		
		IList<hr_promotioninfoEntity> Ihr_promotioninfoFacadeObjects.GetAllByPages(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().GetAllByPages(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_promotioninfoEntity> Ihr_promotioninfoFacade.GetAllByPageshr_promotioninfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_promotioninfoEntity Ihr_promotioninfoFacadeObjects.GetSingle(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().GetSingle(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_promotioninfoEntity Ihr_promotioninfoFacade.GetSinglehr_promotioninfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_promotioninfoEntity> Ihr_promotioninfoFacadeObjects.GAPgListView(hr_promotioninfoEntity hr_promotioninfo)
		{
			try
			{
				return DataAccessFactory.Createhr_promotioninfoDataAccess().GAPgListView(hr_promotioninfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_promotioninfoEntity> Ihr_promotioninfoFacade.GAPgListViewhr_promotioninfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}