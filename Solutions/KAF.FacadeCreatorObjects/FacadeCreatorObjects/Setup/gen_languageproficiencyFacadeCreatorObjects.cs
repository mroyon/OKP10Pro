

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class gen_languageproficiencyFCC
    { 
	
		public gen_languageproficiencyFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Igen_languageproficiencyFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Igen_languageproficiencyFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Igen_languageproficiencyFacadeObjects"] as KAF.IBusinessFacadeObjects.Igen_languageproficiencyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.gen_languageproficiencyFacadeObjects();
                    context.Items["Igen_languageproficiencyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.gen_languageproficiencyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}