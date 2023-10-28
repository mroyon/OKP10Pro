
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
    public sealed partial class hr_attachmentinfoFacadeObjects
    {
        long Ihr_attachmentinfoFacadeObjects.Update_Ext(hr_attachmentinfoEntity hr_attachmentinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_attachmentinfoDataAccess().Update_Ext(hr_attachmentinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_attachmentinfoFacade.UpdateExthr_attachmentinfo"));
            }
        }

        long Ihr_attachmentinfoFacadeObjects.Add_Ext(hr_attachmentinfoEntity hr_attachmentinfo)
        {
            try
            {
                return DataAccessFactory.Createhr_attachmentinfoDataAccess().Add_Ext(hr_attachmentinfo);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ihr_attachmentinfoFacade.AddExthr_attachmentinfo"));
            }
        }

        //      IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Add_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_attachmentinfoDataAccess().Add_WithFiles(hr_attachmentinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Add_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}

        //      IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Update_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_attachmentinfoDataAccess().Update_WithFiles(hr_attachmentinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Update_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}

        //       IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Delete_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo)
        //{
        //	try
        //	{
        //		return DataAccessFactory.Createhr_attachmentinfoDataAccess().Delete_WithFiles(hr_attachmentinfo);
        //	}
        //          catch (DataException ex)
        //          {
        //              throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_attachmentinfoFacadeObjects.Delete_WithFiles"));
        //          }

        //          catch (Exception MegaNet)
        //          {
        //              throw MegaNet;
        //          }
        //}


        //IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacadeObjects.ViewSingle_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo)
        //{
        //    try
        //    {
        //        return DataAccessFactory.Createhr_attachmentinfoDataAccess().ViewSingle_WithFiles(hr_attachmentinfo);
        //    }
        //    catch (DataException ex)
        //    {
        //        throw GetFacadeException(ex, SourceOfException("IList<hr_attachmentinfoEntity> Ihr_attachmentinfoFacadeObjects.ViewSingle_WithFiles"));
        //    }

        //    catch (Exception MegaNet)
        //    {
        //        throw MegaNet;
        //    }
        //}

    }
}