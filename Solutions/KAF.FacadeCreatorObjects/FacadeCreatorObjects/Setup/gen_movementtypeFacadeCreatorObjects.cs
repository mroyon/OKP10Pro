

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_movementtypeFCC
    { 
	
		public gen_movementtypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_movementtypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_movementtypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_movementtypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_movementtypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_movementtypeFacadeObjects();
                    context.Items["Igen_movementtypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_movementtypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}