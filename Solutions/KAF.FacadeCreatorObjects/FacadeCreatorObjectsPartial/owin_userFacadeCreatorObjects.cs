

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;
using System.Web;


namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class stp_organizationentityFCC
    { 
	
		public stp_organizationentityFCC()
        {
		
        }
		
		public static  Istp_organizationentityFacadeObjects GetFacadeCreate()
        {
			
            HttpContext context = HttpContext.Current;
            if (context == null) { return new stp_organizationentityFacadeObjects(); }
            Istp_organizationentityFacadeObjects facade = context.Items["Istp_organizationentityFacadeObjects"] as Istp_organizationentityFacadeObjects;

            if (facade == null)
            {
                facade = new stp_organizationentityFacadeObjects();
                context.Items["Istp_organizationentityFacadeObjects"] = facade;
            }
            return facade;
        }
		
		
	}
}