
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
    public sealed partial class cnf_paymentitemFacadeObjects : BaseFacade, Icnf_paymentitemFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_paymentitemFacadeObjects";
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

        public cnf_paymentitemFacadeObjects()
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

        ~cnf_paymentitemFacadeObjects()
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
		
		long Icnf_paymentitemFacadeObjects.Delete(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
            {
				return DataAccessFactory.Createcnf_paymentitemDataAccess().Delete(cnf_paymentitem);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_paymentitemFacade.Deletecnf_paymentitem"));
            }
        }
		
		long Icnf_paymentitemFacadeObjects.Update(cnf_paymentitemEntity cnf_paymentitem )
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().Update(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_paymentitemFacade.Updatecnf_paymentitem"));
            }
		}
		
		long Icnf_paymentitemFacadeObjects.Add(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().Add(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_paymentitemFacade.Addcnf_paymentitem"));
            }
		}
		
        long Icnf_paymentitemFacadeObjects.SaveList(List<cnf_paymentitemEntity> list)
        {
            try
            {
                IList<cnf_paymentitemEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_paymentitemEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_paymentitemEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createcnf_paymentitemDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_paymentitem"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<cnf_paymentitemEntity> Icnf_paymentitemFacadeObjects.GetAll(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().GetAll(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_paymentitemEntity> Icnf_paymentitemFacade.GetAllcnf_paymentitem"));
            }
		}
		
		IList<cnf_paymentitemEntity> Icnf_paymentitemFacadeObjects.GetAllByPages(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().GetAllByPages(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_paymentitemEntity> Icnf_paymentitemFacade.GetAllByPagescnf_paymentitem"));
            }
		}
		
		#endregion GetAll
        
      
	
        
        #region Simple load Single Row
        cnf_paymentitemEntity Icnf_paymentitemFacadeObjects.GetSingle(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().GetSingle(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_paymentitemEntity Icnf_paymentitemFacade.GetSinglecnf_paymentitem"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<cnf_paymentitemEntity> Icnf_paymentitemFacadeObjects.GAPgListView(cnf_paymentitemEntity cnf_paymentitem)
		{
			try
			{
				return DataAccessFactory.Createcnf_paymentitemDataAccess().GAPgListView(cnf_paymentitem);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_paymentitemEntity> Icnf_paymentitemFacade.GAPgListViewcnf_paymentitem"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}