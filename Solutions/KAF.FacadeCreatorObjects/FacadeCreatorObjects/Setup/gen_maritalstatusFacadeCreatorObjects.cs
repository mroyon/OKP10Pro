

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_maritalstatusFCC
    { 
	
		public gen_maritalstatusFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_maritalstatusFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_maritalstatusFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_maritalstatusFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_maritalstatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_maritalstatusFacadeObjects();
                    context.Items["Igen_maritalstatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_maritalstatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}