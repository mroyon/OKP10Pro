

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Istp_organizationentityFacadeObjects")]
    public partial interface Istp_organizationentityFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(stp_organizationentityEntity stp_organizationentity);
        
		[OperationContract]
		long Update(stp_organizationentityEntity stp_organizationentity);
		
		[OperationContract]
		long Delete(stp_organizationentityEntity stp_organizationentity );
        
        [OperationContract]
        long SaveList(List<stp_organizationentityEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<stp_organizationentityEntity> GetAll(stp_organizationentityEntity stp_organizationentity);
		
		[OperationContract]
        IList<stp_organizationentityEntity> GetAllByPages(stp_organizationentityEntity stp_organizationentity);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_arms(stp_organizationentityEntity Master, List<gen_armsEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_svcinfo(stp_organizationentityEntity Master, List<hr_svcinfoEntity> DetailList);

        //[OperationContract]
        //long SaveMasterDethr_relativesworkinginmod(stp_organizationentityEntity Master, List<hr_relativesworkinginmodEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentitymap(stp_organizationentityEntity Master, List<owin_userroledetlentitymapEntity> DetailList);

        [OperationContract]
        long SaveMasterDetstp_organizationentity(stp_organizationentityEntity Master, List<stp_organizationentityEntity> DetailList);

        [OperationContract]
        long SaveMasterDetuseraccountsprof(stp_organizationentityEntity Master, List<useraccountsprofEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        stp_organizationentityEntity  GetSingle(stp_organizationentityEntity stp_organizationentity);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<stp_organizationentityEntity> GAPgListView(stp_organizationentityEntity stp_organizationentity);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
