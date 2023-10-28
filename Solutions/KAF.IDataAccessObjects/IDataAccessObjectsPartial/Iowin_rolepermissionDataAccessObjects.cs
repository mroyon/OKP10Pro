using KAF.BusinessDataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.IDataAccessObjects
{
    public partial interface Iowin_rolepermissionDataAccessObjects
    {
        IList<owin_rolepermissionEntity> GetAll_Ext(owin_rolepermissionEntity owin_rolepermission);
    }
}
