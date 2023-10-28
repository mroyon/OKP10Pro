
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
    public sealed partial class hr_svcinfoFacadeObjects 
    {
		long Ihr_svcinfoFacadeObjects.Delete_Ext(hr_svcinfoEntity hr_svcinfo)
		{
			try
            {
				return DataAccessFactory.Createhr_svcinfoDataAccess().Delete_Ext(hr_svcinfo);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_svcinfoFacade.Deletehr_svcinfo"));
            }
        }
		
		long Ihr_svcinfoFacadeObjects.Update_Ext(hr_svcinfoEntity hr_svcinfo )
		{
			try
			{
				return DataAccessFactory.Createhr_svcinfoDataAccess().Update_Ext(hr_svcinfo);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ihr_svcinfoFacade.Updatehr_svcinfo"));
            }
		}
		
		long Ihr_svcinfoFacadeObjects.Add_Ext(hr_svcinfoEntity hr_svcinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_svcinfoDataAccess().Add_Ext(hr_svcinfo);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_svcinfoFacade.Addhr_svcinfo"));
            }
		}

        IList<hr_svcinfoEntity> Ihr_svcinfoFacadeObjects.GetAll_Ext(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_svcinfoDataAccess().GetAll_Ext(hr_svcinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_svcinfoEntity> Ihr_svcinfoFacade.GetAllhr_svcinfo"));
            }
        }

        IList<hr_svcinfoEntity> Ihr_svcinfoFacadeObjects.GAPgListView_Ext(hr_svcinfoEntity hr_svcinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_svcinfoDataAccess().GAPgListView_Ext(hr_svcinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_svcinfoEntity> Ihr_svcinfoFacade.GAPgListViewhr_svcinfo"));
            }
        }

    }
}