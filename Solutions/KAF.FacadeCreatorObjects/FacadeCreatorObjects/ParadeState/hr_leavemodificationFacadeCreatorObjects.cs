

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_leavemodificationFCC
    { 
	
		public hr_leavemodificationFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_leavemodificationFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_leavemodificationFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_leavemodificationFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_leavemodificationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_leavemodificationFacadeObjects();
                    context.Items["Ihr_leavemodificationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_leavemodificationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}