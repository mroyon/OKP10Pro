

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_countryFCC
    { 
	
		public stp_countryFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_countryFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_countryFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_countryFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_countryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_countryFacadeObjects();
                    context.Items["Istp_countryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_countryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}