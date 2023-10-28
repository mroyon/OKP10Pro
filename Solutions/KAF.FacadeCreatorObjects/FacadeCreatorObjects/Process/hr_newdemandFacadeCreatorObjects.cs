

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_newdemandFCC
    { 
	
		public hr_newdemandFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_newdemandFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_newdemandFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_newdemandFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_newdemandFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_newdemandFacadeObjects();
                    context.Items["Ihr_newdemandFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_newdemandFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}