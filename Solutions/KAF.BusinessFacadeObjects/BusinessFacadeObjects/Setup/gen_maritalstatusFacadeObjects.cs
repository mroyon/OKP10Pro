
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
    public sealed partial class gen_maritalstatusFacadeObjects : BaseFacade, Igen_maritalstatusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_maritalstatusFacadeObjects";
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

        public gen_maritalstatusFacadeObjects()
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

        ~gen_maritalstatusFacadeObjects()
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
		
		long Igen_maritalstatusFacadeObjects.Delete(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
            {
				return DataAccessFactory.Creategen_maritalstatusDataAccess().Delete(gen_maritalstatus);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Deletegen_maritalstatus"));
            }
        }
		
		long Igen_maritalstatusFacadeObjects.Update(gen_maritalstatusEntity gen_maritalstatus )
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().Update(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Updategen_maritalstatus"));
            }
		}
		
		long Igen_maritalstatusFacadeObjects.Add(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().Add(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Addgen_maritalstatus"));
            }
		}
		
        long Igen_maritalstatusFacadeObjects.SaveList(List<gen_maritalstatusEntity> list)
        {
            try
            {
                IList<gen_maritalstatusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_maritalstatusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_maritalstatusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_maritalstatusDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_maritalstatus"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_maritalstatusEntity> Igen_maritalstatusFacadeObjects.GetAll(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().GetAll(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetAllgen_maritalstatus"));
            }
		}
		
		IList<gen_maritalstatusEntity> Igen_maritalstatusFacadeObjects.GetAllByPages(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().GetAllByPages(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetAllByPagesgen_maritalstatus"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_maritalstatusFacadeObjects.SaveMasterDethr_familyinfo(gen_maritalstatusEntity Master, List<hr_familyinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_maritalstatusDataAccess().SaveMasterDethr_familyinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyinfo"));
               }
        }
        
        
        long Igen_maritalstatusFacadeObjects.SaveMasterDethr_personalinfo(gen_maritalstatusEntity Master, List<hr_personalinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_personalinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_personalinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_personalinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_maritalstatusDataAccess().SaveMasterDethr_personalinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_personalinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_maritalstatusEntity Igen_maritalstatusFacadeObjects.GetSingle(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().GetSingle(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_maritalstatusEntity Igen_maritalstatusFacade.GetSinglegen_maritalstatus"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_maritalstatusEntity> Igen_maritalstatusFacadeObjects.GAPgListView(gen_maritalstatusEntity gen_maritalstatus)
		{
			try
			{
				return DataAccessFactory.Creategen_maritalstatusDataAccess().GAPgListView(gen_maritalstatus);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GAPgListViewgen_maritalstatus"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}