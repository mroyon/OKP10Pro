using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_demanddetlpassportDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		long Update(hr_demanddetlpassportEntity hr_demanddetlpassport);
        
		long Delete(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
        long SaveList(IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_demanddetlpassportEntity> GetAll(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		IList<hr_demanddetlpassportEntity> GetAllByPages(hr_demanddetlpassportEntity hr_demanddetlpassport);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_demanddetlpassportEntity  GetSingle(hr_demanddetlpassportEntity hr_demanddetlpassport);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_demanddetlpassportEntity> GAPgListView(hr_demanddetlpassportEntity hr_demanddetlpassport);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
