

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_reportroletemplateFCC
    { 
	
		public owin_reportroletemplateFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_reportroletemplateFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_reportroletemplateFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_reportroletemplateFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_reportroletemplateFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_reportroletemplateFacadeObjects();
                    context.Items["Iowin_reportroletemplateFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_reportroletemplateFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}