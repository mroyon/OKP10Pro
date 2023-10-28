

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_relationshipFCC
    { 
	
		public gen_relationshipFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_relationshipFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_relationshipFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_relationshipFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_relationshipFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_relationshipFacadeObjects();
                    context.Items["Igen_relationshipFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_relationshipFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}