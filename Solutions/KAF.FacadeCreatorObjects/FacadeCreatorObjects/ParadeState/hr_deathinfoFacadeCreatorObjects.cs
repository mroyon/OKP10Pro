

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_deathinfoFCC
    { 
	
		public hr_deathinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_deathinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_deathinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_deathinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_deathinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_deathinfoFacadeObjects();
                    context.Items["Ihr_deathinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_deathinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}