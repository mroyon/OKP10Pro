

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_basicprofileFCC
    { 
	
		public hr_basicprofileFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_basicprofileFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_basicprofileFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_basicprofileFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_basicprofileFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_basicprofileFacadeObjects();
                    context.Items["Ihr_basicprofileFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_basicprofileFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}