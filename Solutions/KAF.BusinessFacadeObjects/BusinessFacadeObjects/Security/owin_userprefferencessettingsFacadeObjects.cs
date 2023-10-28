
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
    public sealed partial class owin_userprefferencessettingsFacadeObjects : BaseFacade, Iowin_userprefferencessettingsFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userprefferencessettingsFacadeObjects";
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

        public owin_userprefferencessettingsFacadeObjects()
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

        ~owin_userprefferencessettingsFacadeObjects()
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
		
		long Iowin_userprefferencessettingsFacadeObjects.Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
            {
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().Delete(owin_userprefferencessettings);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userprefferencessettingsFacade.Deleteowin_userprefferencessettings"));
            }
        }
		
		long Iowin_userprefferencessettingsFacadeObjects.Update(owin_userprefferencessettingsEntity owin_userprefferencessettings )
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().Update(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userprefferencessettingsFacade.Updateowin_userprefferencessettings"));
            }
		}
		
		long Iowin_userprefferencessettingsFacadeObjects.Add(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().Add(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userprefferencessettingsFacade.Addowin_userprefferencessettings"));
            }
		}
		
        long Iowin_userprefferencessettingsFacadeObjects.SaveList(List<owin_userprefferencessettingsEntity> list)
        {
            try
            {
                IList<owin_userprefferencessettingsEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userprefferencessettingsEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userprefferencessettingsEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userprefferencessettings"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacadeObjects.GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().GetAll(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacade.GetAllowin_userprefferencessettings"));
            }
		}
		
		IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacadeObjects.GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().GetAllByPages(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacade.GetAllByPagesowin_userprefferencessettings"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_userprefferencessettingsEntity Iowin_userprefferencessettingsFacadeObjects.GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().GetSingle(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userprefferencessettingsEntity Iowin_userprefferencessettingsFacade.GetSingleowin_userprefferencessettings"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacadeObjects.GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings)
		{
			try
			{
				return DataAccessFactory.Createowin_userprefferencessettingsDataAccess().GAPgListView(owin_userprefferencessettings);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsFacade.GAPgListViewowin_userprefferencessettings"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}