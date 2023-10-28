

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_manpowerstateFCC
    { 
	
		public tran_manpowerstateFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_manpowerstateFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_manpowerstateFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_manpowerstateFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_manpowerstateFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_manpowerstateFacadeObjects();
                    context.Items["Itran_manpowerstateFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_manpowerstateFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}