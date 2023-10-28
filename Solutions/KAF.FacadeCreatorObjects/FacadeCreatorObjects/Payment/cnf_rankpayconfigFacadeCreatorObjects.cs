

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class cnf_rankpayconfigFCC
    { 
	
		public cnf_rankpayconfigFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Icnf_rankpayconfigFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Icnf_rankpayconfigFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Icnf_rankpayconfigFacadeObjects"] as KAF.IBusinessFacadeObjects.Icnf_rankpayconfigFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.cnf_rankpayconfigFacadeObjects();
                    context.Items["Icnf_rankpayconfigFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.cnf_rankpayconfigFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}