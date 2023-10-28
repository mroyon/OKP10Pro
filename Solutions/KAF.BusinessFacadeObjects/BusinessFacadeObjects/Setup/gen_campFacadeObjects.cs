
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
    public sealed partial class gen_campFacadeObjects : BaseFacade, Igen_campFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_campFacadeObjects";
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

        public gen_campFacadeObjects()
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

        ~gen_campFacadeObjects()
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
		
		long Igen_campFacadeObjects.Delete(gen_campEntity gen_camp)
		{
			try
            {
				return DataAccessFactory.Creategen_campDataAccess().Delete(gen_camp);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_campFacade.Deletegen_camp"));
            }
        }
		
		long Igen_campFacadeObjects.Update(gen_campEntity gen_camp )
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().Update(gen_camp);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_campFacade.Updategen_camp"));
            }
		}
		
		long Igen_campFacadeObjects.Add(gen_campEntity gen_camp)
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().Add(gen_camp);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_campFacade.Addgen_camp"));
            }
		}
		
        long Igen_campFacadeObjects.SaveList(List<gen_campEntity> list)
        {
            try
            {
                IList<gen_campEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_campEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_campEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_campDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_camp"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_campEntity> Igen_campFacadeObjects.GetAll(gen_campEntity gen_camp)
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().GetAll(gen_camp);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_campEntity> Igen_campFacade.GetAllgen_camp"));
            }
		}
		
		IList<gen_campEntity> Igen_campFacadeObjects.GetAllByPages(gen_campEntity gen_camp)
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().GetAllByPages(gen_camp);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_campEntity> Igen_campFacade.GetAllByPagesgen_camp"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
      //  long Igen_campFacadeObjects.SaveMasterDethr_attachmentinfo(gen_campEntity Master, List<hr_attachmentinfoEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<hr_attachmentinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<hr_attachmentinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<hr_attachmentinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Creategen_campDataAccess().SaveMasterDethr_attachmentinfo(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_attachmentinfo"));
      //         }
      //  }
        
        
      //  long Igen_campFacadeObjects.SaveMasterDethr_okptransferinfo(gen_campEntity Master, List<hr_okptransferinfoEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<hr_okptransferinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<hr_okptransferinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<hr_okptransferinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Creategen_campDataAccess().SaveMasterDethr_okptransferinfo(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_okptransferinfo"));
      //         }
      //  }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_campEntity Igen_campFacadeObjects.GetSingle(gen_campEntity gen_camp)
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().GetSingle(gen_camp);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_campEntity Igen_campFacade.GetSinglegen_camp"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_campEntity> Igen_campFacadeObjects.GAPgListView(gen_campEntity gen_camp)
		{
			try
			{
				return DataAccessFactory.Creategen_campDataAccess().GAPgListView(gen_camp);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_campEntity> Igen_campFacade.GAPgListViewgen_camp"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}