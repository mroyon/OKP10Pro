

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_rewardinfoFCC
    { 
	
		public hr_rewardinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_rewardinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_rewardinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_rewardinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_rewardinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_rewardinfoFacadeObjects();
                    context.Items["Ihr_rewardinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_rewardinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}