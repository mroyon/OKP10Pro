

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_freedomfighttypeFCC
    { 
	
		public gen_freedomfighttypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_freedomfighttypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_freedomfighttypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_freedomfighttypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_freedomfighttypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_freedomfighttypeFacadeObjects();
                    context.Items["Igen_freedomfighttypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_freedomfighttypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}