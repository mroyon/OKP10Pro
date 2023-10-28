

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_genderFCC
    { 
	
		public gen_genderFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_genderFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_genderFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_genderFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_genderFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_genderFacadeObjects();
                    context.Items["Igen_genderFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_genderFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}