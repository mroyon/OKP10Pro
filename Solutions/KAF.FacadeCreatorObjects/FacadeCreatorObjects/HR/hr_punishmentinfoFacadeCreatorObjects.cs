

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_punishmentinfoFCC
    { 
	
		public hr_punishmentinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_punishmentinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_punishmentinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_punishmentinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_punishmentinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_punishmentinfoFacadeObjects();
                    context.Items["Ihr_punishmentinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_punishmentinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}