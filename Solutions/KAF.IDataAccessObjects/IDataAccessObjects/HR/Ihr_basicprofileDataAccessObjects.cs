using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_basicprofileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_basicprofileEntity hr_basicprofile);
		
		long Update(hr_basicprofileEntity hr_basicprofile);
        
		long Delete(hr_basicprofileEntity hr_basicprofile);
		
        long SaveList(IList<hr_basicprofileEntity> listAdded, IList<hr_basicprofileEntity> listUpdated, IList<hr_basicprofileEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_basicprofileEntity> GetAll(hr_basicprofileEntity hr_basicprofile);
		
		IList<hr_basicprofileEntity> GetAllByPages(hr_basicprofileEntity hr_basicprofile);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_okpco(hr_basicprofileEntity masterEntity, IList<gen_okpcoEntity> listAdded, IList<gen_okpcoEntity> listUpdated, IList<gen_okpcoEntity> listDeleted);

        long SaveMasterDethr_addresschange(hr_basicprofileEntity masterEntity, IList<hr_addresschangeEntity> listAdded, IList<hr_addresschangeEntity> listUpdated, IList<hr_addresschangeEntity> listDeleted);

        long SaveMasterDethr_arrivalinfodetl(hr_basicprofileEntity masterEntity, IList<hr_arrivalinfodetlEntity> listAdded, IList<hr_arrivalinfodetlEntity> listUpdated, IList<hr_arrivalinfodetlEntity> listDeleted);

        long SaveMasterDethr_bankaccountinfo(hr_basicprofileEntity masterEntity, IList<hr_bankaccountinfoEntity> listAdded, IList<hr_bankaccountinfoEntity> listUpdated, IList<hr_bankaccountinfoEntity> listDeleted);

        long SaveMasterDethr_bankloaninfo(hr_basicprofileEntity masterEntity, IList<hr_bankloaninfoEntity> listAdded, IList<hr_bankloaninfoEntity> listUpdated, IList<hr_bankloaninfoEntity> listDeleted);

        long SaveMasterDethr_basicfile(hr_basicprofileEntity masterEntity, IList<hr_basicfileEntity> listAdded, IList<hr_basicfileEntity> listUpdated, IList<hr_basicfileEntity> listDeleted);

        long SaveMasterDethr_demanddetlpassport(hr_basicprofileEntity masterEntity, IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted);

        long SaveMasterDethr_emergencycontact(hr_basicprofileEntity masterEntity, IList<hr_emergencycontactEntity> listAdded, IList<hr_emergencycontactEntity> listUpdated, IList<hr_emergencycontactEntity> listDeleted);

        long SaveMasterDethr_extensioninfo(hr_basicprofileEntity masterEntity, IList<hr_extensioninfoEntity> listAdded, IList<hr_extensioninfoEntity> listUpdated, IList<hr_extensioninfoEntity> listDeleted);

        long SaveMasterDethr_familyinfo(hr_basicprofileEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_flightinfodetl(hr_basicprofileEntity masterEntity, IList<hr_flightinfodetlEntity> listAdded, IList<hr_flightinfodetlEntity> listUpdated, IList<hr_flightinfodetlEntity> listDeleted);

        long SaveMasterDethr_personalinfo(hr_basicprofileEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        long SaveMasterDethr_ptademanddetl(hr_basicprofileEntity masterEntity, IList<hr_ptademanddetlEntity> listAdded, IList<hr_ptademanddetlEntity> listUpdated, IList<hr_ptademanddetlEntity> listDeleted);

        long SaveMasterDethr_repatriationinfo(hr_basicprofileEntity masterEntity, IList<hr_repatriationinfoEntity> listAdded, IList<hr_repatriationinfoEntity> listUpdated, IList<hr_repatriationinfoEntity> listDeleted);

        long SaveMasterDethr_replacementinfodetl(hr_basicprofileEntity masterEntity, IList<hr_replacementinfodetlEntity> listAdded, IList<hr_replacementinfodetlEntity> listUpdated, IList<hr_replacementinfodetlEntity> listDeleted);

        long SaveMasterDethr_reppassportinfodetl(hr_basicprofileEntity masterEntity, IList<hr_reppassportinfodetlEntity> listAdded, IList<hr_reppassportinfodetlEntity> listUpdated, IList<hr_reppassportinfodetlEntity> listDeleted);

        long SaveMasterDethr_svcinfo(hr_basicprofileEntity masterEntity, IList<hr_svcinfoEntity> listAdded, IList<hr_svcinfoEntity> listUpdated, IList<hr_svcinfoEntity> listDeleted);

        long SaveMasterDethr_visademandinfodetl(hr_basicprofileEntity masterEntity, IList<hr_visademandinfodetlEntity> listAdded, IList<hr_visademandinfodetlEntity> listUpdated, IList<hr_visademandinfodetlEntity> listDeleted);

        long SaveMasterDethr_visaissueinfodetl(hr_basicprofileEntity masterEntity, IList<hr_visaissueinfodetlEntity> listAdded, IList<hr_visaissueinfodetlEntity> listUpdated, IList<hr_visaissueinfodetlEntity> listDeleted);

        long SaveMasterDethr_visasentinfodetl(hr_basicprofileEntity masterEntity, IList<hr_visasentinfodetlEntity> listAdded, IList<hr_visasentinfodetlEntity> listUpdated, IList<hr_visasentinfodetlEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_basicprofileEntity  GetSingle(hr_basicprofileEntity hr_basicprofile);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_basicprofileEntity> GAPgListView(hr_basicprofileEntity hr_basicprofile);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
