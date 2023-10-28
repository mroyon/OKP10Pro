
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
    public sealed partial class hr_newdemanddetlFacadeObjects
    {
		#region Business Facade
		
		#region Save Update Delete List	
		
		long Ihr_newdemanddetlFacadeObjects.Delete_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
            {
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Delete_Ext(hr_newdemanddetl);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Deletehr_newdemanddetl"));
            }
        }
		
		long Ihr_newdemanddetlFacadeObjects.Update_Ext(hr_newdemanddetlEntity hr_newdemanddetl )
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Update_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Updatehr_newdemanddetl"));
            }
		}
		
		long Ihr_newdemanddetlFacadeObjects.Add_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().Add_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemanddetlFacade.Addhr_newdemanddetl"));
            }
		}
		
        long Ihr_newdemanddetlFacadeObjects.SaveList_Ext(List<hr_newdemanddetlEntity> list)
        {
            try
            {
                IList<hr_newdemanddetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_newdemanddetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_newdemanddetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_newdemanddetlDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_newdemanddetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GetAll_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetAll_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GetAllhr_newdemanddetl"));
            }
		}
		
		IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GetAllByPages_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetAllByPages_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GetAllByPageshr_newdemanddetl"));
            }
		}
		
		#endregion GetAll
        
        
	
        
        #region Simple load Single Row
        hr_newdemanddetlEntity Ihr_newdemanddetlFacadeObjects.GetSingle_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GetSingle_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("hr_newdemanddetlEntity Ihr_newdemanddetlFacade.GetSinglehr_newdemanddetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacadeObjects.GAPgListView_Ext(hr_newdemanddetlEntity hr_newdemanddetl)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemanddetlDataAccess().GAPgListView_Ext(hr_newdemanddetl);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemanddetlEntity> Ihr_newdemanddetlFacade.GAPgListViewhr_newdemanddetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}