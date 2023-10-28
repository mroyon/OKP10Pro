

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visasentinfoFCC
    { 
	
		public hr_visasentinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visasentinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visasentinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visasentinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visasentinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visasentinfoFacadeObjects();
                    context.Items["Ihr_visasentinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visasentinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}