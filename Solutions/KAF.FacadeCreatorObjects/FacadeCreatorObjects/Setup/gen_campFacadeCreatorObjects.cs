

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_campFCC
    { 
	
		public gen_campFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_campFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_campFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_campFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_campFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_campFacadeObjects();
                    context.Items["Igen_campFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_campFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}