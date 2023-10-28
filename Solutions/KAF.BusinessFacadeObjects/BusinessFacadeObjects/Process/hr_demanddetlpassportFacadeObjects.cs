
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
    public sealed partial class hr_demanddetlpassportFacadeObjects : BaseFacade, Ihr_demanddetlpassportFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_demanddetlpassportFacadeObjects";
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

        public hr_demanddetlpassportFacadeObjects()
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

        ~hr_demanddetlpassportFacadeObjects()
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
		
		long Ihr_demanddetlpassportFacadeObjects.Delete(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
            {
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Delete(hr_demanddetlpassport);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Deletehr_demanddetlpassport"));
            }
        }
		
		long Ihr_demanddetlpassportFacadeObjects.Update(hr_demanddetlpassportEntity hr_demanddetlpassport )
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Update(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Updatehr_demanddetlpassport"));
            }
		}
		
		long Ihr_demanddetlpassportFacadeObjects.Add(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Add(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Addhr_demanddetlpassport"));
            }
		}
		
        long Ihr_demanddetlpassportFacadeObjects.SaveList(List<hr_demanddetlpassportEntity> list)
        {
            try
            {
                IList<hr_demanddetlpassportEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_demanddetlpassportEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_demanddetlpassportEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_demanddetlpassportDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_demanddetlpassport"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GetAll(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetAll(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GetAllhr_demanddetlpassport"));
            }
		}
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GetAllByPages(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetAllByPages(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GetAllByPageshr_demanddetlpassport"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_demanddetlpassportEntity Ihr_demanddetlpassportFacadeObjects.GetSingle(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetSingle(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_demanddetlpassportEntity Ihr_demanddetlpassportFacade.GetSinglehr_demanddetlpassport"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GAPgListView(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GAPgListView(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GAPgListViewhr_demanddetlpassport"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}