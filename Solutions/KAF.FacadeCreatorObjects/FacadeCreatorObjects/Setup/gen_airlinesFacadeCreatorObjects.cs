

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_airlinesFCC
    { 
	
		public gen_airlinesFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_airlinesFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_airlinesFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_airlinesFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_airlinesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_airlinesFacadeObjects();
                    context.Items["Igen_airlinesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_airlinesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}