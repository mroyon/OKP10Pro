using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;
using System.Web;


namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class FCCSelectTwo
    {

        public FCCSelectTwo()
        {

        }

        public static ISelectTwoFacadeObjects GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;
            if (context == null) { return new SelectTwoFacadeObjects(); }
            ISelectTwoFacadeObjects facade = context.Items["ISelectTwoFacadeObjects"] as ISelectTwoFacadeObjects;

            if (facade == null)
            {
                facade = new SelectTwoFacadeObjects();
                context.Items["IKAFUserSecurity"] = facade;
            }
            return facade;
        }

    }
}
