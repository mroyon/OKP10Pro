
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
    public sealed partial class hr_punishmentinfoFacadeObjects : BaseFacade, Ihr_punishmentinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_punishmentinfoFacadeObjects";
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

        public hr_punishmentinfoFacadeObjects()
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

        ~hr_punishmentinfoFacadeObjects()
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
		
		long Ihr_punishmentinfoFacadeObjects.Delete(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().Delete(hr_punishmentinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_punishmentinfoFacade.Deletehr_punishmentinfo"));
            }
        }
		
		long Ihr_punishmentinfoFacadeObjects.Update(hr_punishmentinfoEntity hr_punishmentinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().Update(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_punishmentinfoFacade.Updatehr_punishmentinfo"));
            }
		}
		
		long Ihr_punishmentinfoFacadeObjects.Add(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().Add(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_punishmentinfoFacade.Addhr_punishmentinfo"));
            }
		}
		
        long Ihr_punishmentinfoFacadeObjects.SaveList(List<hr_punishmentinfoEntity> list)
        {
            try
            {
                IList<hr_punishmentinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_punishmentinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_punishmentinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_punishmentinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_punishmentinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacadeObjects.GetAll(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().GetAll(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacade.GetAllhr_punishmentinfo"));
            }
		}
		
		IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacadeObjects.GetAllByPages(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().GetAllByPages(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacade.GetAllByPageshr_punishmentinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_punishmentinfoEntity Ihr_punishmentinfoFacadeObjects.GetSingle(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().GetSingle(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_punishmentinfoEntity Ihr_punishmentinfoFacade.GetSinglehr_punishmentinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacadeObjects.GAPgListView(hr_punishmentinfoEntity hr_punishmentinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_punishmentinfoDataAccess().GAPgListView(hr_punishmentinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_punishmentinfoEntity> Ihr_punishmentinfoFacade.GAPgListViewhr_punishmentinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}