

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_promotioninfoFCC
    { 
	
		public hr_promotioninfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_promotioninfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_promotioninfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_promotioninfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_promotioninfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_promotioninfoFacadeObjects();
                    context.Items["Ihr_promotioninfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_promotioninfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}