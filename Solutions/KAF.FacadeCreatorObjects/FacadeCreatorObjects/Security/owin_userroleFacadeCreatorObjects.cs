

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userroleFCC
    { 
	
		public owin_userroleFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userroleFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userroleFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userroleFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userroleFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userroleFacadeObjects();
                    context.Items["Iowin_userroleFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userroleFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}