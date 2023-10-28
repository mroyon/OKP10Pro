

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userFCC
    { 
	
		public owin_userFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userFacadeObjects();
                    context.Items["Iowin_userFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}