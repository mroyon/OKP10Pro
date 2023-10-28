

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_bankbranchFCC
    { 
	
		public gen_bankbranchFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_bankbranchFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_bankbranchFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_bankbranchFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_bankbranchFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_bankbranchFacadeObjects();
                    context.Items["Igen_bankbranchFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_bankbranchFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}