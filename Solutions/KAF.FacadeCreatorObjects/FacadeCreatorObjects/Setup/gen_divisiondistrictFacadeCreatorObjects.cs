

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_divisiondistrictFCC
    { 
	
		public gen_divisiondistrictFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_divisiondistrictFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_divisiondistrictFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_divisiondistrictFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_divisiondistrictFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_divisiondistrictFacadeObjects();
                    context.Items["Igen_divisiondistrictFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_divisiondistrictFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}