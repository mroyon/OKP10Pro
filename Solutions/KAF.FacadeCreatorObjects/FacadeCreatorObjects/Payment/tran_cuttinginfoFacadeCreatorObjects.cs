

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_cuttinginfoFCC
    { 
	
		public tran_cuttinginfoFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_cuttinginfoFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_cuttinginfoFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_cuttinginfoFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_cuttinginfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_cuttinginfoFacadeObjects();
                    context.Items["Itran_cuttinginfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_cuttinginfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}