using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using System.Web;
using KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial;

namespace KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial
{
    public class FCCReportExtension
    {
        public FCCReportExtension()
        {

        }

        public static IReportExtensionFacade GetFacadeCreate()
        {
            KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial.IReportExtensionFacade facade = null;
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                facade = context.Items["IReportExtensionFacade"] as KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial.IReportExtensionFacade;

                if (facade == null)
                {
                    facade = new KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial.ReportExtensionFacade();
                    context.Items["IReportExtensionFacade"] = facade;
                }
            }
            else
            {
                facade = new KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial.ReportExtensionFacade();
                return facade;
            }
            return facade;
        }
    }
}
