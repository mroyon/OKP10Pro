

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_okpFCC
    { 
	
		public gen_okpFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_okpFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_okpFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_okpFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_okpFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_okpFacadeObjects();
                    context.Items["Igen_okpFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_okpFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}