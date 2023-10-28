

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_thanaFacadeObjects")]
    public partial interface Igen_thanaFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_thanaEntity gen_thana);
        
		[OperationContract]
		long Update(gen_thanaEntity gen_thana);
		
		[OperationContract]
		long Delete(gen_thanaEntity gen_thana );
        
        [OperationContract]
        long SaveList(List<gen_thanaEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_thanaEntity> GetAll(gen_thanaEntity gen_thana);
		
		[OperationContract]
        IList<gen_thanaEntity> GetAllByPages(gen_thanaEntity gen_thana);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_postoffice(gen_thanaEntity Master, List<gen_postofficeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_addresschange(gen_thanaEntity Master, List<hr_addresschangeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_emergencycontact(gen_thanaEntity Master, List<hr_emergencycontactEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_thanaEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_thanaEntity  GetSingle(gen_thanaEntity gen_thana);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_thanaEntity> GAPgListView(gen_thanaEntity gen_thana);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
