

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_thanaFCC
    { 
	
		public gen_thanaFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_thanaFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_thanaFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_thanaFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_thanaFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_thanaFacadeObjects();
                    context.Items["Igen_thanaFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_thanaFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}