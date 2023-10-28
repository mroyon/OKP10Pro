

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_roleFCC
    { 
	
		public owin_roleFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_roleFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_roleFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_roleFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_roleFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_roleFacadeObjects();
                    context.Items["Iowin_roleFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_roleFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}