
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
    public sealed partial class hr_familycivilidinfoFacadeObjects : BaseFacade, Ihr_familycivilidinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "hr_familycivilidinfoFacadeObjects";
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

        public hr_familycivilidinfoFacadeObjects()
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

        ~hr_familycivilidinfoFacadeObjects()
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
		
		long Ihr_familycivilidinfoFacadeObjects.Delete(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().Delete(hr_familycivilidinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familycivilidinfoFacade.Deletehr_familycivilidinfo"));
            }
        }
		
		long Ihr_familycivilidinfoFacadeObjects.Update(hr_familycivilidinfoEntity hr_familycivilidinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().Update(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_familycivilidinfoFacade.Updatehr_familycivilidinfo"));
            }
		}
		
		long Ihr_familycivilidinfoFacadeObjects.Add(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().Add(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_familycivilidinfoFacade.Addhr_familycivilidinfo"));
            }
		}
		
        long Ihr_familycivilidinfoFacadeObjects.SaveList(List<hr_familycivilidinfoEntity> list)
        {
            try
            {
                IList<hr_familycivilidinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_familycivilidinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_familycivilidinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_familycivilidinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_familycivilidinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacadeObjects.GetAll(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().GetAll(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacade.GetAllhr_familycivilidinfo"));
            }
		}
		
		IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacadeObjects.GetAllByPages(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().GetAllByPages(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacade.GetAllByPageshr_familycivilidinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_familycivilidinfoEntity Ihr_familycivilidinfoFacadeObjects.GetSingle(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().GetSingle(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_familycivilidinfoEntity Ihr_familycivilidinfoFacade.GetSinglehr_familycivilidinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacadeObjects.GAPgListView(hr_familycivilidinfoEntity hr_familycivilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_familycivilidinfoDataAccess().GAPgListView(hr_familycivilidinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_familycivilidinfoEntity> Ihr_familycivilidinfoFacade.GAPgListViewhr_familycivilidinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}