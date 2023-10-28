using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;


namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_okptransferinfoDataAccessObjects
    {

        //IList<KAFGenericComboEntity> Add_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //IList<KAFGenericComboEntity> Update_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //IList<KAFGenericComboEntity> Delete_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        //IList<hr_okptransferinfoEntity> ViewSingle_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo);

        long Add_Ext(hr_okptransferinfoEntity hr_okptransferinfo);

        long Update_Ext(hr_okptransferinfoEntity hr_okptransferinfo);

    }
}
