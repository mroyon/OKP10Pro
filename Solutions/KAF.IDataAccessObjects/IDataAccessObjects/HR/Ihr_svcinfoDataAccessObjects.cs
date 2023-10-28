using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_svcinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_svcinfoEntity hr_svcinfo);
		
		long Update(hr_svcinfoEntity hr_svcinfo);
        
		long Delete(hr_svcinfoEntity hr_svcinfo);
		
        long SaveList(IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_svcinfoEntity> GetAll(hr_svcinfoEntity hr_svcinfo);
		
		IList<hr_svcinfoEntity> GetAllByPages(hr_svcinfoEntity hr_svcinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_arrivalinfodetl(hr_svcinfoEntity masterEntity, IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted);

        long SaveMasterDethr_demanddetlpassport(hr_svcinfoEntity masterEntity, IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted);

        long SaveMasterDethr_flightinfodetl(hr_svcinfoEntity masterEntity, IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        long SaveMasterDethr_ptademanddetl(hr_svcinfoEntity masterEntity, IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted);

        long SaveMasterDethr_repatriationinfo(hr_svcinfoEntity masterEntity, IList<hr_repatriationinfoEntity> listAdded, IList<hr_repatriationinfoEntity> listUpdated, IList<hr_repatriationinfoEntity> listDeleted);

        long SaveMasterDethr_replacementinfodetl(hr_svcinfoEntity masterEntity, IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted);

        long SaveMasterDethr_reppassportinfodetl(hr_svcinfoEntity masterEntity, IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted);

        long SaveMasterDethr_visademandinfodetl(hr_svcinfoEntity masterEntity, IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted);

        long SaveMasterDethr_visaissueinfodetl(hr_svcinfoEntity masterEntity, IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted);

        long SaveMasterDethr_visasentinfodetl(hr_svcinfoEntity masterEntity, IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_svcinfoEntity  GetSingle(hr_svcinfoEntity hr_svcinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_svcinfoEntity> GAPgListView(hr_svcinfoEntity hr_svcinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
