

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_documenttypeFCC
    { 
	
		public gen_documenttypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_documenttypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_documenttypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_documenttypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_documenttypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_documenttypeFacadeObjects();
                    context.Items["Igen_documenttypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_documenttypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}