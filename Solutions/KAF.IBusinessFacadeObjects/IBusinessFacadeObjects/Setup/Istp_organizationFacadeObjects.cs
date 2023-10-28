

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_organizationFacadeObjects")]
    public partial interface Istp_organizationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_organizationEntity stp_organization);
        
		[OperationContract]
		long Update(stp_organizationEntity stp_organization);
		
		[OperationContract]
		long Delete(stp_organizationEntity stp_organization );
        
        [OperationContract]
        long SaveList(List<stp_organizationEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_organizationEntity> GetAll(stp_organizationEntity stp_organization);
		
		[OperationContract]
        IList<stp_organizationEntity> GetAllByPages(stp_organizationEntity stp_organization);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetstp_organizationentity(stp_organizationEntity Master, List<stp_organizationentityEntity> DetailList);

        [OperationContract]
        long SaveMasterDetstp_organizationentitytype(stp_organizationEntity Master, List<stp_organizationentitytypeEntity> DetailList);

        [OperationContract]
        long SaveMasterDetstp_passpolicy(stp_organizationEntity Master, List<stp_passpolicyEntity> DetailList);

        [OperationContract]
        long SaveMasterDetuseraccountsprof(stp_organizationEntity Master, List<useraccountsprofEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        stp_organizationEntity  GetSingle(stp_organizationEntity stp_organization);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<stp_organizationEntity> GAPgListView(stp_organizationEntity stp_organization);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
