

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_forminfoFCC
    { 
	
		public owin_forminfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_forminfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_forminfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_forminfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_forminfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_forminfoFacadeObjects();
                    context.Items["Iowin_forminfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_forminfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}