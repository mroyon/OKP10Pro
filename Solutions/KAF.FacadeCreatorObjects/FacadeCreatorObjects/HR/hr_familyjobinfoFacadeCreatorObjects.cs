

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_familyjobinfoFCC
    { 
	
		public hr_familyjobinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_familyjobinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_familyjobinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_familyjobinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_familyjobinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_familyjobinfoFacadeObjects();
                    context.Items["Ihr_familyjobinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_familyjobinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}