
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
    public sealed partial class gen_languageproficiencyFacadeObjects : BaseFacade, Igen_languageproficiencyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_languageproficiencyFacadeObjects";
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

        public gen_languageproficiencyFacadeObjects()
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

        ~gen_languageproficiencyFacadeObjects()
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
		
		long Igen_languageproficiencyFacadeObjects.Delete(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
            {
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().Delete(gen_languageproficiency);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languageproficiencyFacade.Deletegen_languageproficiency"));
            }
        }
		
		long Igen_languageproficiencyFacadeObjects.Update(gen_languageproficiencyEntity gen_languageproficiency )
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().Update(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_languageproficiencyFacade.Updategen_languageproficiency"));
            }
		}
		
		long Igen_languageproficiencyFacadeObjects.Add(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().Add(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languageproficiencyFacade.Addgen_languageproficiency"));
            }
		}
		
        long Igen_languageproficiencyFacadeObjects.SaveList(List<gen_languageproficiencyEntity> list)
        {
            try
            {
                IList<gen_languageproficiencyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_languageproficiencyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_languageproficiencyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_languageproficiencyDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_languageproficiency"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacadeObjects.GetAll(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().GetAll(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacade.GetAllgen_languageproficiency"));
            }
		}
		
		IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacadeObjects.GetAllByPages(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().GetAllByPages(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacade.GetAllByPagesgen_languageproficiency"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_languageproficiencyFacadeObjects.SaveMasterDethr_languageproficiency(gen_languageproficiencyEntity Master, List<hr_languageproficiencyEntity> DetailList)
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
                    return DataAccessFactory.Creategen_languageproficiencyDataAccess().SaveMasterDethr_languageproficiency(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_languageproficiency"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_languageproficiencyEntity Igen_languageproficiencyFacadeObjects.GetSingle(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().GetSingle(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_languageproficiencyEntity Igen_languageproficiencyFacade.GetSinglegen_languageproficiency"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacadeObjects.GAPgListView(gen_languageproficiencyEntity gen_languageproficiency)
		{
			try
			{
				return DataAccessFactory.Creategen_languageproficiencyDataAccess().GAPgListView(gen_languageproficiency);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageproficiencyEntity> Igen_languageproficiencyFacade.GAPgListViewgen_languageproficiency"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}