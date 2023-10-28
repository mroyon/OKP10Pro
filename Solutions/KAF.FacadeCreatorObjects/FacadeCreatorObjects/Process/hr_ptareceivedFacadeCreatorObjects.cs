

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_ptareceivedFCC
    { 
	
		public hr_ptareceivedFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_ptareceivedFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_ptareceivedFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_ptareceivedFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_ptareceivedFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_ptareceivedFacadeObjects();
                    context.Items["Ihr_ptareceivedFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_ptareceivedFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}