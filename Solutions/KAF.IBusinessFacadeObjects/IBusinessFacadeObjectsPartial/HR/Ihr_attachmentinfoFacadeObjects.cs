

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_attachmentinfoFacadeObjects 
    {
        //[OperationContract]
        //IList<KAFGenericComboEntity> Add_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //[OperationContract]
        //IList<KAFGenericComboEntity> Update_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //[OperationContract]
        //IList<KAFGenericComboEntity> Delete_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //[OperationContract]
        //IList<hr_attachmentinfoEntity> ViewSingle_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        [OperationContract]
        long Add_Ext(hr_attachmentinfoEntity hr_attachmentinfo);

        [OperationContract]
        long Update_Ext(hr_attachmentinfoEntity hr_attachmentinfo);
    }
}
