

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visademandinfodetlFCC
    { 
	
		public hr_visademandinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visademandinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visademandinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visademandinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visademandinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visademandinfodetlFacadeObjects();
                    context.Items["Ihr_visademandinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visademandinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}