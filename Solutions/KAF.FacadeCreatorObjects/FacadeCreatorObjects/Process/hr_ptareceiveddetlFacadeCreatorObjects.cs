

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_ptareceiveddetlFCC
    { 
	
		public hr_ptareceiveddetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_ptareceiveddetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_ptareceiveddetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_ptareceiveddetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_ptareceiveddetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_ptareceiveddetlFacadeObjects();
                    context.Items["Ihr_ptareceiveddetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_ptareceiveddetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}