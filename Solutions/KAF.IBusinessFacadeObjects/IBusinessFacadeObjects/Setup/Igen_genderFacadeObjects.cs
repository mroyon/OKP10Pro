

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_genderFacadeObjects")]
    public partial interface Igen_genderFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_genderEntity gen_gender);
        
		[OperationContract]
		long Update(gen_genderEntity gen_gender);
		
		[OperationContract]
		long Delete(gen_genderEntity gen_gender );
        
        [OperationContract]
        long SaveList(List<gen_genderEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_genderEntity> GetAll(gen_genderEntity gen_gender);
		
		[OperationContract]
        IList<gen_genderEntity> GetAllByPages(gen_genderEntity gen_gender);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_genderEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_genderEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_genderEntity  GetSingle(gen_genderEntity gen_gender);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_genderEntity> GAPgListView(gen_genderEntity gen_gender);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
