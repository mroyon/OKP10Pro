
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
    public sealed partial class gen_divisiondistrictFacadeObjects : BaseFacade, Igen_divisiondistrictFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_divisiondistrictFacadeObjects";
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

        public gen_divisiondistrictFacadeObjects()
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

        ~gen_divisiondistrictFacadeObjects()
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
		
		long Igen_divisiondistrictFacadeObjects.Delete(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
            {
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().Delete(gen_divisiondistrict);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_divisiondistrictFacade.Deletegen_divisiondistrict"));
            }
        }
		
		long Igen_divisiondistrictFacadeObjects.Update(gen_divisiondistrictEntity gen_divisiondistrict )
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().Update(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_divisiondistrictFacade.Updategen_divisiondistrict"));
            }
		}
		
		long Igen_divisiondistrictFacadeObjects.Add(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().Add(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_divisiondistrictFacade.Addgen_divisiondistrict"));
            }
		}
		
        long Igen_divisiondistrictFacadeObjects.SaveList(List<gen_divisiondistrictEntity> list)
        {
            try
            {
                IList<gen_divisiondistrictEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_divisiondistrictEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_divisiondistrictEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_divisiondistrict"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacadeObjects.GetAll(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().GetAll(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacade.GetAllgen_divisiondistrict"));
            }
		}
		
		IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacadeObjects.GetAllByPages(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().GetAllByPages(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacade.GetAllByPagesgen_divisiondistrict"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_divisiondistrictFacadeObjects.SaveMasterDetgen_divisiondistrict(gen_divisiondistrictEntity Master, List<gen_divisiondistrictEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_divisiondistrictEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_divisiondistrictEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_divisiondistrictEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveMasterDetgen_divisiondistrict(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_divisiondistrict"));
               }
        }
        
        
        long Igen_divisiondistrictFacadeObjects.SaveMasterDetgen_thana(gen_divisiondistrictEntity Master, List<gen_thanaEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_thanaEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_thanaEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_thanaEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveMasterDetgen_thana(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_thana"));
               }
        }
        
        
        long Igen_divisiondistrictFacadeObjects.SaveMasterDethr_addresschange(gen_divisiondistrictEntity Master, List<hr_addresschangeEntity> DetailList)
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
                    return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveMasterDethr_addresschange(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_addresschange"));
               }
        }
        
        
        long Igen_divisiondistrictFacadeObjects.SaveMasterDethr_emergencycontact(gen_divisiondistrictEntity Master, List<hr_emergencycontactEntity> DetailList)
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
                    return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveMasterDethr_emergencycontact(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_emergencycontact"));
               }
        }
        
        
        long Igen_divisiondistrictFacadeObjects.SaveMasterDethr_personalinfo(gen_divisiondistrictEntity Master, List<hr_personalinfoEntity> DetailList)
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
                    return DataAccessFactory.Creategen_divisiondistrictDataAccess().SaveMasterDethr_personalinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_personalinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_divisiondistrictEntity Igen_divisiondistrictFacadeObjects.GetSingle(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().GetSingle(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_divisiondistrictEntity Igen_divisiondistrictFacade.GetSinglegen_divisiondistrict"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacadeObjects.GAPgListView(gen_divisiondistrictEntity gen_divisiondistrict)
		{
			try
			{
				return DataAccessFactory.Creategen_divisiondistrictDataAccess().GAPgListView(gen_divisiondistrict);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_divisiondistrictEntity> Igen_divisiondistrictFacade.GAPgListViewgen_divisiondistrict"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}