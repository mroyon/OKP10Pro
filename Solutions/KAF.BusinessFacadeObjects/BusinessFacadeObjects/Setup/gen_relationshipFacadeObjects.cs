
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
    public sealed partial class gen_relationshipFacadeObjects : BaseFacade, Igen_relationshipFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_relationshipFacadeObjects";
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

        public gen_relationshipFacadeObjects()
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

        ~gen_relationshipFacadeObjects()
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
		
		long Igen_relationshipFacadeObjects.Delete(gen_relationshipEntity gen_relationship)
		{
			try
            {
				return DataAccessFactory.Creategen_relationshipDataAccess().Delete(gen_relationship);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Deletegen_relationship"));
            }
        }
		
		long Igen_relationshipFacadeObjects.Update(gen_relationshipEntity gen_relationship )
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().Update(gen_relationship);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Updategen_relationship"));
            }
		}
		
		long Igen_relationshipFacadeObjects.Add(gen_relationshipEntity gen_relationship)
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().Add(gen_relationship);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Addgen_relationship"));
            }
		}
		
        long Igen_relationshipFacadeObjects.SaveList(List<gen_relationshipEntity> list)
        {
            try
            {
                IList<gen_relationshipEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_relationshipEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_relationshipEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_relationshipDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_relationship"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_relationshipEntity> Igen_relationshipFacadeObjects.GetAll(gen_relationshipEntity gen_relationship)
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().GetAll(gen_relationship);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetAllgen_relationship"));
            }
		}
		
		IList<gen_relationshipEntity> Igen_relationshipFacadeObjects.GetAllByPages(gen_relationshipEntity gen_relationship)
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().GetAllByPages(gen_relationship);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetAllByPagesgen_relationship"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_relationshipFacadeObjects.SaveMasterDethr_emergencycontact(gen_relationshipEntity Master, List<hr_emergencycontactEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_emergencycontactEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_emergencycontactEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_emergencycontactEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_relationshipDataAccess().SaveMasterDethr_emergencycontact(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_emergencycontact"));
               }
        }
        
        
        long Igen_relationshipFacadeObjects.SaveMasterDethr_familyinfo(gen_relationshipEntity Master, List<hr_familyinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_familyinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_familyinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_familyinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_relationshipDataAccess().SaveMasterDethr_familyinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_relationshipEntity Igen_relationshipFacadeObjects.GetSingle(gen_relationshipEntity gen_relationship)
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().GetSingle(gen_relationship);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_relationshipEntity Igen_relationshipFacade.GetSinglegen_relationship"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_relationshipEntity> Igen_relationshipFacadeObjects.GAPgListView(gen_relationshipEntity gen_relationship)
		{
			try
			{
				return DataAccessFactory.Creategen_relationshipDataAccess().GAPgListView(gen_relationship);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GAPgListViewgen_relationship"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}