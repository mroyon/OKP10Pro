

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userroledetlFCC
    { 
	
		public owin_userroledetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userroledetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userroledetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userroledetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userroledetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userroledetlFacadeObjects();
                    context.Items["Iowin_userroledetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userroledetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}