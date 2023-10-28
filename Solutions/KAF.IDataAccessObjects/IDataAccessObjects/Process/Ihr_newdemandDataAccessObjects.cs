using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_newdemandDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_newdemandEntity hr_newdemand);
		
		long Update(hr_newdemandEntity hr_newdemand);
        
		long Delete(hr_newdemandEntity hr_newdemand);
		
        long SaveList(IList<hr_newdemandEntity> listAdded, IList<hr_newdemandEntity> listUpdated, IList<hr_newdemandEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_newdemandEntity> GetAll(hr_newdemandEntity hr_newdemand);
		
		IList<hr_newdemandEntity> GetAllByPages(hr_newdemandEntity hr_newdemand);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_newdemanddetl(hr_newdemandEntity masterEntity, IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_newdemandEntity  GetSingle(hr_newdemandEntity hr_newdemand);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_newdemandEntity> GAPgListView(hr_newdemandEntity hr_newdemand);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
