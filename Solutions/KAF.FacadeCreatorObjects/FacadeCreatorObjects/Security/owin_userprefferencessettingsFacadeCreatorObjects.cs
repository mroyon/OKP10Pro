

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userprefferencessettingsFCC
    { 
	
		public owin_userprefferencessettingsFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userprefferencessettingsFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userprefferencessettingsFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userprefferencessettingsFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userprefferencessettingsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userprefferencessettingsFacadeObjects();
                    context.Items["Iowin_userprefferencessettingsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userprefferencessettingsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}