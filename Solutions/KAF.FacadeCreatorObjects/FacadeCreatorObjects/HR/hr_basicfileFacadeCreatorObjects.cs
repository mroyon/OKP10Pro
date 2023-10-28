

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_basicfileFCC
    { 
	
		public hr_basicfileFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_basicfileFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_basicfileFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_basicfileFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_basicfileFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_basicfileFacadeObjects();
                    context.Items["Ihr_basicfileFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_basicfileFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}