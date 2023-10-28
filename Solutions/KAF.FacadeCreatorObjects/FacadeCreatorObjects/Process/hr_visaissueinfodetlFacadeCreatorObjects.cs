

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_visaissueinfodetlFCC
    { 
	
		public hr_visaissueinfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_visaissueinfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_visaissueinfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_visaissueinfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_visaissueinfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_visaissueinfodetlFacadeObjects();
                    context.Items["Ihr_visaissueinfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_visaissueinfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}