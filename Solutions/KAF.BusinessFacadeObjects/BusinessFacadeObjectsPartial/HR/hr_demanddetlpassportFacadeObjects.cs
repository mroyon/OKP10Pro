
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
    public sealed partial class hr_demanddetlpassportFacadeObjects
    {
		
		#region Business Facade
		
		#region Save Update Delete List	
		
		long Ihr_demanddetlpassportFacadeObjects.Delete_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
            {
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Delete_Ext(hr_demanddetlpassport);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Deletehr_demanddetlpassport"));
            }
        }
		
		long Ihr_demanddetlpassportFacadeObjects.Update_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport )
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Update_Ext(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Updatehr_demanddetlpassport"));
            }
		}
		
		long Ihr_demanddetlpassportFacadeObjects.Add_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().Add_Ext(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_demanddetlpassportFacade.Addhr_demanddetlpassport"));
            }
		}
		
        long Ihr_demanddetlpassportFacadeObjects.SaveList_Ext(List<hr_demanddetlpassportEntity> list)
        {
            try
            {
                IList<hr_demanddetlpassportEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<hr_demanddetlpassportEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<hr_demanddetlpassportEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return DataAccessFactory.Createhr_demanddetlpassportDataAccess().SaveList_Ext(listAdded, listUpdated, listDeleted);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_hr_demanddetlpassport"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GetAll_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetAll_Ext(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GetAllhr_demanddetlpassport"));
            }
		}
		
		IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GetAllByPages_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
		{
			try
			{
				return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetAllByPages_Ext(hr_demanddetlpassport);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GetAllByPageshr_demanddetlpassport"));
            }
		}

        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GetDemandPassportLetterNoByNewDemandID(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
            try
            {
                return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GetDemandPassportLetterNoByNewDemandID(hr_demanddetlpassport);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GetDemandPassportLetterNoByNewDemandID"));
            }
        }

        #region ForListView Paged Method
        IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacadeObjects.GAPgListView_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport)
        {
            try
            {
                return DataAccessFactory.Createhr_demanddetlpassportDataAccess().GAPgListView_Ext(hr_demanddetlpassport);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_demanddetlpassportEntity> Ihr_demanddetlpassportFacade.GAPgListViewhr_demanddetlpassport"));
            }
        }
        #endregion
        #endregion GetAll

        #endregion
    }
}