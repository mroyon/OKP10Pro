

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_authorizestrengthFCC
    { 
	
		public gen_authorizestrengthFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_authorizestrengthFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_authorizestrengthFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_authorizestrengthFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_authorizestrengthFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_authorizestrengthFacadeObjects();
                    context.Items["Igen_authorizestrengthFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_authorizestrengthFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}