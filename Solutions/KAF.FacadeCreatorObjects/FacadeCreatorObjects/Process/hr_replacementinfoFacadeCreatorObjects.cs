

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_replacementinfoFCC
    { 
	
		public hr_replacementinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_replacementinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_replacementinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_replacementinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_replacementinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_replacementinfoFacadeObjects();
                    context.Items["Ihr_replacementinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_replacementinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}