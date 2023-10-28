

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_relationshipFacadeObjects")]
    public partial interface Igen_relationshipFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_relationshipEntity gen_relationship);
        
		[OperationContract]
		long Update(gen_relationshipEntity gen_relationship);
		
		[OperationContract]
		long Delete(gen_relationshipEntity gen_relationship );
        
        [OperationContract]
        long SaveList(List<gen_relationshipEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_relationshipEntity> GetAll(gen_relationshipEntity gen_relationship);
		
		[OperationContract]
        IList<gen_relationshipEntity> GetAllByPages(gen_relationshipEntity gen_relationship);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_emergencycontact(gen_relationshipEntity Master, List<hr_emergencycontactEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_relationshipEntity Master, List<hr_familyinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_relationshipEntity  GetSingle(gen_relationshipEntity gen_relationship);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_relationshipEntity> GAPgListView(gen_relationshipEntity gen_relationship);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
