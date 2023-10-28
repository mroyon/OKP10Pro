

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_ranktypeFCC
    { 
	
		public gen_ranktypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_ranktypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_ranktypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_ranktypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_ranktypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_ranktypeFacadeObjects();
                    context.Items["Igen_ranktypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_ranktypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}