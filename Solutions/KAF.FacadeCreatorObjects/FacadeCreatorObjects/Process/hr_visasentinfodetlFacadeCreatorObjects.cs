

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visasentinfodetlFCC
    { 
	
		public hr_visasentinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visasentinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visasentinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visasentinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visasentinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visasentinfodetlFacadeObjects();
                    context.Items["Ihr_visasentinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visasentinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}