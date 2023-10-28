

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_familyinfoFCC
    { 
	
		public hr_familyinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_familyinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_familyinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_familyinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_familyinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_familyinfoFacadeObjects();
                    context.Items["Ihr_familyinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_familyinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}