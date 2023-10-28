using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;
using System.Web;


namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class FCCKAFUserSecurity
    {

        public FCCKAFUserSecurity()
        {

        }

        public static IKAFUserSecurity GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;
            if (context == null) { return new KAFUserSecurity(); }
            IKAFUserSecurity facade = context.Items["IKAFUserSecurity"] as IKAFUserSecurity;

            if (facade == null)
            {
                facade = new KAFUserSecurity();
                context.Items["IKAFUserSecurity"] = facade;
            }
            return facade;
        }


    }
}
