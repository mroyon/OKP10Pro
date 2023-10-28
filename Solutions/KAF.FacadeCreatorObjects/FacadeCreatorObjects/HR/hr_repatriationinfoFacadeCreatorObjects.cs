

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_repatriationinfoFCC
    { 
	
		public hr_repatriationinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_repatriationinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_repatriationinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_repatriationinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_repatriationinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_repatriationinfoFacadeObjects();
                    context.Items["Ihr_repatriationinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_repatriationinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}