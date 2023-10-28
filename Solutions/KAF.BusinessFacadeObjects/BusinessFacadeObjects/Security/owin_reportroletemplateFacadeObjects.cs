
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
    public sealed partial class owin_reportroletemplateFacadeObjects : BaseFacade, Iowin_reportroletemplateFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_reportroletemplateFacadeObjects";
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

        public owin_reportroletemplateFacadeObjects()
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

        ~owin_reportroletemplateFacadeObjects()
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
		
		long Iowin_reportroletemplateFacadeObjects.Delete(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
            {
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().Delete(owin_reportroletemplate);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportroletemplateFacade.Deleteowin_reportroletemplate"));
            }
        }
		
		long Iowin_reportroletemplateFacadeObjects.Update(owin_reportroletemplateEntity owin_reportroletemplate )
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().Update(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_reportroletemplateFacade.Updateowin_reportroletemplate"));
            }
		}
		
		long Iowin_reportroletemplateFacadeObjects.Add(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().Add(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_reportroletemplateFacade.Addowin_reportroletemplate"));
            }
		}
		
        long Iowin_reportroletemplateFacadeObjects.SaveList(List<owin_reportroletemplateEntity> list)
        {
            try
            {
                IList<owin_reportroletemplateEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_reportroletemplateEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_reportroletemplateEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_reportroletemplateDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_reportroletemplate"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacadeObjects.GetAll(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().GetAll(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacade.GetAllowin_reportroletemplate"));
            }
		}
		
		IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacadeObjects.GetAllByPages(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().GetAllByPages(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacade.GetAllByPagesowin_reportroletemplate"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_reportroletemplateEntity Iowin_reportroletemplateFacadeObjects.GetSingle(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().GetSingle(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_reportroletemplateEntity Iowin_reportroletemplateFacade.GetSingleowin_reportroletemplate"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacadeObjects.GAPgListView(owin_reportroletemplateEntity owin_reportroletemplate)
		{
			try
			{
				return DataAccessFactory.Createowin_reportroletemplateDataAccess().GAPgListView(owin_reportroletemplate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroletemplateEntity> Iowin_reportroletemplateFacade.GAPgListViewowin_reportroletemplate"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}