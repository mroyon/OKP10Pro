

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class stp_passpolicyFCC
    { 
	
		public stp_passpolicyFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Istp_passpolicyFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Istp_passpolicyFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Istp_passpolicyFacadeObjects"] as KAF.IBusinessFacadeObjects.Istp_passpolicyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.stp_passpolicyFacadeObjects();
                    context.Items["Istp_passpolicyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.stp_passpolicyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}