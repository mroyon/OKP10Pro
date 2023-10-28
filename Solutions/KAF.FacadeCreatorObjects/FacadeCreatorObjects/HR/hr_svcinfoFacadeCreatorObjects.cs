

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_svcinfoFCC
    { 
	
		public hr_svcinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_svcinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_svcinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_svcinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_svcinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_svcinfoFacadeObjects();
                    context.Items["Ihr_svcinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_svcinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}