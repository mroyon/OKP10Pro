using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_subunitDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_subunitEntity gen_subunit);
		
		long Update(gen_subunitEntity gen_subunit);
        
		long Delete(gen_subunitEntity gen_subunit);
		
        long SaveList(IList<gen_subunitEntity> listAdded, IList<gen_subunitEntity> listUpdated, IList<gen_subunitEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_subunitEntity> GetAll(gen_subunitEntity gen_subunit);
		
		IList<gen_subunitEntity> GetAllByPages(gen_subunitEntity gen_subunit);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        //long SaveMasterDethr_attachmentinfo(gen_subunitEntity masterEntity, IList<hr_attachmentinfoEntity> listAdded, IList<hr_attachmentinfoEntity> listUpdated, IList<hr_attachmentinfoEntity> listDeleted);

        //long SaveMasterDethr_okptransferinfo(gen_subunitEntity masterEntity, IList<hr_okptransferinfoEntity> listAdded, IList<hr_okptransferinfoEntity> listUpdated, IList<hr_okptransferinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_subunitEntity  GetSingle(gen_subunitEntity gen_subunit);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_subunitEntity> GAPgListView(gen_subunitEntity gen_subunit);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
