
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
    public sealed partial class gen_subunitFacadeObjects : BaseFacade, Igen_subunitFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_subunitFacadeObjects";
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

        public gen_subunitFacadeObjects()
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

        ~gen_subunitFacadeObjects()
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
		
		long Igen_subunitFacadeObjects.Delete(gen_subunitEntity gen_subunit)
		{
			try
            {
				return DataAccessFactory.Creategen_subunitDataAccess().Delete(gen_subunit);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_subunitFacade.Deletegen_subunit"));
            }
        }
		
		long Igen_subunitFacadeObjects.Update(gen_subunitEntity gen_subunit )
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().Update(gen_subunit);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_subunitFacade.Updategen_subunit"));
            }
		}
		
		long Igen_subunitFacadeObjects.Add(gen_subunitEntity gen_subunit)
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().Add(gen_subunit);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_subunitFacade.Addgen_subunit"));
            }
		}
		
        long Igen_subunitFacadeObjects.SaveList(List<gen_subunitEntity> list)
        {
            try
            {
                IList<gen_subunitEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_subunitEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_subunitEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_subunitDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_subunit"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_subunitEntity> Igen_subunitFacadeObjects.GetAll(gen_subunitEntity gen_subunit)
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().GetAll(gen_subunit);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_subunitEntity> Igen_subunitFacade.GetAllgen_subunit"));
            }
		}
		
		IList<gen_subunitEntity> Igen_subunitFacadeObjects.GetAllByPages(gen_subunitEntity gen_subunit)
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().GetAllByPages(gen_subunit);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_subunitEntity> Igen_subunitFacade.GetAllByPagesgen_subunit"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
      //  long Igen_subunitFacadeObjects.SaveMasterDethr_attachmentinfo(gen_subunitEntity Master, List<hr_attachmentinfoEntity> DetailList)
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
      //              return DataAccessFactory.Creategen_subunitDataAccess().SaveMasterDethr_attachmentinfo(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_attachmentinfo"));
      //         }
      //  }
        
        
      //  long Igen_subunitFacadeObjects.SaveMasterDethr_okptransferinfo(gen_subunitEntity Master, List<hr_okptransferinfoEntity> DetailList)
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
      //              return DataAccessFactory.Creategen_subunitDataAccess().SaveMasterDethr_okptransferinfo(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_okptransferinfo"));
      //         }
      //  }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_subunitEntity Igen_subunitFacadeObjects.GetSingle(gen_subunitEntity gen_subunit)
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().GetSingle(gen_subunit);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_subunitEntity Igen_subunitFacade.GetSinglegen_subunit"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_subunitEntity> Igen_subunitFacadeObjects.GAPgListView(gen_subunitEntity gen_subunit)
		{
			try
			{
				return DataAccessFactory.Creategen_subunitDataAccess().GAPgListView(gen_subunit);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_subunitEntity> Igen_subunitFacade.GAPgListViewgen_subunit"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}