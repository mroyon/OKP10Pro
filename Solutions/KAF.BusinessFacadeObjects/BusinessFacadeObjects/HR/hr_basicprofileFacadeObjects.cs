
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
    public sealed partial class hr_basicprofileFacadeObjects
    {
		
		#region Business Facade
		
		#region Save Update Delete List	
		
		long Ihr_basicprofileFacadeObjects.Delete_Ext(hr_basicprofileEntity hr_basicprofile)
		{
			try
            {
				return DataAccessFactory.Createhr_basicprofileDataAccess().Delete_Ext(hr_basicprofile);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_basicprofileFacade.Delete_Exthr_basicprofile"));
            }
        }
		
		long Ihr_basicprofileFacadeObjects.Update_Ext(hr_basicprofileEntity hr_basicprofile )
		{
			try
			{
				return DataAccessFactory.Createhr_basicprofileDataAccess().Update_Ext(hr_basicprofile);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_basicprofileFacade.Update_Exthr_basicprofile"));
            }
		}
		
		long Ihr_basicprofileFacadeObjects.Add_Ext(hr_basicprofileEntity hr_basicprofile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicprofileDataAccess().Add_Ext(hr_basicprofile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_basicprofileFacade.Add_Exthr_basicprofile"));
            }
		}
		
        long Ihr_basicprofileFacadeObjects.SaveList_Ext(List<hr_basicprofileEntity> list)
        {
            try
            {
                IList<hr_basicprofileEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_basicprofileEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_basicprofileEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_basicprofileDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_Ext_hr_basicprofile"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_basicprofileEntity> Ihr_basicprofileFacadeObjects.GetAll_Ext(hr_basicprofileEntity hr_basicprofile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicprofileDataAccess().GetAll_Ext(hr_basicprofile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicprofileEntity> Ihr_basicprofileFacade.GetAll_Exthr_basicprofile"));
            }
		}
		
		IList<hr_basicprofileEntity> Ihr_basicprofileFacadeObjects.GetAllByPages_Ext(hr_basicprofileEntity hr_basicprofile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicprofileDataAccess().GetAllByPages_Ext(hr_basicprofile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicprofileEntity> Ihr_basicprofileFacade.GetAllByPages_Exthr_basicprofile"));
            }
		}
		
		#endregion GetAll
        
        
	
        
        
         
        #region ForListView Paged Method
        IList<hr_basicprofileEntity> Ihr_basicprofileFacadeObjects.GAPgListView_Ext(hr_basicprofileEntity hr_basicprofile)
		{
			try
			{
				return DataAccessFactory.Createhr_basicprofileDataAccess().GAPgListView_Ext(hr_basicprofile);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_basicprofileEntity> Ihr_basicprofileFacade.GAPgListView_Exthr_basicprofile"));
            }
		}
        #endregion
        
        
    
        #endregion
	}
}