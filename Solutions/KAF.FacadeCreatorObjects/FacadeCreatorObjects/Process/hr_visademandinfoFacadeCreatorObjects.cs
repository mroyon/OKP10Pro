

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visademandinfoFCC
    { 
	
		public hr_visademandinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visademandinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visademandinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visademandinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visademandinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visademandinfoFacadeObjects();
                    context.Items["Ihr_visademandinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visademandinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}