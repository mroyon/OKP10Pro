

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_organizationentityFCC
    { 
	
		public stp_organizationentityFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_organizationentityFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_organizationentityFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_organizationentityFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_organizationentityFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_organizationentityFacadeObjects();
                    context.Items["Istp_organizationentityFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_organizationentityFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}