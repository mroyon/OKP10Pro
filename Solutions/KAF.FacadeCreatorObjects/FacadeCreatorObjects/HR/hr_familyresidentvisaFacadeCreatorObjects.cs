

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_familyresidentvisaFCC
    { 
	
		public hr_familyresidentvisaFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_familyresidentvisaFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_familyresidentvisaFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_familyresidentvisaFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_familyresidentvisaFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_familyresidentvisaFacadeObjects();
                    context.Items["Ihr_familyresidentvisaFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_familyresidentvisaFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}