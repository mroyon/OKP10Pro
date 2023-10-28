

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_lastworkingpageFCC
    { 
	
		public owin_lastworkingpageFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_lastworkingpageFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_lastworkingpageFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_lastworkingpageFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_lastworkingpageFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_lastworkingpageFacadeObjects();
                    context.Items["Iowin_lastworkingpageFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_lastworkingpageFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}