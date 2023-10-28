

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_newdemanddetlFCC
    { 
	
		public hr_newdemanddetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_newdemanddetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_newdemanddetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_newdemanddetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_newdemanddetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_newdemanddetlFacadeObjects();
                    context.Items["Ihr_newdemanddetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_newdemanddetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}