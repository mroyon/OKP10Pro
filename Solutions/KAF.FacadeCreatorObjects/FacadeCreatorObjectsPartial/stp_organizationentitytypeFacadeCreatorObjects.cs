

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;
using System.Web;


namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class owin_userFCC
    { 
	
		public owin_userFCC()
        {
		
        }
		
		public static  Iowin_userFacadeObjects GetFacadeCreate()
        {
			
            HttpContext context = HttpContext.Current;
            if (context == null) { return new owin_userFacadeObjects(); }
            Iowin_userFacadeObjects facade = context.Items["Iowin_userFacadeObjects"] as Iowin_userFacadeObjects;

            if (facade == null)
            {
                facade = new owin_userFacadeObjects();
                context.Items["Iowin_userFacadeObjects"] = facade;
            }
            return facade;
        }
		
		
	}
}