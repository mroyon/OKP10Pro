

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_countryFacadeObjects")]
    public partial interface Igen_countryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_countryEntity gen_country);
        
		[OperationContract]
		long Update(gen_countryEntity gen_country);
		
		[OperationContract]
		long Delete(gen_countryEntity gen_country );
        
        [OperationContract]
        long SaveList(List<gen_countryEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_countryEntity> GetAll(gen_countryEntity gen_country);
		
		[OperationContract]
        IList<gen_countryEntity> GetAllByPages(gen_countryEntity gen_country);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_arms(gen_countryEntity Master, List<gen_armsEntity> DetailList);

        [OperationContract]
        long SaveMasterDetgen_bank(gen_countryEntity Master, List<gen_bankEntity> DetailList);

        [OperationContract]
        long SaveMasterDetgen_divisiondistrict(gen_countryEntity Master, List<gen_divisiondistrictEntity> DetailList);

        [OperationContract]
        long SaveMasterDetgen_govcity(gen_countryEntity Master, List<gen_govcityEntity> DetailList);

        [OperationContract]
        long SaveMasterDetgen_rank(gen_countryEntity Master, List<gen_rankEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_countryEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_hospitaladmissioninfo(gen_countryEntity Master, List<hr_hospitaladmissioninfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_rewardinfo(gen_countryEntity Master, List<hr_rewardinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_passportinfo(gen_countryEntity Master, List<hr_passportinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_countryEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_countryEntity  GetSingle(gen_countryEntity gen_country);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_countryEntity> GAPgListView(gen_countryEntity gen_country);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
