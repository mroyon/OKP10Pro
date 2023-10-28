using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_countryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_countryEntity gen_country);
		
		long Update(gen_countryEntity gen_country);
        
		long Delete(gen_countryEntity gen_country);
		
        long SaveList(IList<gen_countryEntity> listAdded, IList<gen_countryEntity> listUpdated, IList<gen_countryEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_countryEntity> GetAll(gen_countryEntity gen_country);
		
		IList<gen_countryEntity> GetAllByPages(gen_countryEntity gen_country);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetgen_arms(gen_countryEntity masterEntity, IList<gen_armsEntity> listAdded, IList<gen_armsEntity> listUpdated, IList<gen_armsEntity> listDeleted);

        long SaveMasterDetgen_bank(gen_countryEntity masterEntity, IList<gen_bankEntity> listAdded, IList<gen_bankEntity> listUpdated, IList<gen_bankEntity> listDeleted);

        long SaveMasterDetgen_divisiondistrict(gen_countryEntity masterEntity, IList<gen_divisiondistrictEntity> listAdded, IList<gen_divisiondistrictEntity> listUpdated, IList<gen_divisiondistrictEntity> listDeleted);

        long SaveMasterDetgen_govcity(gen_countryEntity masterEntity, IList<gen_govcityEntity> listAdded, IList<gen_govcityEntity> listUpdated, IList<gen_govcityEntity> listDeleted);

        long SaveMasterDetgen_rank(gen_countryEntity masterEntity, IList<gen_rankEntity> listAdded, IList<gen_rankEntity> listUpdated, IList<gen_rankEntity> listDeleted);

        long SaveMasterDethr_familyinfo(gen_countryEntity masterEntity, IList<hr_familyinfoEntity> listAdded, IList<hr_familyinfoEntity> listUpdated, IList<hr_familyinfoEntity> listDeleted);

        long SaveMasterDethr_hospitaladmissioninfo(gen_countryEntity masterEntity, IList<hr_hospitaladmissioninfoEntity> listAdded, IList<hr_hospitaladmissioninfoEntity> listUpdated, IList<hr_hospitaladmissioninfoEntity> listDeleted);

        long SaveMasterDethr_rewardinfo(gen_countryEntity masterEntity, IList<hr_rewardinfoEntity> listAdded, IList<hr_rewardinfoEntity> listUpdated, IList<hr_rewardinfoEntity> listDeleted);

        long SaveMasterDethr_passportinfo(gen_countryEntity masterEntity, IList<hr_passportinfoEntity> listAdded, IList<hr_passportinfoEntity> listUpdated, IList<hr_passportinfoEntity> listDeleted);

        long SaveMasterDethr_personalinfo(gen_countryEntity masterEntity, IList<hr_personalinfoEntity> listAdded, IList<hr_personalinfoEntity> listUpdated, IList<hr_personalinfoEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_countryEntity  GetSingle(gen_countryEntity gen_country);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_countryEntity> GAPgListView(gen_countryEntity gen_country);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
