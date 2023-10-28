

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_ptademandFCC
    { 
	
		public hr_ptademandFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_ptademandFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_ptademandFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_ptademandFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_ptademandFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_ptademandFacadeObjects();
                    context.Items["Ihr_ptademandFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_ptademandFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}