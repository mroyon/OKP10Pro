

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

namespace KAF.IBusinessFacadeObjects
{
    public partial interface Ihr_civilidinfoFacadeObjects 
    {
        [OperationContract]
        IList<KAFGenericComboEntity> Add_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
         
        [OperationContract]
        IList<KAFGenericComboEntity> Update_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
         
        [OperationContract]
        IList<KAFGenericComboEntity> Delete_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
        
        [OperationContract]
        IList<hr_civilidinfoEntity> ViewSingle_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
		
    }
}
