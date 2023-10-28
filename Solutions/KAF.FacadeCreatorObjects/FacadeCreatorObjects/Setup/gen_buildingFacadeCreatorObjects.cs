

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_buildingFCC
    { 
	
		public gen_buildingFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_buildingFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_buildingFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_buildingFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_buildingFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_buildingFacadeObjects();
                    context.Items["Igen_buildingFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_buildingFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}