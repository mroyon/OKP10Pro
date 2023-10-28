

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_countrycityFacadeObjects")]
    public partial interface Istp_countrycityFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_countrycityEntity stp_countrycity);
        
		[OperationContract]
		long Update(stp_countrycityEntity stp_countrycity);
		
		[OperationContract]
		long Delete(stp_countrycityEntity stp_countrycity );
        
        [OperationContract]
        long SaveList(List<stp_countrycityEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_countrycityEntity> GetAll(stp_countrycityEntity stp_countrycity);
		
		[OperationContract]
        IList<stp_countrycityEntity> GetAllByPages(stp_countrycityEntity stp_countrycity);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetstp_countrycity(stp_countrycityEntity Master, List<stp_countrycityEntity> DetailList);

        #endregion Save Master/Details	
    }
}
