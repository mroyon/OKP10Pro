

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_ptademanddetlFCC
    { 
	
		public hr_ptademanddetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_ptademanddetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_ptademanddetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_ptademanddetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_ptademanddetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_ptademanddetlFacadeObjects();
                    context.Items["Ihr_ptademanddetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_ptademanddetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}