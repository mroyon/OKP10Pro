

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_reppassportinfodetlFCC
    { 
	
		public hr_reppassportinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_reppassportinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_reppassportinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_reppassportinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_reppassportinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_reppassportinfodetlFacadeObjects();
                    context.Items["Ihr_reppassportinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_reppassportinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}