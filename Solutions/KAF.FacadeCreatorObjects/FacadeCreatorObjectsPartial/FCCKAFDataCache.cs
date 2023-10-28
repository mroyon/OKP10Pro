using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;
using System.Web;


namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class FCCKAFDataCache
    {
        public FCCKAFDataCache()
        {

        }

        public static IKAFDataCacheFacadeObjects GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;
            if (context == null) { return new KAFDataCacheFacadeObjects(); }
            IKAFDataCacheFacadeObjects facade = context.Items["IKAFDataCacheFacadeObjects"] as IKAFDataCacheFacadeObjects;

            if (facade == null)
            {
                facade = new KAFDataCacheFacadeObjects();
                context.Items["IKAFDataCacheFacadeObjects"] = facade;
            }
            return facade;
        }
    }
}
