

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_organizationFCC
    { 
	
		public stp_organizationFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_organizationFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_organizationFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_organizationFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_organizationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_organizationFacadeObjects();
                    context.Items["Istp_organizationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_organizationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}