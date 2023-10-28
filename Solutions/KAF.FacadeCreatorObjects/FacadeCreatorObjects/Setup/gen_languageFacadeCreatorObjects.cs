

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_languageFCC
    { 
	
		public gen_languageFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_languageFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_languageFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_languageFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_languageFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_languageFacadeObjects();
                    context.Items["Igen_languageFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_languageFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}