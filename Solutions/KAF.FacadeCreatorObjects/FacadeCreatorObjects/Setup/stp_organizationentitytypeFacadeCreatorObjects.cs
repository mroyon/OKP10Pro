

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_organizationentitytypeFCC
    { 
	
		public stp_organizationentitytypeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_organizationentitytypeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_organizationentitytypeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_organizationentitytypeFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_organizationentitytypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_organizationentitytypeFacadeObjects();
                    context.Items["Istp_organizationentitytypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_organizationentitytypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}