

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_subunitFCC
    { 
	
		public gen_subunitFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_subunitFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_subunitFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_subunitFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_subunitFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_subunitFacadeObjects();
                    context.Items["Igen_subunitFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_subunitFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}