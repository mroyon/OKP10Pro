
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
    public sealed partial class gen_armsFacadeObjects : BaseFacade, Igen_armsFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_armsFacadeObjects";
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

        public gen_armsFacadeObjects()
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

        ~gen_armsFacadeObjects()
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
		
		long Igen_armsFacadeObjects.Delete(gen_armsEntity gen_arms)
		{
			try
            {
				return DataAccessFactory.Creategen_armsDataAccess().Delete(gen_arms);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_armsFacade.Deletegen_arms"));
            }
        }
		
		long Igen_armsFacadeObjects.Update(gen_armsEntity gen_arms )
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().Update(gen_arms);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_armsFacade.Updategen_arms"));
            }
		}
		
		long Igen_armsFacadeObjects.Add(gen_armsEntity gen_arms)
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().Add(gen_arms);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_armsFacade.Addgen_arms"));
            }
		}
		
        long Igen_armsFacadeObjects.SaveList(List<gen_armsEntity> list)
        {
            try
            {
                IList<gen_armsEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_armsEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_armsEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_armsDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_arms"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_armsEntity> Igen_armsFacadeObjects.GetAll(gen_armsEntity gen_arms)
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().GetAll(gen_arms);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_armsEntity> Igen_armsFacade.GetAllgen_arms"));
            }
		}
		
		IList<gen_armsEntity> Igen_armsFacadeObjects.GetAllByPages(gen_armsEntity gen_arms)
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().GetAllByPages(gen_arms);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_armsEntity> Igen_armsFacade.GetAllByPagesgen_arms"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_armsFacadeObjects.SaveMasterDethr_svcinfo(gen_armsEntity Master, List<hr_svcinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_svcinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_svcinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_svcinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_armsDataAccess().SaveMasterDethr_svcinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_svcinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_armsEntity Igen_armsFacadeObjects.GetSingle(gen_armsEntity gen_arms)
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().GetSingle(gen_arms);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_armsEntity Igen_armsFacade.GetSinglegen_arms"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_armsEntity> Igen_armsFacadeObjects.GAPgListView(gen_armsEntity gen_arms)
		{
			try
			{
				return DataAccessFactory.Creategen_armsDataAccess().GAPgListView(gen_arms);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_armsEntity> Igen_armsFacade.GAPgListViewgen_arms"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}