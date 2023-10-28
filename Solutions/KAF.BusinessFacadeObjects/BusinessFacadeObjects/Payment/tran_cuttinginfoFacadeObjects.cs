
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
    public sealed partial class tran_cuttinginfoFacadeObjects : BaseFacade, Itran_cuttinginfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_cuttinginfoFacadeObjects";
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

        public tran_cuttinginfoFacadeObjects()
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

        ~tran_cuttinginfoFacadeObjects()
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
		
		long Itran_cuttinginfoFacadeObjects.Delete(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
            {
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().Delete(tran_cuttinginfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfoFacade.Deletetran_cuttinginfo"));
            }
        }
		
		long Itran_cuttinginfoFacadeObjects.Update(tran_cuttinginfoEntity tran_cuttinginfo )
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().Update(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfoFacade.Updatetran_cuttinginfo"));
            }
		}
		
		long Itran_cuttinginfoFacadeObjects.Add(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().Add(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfoFacade.Addtran_cuttinginfo"));
            }
		}
		
        long Itran_cuttinginfoFacadeObjects.SaveList(List<tran_cuttinginfoEntity> list)
        {
            try
            {
                IList<tran_cuttinginfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_cuttinginfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_cuttinginfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createtran_cuttinginfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_cuttinginfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacadeObjects.GetAll(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().GetAll(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacade.GetAlltran_cuttinginfo"));
            }
		}
		
		IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacadeObjects.GetAllByPages(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().GetAllByPages(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacade.GetAllByPagestran_cuttinginfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Itran_cuttinginfoFacadeObjects.SaveMasterDettran_cuttinginfodetl(tran_cuttinginfoEntity Master, List<tran_cuttinginfodetlEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_cuttinginfodetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_cuttinginfodetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_cuttinginfodetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Createtran_cuttinginfoDataAccess().SaveMasterDettran_cuttinginfodetl(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_cuttinginfodetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        tran_cuttinginfoEntity Itran_cuttinginfoFacadeObjects.GetSingle(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().GetSingle(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_cuttinginfoEntity Itran_cuttinginfoFacade.GetSingletran_cuttinginfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacadeObjects.GAPgListView(tran_cuttinginfoEntity tran_cuttinginfo)
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().GAPgListView(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfoEntity> Itran_cuttinginfoFacade.GAPgListViewtran_cuttinginfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        long Itran_cuttinginfoFacadeObjects.UpdateReviewed(tran_cuttinginfoEntity tran_cuttinginfo )
		{
			try
			{
				return DataAccessFactory.Createtran_cuttinginfoDataAccess().Update(tran_cuttinginfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_cuttinginfoFacade.UpdateReviewedtran_cuttinginfo"));
            }
		}
        #endregion 
    
        #endregion
	}
}