

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_monthFCC
    { 
	
		public gen_monthFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_monthFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_monthFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_monthFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_monthFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_monthFacadeObjects();
                    context.Items["Igen_monthFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_monthFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}