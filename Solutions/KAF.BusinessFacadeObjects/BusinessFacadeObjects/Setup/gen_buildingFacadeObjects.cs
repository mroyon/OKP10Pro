
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
    public sealed partial class gen_buildingFacadeObjects : BaseFacade, Igen_buildingFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_buildingFacadeObjects";
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

        public gen_buildingFacadeObjects()
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

        ~gen_buildingFacadeObjects()
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
		
		long Igen_buildingFacadeObjects.Delete(gen_buildingEntity gen_building)
		{
			try
            {
				return DataAccessFactory.Creategen_buildingDataAccess().Delete(gen_building);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_buildingFacade.Deletegen_building"));
            }
        }
		
		long Igen_buildingFacadeObjects.Update(gen_buildingEntity gen_building )
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().Update(gen_building);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_buildingFacade.Updategen_building"));
            }
		}
		
		long Igen_buildingFacadeObjects.Add(gen_buildingEntity gen_building)
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().Add(gen_building);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_buildingFacade.Addgen_building"));
            }
		}
		
        long Igen_buildingFacadeObjects.SaveList(List<gen_buildingEntity> list)
        {
            try
            {
                IList<gen_buildingEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_buildingEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_buildingEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_buildingDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_building"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_buildingEntity> Igen_buildingFacadeObjects.GetAll(gen_buildingEntity gen_building)
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().GetAll(gen_building);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_buildingEntity> Igen_buildingFacade.GetAllgen_building"));
            }
		}
		
		IList<gen_buildingEntity> Igen_buildingFacadeObjects.GetAllByPages(gen_buildingEntity gen_building)
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().GetAllByPages(gen_building);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_buildingEntity> Igen_buildingFacade.GetAllByPagesgen_building"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_buildingFacadeObjects.SaveMasterDethr_addresschange(gen_buildingEntity Master, List<hr_addresschangeEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_addresschangeEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_addresschangeEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_addresschangeEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_buildingDataAccess().SaveMasterDethr_addresschange(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_addresschange"));
               }
        }
        
        
        long Igen_buildingFacadeObjects.SaveMasterDethr_personalinfo(gen_buildingEntity Master, List<hr_personalinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_buildingDataAccess().SaveMasterDethr_personalinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_personalinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_buildingEntity Igen_buildingFacadeObjects.GetSingle(gen_buildingEntity gen_building)
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().GetSingle(gen_building);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_buildingEntity Igen_buildingFacade.GetSinglegen_building"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_buildingEntity> Igen_buildingFacadeObjects.GAPgListView(gen_buildingEntity gen_building)
		{
			try
			{
				return DataAccessFactory.Creategen_buildingDataAccess().GAPgListView(gen_building);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_buildingEntity> Igen_buildingFacade.GAPgListViewgen_building"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}