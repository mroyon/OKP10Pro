

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_passportinfoFCC
    { 
	
		public hr_passportinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_passportinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_passportinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_passportinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_passportinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_passportinfoFacadeObjects();
                    context.Items["Ihr_passportinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_passportinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}