
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
    public sealed partial class hr_newdemandFacadeObjects 
    {
		long Ihr_newdemandFacadeObjects.Delete_Ext(hr_newdemandEntity hr_newdemand)
		{
			try
            {
				return DataAccessFactory.Createhr_newdemandDataAccess().Delete_Ext(hr_newdemand);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Deletehr_newdemand"));
            }
        }
		
		long Ihr_newdemandFacadeObjects.Update_Ext(hr_newdemandEntity hr_newdemand )
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().Update_Ext(hr_newdemand);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Updatehr_newdemand"));
            }
		}
		
		long Ihr_newdemandFacadeObjects.Add_Ext(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().Add_Ext(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_newdemandFacade.Addhr_newdemand"));
            }
		}
		
        long Ihr_newdemandFacadeObjects.SaveList_Ext(List<hr_newdemandEntity> list)
        {
            try
            {
                IList<hr_newdemandEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_newdemandEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_newdemandEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_newdemandDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_newdemand"));
            }
        }
		
		IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GetAll_Ext(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GetAll_Ext(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GetAllhr_newdemand"));
            }
		}
		
		IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GetAllByPages_Ext(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GetAllByPages_Ext(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GetAllByPageshr_newdemand"));
            }
		}
		IList<hr_newdemandEntity> Ihr_newdemandFacadeObjects.GAPgListView_Ext(hr_newdemandEntity hr_newdemand)
		{
			try
			{
				return DataAccessFactory.Createhr_newdemandDataAccess().GAPgListView_Ext(hr_newdemand);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_newdemandEntity> Ihr_newdemandFacade.GAPgListView_Exthr_newdemand"));
            }
		}

    }
}