

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_tradeFCC
    { 
	
		public gen_tradeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_tradeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_tradeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_tradeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_tradeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_tradeFacadeObjects();
                    context.Items["Igen_tradeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_tradeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}