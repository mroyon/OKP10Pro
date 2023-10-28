

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_countryFacadeObjects")]
    public partial interface Istp_countryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_countryEntity stp_country);
        
		[OperationContract]
		long Update(stp_countryEntity stp_country);
		
		[OperationContract]
		long Delete(stp_countryEntity stp_country );
        
        [OperationContract]
        long SaveList(List<stp_countryEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_countryEntity> GetAll(stp_countryEntity stp_country);
		
		[OperationContract]
        IList<stp_countryEntity> GetAllByPages(stp_countryEntity stp_country);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetstp_countrycity(stp_countryEntity Master, List<stp_countrycityEntity> DetailList);

        #endregion Save Master/Details	
    }
}
