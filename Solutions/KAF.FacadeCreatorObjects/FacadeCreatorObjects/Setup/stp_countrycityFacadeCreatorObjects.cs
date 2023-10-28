

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_countrycityFCC
    { 
	
		public stp_countrycityFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_countrycityFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_countrycityFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_countrycityFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_countrycityFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_countrycityFacadeObjects();
                    context.Items["Istp_countrycityFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_countrycityFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}