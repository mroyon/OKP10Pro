

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_flightinfoFCC
    { 
	
		public hr_flightinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_flightinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_flightinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_flightinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_flightinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_flightinfoFacadeObjects();
                    context.Items["Ihr_flightinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_flightinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}