

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_okptransferinfoFCC
    { 
	
		public hr_okptransferinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_okptransferinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_okptransferinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_okptransferinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_okptransferinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_okptransferinfoFacadeObjects();
                    context.Items["Ihr_okptransferinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_okptransferinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}