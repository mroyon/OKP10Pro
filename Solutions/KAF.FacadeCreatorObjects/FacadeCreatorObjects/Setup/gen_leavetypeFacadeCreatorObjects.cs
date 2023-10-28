

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_leavetypeFCC
    { 
	
		public gen_leavetypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_leavetypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_leavetypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_leavetypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_leavetypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_leavetypeFacadeObjects();
                    context.Items["Igen_leavetypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_leavetypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}