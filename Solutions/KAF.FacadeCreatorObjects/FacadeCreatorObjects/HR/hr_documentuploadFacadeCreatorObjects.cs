

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_documentuploadFCC
    { 
	
		public hr_documentuploadFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_documentuploadFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_documentuploadFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_documentuploadFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_documentuploadFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_documentuploadFacadeObjects();
                    context.Items["Ihr_documentuploadFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_documentuploadFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}