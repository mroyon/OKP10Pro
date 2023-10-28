

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class cnf_paymentitemFCC
    { 
	
		public cnf_paymentitemFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Icnf_paymentitemFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Icnf_paymentitemFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Icnf_paymentitemFacadeObjects"] as KAF.IBusinessFacadeObjects.Icnf_paymentitemFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.cnf_paymentitemFacadeObjects();
                    context.Items["Icnf_paymentitemFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.cnf_paymentitemFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}