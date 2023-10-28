

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class hr_languageproficiencyFCC
    { 
	
		public hr_languageproficiencyFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Ihr_languageproficiencyFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Ihr_languageproficiencyFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Ihr_languageproficiencyFacadeObjects"] as KAF.IBusinessFacadeObjects.Ihr_languageproficiencyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.hr_languageproficiencyFacadeObjects();
                    context.Items["Ihr_languageproficiencyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.hr_languageproficiencyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}