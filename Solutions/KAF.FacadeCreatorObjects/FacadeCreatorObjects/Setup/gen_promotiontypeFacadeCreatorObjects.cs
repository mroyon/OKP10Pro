

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_promotiontypeFCC
    { 
	
		public gen_promotiontypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_promotiontypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_promotiontypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_promotiontypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_promotiontypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_promotiontypeFacadeObjects();
                    context.Items["Igen_promotiontypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_promotiontypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}