

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_grouprankFCC
    { 
	
		public gen_grouprankFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_grouprankFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_grouprankFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_grouprankFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_grouprankFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_grouprankFacadeObjects();
                    context.Items["Igen_grouprankFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_grouprankFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}