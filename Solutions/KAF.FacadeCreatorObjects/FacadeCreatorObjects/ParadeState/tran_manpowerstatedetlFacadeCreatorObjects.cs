

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_manpowerstatedetlFCC
    { 
	
		public tran_manpowerstatedetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_manpowerstatedetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_manpowerstatedetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_manpowerstatedetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_manpowerstatedetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_manpowerstatedetlFacadeObjects();
                    context.Items["Itran_manpowerstatedetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_manpowerstatedetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}