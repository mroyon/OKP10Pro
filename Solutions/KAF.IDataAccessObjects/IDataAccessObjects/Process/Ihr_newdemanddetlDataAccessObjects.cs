using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_newdemanddetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_newdemanddetlEntity hr_newdemanddetl);
		
		long Update(hr_newdemanddetlEntity hr_newdemanddetl);
        
		long Delete(hr_newdemanddetlEntity hr_newdemanddetl);
		
        long SaveList(IList<hr_newdemanddetlEntity> listAdded, IList<hr_newdemanddetlEntity> listUpdated, IList<hr_newdemanddetlEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_newdemanddetlEntity> GetAll(hr_newdemanddetlEntity hr_newdemanddetl);
		
		IList<hr_newdemanddetlEntity> GetAllByPages(hr_newdemanddetlEntity hr_newdemanddetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_demanddetlpassport(hr_newdemanddetlEntity masterEntity, IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_newdemanddetlEntity  GetSingle(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_newdemanddetlEntity> GAPgListView(hr_newdemanddetlEntity hr_newdemanddetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
