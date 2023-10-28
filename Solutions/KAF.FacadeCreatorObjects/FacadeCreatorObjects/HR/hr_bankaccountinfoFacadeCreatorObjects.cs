

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_bankaccountinfoFCC
    { 
	
		public hr_bankaccountinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_bankaccountinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_bankaccountinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_bankaccountinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_bankaccountinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_bankaccountinfoFacadeObjects();
                    context.Items["Ihr_bankaccountinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_bankaccountinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}