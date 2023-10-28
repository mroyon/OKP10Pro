using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessReportDataObjects;
using System.Data;


namespace KAFWebAdmin.HelperClasses
{
    public class clsReportingEntity
    {
		
		public List<KAF_GetReplacementInfoEntity> Get_KAF_GetReplacementInfo()
		{
			List<KAF_GetReplacementInfoEntity> db = new List<KAF_GetReplacementInfoEntity>();
			return db.ToList();
		}
	}
}
