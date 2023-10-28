

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_airlinesFacadeObjects")]
    public partial interface Igen_airlinesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_airlinesEntity gen_airlines);
        
		[OperationContract]
		long Update(gen_airlinesEntity gen_airlines);
		
		[OperationContract]
		long Delete(gen_airlinesEntity gen_airlines );
        
        [OperationContract]
        long SaveList(List<gen_airlinesEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_airlinesEntity> GetAll(gen_airlinesEntity gen_airlines);
		
		[OperationContract]
        IList<gen_airlinesEntity> GetAllByPages(gen_airlinesEntity gen_airlines);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_flightinfo(gen_airlinesEntity Master, List<hr_flightinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_airlinesEntity  GetSingle(gen_airlinesEntity gen_airlines);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_airlinesEntity> GAPgListView(gen_airlinesEntity gen_airlines);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
