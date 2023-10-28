

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_userroledetlentityprofilemapFCC
    { 
	
		public owin_userroledetlentityprofilemapFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_userroledetlentityprofilemapFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_userroledetlentityprofilemapFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_userroledetlentityprofilemapFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_userroledetlentityprofilemapFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_userroledetlentityprofilemapFacadeObjects();
                    context.Items["Iowin_userroledetlentityprofilemapFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_userroledetlentityprofilemapFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}