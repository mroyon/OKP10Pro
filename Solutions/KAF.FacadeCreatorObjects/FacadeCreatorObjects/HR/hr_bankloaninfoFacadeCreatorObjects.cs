

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_bankloaninfoFCC
    { 
	
		public hr_bankloaninfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_bankloaninfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_bankloaninfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_bankloaninfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_bankloaninfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_bankloaninfoFacadeObjects();
                    context.Items["Ihr_bankloaninfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_bankloaninfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}