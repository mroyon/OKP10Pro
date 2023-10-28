using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_deathinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_deathinfoEntity hr_deathinfo);
		
		long Update(hr_deathinfoEntity hr_deathinfo);
        
		long Delete(hr_deathinfoEntity hr_deathinfo);
		
        long SaveList(IList<hr_deathinfoEntity> listAdded, IList<hr_deathinfoEntity> listUpdated, IList<hr_deathinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_deathinfoEntity> GetAll(hr_deathinfoEntity hr_deathinfo);
		
		IList<hr_deathinfoEntity> GetAllByPages(hr_deathinfoEntity hr_deathinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_deathinfoEntity  GetSingle(hr_deathinfoEntity hr_deathinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_deathinfoEntity> GAPgListView(hr_deathinfoEntity hr_deathinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
