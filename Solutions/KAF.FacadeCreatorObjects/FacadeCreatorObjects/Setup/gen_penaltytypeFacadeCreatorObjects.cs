

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_penaltytypeFCC
    { 
	
		public gen_penaltytypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_penaltytypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_penaltytypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_penaltytypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_penaltytypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_penaltytypeFacadeObjects();
                    context.Items["Igen_penaltytypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_penaltytypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}