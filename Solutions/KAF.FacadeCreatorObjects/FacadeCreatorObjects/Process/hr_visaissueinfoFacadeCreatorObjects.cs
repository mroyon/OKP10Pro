

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visaissueinfoFCC
    { 
	
		public hr_visaissueinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visaissueinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visaissueinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visaissueinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visaissueinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visaissueinfoFacadeObjects();
                    context.Items["Ihr_visaissueinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visaissueinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}