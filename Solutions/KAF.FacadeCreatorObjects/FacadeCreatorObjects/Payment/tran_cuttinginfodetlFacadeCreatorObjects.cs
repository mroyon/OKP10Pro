

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class tran_cuttinginfodetlFCC
    { 
	
		public tran_cuttinginfodetlFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.Itran_cuttinginfodetlFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.Itran_cuttinginfodetlFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["Itran_cuttinginfodetlFacadeObjects"] as KAF.IBusinessFacadeObjects.Itran_cuttinginfodetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.tran_cuttinginfodetlFacadeObjects();
                    context.Items["Itran_cuttinginfodetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.tran_cuttinginfodetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}