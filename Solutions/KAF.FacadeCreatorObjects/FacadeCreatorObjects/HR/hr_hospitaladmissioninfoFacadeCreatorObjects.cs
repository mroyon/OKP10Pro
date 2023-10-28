

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_hospitaladmissioninfoFCC
    { 
	
		public hr_hospitaladmissioninfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_hospitaladmissioninfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_hospitaladmissioninfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_hospitaladmissioninfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_hospitaladmissioninfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_hospitaladmissioninfoFacadeObjects();
                    context.Items["Ihr_hospitaladmissioninfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_hospitaladmissioninfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}