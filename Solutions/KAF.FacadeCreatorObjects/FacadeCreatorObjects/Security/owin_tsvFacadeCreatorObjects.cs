

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_tsvFCC
    { 
	
		public owin_tsvFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_tsvFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_tsvFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_tsvFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_tsvFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_tsvFacadeObjects();
                    context.Items["Iowin_tsvFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_tsvFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}