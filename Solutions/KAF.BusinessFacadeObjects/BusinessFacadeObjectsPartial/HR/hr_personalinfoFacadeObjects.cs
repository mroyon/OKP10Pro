
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
    public sealed partial class hr_personalinfoFacadeObjects : BaseFacade, Ihr_personalinfoFacadeObjects
    {
		#region Business Facade
		
		#region Save Update Delete List	
		
		long Ihr_personalinfoFacadeObjects.Delete_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_personalinfoDataAccess().Delete_Ext(hr_personalinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Deletehr_personalinfo"));
            }
        }
		
		long Ihr_personalinfoFacadeObjects.Update_Ext(hr_personalinfoEntity hr_personalinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().Update_Ext(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Updatehr_personalinfo"));
            }
		}
		
		long Ihr_personalinfoFacadeObjects.Add_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().Add_Ext(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_personalinfoFacade.Addhr_personalinfo"));
            }
		}
		
        long Ihr_personalinfoFacadeObjects.SaveList_Ext(List<hr_personalinfoEntity> list)
        {
            try
            {
                IList<hr_personalinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_personalinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_personalinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_personalinfoDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_personalinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GetAll_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetAll_Ext(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GetAllhr_personalinfo"));
            }
		}
		
		IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GetAllByPages_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetAllByPages_Ext(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GetAllByPageshr_personalinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        hr_personalinfoEntity Ihr_personalinfoFacadeObjects.GetSingle_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GetSingle_Ext(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_personalinfoEntity Ihr_personalinfoFacade.GetSinglehr_personalinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_personalinfoEntity> Ihr_personalinfoFacadeObjects.GAPgListView_Ext(hr_personalinfoEntity hr_personalinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_personalinfoDataAccess().GAPgListView(hr_personalinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_personalinfoEntity> Ihr_personalinfoFacade.GAPgListViewhr_personalinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}