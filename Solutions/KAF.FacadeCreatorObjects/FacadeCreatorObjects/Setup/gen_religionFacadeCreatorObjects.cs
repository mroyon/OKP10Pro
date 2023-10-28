

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_religionFCC
    { 
	
		public gen_religionFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_religionFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_religionFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_religionFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_religionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_religionFacadeObjects();
                    context.Items["Igen_religionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_religionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}