

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_rankFCC
    { 
	
		public gen_rankFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_rankFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_rankFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_rankFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_rankFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_rankFacadeObjects();
                    context.Items["Igen_rankFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_rankFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}