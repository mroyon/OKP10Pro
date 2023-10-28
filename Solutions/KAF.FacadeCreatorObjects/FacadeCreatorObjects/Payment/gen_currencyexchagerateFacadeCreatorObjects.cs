

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_currencyexchagerateFCC
    { 
	
		public gen_currencyexchagerateFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_currencyexchagerateFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_currencyexchagerateFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_currencyexchagerateFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_currencyexchagerateFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_currencyexchagerateFacadeObjects();
                    context.Items["Igen_currencyexchagerateFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_currencyexchagerateFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}