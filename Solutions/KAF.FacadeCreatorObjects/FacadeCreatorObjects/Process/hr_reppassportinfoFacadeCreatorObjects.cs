

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_reppassportinfoFCC
    { 
	
		public hr_reppassportinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_reppassportinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_reppassportinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_reppassportinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_reppassportinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_reppassportinfoFacadeObjects();
                    context.Items["Ihr_reppassportinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_reppassportinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}