
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
    public sealed partial class owin_tsvFacadeObjects : BaseFacade, Iowin_tsvFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_tsvFacadeObjects";
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

        public owin_tsvFacadeObjects()
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

        ~owin_tsvFacadeObjects()
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
		
		long Iowin_tsvFacadeObjects.Delete(owin_tsvEntity owin_tsv)
		{
			try
            {
				return DataAccessFactory.Createowin_tsvDataAccess().Delete(owin_tsv);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_tsvFacade.Deleteowin_tsv"));
            }
        }
		
		long Iowin_tsvFacadeObjects.Update(owin_tsvEntity owin_tsv )
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().Update(owin_tsv);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_tsvFacade.Updateowin_tsv"));
            }
		}
		
		long Iowin_tsvFacadeObjects.Add(owin_tsvEntity owin_tsv)
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().Add(owin_tsv);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_tsvFacade.Addowin_tsv"));
            }
		}
		
        long Iowin_tsvFacadeObjects.SaveList(List<owin_tsvEntity> list)
        {
            try
            {
                IList<owin_tsvEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_tsvEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_tsvEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_tsvDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_tsv"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_tsvEntity> Iowin_tsvFacadeObjects.GetAll(owin_tsvEntity owin_tsv)
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().GetAll(owin_tsv);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_tsvEntity> Iowin_tsvFacade.GetAllowin_tsv"));
            }
		}
		
		IList<owin_tsvEntity> Iowin_tsvFacadeObjects.GetAllByPages(owin_tsvEntity owin_tsv)
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().GetAllByPages(owin_tsv);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_tsvEntity> Iowin_tsvFacade.GetAllByPagesowin_tsv"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_tsvEntity Iowin_tsvFacadeObjects.GetSingle(owin_tsvEntity owin_tsv)
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().GetSingle(owin_tsv);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_tsvEntity Iowin_tsvFacade.GetSingleowin_tsv"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_tsvEntity> Iowin_tsvFacadeObjects.GAPgListView(owin_tsvEntity owin_tsv)
		{
			try
			{
				return DataAccessFactory.Createowin_tsvDataAccess().GAPgListView(owin_tsv);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_tsvEntity> Iowin_tsvFacade.GAPgListViewowin_tsv"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}