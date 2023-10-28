

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_extensioninfoFCC
    { 
	
		public hr_extensioninfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_extensioninfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_extensioninfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_extensioninfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_extensioninfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_extensioninfoFacadeObjects();
                    context.Items["Ihr_extensioninfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_extensioninfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}