

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_reportroleFCC
    { 
	
		public owin_reportroleFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_reportroleFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_reportroleFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_reportroleFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_reportroleFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_reportroleFacadeObjects();
                    context.Items["Iowin_reportroleFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_reportroleFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}