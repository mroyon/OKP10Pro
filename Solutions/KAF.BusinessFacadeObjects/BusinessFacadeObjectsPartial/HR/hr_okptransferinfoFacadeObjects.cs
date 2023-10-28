
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
    public sealed partial class hr_okptransferinfoFacadeObjects
    {
        long Ihr_okptransferinfoFacadeObjects.Update_Ext(hr_okptransferinfoEntity hr_okptransferinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_okptransferinfoDataAccess().Update_Ext(hr_okptransferinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_okptransferinfoFacade.Update_Exthr_okptransferinfo"));
            }
        }

        long Ihr_okptransferinfoFacadeObjects.Add_Ext(hr_okptransferinfoEntity hr_okptransferinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_okptransferinfoDataAccess().Add_Ext(hr_okptransferinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_okptransferinfoFacade.Add_Exthr_okptransferinfo"));
            }
        }
        //      IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Add_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_okptransferinfoDataAccess().Add_WithFiles(hr_okptransferinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Add_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}

        //      IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Update_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_okptransferinfoDataAccess().Update_WithFiles(hr_okptransferinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Update_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}

        //       IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Delete_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_okptransferinfoDataAccess().Delete_WithFiles(hr_okptransferinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_okptransferinfoFacadeObjects.Delete_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}


        //       IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacadeObjects.ViewSingle_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_okptransferinfoDataAccess().ViewSingle_WithFiles(hr_okptransferinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<hr_okptransferinfoEntity> Ihr_okptransferinfoFacadeObjects.ViewSingle_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}

    }
}