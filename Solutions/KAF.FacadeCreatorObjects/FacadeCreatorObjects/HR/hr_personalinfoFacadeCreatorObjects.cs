

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_personalinfoFCC
    { 
	
		public hr_personalinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_personalinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_personalinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_personalinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_personalinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_personalinfoFacadeObjects();
                    context.Items["Ihr_personalinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_personalinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}