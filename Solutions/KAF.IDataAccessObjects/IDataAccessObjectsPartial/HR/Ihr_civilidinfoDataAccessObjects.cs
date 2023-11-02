using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;


namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_civilidinfoDataAccessObjects
    {
		
         IList<KAFGenericComboEntity> Add_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
         
         IList<KAFGenericComboEntity> Update_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
         
         IList<KAFGenericComboEntity> Delete_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
        
         IList<hr_civilidinfoEntity> ViewSingle_WithFiles(hr_civilidinfoEntity hr_civilidinfo);
		
    }
}
