

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class owin_reportpermissionFCC
    { 
	
		public owin_reportpermissionFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Iowin_reportpermissionFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Iowin_reportpermissionFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Iowin_reportpermissionFacadeObjects"] as KAF.IBusinessFacadeObjects.Iowin_reportpermissionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.owin_reportpermissionFacadeObjects();
                    context.Items["Iowin_reportpermissionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.owin_reportpermissionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}