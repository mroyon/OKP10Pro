

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_svcinfoFacadeObjects")]
    public partial interface Ihr_svcinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_svcinfoEntity hr_svcinfo);
        
		[OperationContract]
		long Update(hr_svcinfoEntity hr_svcinfo);
		
		[OperationContract]
		long Delete(hr_svcinfoEntity hr_svcinfo );
        
        [OperationContract]
        long SaveList(List<hr_svcinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_svcinfoEntity> GetAll(hr_svcinfoEntity hr_svcinfo);
		
		[OperationContract]
        IList<hr_svcinfoEntity> GetAllByPages(hr_svcinfoEntity hr_svcinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_arrivalinfodetl(hr_svcinfoEntity Master, List<hr_arrivalinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_demanddetlpassport(hr_svcinfoEntity Master, List<hr_demanddetlpassportEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_flightinfodetl(hr_svcinfoEntity Master, List<hr_flightinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_ptademanddetl(hr_svcinfoEntity Master, List<hr_ptademanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_repatriationinfo(hr_svcinfoEntity Master, List<hr_repatriationinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_replacementinfodetl(hr_svcinfoEntity Master, List<hr_replacementinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_reppassportinfodetl(hr_svcinfoEntity Master, List<hr_reppassportinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visademandinfodetl(hr_svcinfoEntity Master, List<hr_visademandinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visaissueinfodetl(hr_svcinfoEntity Master, List<hr_visaissueinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visasentinfodetl(hr_svcinfoEntity Master, List<hr_visasentinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_svcinfoEntity  GetSingle(hr_svcinfoEntity hr_svcinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_svcinfoEntity> GAPgListView(hr_svcinfoEntity hr_svcinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
