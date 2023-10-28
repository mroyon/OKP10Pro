

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_organizationentitytypeFacadeObjects")]
    public partial interface Istp_organizationentitytypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_organizationentitytypeEntity stp_organizationentitytype);
        
		[OperationContract]
		long Update(stp_organizationentitytypeEntity stp_organizationentitytype);
		
		[OperationContract]
		long Delete(stp_organizationentitytypeEntity stp_organizationentitytype );
        
        [OperationContract]
        long SaveList(List<stp_organizationentitytypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_organizationentitytypeEntity> GetAll(stp_organizationentitytypeEntity stp_organizationentitytype);
		
		[OperationContract]
        IList<stp_organizationentitytypeEntity> GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity Master, List<stp_organizationentityEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        stp_organizationentitytypeEntity  GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<stp_organizationentitytypeEntity> GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
