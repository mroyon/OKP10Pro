
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
    public sealed partial class gen_promotiontypeFacadeObjects : BaseFacade, Igen_promotiontypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_promotiontypeFacadeObjects";
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

        public gen_promotiontypeFacadeObjects()
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

        ~gen_promotiontypeFacadeObjects()
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
		
		long Igen_promotiontypeFacadeObjects.Delete(gen_promotiontypeEntity gen_promotiontype)
		{
			try
            {
				return DataAccessFactory.Creategen_promotiontypeDataAccess().Delete(gen_promotiontype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_promotiontypeFacade.Deletegen_promotiontype"));
            }
        }
		
		long Igen_promotiontypeFacadeObjects.Update(gen_promotiontypeEntity gen_promotiontype )
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().Update(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_promotiontypeFacade.Updategen_promotiontype"));
            }
		}
		
		long Igen_promotiontypeFacadeObjects.Add(gen_promotiontypeEntity gen_promotiontype)
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().Add(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_promotiontypeFacade.Addgen_promotiontype"));
            }
		}
		
        long Igen_promotiontypeFacadeObjects.SaveList(List<gen_promotiontypeEntity> list)
        {
            try
            {
                IList<gen_promotiontypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_promotiontypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_promotiontypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_promotiontypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_promotiontype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_promotiontypeEntity> Igen_promotiontypeFacadeObjects.GetAll(gen_promotiontypeEntity gen_promotiontype)
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().GetAll(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_promotiontypeEntity> Igen_promotiontypeFacade.GetAllgen_promotiontype"));
            }
		}
		
		IList<gen_promotiontypeEntity> Igen_promotiontypeFacadeObjects.GetAllByPages(gen_promotiontypeEntity gen_promotiontype)
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().GetAllByPages(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_promotiontypeEntity> Igen_promotiontypeFacade.GetAllByPagesgen_promotiontype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_promotiontypeFacadeObjects.SaveMasterDethr_promotioninfo(gen_promotiontypeEntity Master, List<hr_promotioninfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_promotioninfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_promotioninfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_promotioninfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_promotiontypeDataAccess().SaveMasterDethr_promotioninfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_promotioninfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_promotiontypeEntity Igen_promotiontypeFacadeObjects.GetSingle(gen_promotiontypeEntity gen_promotiontype)
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().GetSingle(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_promotiontypeEntity Igen_promotiontypeFacade.GetSinglegen_promotiontype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_promotiontypeEntity> Igen_promotiontypeFacadeObjects.GAPgListView(gen_promotiontypeEntity gen_promotiontype)
		{
			try
			{
				return DataAccessFactory.Creategen_promotiontypeDataAccess().GAPgListView(gen_promotiontype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_promotiontypeEntity> Igen_promotiontypeFacade.GAPgListViewgen_promotiontype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}