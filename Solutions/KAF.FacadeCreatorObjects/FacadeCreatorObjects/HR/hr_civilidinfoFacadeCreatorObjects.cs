

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_civilidinfoFCC
    { 
	
		public hr_civilidinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_civilidinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_civilidinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_civilidinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_civilidinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_civilidinfoFacadeObjects();
                    context.Items["Ihr_civilidinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_civilidinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}