

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_arrivalinfoFCC
    { 
	
		public hr_arrivalinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_arrivalinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_arrivalinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_arrivalinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_arrivalinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_arrivalinfoFacadeObjects();
                    context.Items["Ihr_arrivalinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_arrivalinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}