

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_manpowerstatedetl_historyFCC
    { 
	
		public tran_manpowerstatedetl_historyFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_manpowerstatedetl_historyFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_manpowerstatedetl_historyFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_manpowerstatedetl_historyFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_manpowerstatedetl_historyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_manpowerstatedetl_historyFacadeObjects();
                    context.Items["Itran_manpowerstatedetl_historyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_manpowerstatedetl_historyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}