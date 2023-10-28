

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_govcityFacadeObjects")]
    public partial interface Igen_govcityFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_govcityEntity gen_govcity);
        
		[OperationContract]
		long Update(gen_govcityEntity gen_govcity);
		
		[OperationContract]
		long Delete(gen_govcityEntity gen_govcity );
        
        [OperationContract]
        long SaveList(List<gen_govcityEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_govcityEntity> GetAll(gen_govcityEntity gen_govcity);
		
		[OperationContract]
        IList<gen_govcityEntity> GetAllByPages(gen_govcityEntity gen_govcity);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_building(gen_govcityEntity Master, List<gen_buildingEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_addresschange(gen_govcityEntity Master, List<hr_addresschangeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_emergencycontact(gen_govcityEntity Master, List<hr_emergencycontactEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_familyinfo(gen_govcityEntity Master, List<hr_familyinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_govcityEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_govcityEntity  GetSingle(gen_govcityEntity gen_govcity);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_govcityEntity> GAPgListView(gen_govcityEntity gen_govcity);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
