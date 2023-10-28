using KAF.BusinessDataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KAF.IBusinessFacadeObjects
{
    //[ServiceContract(Name = "Iowin_rolepermissionFacadeObjects")]
    public partial interface Iowin_rolepermissionFacadeObjects : IDisposable
    {
        [OperationContract]
        IList<owin_rolepermissionEntity> GetAll_Ext(owin_rolepermissionEntity owin_rolepermission);
    }
}
