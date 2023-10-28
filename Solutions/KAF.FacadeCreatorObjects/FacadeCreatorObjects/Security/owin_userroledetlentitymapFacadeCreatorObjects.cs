

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userroledetlentitymapFCC
    { 
	
		public owin_userroledetlentitymapFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userroledetlentitymapFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userroledetlentitymapFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userroledetlentitymapFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userroledetlentitymapFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userroledetlentitymapFacadeObjects();
                    context.Items["Iowin_userroledetlentitymapFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userroledetlentitymapFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}