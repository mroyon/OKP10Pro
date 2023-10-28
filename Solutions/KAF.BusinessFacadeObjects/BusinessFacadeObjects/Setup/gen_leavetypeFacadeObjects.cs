
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
    public sealed partial class gen_leavetypeFacadeObjects : BaseFacade, Igen_leavetypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_leavetypeFacadeObjects";
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

        public gen_leavetypeFacadeObjects()
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

        ~gen_leavetypeFacadeObjects()
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
		
		long Igen_leavetypeFacadeObjects.Delete(gen_leavetypeEntity gen_leavetype)
		{
			try
            {
				return DataAccessFactory.Creategen_leavetypeDataAccess().Delete(gen_leavetype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_leavetypeFacade.Deletegen_leavetype"));
            }
        }
		
		long Igen_leavetypeFacadeObjects.Update(gen_leavetypeEntity gen_leavetype )
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().Update(gen_leavetype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_leavetypeFacade.Updategen_leavetype"));
            }
		}
		
		long Igen_leavetypeFacadeObjects.Add(gen_leavetypeEntity gen_leavetype)
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().Add(gen_leavetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_leavetypeFacade.Addgen_leavetype"));
            }
		}
		
        long Igen_leavetypeFacadeObjects.SaveList(List<gen_leavetypeEntity> list)
        {
            try
            {
                IList<gen_leavetypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_leavetypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_leavetypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_leavetypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_leavetype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_leavetypeEntity> Igen_leavetypeFacadeObjects.GetAll(gen_leavetypeEntity gen_leavetype)
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().GetAll(gen_leavetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leavetypeEntity> Igen_leavetypeFacade.GetAllgen_leavetype"));
            }
		}
		
		IList<gen_leavetypeEntity> Igen_leavetypeFacadeObjects.GetAllByPages(gen_leavetypeEntity gen_leavetype)
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().GetAllByPages(gen_leavetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leavetypeEntity> Igen_leavetypeFacade.GetAllByPagesgen_leavetype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
      //  long Igen_leavetypeFacadeObjects.SaveMasterDetgen_leaveconfig(gen_leavetypeEntity Master, List<gen_leaveconfigEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<gen_leaveconfigEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<gen_leaveconfigEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<gen_leaveconfigEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Creategen_leavetypeDataAccess().SaveMasterDetgen_leaveconfig(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_leaveconfig"));
      //         }
      //  }
        
        
      //  long Igen_leavetypeFacadeObjects.SaveMasterDethr_leaveinfo(gen_leavetypeEntity Master, List<hr_leaveinfoEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<hr_leaveinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<hr_leaveinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<hr_leaveinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Creategen_leavetypeDataAccess().SaveMasterDethr_leaveinfo(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_leaveinfo"));
      //         }
      //  }
        
        
      //  long Igen_leavetypeFacadeObjects.SaveMasterDethr_leavemodification(gen_leavetypeEntity Master, List<hr_leavemodificationEntity> DetailList)
      //  {
      //      try
      //         {
      //              DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
      //              DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
      //              if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						//DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
      //              IList<hr_leavemodificationEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
      //              IList<hr_leavemodificationEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
      //              IList<hr_leavemodificationEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
      //              return DataAccessFactory.Creategen_leavetypeDataAccess().SaveMasterDethr_leavemodification(Master, listAdded, listUpdated, listDeleted);
      //         }
      //         catch (Exception ex)
      //         {
      //              throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_leavemodification"));
      //         }
      //  }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_leavetypeEntity Igen_leavetypeFacadeObjects.GetSingle(gen_leavetypeEntity gen_leavetype)
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().GetSingle(gen_leavetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_leavetypeEntity Igen_leavetypeFacade.GetSinglegen_leavetype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_leavetypeEntity> Igen_leavetypeFacadeObjects.GAPgListView(gen_leavetypeEntity gen_leavetype)
		{
			try
			{
				return DataAccessFactory.Creategen_leavetypeDataAccess().GAPgListView(gen_leavetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leavetypeEntity> Igen_leavetypeFacade.GAPgListViewgen_leavetype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}