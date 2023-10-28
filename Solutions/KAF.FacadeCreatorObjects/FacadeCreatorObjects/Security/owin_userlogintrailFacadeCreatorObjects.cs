

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userlogintrailFCC
    { 
	
		public owin_userlogintrailFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userlogintrailFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userlogintrailFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userlogintrailFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userlogintrailFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userlogintrailFacadeObjects();
                    context.Items["Iowin_userlogintrailFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userlogintrailFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}