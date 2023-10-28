

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_manpowerstate_historyFCC
    { 
	
		public tran_manpowerstate_historyFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_manpowerstate_historyFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_manpowerstate_historyFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_manpowerstate_historyFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_manpowerstate_historyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_manpowerstate_historyFacadeObjects();
                    context.Items["Itran_manpowerstate_historyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_manpowerstate_historyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}