

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_postofficeFCC
    { 
	
		public gen_postofficeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_postofficeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_postofficeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_postofficeFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_postofficeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_postofficeFacadeObjects();
                    context.Items["Igen_postofficeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_postofficeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}