

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_demanddetlpassportFCC
    { 
	
		public hr_demanddetlpassportFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_demanddetlpassportFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_demanddetlpassportFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_demanddetlpassportFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_demanddetlpassportFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_demanddetlpassportFacadeObjects();
                    context.Items["Ihr_demanddetlpassportFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_demanddetlpassportFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}