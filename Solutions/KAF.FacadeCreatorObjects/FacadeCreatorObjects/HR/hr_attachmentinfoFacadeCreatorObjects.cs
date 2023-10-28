

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_attachmentinfoFCC
    { 
	
		public hr_attachmentinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_attachmentinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_attachmentinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_attachmentinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_attachmentinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_attachmentinfoFacadeObjects();
                    context.Items["Ihr_attachmentinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_attachmentinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}