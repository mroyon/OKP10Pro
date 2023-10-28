

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_emergencycontactFCC
    { 
	
		public hr_emergencycontactFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_emergencycontactFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_emergencycontactFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_emergencycontactFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_emergencycontactFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_emergencycontactFacadeObjects();
                    context.Items["Ihr_emergencycontactFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_emergencycontactFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}