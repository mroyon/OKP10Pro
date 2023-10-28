using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
    public partial interface Ihr_hospitaladmissioninfoDataAccessObjects
    {
        hr_hospitaladmissioninfoEntity GetCurrentActive(hr_hospitaladmissioninfoEntity hr_hospitaladmissioninfo);
    }
}
