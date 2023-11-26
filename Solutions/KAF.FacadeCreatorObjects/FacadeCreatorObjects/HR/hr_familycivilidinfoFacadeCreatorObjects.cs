

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_familycivilidinfoFCC
    { 
	
		public hr_familycivilidinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_familycivilidinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_familycivilidinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_familycivilidinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_familycivilidinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_familycivilidinfoFacadeObjects();
                    context.Items["Ihr_familycivilidinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_familycivilidinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}