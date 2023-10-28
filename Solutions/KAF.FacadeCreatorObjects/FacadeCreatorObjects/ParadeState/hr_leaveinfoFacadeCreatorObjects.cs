

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_leaveinfoFCC
    { 
	
		public hr_leaveinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_leaveinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_leaveinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_leaveinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_leaveinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_leaveinfoFacadeObjects();
                    context.Items["Ihr_leaveinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_leaveinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}