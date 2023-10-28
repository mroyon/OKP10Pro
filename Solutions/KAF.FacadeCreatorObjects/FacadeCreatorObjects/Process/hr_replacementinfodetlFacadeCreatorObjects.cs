

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_replacementinfodetlFCC
    { 
	
		public hr_replacementinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_replacementinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_replacementinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_replacementinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_replacementinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_replacementinfodetlFacadeObjects();
                    context.Items["Ihr_replacementinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_replacementinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}