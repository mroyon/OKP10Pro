
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
    public sealed partial class gen_bloodgroupFacadeObjects : BaseFacade, Igen_bloodgroupFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_bloodgroupFacadeObjects";
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

        public gen_bloodgroupFacadeObjects()
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

        ~gen_bloodgroupFacadeObjects()
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
		
		long Igen_bloodgroupFacadeObjects.Delete(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
            {
				return DataAccessFactory.Creategen_bloodgroupDataAccess().Delete(gen_bloodgroup);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Deletegen_bloodgroup"));
            }
        }
		
		long Igen_bloodgroupFacadeObjects.Update(gen_bloodgroupEntity gen_bloodgroup )
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().Update(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Updategen_bloodgroup"));
            }
		}
		
		long Igen_bloodgroupFacadeObjects.Add(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().Add(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Addgen_bloodgroup"));
            }
		}
		
        long Igen_bloodgroupFacadeObjects.SaveList(List<gen_bloodgroupEntity> list)
        {
            try
            {
                IList<gen_bloodgroupEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_bloodgroupEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_bloodgroupEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_bloodgroupDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_bloodgroup"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_bloodgroupEntity> Igen_bloodgroupFacadeObjects.GetAll(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().GetAll(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetAllgen_bloodgroup"));
            }
		}
		
		IList<gen_bloodgroupEntity> Igen_bloodgroupFacadeObjects.GetAllByPages(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().GetAllByPages(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetAllByPagesgen_bloodgroup"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_bloodgroupFacadeObjects.SaveMasterDethr_familyinfo(gen_bloodgroupEntity Master, List<hr_familyinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_bloodgroupDataAccess().SaveMasterDethr_familyinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_familyinfo"));
               }
        }
        
        
        long Igen_bloodgroupFacadeObjects.SaveMasterDethr_personalinfo(gen_bloodgroupEntity Master, List<hr_personalinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_bloodgroupDataAccess().SaveMasterDethr_personalinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_personalinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_bloodgroupEntity Igen_bloodgroupFacadeObjects.GetSingle(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().GetSingle(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_bloodgroupEntity Igen_bloodgroupFacade.GetSinglegen_bloodgroup"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_bloodgroupEntity> Igen_bloodgroupFacadeObjects.GAPgListView(gen_bloodgroupEntity gen_bloodgroup)
		{
			try
			{
				return DataAccessFactory.Creategen_bloodgroupDataAccess().GAPgListView(gen_bloodgroup);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GAPgListViewgen_bloodgroup"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}