

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_leaveconfigFCC
    { 
	
		public gen_leaveconfigFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_leaveconfigFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_leaveconfigFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_leaveconfigFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_leaveconfigFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_leaveconfigFacadeObjects();
                    context.Items["Igen_leaveconfigFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_leaveconfigFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}