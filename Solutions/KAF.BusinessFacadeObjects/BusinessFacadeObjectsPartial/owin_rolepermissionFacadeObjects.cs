using KAF.BusinessDataObjects;
using KAF.IBusinessFacadeObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessFacadeObjects
{
    public sealed partial class owin_rolepermissionFacadeObjects : BaseFacade, Iowin_rolepermissionFacadeObjects
    {
        IList<owin_rolepermissionEntity> Iowin_rolepermissionFacadeObjects.GetAll_Ext(owin_rolepermissionEntity owin_rolepermission)
        {
            try
            {
                return DataAccessFactory.Createowin_rolepermissionDataAccess().GetAll_Ext(owin_rolepermission);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GetAllowin_rolepermission"));
            }
        }
    }
}
