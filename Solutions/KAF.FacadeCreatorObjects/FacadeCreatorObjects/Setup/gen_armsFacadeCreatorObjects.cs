

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_armsFCC
    { 
	
		public gen_armsFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_armsFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_armsFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_armsFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_armsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_armsFacadeObjects();
                    context.Items["Igen_armsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_armsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}