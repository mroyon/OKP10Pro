
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
    public sealed partial class gen_languageFacadeObjects : BaseFacade, Igen_languageFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_languageFacadeObjects";
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

        public gen_languageFacadeObjects()
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

        ~gen_languageFacadeObjects()
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
		
		long Igen_languageFacadeObjects.Delete(gen_languageEntity gen_language)
		{
			try
            {
				return DataAccessFactory.Creategen_languageDataAccess().Delete(gen_language);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languageFacade.Deletegen_language"));
            }
        }
		
		long Igen_languageFacadeObjects.Update(gen_languageEntity gen_language )
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().Update(gen_language);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_languageFacade.Updategen_language"));
            }
		}
		
		long Igen_languageFacadeObjects.Add(gen_languageEntity gen_language)
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().Add(gen_language);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languageFacade.Addgen_language"));
            }
		}
		
        long Igen_languageFacadeObjects.SaveList(List<gen_languageEntity> list)
        {
            try
            {
                IList<gen_languageEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_languageEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_languageEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_languageDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_language"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_languageEntity> Igen_languageFacadeObjects.GetAll(gen_languageEntity gen_language)
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().GetAll(gen_language);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageEntity> Igen_languageFacade.GetAllgen_language"));
            }
		}
		
		IList<gen_languageEntity> Igen_languageFacadeObjects.GetAllByPages(gen_languageEntity gen_language)
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().GetAllByPages(gen_language);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageEntity> Igen_languageFacade.GetAllByPagesgen_language"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_languageFacadeObjects.SaveMasterDethr_languageproficiency(gen_languageEntity Master, List<hr_languageproficiencyEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_languageproficiencyEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_languageproficiencyEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_languageproficiencyEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_languageDataAccess().SaveMasterDethr_languageproficiency(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_languageproficiency"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_languageEntity Igen_languageFacadeObjects.GetSingle(gen_languageEntity gen_language)
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().GetSingle(gen_language);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_languageEntity Igen_languageFacade.GetSinglegen_language"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_languageEntity> Igen_languageFacadeObjects.GAPgListView(gen_languageEntity gen_language)
		{
			try
			{
				return DataAccessFactory.Creategen_languageDataAccess().GAPgListView(gen_language);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageEntity> Igen_languageFacade.GAPgListViewgen_language"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}