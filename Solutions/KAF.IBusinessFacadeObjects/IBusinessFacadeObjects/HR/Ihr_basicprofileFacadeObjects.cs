

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_basicprofileFacadeObjects")]
    public partial interface Ihr_basicprofileFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_basicprofileEntity hr_basicprofile);
        
		[OperationContract]
		long Update(hr_basicprofileEntity hr_basicprofile);
		
		[OperationContract]
		long Delete(hr_basicprofileEntity hr_basicprofile );
        
        [OperationContract]
        long SaveList(List<hr_basicprofileEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_basicprofileEntity> GetAll(hr_basicprofileEntity hr_basicprofile);
		
		[OperationContract]
        IList<hr_basicprofileEntity> GetAllByPages(hr_basicprofileEntity hr_basicprofile);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_okpco(hr_basicprofileEntity Master, List<gen_okpcoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_addresschange(hr_basicprofileEntity Master, List<hr_addresschangeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_arrivalinfodetl(hr_basicprofileEntity Master, List<hr_arrivalinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_bankaccountinfo(hr_basicprofileEntity Master, List<hr_bankaccountinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_bankloaninfo(hr_basicprofileEntity Master, List<hr_bankloaninfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_basicfile(hr_basicprofileEntity Master, List<hr_basicfileEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_demanddetlpassport(hr_basicprofileEntity Master, List<hr_demanddetlpassportEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_emergencycontact(hr_basicprofileEntity Master, List<hr_emergencycontactEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_extensioninfo(hr_basicprofileEntity Master, List<hr_extensioninfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_familyinfo(hr_basicprofileEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_flightinfodetl(hr_basicprofileEntity Master, List<hr_flightinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(hr_basicprofileEntity Master, List<hr_personalinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_ptademanddetl(hr_basicprofileEntity Master, List<hr_ptademanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_repatriationinfo(hr_basicprofileEntity Master, List<hr_repatriationinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_replacementinfodetl(hr_basicprofileEntity Master, List<hr_replacementinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_reppassportinfodetl(hr_basicprofileEntity Master, List<hr_reppassportinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_svcinfo(hr_basicprofileEntity Master, List<hr_svcinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visademandinfodetl(hr_basicprofileEntity Master, List<hr_visademandinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visaissueinfodetl(hr_basicprofileEntity Master, List<hr_visaissueinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visasentinfodetl(hr_basicprofileEntity Master, List<hr_visasentinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_basicprofileEntity  GetSingle(hr_basicprofileEntity hr_basicprofile);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_basicprofileEntity> GAPgListView(hr_basicprofileEntity hr_basicprofile);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
