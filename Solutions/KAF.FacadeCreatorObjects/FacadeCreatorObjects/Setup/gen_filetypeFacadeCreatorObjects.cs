

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_filetypeFCC
    { 
	
		public gen_filetypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_filetypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_filetypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_filetypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_filetypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_filetypeFacadeObjects();
                    context.Items["Igen_filetypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_filetypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}