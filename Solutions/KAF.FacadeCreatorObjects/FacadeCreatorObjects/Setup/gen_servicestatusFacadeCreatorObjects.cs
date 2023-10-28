

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_servicestatusFCC
    { 
	
		public gen_servicestatusFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_servicestatusFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_servicestatusFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_servicestatusFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_servicestatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_servicestatusFacadeObjects();
                    context.Items["Igen_servicestatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_servicestatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}