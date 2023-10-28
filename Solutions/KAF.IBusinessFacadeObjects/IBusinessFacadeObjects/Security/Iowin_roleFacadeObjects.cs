

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_roleFacadeObjects")]
    public partial interface Iowin_roleFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_roleEntity owin_role);
        
		[OperationContract]
		long Update(owin_roleEntity owin_role);
		
		[OperationContract]
		long Delete(owin_roleEntity owin_role );
        
        [OperationContract]
        long SaveList(List<owin_roleEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_roleEntity> GetAll(owin_roleEntity owin_role);
		
		[OperationContract]
        IList<owin_roleEntity> GetAllByPages(owin_roleEntity owin_role);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_userroledetl(owin_roleEntity Master, List<owin_userroledetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_rolepermission(owin_roleEntity Master, List<owin_rolepermissionEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userrole(owin_roleEntity Master, List<owin_userroleEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentitymap(owin_roleEntity Master, List<owin_userroledetlentitymapEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_roleEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_roleEntity  GetSingle(owin_roleEntity owin_role);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_roleEntity> GAPgListView(owin_roleEntity owin_role);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
