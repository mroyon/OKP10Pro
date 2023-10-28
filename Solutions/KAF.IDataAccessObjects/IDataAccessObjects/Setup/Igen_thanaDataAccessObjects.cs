using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_thanaDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_thanaEntity gen_thana);
		
		long Update(gen_thanaEntity gen_thana);
        
		long Delete(gen_thanaEntity gen_thana);
		
        long SaveList(IList<gen_thanaEntity> listAdded, IList<gen_thanaEntity> listUpdated, IList<gen_thanaEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_thanaEntity> GetAll(gen_thanaEntity gen_thana);
		
		IList<gen_thanaEntity> GetAllByPages(gen_thanaEntity gen_thana);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_postoffice(gen_thanaEntity masterEntity, IList<gen_postofficeEntity> listAdded, IList<gen_postofficeEntity> listUpdated, IList<gen_postofficeEntity> listDeleted);

        long SaveMasterDethr_addresschange(gen_thanaEntity masterEntity, IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);

        long SaveMasterDethr_emergencycontact(gen_thanaEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_thanaEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_thanaEntity  GetSingle(gen_thanaEntity gen_thana);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_thanaEntity> GAPgListView(gen_thanaEntity gen_thana);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
