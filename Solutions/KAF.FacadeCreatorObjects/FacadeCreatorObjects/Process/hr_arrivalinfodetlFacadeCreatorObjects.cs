

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_arrivalinfodetlFCC
    { 
	
		public hr_arrivalinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_arrivalinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_arrivalinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_arrivalinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_arrivalinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_arrivalinfodetlFacadeObjects();
                    context.Items["Ihr_arrivalinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_arrivalinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}