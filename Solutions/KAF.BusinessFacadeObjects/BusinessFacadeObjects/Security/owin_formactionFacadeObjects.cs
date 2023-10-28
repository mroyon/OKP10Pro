
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
    public sealed partial class owin_formactionFacadeObjects : BaseFacade, Iowin_formactionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_formactionFacadeObjects";
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

        public owin_formactionFacadeObjects()
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

        ~owin_formactionFacadeObjects()
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
		
		long Iowin_formactionFacadeObjects.Delete(owin_formactionEntity owin_formaction)
		{
			try
            {
				return DataAccessFactory.Createowin_formactionDataAccess().Delete(owin_formaction);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Deleteowin_formaction"));
            }
        }
		
		long Iowin_formactionFacadeObjects.Update(owin_formactionEntity owin_formaction )
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().Update(owin_formaction);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Updateowin_formaction"));
            }
		}
		
		long Iowin_formactionFacadeObjects.Add(owin_formactionEntity owin_formaction)
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().Add(owin_formaction);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Addowin_formaction"));
            }
		}
		
        long Iowin_formactionFacadeObjects.SaveList(List<owin_formactionEntity> list)
        {
            try
            {
                IList<owin_formactionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_formactionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_formactionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createowin_formactionDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_formaction"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<owin_formactionEntity> Iowin_formactionFacadeObjects.GetAll(owin_formactionEntity owin_formaction)
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().GetAll(owin_formaction);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetAllowin_formaction"));
            }
		}
		
		IList<owin_formactionEntity> Iowin_formactionFacadeObjects.GetAllByPages(owin_formactionEntity owin_formaction)
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().GetAllByPages(owin_formaction);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetAllByPagesowin_formaction"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Iowin_formactionFacadeObjects.SaveMasterDetowin_rolepermission(owin_formactionEntity Master, List<owin_rolepermissionEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_rolepermissionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_rolepermissionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_rolepermissionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createowin_formactionDataAccess().SaveMasterDetowin_rolepermission(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_rolepermission"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        owin_formactionEntity Iowin_formactionFacadeObjects.GetSingle(owin_formactionEntity owin_formaction)
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().GetSingle(owin_formaction);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_formactionEntity Iowin_formactionFacade.GetSingleowin_formaction"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<owin_formactionEntity> Iowin_formactionFacadeObjects.GAPgListView(owin_formactionEntity owin_formaction)
		{
			try
			{
				return DataAccessFactory.Createowin_formactionDataAccess().GAPgListView(owin_formaction);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GAPgListViewowin_formaction"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}