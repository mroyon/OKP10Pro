

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_divisiondistrictFacadeObjects")]
    public partial interface Igen_divisiondistrictFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_divisiondistrictEntity gen_divisiondistrict);
        
		[OperationContract]
		long Update(gen_divisiondistrictEntity gen_divisiondistrict);
		
		[OperationContract]
		long Delete(gen_divisiondistrictEntity gen_divisiondistrict );
        
        [OperationContract]
        long SaveList(List<gen_divisiondistrictEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_divisiondistrictEntity> GetAll(gen_divisiondistrictEntity gen_divisiondistrict);
		
		[OperationContract]
        IList<gen_divisiondistrictEntity> GetAllByPages(gen_divisiondistrictEntity gen_divisiondistrict);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_divisiondistrict(gen_divisiondistrictEntity Master, List<gen_divisiondistrictEntity> DetailList);

        [OperationContract]
        long SaveMasterDetgen_thana(gen_divisiondistrictEntity Master, List<gen_thanaEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_addresschange(gen_divisiondistrictEntity Master, List<hr_addresschangeEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_emergencycontact(gen_divisiondistrictEntity Master, List<hr_emergencycontactEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_personalinfo(gen_divisiondistrictEntity Master, List<hr_personalinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_divisiondistrictEntity  GetSingle(gen_divisiondistrictEntity gen_divisiondistrict);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_divisiondistrictEntity> GAPgListView(gen_divisiondistrictEntity gen_divisiondistrict);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
