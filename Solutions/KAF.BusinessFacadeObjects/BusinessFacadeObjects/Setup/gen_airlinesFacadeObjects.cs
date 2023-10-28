
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
    public sealed partial class gen_airlinesFacadeObjects : BaseFacade, Igen_airlinesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_airlinesFacadeObjects";
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

        public gen_airlinesFacadeObjects()
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

        ~gen_airlinesFacadeObjects()
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
		
		long Igen_airlinesFacadeObjects.Delete(gen_airlinesEntity gen_airlines)
		{
			try
            {
				return DataAccessFactory.Creategen_airlinesDataAccess().Delete(gen_airlines);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_airlinesFacade.Deletegen_airlines"));
            }
        }
		
		long Igen_airlinesFacadeObjects.Update(gen_airlinesEntity gen_airlines )
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().Update(gen_airlines);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_airlinesFacade.Updategen_airlines"));
            }
		}
		
		long Igen_airlinesFacadeObjects.Add(gen_airlinesEntity gen_airlines)
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().Add(gen_airlines);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_airlinesFacade.Addgen_airlines"));
            }
		}
		
        long Igen_airlinesFacadeObjects.SaveList(List<gen_airlinesEntity> list)
        {
            try
            {
                IList<gen_airlinesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_airlinesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_airlinesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Creategen_airlinesDataAccess().SaveList(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_airlines"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<gen_airlinesEntity> Igen_airlinesFacadeObjects.GetAll(gen_airlinesEntity gen_airlines)
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().GetAll(gen_airlines);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_airlinesEntity> Igen_airlinesFacade.GetAllgen_airlines"));
            }
		}
		
		IList<gen_airlinesEntity> Igen_airlinesFacadeObjects.GetAllByPages(gen_airlinesEntity gen_airlines)
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().GetAllByPages(gen_airlines);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_airlinesEntity> Igen_airlinesFacade.GetAllByPagesgen_airlines"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        long Igen_airlinesFacadeObjects.SaveMasterDethr_flightinfo(gen_airlinesEntity Master, List<hr_flightinfoEntity> DetailList)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<hr_flightinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<hr_flightinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<hr_flightinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return DataAccessFactory.Creategen_airlinesDataAccess().SaveMasterDethr_flightinfo(Master, listAdded, listUpdated, listDeleted);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDethr_flightinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        gen_airlinesEntity Igen_airlinesFacadeObjects.GetSingle(gen_airlinesEntity gen_airlines)
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().GetSingle(gen_airlines);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_airlinesEntity Igen_airlinesFacade.GetSinglegen_airlines"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<gen_airlinesEntity> Igen_airlinesFacadeObjects.GAPgListView(gen_airlinesEntity gen_airlines)
		{
			try
			{
				return DataAccessFactory.Creategen_airlinesDataAccess().GAPgListView(gen_airlines);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_airlinesEntity> Igen_airlinesFacade.GAPgListViewgen_airlines"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}