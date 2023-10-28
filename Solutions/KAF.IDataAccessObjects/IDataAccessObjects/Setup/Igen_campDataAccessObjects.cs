using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_campDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_campEntity gen_camp);
		
		long Update(gen_campEntity gen_camp);
        
		long Delete(gen_campEntity gen_camp);
		
        long SaveList(IList<gen_campEntity> listAdded, IList<gen_campEntity> listUpdated, IList<gen_campEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_campEntity> GetAll(gen_campEntity gen_camp);
		
		IList<gen_campEntity> GetAllByPages(gen_campEntity gen_camp);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        //long SaveMasterDethr_attachmentinfo(gen_campEntity masterEntity, IList<hr_attachmentinfoEntity> listAdded, IList<hr_attachmentinfoEntity> listUpdated, IList<hr_attachmentinfoEntity> listDeleted);

        //long SaveMasterDethr_okptransferinfo(gen_campEntity masterEntity, IList<hr_okptransferinfoEntity> listAdded, IList<hr_okptransferinfoEntity> listUpdated, IList<hr_okptransferinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_campEntity  GetSingle(gen_campEntity gen_camp);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_campEntity> GAPgListView(gen_campEntity gen_camp);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
