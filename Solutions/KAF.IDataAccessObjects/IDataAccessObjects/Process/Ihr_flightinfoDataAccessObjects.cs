using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_flightinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_flightinfoEntity hr_flightinfo);
		
		long Update(hr_flightinfoEntity hr_flightinfo);
        
		long Delete(hr_flightinfoEntity hr_flightinfo);
		
        long SaveList(IList<hr_flightinfoEntity> listAdded, IList<hr_flightinfoEntity> listUpdated, IList<hr_flightinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_flightinfoEntity> GetAll(hr_flightinfoEntity hr_flightinfo);
		
		IList<hr_flightinfoEntity> GetAllByPages(hr_flightinfoEntity hr_flightinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_arrivalinfo(hr_flightinfoEntity masterEntity, IList<hr_arrivalinfoEntity> listAdded, IList<hr_arrivalinfoEntity> listUpdated, IList<hr_arrivalinfoEntity> listDeleted);

        long SaveMasterDethr_flightinfodetl(hr_flightinfoEntity masterEntity, IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_flightinfoEntity  GetSingle(hr_flightinfoEntity hr_flightinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_flightinfoEntity> GAPgListView(hr_flightinfoEntity hr_flightinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
