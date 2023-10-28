

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class rptm_allreportinfoFCC
    { 
	
		public rptm_allreportinfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Irptm_allreportinfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Irptm_allreportinfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Irptm_allreportinfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Irptm_allreportinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.rptm_allreportinfoFacadeObjects();
                    context.Items["Irptm_allreportinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.rptm_allreportinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}