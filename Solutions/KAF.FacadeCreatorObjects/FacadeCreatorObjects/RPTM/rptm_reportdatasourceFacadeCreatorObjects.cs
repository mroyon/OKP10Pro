

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class rptm_reportdatasourceFCC
    { 
	
		public rptm_reportdatasourceFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Irptm_reportdatasourceFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Irptm_reportdatasourceFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Irptm_reportdatasourceFacadeObjects"] as KAF.IBusinessFacadeObjects.Irptm_reportdatasourceFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.rptm_reportdatasourceFacadeObjects();
                    context.Items["Irptm_reportdatasourceFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.rptm_reportdatasourceFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}