

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_addresschangeFCC
    { 
	
		public hr_addresschangeFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_addresschangeFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_addresschangeFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_addresschangeFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_addresschangeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_addresschangeFacadeObjects();
                    context.Items["Ihr_addresschangeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_addresschangeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}