

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_bankFCC
    { 
	
		public gen_bankFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_bankFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_bankFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_bankFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_bankFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_bankFacadeObjects();
                    context.Items["Igen_bankFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_bankFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}