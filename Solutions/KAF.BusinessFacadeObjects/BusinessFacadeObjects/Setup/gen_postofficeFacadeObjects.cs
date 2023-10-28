
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
    public sealed partial class gen_postofficeFacadeObjects : BaseFacade, Igen_postofficeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_postofficeFacadeObjects";
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

        public gen_postofficeFacadeObjects()
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

        ~gen_postofficeFacadeObjects()
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
		
		long Igen_postofficeFacadeObjects.Delete(gen_postofficeEntity gen_postoffice)
		{
			try
            {
				return DataAccessFactory.Creategen_postofficeDataAccess().Delete(gen_postoffice);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_postofficeFacade.Deletegen_postoffice"));
            }
        }
		
		long Igen_postofficeFacadeObjects.Update(gen_postofficeEntity gen_postoffice )
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().Update(gen_postoffice);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_postofficeFacade.Updategen_postoffice"));
            }
		}
		
		long Igen_postofficeFacadeObjects.Add(gen_postofficeEntity gen_postoffice)
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().Add(gen_postoffice);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_postofficeFacade.Addgen_postoffice"));
            }
		}
		
        long Igen_postofficeFacadeObjects.SaveList(List<gen_postofficeEntity> list)
        {
            try
            {
                IList<gen_postofficeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_postofficeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_postofficeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_postofficeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_postoffice"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_postofficeEntity> Igen_postofficeFacadeObjects.GetAll(gen_postofficeEntity gen_postoffice)
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().GetAll(gen_postoffice);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_postofficeEntity> Igen_postofficeFacade.GetAllgen_postoffice"));
            }
		}
		
		IList<gen_postofficeEntity> Igen_postofficeFacadeObjects.GetAllByPages(gen_postofficeEntity gen_postoffice)
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().GetAllByPages(gen_postoffice);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_postofficeEntity> Igen_postofficeFacade.GetAllByPagesgen_postoffice"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_postofficeFacadeObjects.SaveMasterDethr_emergencycontact(gen_postofficeEntity Master, List<hr_emergencycontactEntity> DetailList)
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
                    return DataAccessFactory.Creategen_postofficeDataAccess().SaveMasterDethr_emergencycontact(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_emergencycontact"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_postofficeEntity Igen_postofficeFacadeObjects.GetSingle(gen_postofficeEntity gen_postoffice)
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().GetSingle(gen_postoffice);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_postofficeEntity Igen_postofficeFacade.GetSinglegen_postoffice"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_postofficeEntity> Igen_postofficeFacadeObjects.GAPgListView(gen_postofficeEntity gen_postoffice)
		{
			try
			{
				return DataAccessFactory.Creategen_postofficeDataAccess().GAPgListView(gen_postoffice);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_postofficeEntity> Igen_postofficeFacade.GAPgListViewgen_postoffice"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}