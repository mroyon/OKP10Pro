
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
    public sealed partial class hr_passportinfoFacadeObjects : BaseFacade, Ihr_passportinfoFacadeObjects
    {
			
		#region Business Facade
		
		#region Save Update Delete List	
		
		long Ihr_passportinfoFacadeObjects.Delete_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_passportinfoDataAccess().Delete_Ext(hr_passportinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Deletehr_passportinfo"));
            }
        }
		
		long Ihr_passportinfoFacadeObjects.Update_Ext(hr_passportinfoEntity hr_passportinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().Update_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Updatehr_passportinfo"));
            }
		}
		
		long Ihr_passportinfoFacadeObjects.Add_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().Add_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_passportinfoFacade.Addhr_passportinfo"));
            }
		}
		
        long Ihr_passportinfoFacadeObjects.SaveList_Ext(List<hr_passportinfoEntity> list)
        {
            try
            {
                IList<hr_passportinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_passportinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_passportinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_passportinfoDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_passportinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GetAll_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetAll_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GetAllhr_passportinfo"));
            }
		}
		
		IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GetAllByPages_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetAllByPages_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GetAllByPageshr_passportinfo"));
            }
		}
		
		#endregion GetAll
        
        
	
        
        #region Simple load Single Row
        hr_passportinfoEntity Ihr_passportinfoFacadeObjects.GetSingle_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GetSingle_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_passportinfoEntity Ihr_passportinfoFacade.GetSinglehr_passportinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_passportinfoEntity> Ihr_passportinfoFacadeObjects.GAPgListView_Ext(hr_passportinfoEntity hr_passportinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_passportinfoDataAccess().GAPgListView_Ext(hr_passportinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_passportinfoEntity> Ihr_passportinfoFacade.GAPgListViewhr_passportinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}