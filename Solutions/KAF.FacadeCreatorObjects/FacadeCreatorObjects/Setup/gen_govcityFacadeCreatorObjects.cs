

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_govcityFCC
    { 
	
		public gen_govcityFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_govcityFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_govcityFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_govcityFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_govcityFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_govcityFacadeObjects();
                    context.Items["Igen_govcityFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_govcityFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}