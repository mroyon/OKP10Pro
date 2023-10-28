

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_residentvisaFCC
    { 
	
		public hr_residentvisaFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_residentvisaFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_residentvisaFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_residentvisaFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_residentvisaFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_residentvisaFacadeObjects();
                    context.Items["Ihr_residentvisaFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_residentvisaFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}