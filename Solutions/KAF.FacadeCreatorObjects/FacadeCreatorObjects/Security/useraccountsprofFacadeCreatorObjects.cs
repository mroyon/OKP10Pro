

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects;
using KAF.BusinessFacadeObjects;
using System.Web;


namespace KAF.FacadeCreatorObjects
{
    public class useraccountsprofFCC
    { 
	
		public useraccountsprofFCC()
        {
		
        }
		
		public static KAF.IBusinessFacadeObjects.IuseraccountsprofFacadeObjects GetFacadeCreate()
        {
			KAF.IBusinessFacadeObjects.IuseraccountsprofFacadeObjects facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["IuseraccountsprofFacadeObjects"] as KAF.IBusinessFacadeObjects.IuseraccountsprofFacadeObjects;
    
                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.useraccountsprofFacadeObjects();
                    context.Items["IuseraccountsprofFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.useraccountsprofFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}