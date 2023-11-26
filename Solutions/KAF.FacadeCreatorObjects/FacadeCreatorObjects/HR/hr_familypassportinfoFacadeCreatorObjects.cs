

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_familypassportinfoFCC
    { 
	
		public hr_familypassportinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_familypassportinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_familypassportinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_familypassportinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_familypassportinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_familypassportinfoFacadeObjects();
                    context.Items["Ihr_familypassportinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_familypassportinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}