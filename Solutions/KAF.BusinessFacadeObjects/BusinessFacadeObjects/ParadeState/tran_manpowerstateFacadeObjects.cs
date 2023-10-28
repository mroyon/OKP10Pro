
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
    public sealed partial class tran_manpowerstateFacadeObjects : BaseFacade, Itran_manpowerstateFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_manpowerstateFacadeObjects";
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

        public tran_manpowerstateFacadeObjects()
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

        ~tran_manpowerstateFacadeObjects()
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
		
		long Itran_manpowerstateFacadeObjects.Delete(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
            {
				return DataAccessFactory.Createtran_manpowerstateDataAccess().Delete(tran_manpowerstate);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstateFacade.Deletetran_manpowerstate"));
            }
        }
		
		long Itran_manpowerstateFacadeObjects.Update(tran_manpowerstateEntity tran_manpowerstate )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().Update(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstateFacade.Updatetran_manpowerstate"));
            }
		}
		
		long Itran_manpowerstateFacadeObjects.Add(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().Add(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_manpowerstateFacade.Addtran_manpowerstate"));
            }
		}
		
        long Itran_manpowerstateFacadeObjects.SaveList(List<tran_manpowerstateEntity> list)
        {
            try
            {
                IList<tran_manpowerstateEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_manpowerstateEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_manpowerstateEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_manpowerstateDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_manpowerstate"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_manpowerstateEntity> Itran_manpowerstateFacadeObjects.GetAll(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().GetAll(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstateEntity> Itran_manpowerstateFacade.GetAlltran_manpowerstate"));
            }
		}
		
		IList<tran_manpowerstateEntity> Itran_manpowerstateFacadeObjects.GetAllByPages(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().GetAllByPages(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstateEntity> Itran_manpowerstateFacade.GetAllByPagestran_manpowerstate"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Itran_manpowerstateFacadeObjects.SaveMasterDettran_manpowerstatedetl(tran_manpowerstateEntity Master, List<tran_manpowerstatedetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_manpowerstatedetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_manpowerstatedetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_manpowerstatedetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createtran_manpowerstateDataAccess().SaveMasterDettran_manpowerstatedetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_manpowerstatedetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_manpowerstateEntity Itran_manpowerstateFacadeObjects.GetSingle(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().GetSingle(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_manpowerstateEntity Itran_manpowerstateFacade.GetSingletran_manpowerstate"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_manpowerstateEntity> Itran_manpowerstateFacadeObjects.GAPgListView(tran_manpowerstateEntity tran_manpowerstate)
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().GAPgListView(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_manpowerstateEntity> Itran_manpowerstateFacade.GAPgListViewtran_manpowerstate"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_manpowerstateFacadeObjects.UpdateReviewed(tran_manpowerstateEntity tran_manpowerstate )
		{
			try
			{
				return DataAccessFactory.Createtran_manpowerstateDataAccess().UpdateReviewed(tran_manpowerstate);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_manpowerstateFacade.UpdateReviewedtran_manpowerstate"));
            }
		}
        #endregion 
    
        #endregion
	}
}