using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;


namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_attachmentinfoDataAccessObjects
    {

        //IList<KAFGenericComboEntity> Add_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //IList<KAFGenericComboEntity> Update_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //IList<KAFGenericComboEntity> Delete_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);

        //IList<hr_attachmentinfoEntity> ViewSingle_WithFiles(hr_attachmentinfoEntity hr_attachmentinfo);
        long Add_Ext(hr_attachmentinfoEntity hr_attachmentinfo);

        long Update_Ext(hr_attachmentinfoEntity hr_attachmentinfo);
    }
}
