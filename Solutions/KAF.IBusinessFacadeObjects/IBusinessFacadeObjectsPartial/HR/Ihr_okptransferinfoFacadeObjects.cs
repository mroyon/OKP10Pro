

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_okptransferinfoFacadeObjects 
    {
        //[OperationContract]
        //IList<KAFGenericComboEntity> Add_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //[OperationContract]
        //IList<KAFGenericComboEntity> Update_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //[OperationContract]
        //IList<KAFGenericComboEntity> Delete_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //[OperationContract]
        //IList<hr_okptransferinfoEntity> ViewSingle_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);


        [OperationContract]
        long Add_Ext(hr_okptransferinfoEntity hr_okptransferinfo);

        [OperationContract]
        long Update_Ext(hr_okptransferinfoEntity hr_okptransferinfo);
    }
}
