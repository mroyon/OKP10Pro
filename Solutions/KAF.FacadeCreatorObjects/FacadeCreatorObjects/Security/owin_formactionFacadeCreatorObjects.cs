

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_formactionFCC
    { 
	
		public owin_formactionFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_formactionFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_formactionFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_formactionFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_formactionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_formactionFacadeObjects();
                    context.Items["Iowin_formactionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_formactionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}