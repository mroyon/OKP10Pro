

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class rptm_reportparameterFCC
    { 
	
		public rptm_reportparameterFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Irptm_reportparameterFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Irptm_reportparameterFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Irptm_reportparameterFacadeObjects"] as KAF.IBusinessFacadeObjects.Irptm_reportparameterFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.rptm_reportparameterFacadeObjects();
                    context.Items["Irptm_reportparameterFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.rptm_reportparameterFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}