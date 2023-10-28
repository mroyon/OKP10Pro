using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_flightinfodetlDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_flightinfodetlEntity hr_flightinfodetl);
		
		long Update(hr_flightinfodetlEntity hr_flightinfodetl);
        
		long Delete(hr_flightinfodetlEntity hr_flightinfodetl);

        long Delete_ReIssue(hr_flightinfodetlEntity hr_flightinfodetl);


        long SaveList(IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        long SaveCancelReIssueList(IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        #endregion Save Update Delete List


        #region GetAll	

        IList<hr_flightinfodetlEntity> GetAll(hr_flightinfodetlEntity hr_flightinfodetl);
		
		IList<hr_flightinfodetlEntity> GetAllByPages(hr_flightinfodetlEntity hr_flightinfodetl);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_arrivalinfodetl(hr_flightinfodetlEntity masterEntity, IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_flightinfodetlEntity  GetSingle(hr_flightinfodetlEntity hr_flightinfodetl);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_flightinfodetlEntity> GAPgListView(hr_flightinfodetlEntity hr_flightinfodetl);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
