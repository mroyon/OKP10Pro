

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_bloodgroupFCC
    { 
	
		public gen_bloodgroupFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_bloodgroupFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_bloodgroupFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_bloodgroupFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_bloodgroupFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_bloodgroupFacadeObjects();
                    context.Items["Igen_bloodgroupFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_bloodgroupFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}