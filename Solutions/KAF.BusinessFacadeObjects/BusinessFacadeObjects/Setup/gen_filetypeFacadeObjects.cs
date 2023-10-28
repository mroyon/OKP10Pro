
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
    public sealed partial class gen_filetypeFacadeObjects : BaseFacade, Igen_filetypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_filetypeFacadeObjects";
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

        public gen_filetypeFacadeObjects()
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

        ~gen_filetypeFacadeObjects()
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
		
		long Igen_filetypeFacadeObjects.Delete(gen_filetypeEntity gen_filetype)
		{
			try
            {
				return DataAccessFactory.Creategen_filetypeDataAccess().Delete(gen_filetype);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_filetypeFacade.Deletegen_filetype"));
            }
        }
		
		long Igen_filetypeFacadeObjects.Update(gen_filetypeEntity gen_filetype )
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().Update(gen_filetype);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_filetypeFacade.Updategen_filetype"));
            }
		}
		
		long Igen_filetypeFacadeObjects.Add(gen_filetypeEntity gen_filetype)
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().Add(gen_filetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_filetypeFacade.Addgen_filetype"));
            }
		}
		
        long Igen_filetypeFacadeObjects.SaveList(List<gen_filetypeEntity> list)
        {
            try
            {
                IList<gen_filetypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_filetypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_filetypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_filetypeDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_filetype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_filetypeEntity> Igen_filetypeFacadeObjects.GetAll(gen_filetypeEntity gen_filetype)
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().GetAll(gen_filetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_filetypeEntity> Igen_filetypeFacade.GetAllgen_filetype"));
            }
		}
		
		IList<gen_filetypeEntity> Igen_filetypeFacadeObjects.GetAllByPages(gen_filetypeEntity gen_filetype)
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().GetAllByPages(gen_filetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_filetypeEntity> Igen_filetypeFacade.GetAllByPagesgen_filetype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_filetypeFacadeObjects.SaveMasterDethr_basicfile(gen_filetypeEntity Master, List<hr_basicfileEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_basicfileEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_basicfileEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_basicfileEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_filetypeDataAccess().SaveMasterDethr_basicfile(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_basicfile"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_filetypeEntity Igen_filetypeFacadeObjects.GetSingle(gen_filetypeEntity gen_filetype)
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().GetSingle(gen_filetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_filetypeEntity Igen_filetypeFacade.GetSinglegen_filetype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_filetypeEntity> Igen_filetypeFacadeObjects.GAPgListView(gen_filetypeEntity gen_filetype)
		{
			try
			{
				return DataAccessFactory.Creategen_filetypeDataAccess().GAPgListView(gen_filetype);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_filetypeEntity> Igen_filetypeFacade.GAPgListViewgen_filetype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}