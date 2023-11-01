
using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.DataAccessObjects;
using  KAF.IBusinessFacadeObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Data;
using System;

namespace KAF.BusinessFacadeObjects
{
    public sealed partial class hr_civilidinfoFacadeObjects
    {
		
        IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Add_WithFiles(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Add_WithFiles(hr_civilidinfo);
			}
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Add_WithFiles"));
            }
            
            catch (Exception MegaNet)
            {
                throw MegaNet;
            }
		}
        
        IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Update_WithFiles(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Update_WithFiles(hr_civilidinfo);
			}
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Update_WithFiles"));
            }
            
            catch (Exception MegaNet)
            {
                throw MegaNet;
            }
		}
        
         IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Delete_WithFiles(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().Delete_WithFiles(hr_civilidinfo);
			}
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAFGenericComboEntity> Ihr_civilidinfoFacadeObjects.Delete_WithFiles"));
            }
            
            catch (Exception MegaNet)
            {
                throw MegaNet;
            }
		}
        
         
         IList<hr_civilidinfoEntity> Ihr_civilidinfoFacadeObjects.ViewSingle_WithFiles(hr_civilidinfoEntity hr_civilidinfo)
		{
			try
			{
				return DataAccessFactory.Createhr_civilidinfoDataAccess().ViewSingle_WithFiles(hr_civilidinfo);
			}
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<hr_civilidinfoEntity> Ihr_civilidinfoFacadeObjects.ViewSingle_WithFiles"));
            }
            
            catch (Exception MegaNet)
            {
                throw MegaNet;
            }
		}
        
	}
}