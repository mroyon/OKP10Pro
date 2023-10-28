

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_issuetypeFCC
    { 
	
		public gen_issuetypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_issuetypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_issuetypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_issuetypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_issuetypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_issuetypeFacadeObjects();
                    context.Items["Igen_issuetypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_issuetypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}