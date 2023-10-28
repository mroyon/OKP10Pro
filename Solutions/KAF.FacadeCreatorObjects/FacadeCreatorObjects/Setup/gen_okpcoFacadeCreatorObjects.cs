

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_okpcoFCC
    { 
	
		public gen_okpcoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_okpcoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_okpcoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_okpcoFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_okpcoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_okpcoFacadeObjects();
                    context.Items["Igen_okpcoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_okpcoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}