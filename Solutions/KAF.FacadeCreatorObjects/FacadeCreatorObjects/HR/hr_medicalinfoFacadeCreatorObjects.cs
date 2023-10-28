

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_medicalinfoFCC
    { 
	
		public hr_medicalinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_medicalinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_medicalinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_medicalinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_medicalinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_medicalinfoFacadeObjects();
                    context.Items["Ihr_medicalinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_medicalinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}