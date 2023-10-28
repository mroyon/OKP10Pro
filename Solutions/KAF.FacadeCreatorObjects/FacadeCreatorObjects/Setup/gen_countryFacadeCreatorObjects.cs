

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_countryFCC
    { 
	
		public gen_countryFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_countryFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_countryFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_countryFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_countryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_countryFacadeObjects();
                    context.Items["Igen_countryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_countryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}